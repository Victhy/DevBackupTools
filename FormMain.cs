using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VicthyCopy
{
    public partial class FormMain : Form
    {
        VicthyCopyEntities context = new VicthyCopyEntities();
        private const string WinRAR_KEY = @"WinRAR.ZIP\shell\open\command";
        int TaskCount;
        int ComplectedCount;
        Dictionary<string, DateTime> FinishedTasks;
        public FormMain()
        {
            InitializeComponent();
            FinishedTasks = new Dictionary<string, DateTime>();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void toolStripButtonRun_Click(object sender, EventArgs e)
        {
            FinishedTasks.Clear();
            var projects = context.Projects
                .Where<Projects>(p=>p.IsChoiced==true)
                .OrderBy(p => p.ProjectType)
                .AsNoTracking().ToList();
            if (projects == null)
                return;

            TaskCount = projects.Count();
            ComplectedCount = 0;
            this.labelTask.Text = TaskCount.ToString();
            this.labelCompleted.Text = ComplectedCount.ToString();
            var codeProject = projects.Where(c => c.ProjectType == "PRO");
            var database=projects.Where(d=>d.ProjectType=="SQL");
            if(codeProject.Count()>0)
                ProjectCopy(codeProject);
            if (database.Count() > 0)
            {
                Thread thread = new Thread(new ThreadStart(delegate()
                {
                    DatabaseCopy(database);
                }));
                thread.Start();

                Thread threadWait = new Thread(new ThreadStart(delegate()
                {
                    WaitThreadEnd(thread);
                }));
                threadWait.IsBackground = true;
                threadWait.Start();
            }
        }

        private void WaitThreadEnd(Thread thread)
        {
            int i=0;
            string dot=string.Empty;
            
            while (thread.IsAlive)
            {
                Thread.Sleep(1000);
                i++;
                if (i > 10)
                {
                    i = 0;
                    dot = string.Empty;
                }

                dot = dot.PadRight(i, '▌');
                this.labelMessage.Text = dot;
                this.labelCompleted.Text = ComplectedCount.ToString();
            }
            this.labelMessage.Text = string.Empty;
            UpdateExecutedDate();
        }

        private void UpdateExecutedDate()
        {
            foreach (var item in FinishedTasks)
            {
                var project = context.Projects.SingleOrDefault(p => p.ProjectName == item.Key);
                project.LastExecuted = item.Value;
                context.Projects.Attach(project);
                context.Entry<Projects>(project).State = EntityState.Modified;
                context.SaveChanges();
            }
            DatagridDatabind();
        }

        /// <summary>
        /// 项目代码备份
        /// </summary>
        /// <param name="Projects">Projects类的集合</param>
        /// <param name="WinrarFullname">Winrar的完整路径</param>
        private void ProjectCopy(IEnumerable<Projects> Projects)
        {
            string rarFilename;
            string targetPath ;
            
            foreach (var pro in Projects)
            {
                rarFilename = string.Format("{0} {1}.rar", pro.ProjectName, MakeTimeStamp());
                targetPath = Path.Combine(pro.DistinationDir, rarFilename);

                string message;
                if (RARCompress(pro.SourceDir, pro.DistinationDir, targetPath, out message))
                {
                    FinishedTasks.Add(pro.ProjectName, DateTime.Now);
                    ComplectedCount += 1;
                }
                else
                    ShowNotice("WARNING", message);
            }
            this.labelCompleted.Text = ComplectedCount.ToString();
            UpdateExecutedDate();
        }

        private string MakeTimeStamp()
        {
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;
            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;

            string y = year.ToString().Substring(3);
            string mo = mo = month.ToString();
            if (month > 9)
            {
                switch (month)
                {
                    case 10:
                        mo = "A";
                        break;
                    case 11:
                        mo = "B";
                        break;
                    case 12:
                        mo = "C";
                        break;
                }
            }

            string d = day.ToString();
            if (day < 10)
                d = "0" + day.ToString();

            string mi = minute.ToString();
            if (minute < 10)
                mi = "0" + minute.ToString();

            string h = hour.ToString();
            if (hour < 10)
                h = "0" + hour.ToString();


            return string.Format("{0}{1}{2}-{3}{4}", y, mo, d, h, mi);
        }
      
        private void DatabaseCopy(IEnumerable<Projects> database)
        {
            string message;
            string fullPath;
            foreach (var pro in database)
            {
                fullPath = Path.Combine(pro.DistinationDir, pro.ProjectName + MakeTimeStamp() + ".bak");
                if (BackupDatabase(pro.ProjectName, fullPath, out message))
                {
                    FinishedTasks.Add(pro.ProjectName, DateTime.Now);
                    ComplectedCount += 1;
                }
                    
                else
                    ShowNotice("WARNING", message);
            }
        }

        /// <summary>
        /// 备份SqlServer数据库
        /// </summary>
        /// <param name="databaseName">数据库名</param>
        /// <param name="targetDir">备份到的完整路径，包含文件名和后缀</param>
        /// <param name="message">成功为空，失败为错误信息</param>
        /// <returns></returns>
        private bool BackupDatabase(string databaseName,string targetDir,out string message)
        {
            message=string.Empty;
            string connStr = GetConnectString();
            if (connStr == string.Empty)
                return false;

            bool flag = false;
            string cmdStirng = string.Format("BACKUP DATABASE {0} TO DISK='{1}'",databaseName,targetDir);
            SqlConnection connect = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(cmdStirng, connect);
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                    cmd.ExecuteNonQuery();
                    flag = true;
                }
            }
            catch (SqlException e)
            {
                message = e.Message;
                if (connect != null && connect.State == ConnectionState.Open)
                {
                    connect.Dispose();
                }
            }
            finally
            {
                connect.Close();
            }

            return flag ;
        }

        private string GetConnectString()
        {

            var setting = context.Settings.First();
            if (setting == null)
                return string.Empty;

            string connStr = string.Format("uid={0};pwd={1};initial catalog={2};Server={3};Connect Timeout=10"
                , setting.UserName, setting.Password, setting.DatabaseName, setting.ServerName);

            return connStr;
        }

        private void toolStripButtonSet_Click(object sender, EventArgs e)
        {
            FormSettings set = new FormSettings();
            set.ShowDialog();
            DatagridDatabind();
        }

        private void toolStripButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            DatagridDatabind();
        }

        private void DatagridDatabind()
        {
            try
            {
                var list = context.Projects.AsNoTracking().ToList();
                this.dataGridMain.DataSource = list;
            }
            catch (Exception ex)
            {
                ShowNotice("WARNING", ex.Message);
            }
            
        }

        private void toolStripButtonConnect_Click(object sender, EventArgs e)
        {
            FormConnect formConn = new FormConnect();
            formConn.ShowDialog();
        }

        private void dataGridMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRow = this.dataGridMain.CurrentRow.Index;
            var projectName = this.dataGridMain.Rows[currentRow].Cells[colProjectName.Name].Value.ToString();
            FormSettings setting = new FormSettings(projectName);
            setting.ShowDialog();
            DatagridDatabind();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Flag">SUCCESS/WARNING</param>
        /// <param name="Message"></param>
        private void ShowNotice(string Flag, string Message)
        {
            if (string.IsNullOrEmpty(Flag))
                Flag = "SUCCESS";

            if (Flag.ToUpper() == "SUCCESS")
            {
                this.labelMessage.ForeColor = Color.Green;
            }
            else if (Flag.ToUpper() == "WARNING")
            {
                this.labelMessage.ForeColor = Color.Red;
            }
            if (Message.Length > 40)
            {
                Message = Message.Replace('\r', ' ').Replace('\n', ' ');
                Message = Message.Substring(0, 40) + "...";
            }

            string timeStamp = string.Format("[{0}.{1}.{2}]", DateTime.Now.Minute.ToString()
                , DateTime.Now.Second.ToString(), DateTime.Now.Millisecond.ToString());
            this.labelMessage.Text = timeStamp+" "+Message;
            
        }

        /// <summary>
        /// 利用 WinRAR 进行压缩
        /// </summary>
        /// <param name="path">将要被压缩的文件夹（绝对路径）</param>
        /// <param name="rarPath">压缩后的 .rar 的存放目录（绝对路径）</param>
        /// <param name="rarName">压缩文件的名称（包括后缀）</param>
        /// <returns>true 或 false。压缩成功返回 true，反之，false。</returns>
        /// <param name="message">成功为空，失败返回失败信息</param>
        public bool RARCompress(string path, string rarPath, string rarName,out string message)
        {
            message = string.Empty;
            bool flag = false;
            string rarexe;  
            string cmd;
            //winara的工作目录，避免压缩包里包含完整路径
            string workDir = path.Substring(0, path.LastIndexOf('\\'));
            //将要添加到压缩包的文件夹名
            string folderName = path.Substring(path.LastIndexOf('\\') + 1);
            Microsoft.Win32.RegistryKey regkey;
            Object regvalue;
            ProcessStartInfo startinfo;
            Process process;
            try
            {
                regkey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(WinRAR_KEY);
                regvalue = regkey.GetValue("");  
                rarexe = regvalue.ToString();
                regkey.Close();
                rarexe = rarexe.Substring(1, rarexe.Length - 7); 
                Directory.CreateDirectory(path);
                cmd = string.Format("a \"{0}\" \"{1}\"", rarName, folderName);
                startinfo = new ProcessStartInfo();
                startinfo.FileName = rarexe;
                startinfo.Arguments = cmd;                          
                startinfo.WindowStyle = ProcessWindowStyle.Hidden;  
                
                startinfo.WorkingDirectory = workDir;
                process = new Process();
                
                process.StartInfo = startinfo;
                process.Start();
                process.WaitForExit(); 
                if (process.HasExited)
                {
                    flag = true;
                }
                process.Close();
            }
            catch (Exception e)
            {
                throw e;
            }

            return flag;
        }

        private void toolStripMenuDeleteRow_Click(object sender, EventArgs e)
        {
            if (this.dataGridMain.CurrentRow == null)
                return;

            int rowIndex=this.dataGridMain.CurrentRow.Index;
            string projectName = this.dataGridMain.Rows[rowIndex].Cells[colProjectName.Name].Value.ToString();
            if (DeleteProjects(projectName))
                ShowNotice("SUCCESS", "1 item has deleted");
            else
                ShowNotice("WARNING", "Delete error occured!");

            DatagridDatabind();
        }

        private bool DeleteProjects(string ProjectName)
        {
            var project =context.Projects.FirstOrDefault<Projects>(p=>p.ProjectName==ProjectName);
            if (project == null)
                return false;

            context.Projects.Remove(project);
            if (context.SaveChanges() > 0)
                return true;
            else
                return false;
        }

        private void dataGridMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==0||e.RowIndex==-1)
                return;
            if (this.dataGridMain.Columns[e.ColumnIndex].Name != colIsChoiced.Name)
                return;

            DataGridViewRow row = this.dataGridMain.Rows[e.RowIndex];
            var projectName = row.Cells[colProjectName.Name].Value.ToString();
            var isChoiced = Convert.ToBoolean(row.Cells[colIsChoiced.Name].EditedFormattedValue);

            var project =context.Projects.FirstOrDefault<Projects>(p=>p.ProjectName==projectName);
            if (project != null)
            {
                project.IsChoiced = isChoiced;
                context.Projects.Attach(project);
                context.Entry<Projects>(project).State = EntityState.Modified;
                if (context.SaveChanges() <= 0)
                    ShowNotice("WARNING", "Changed item status faild!");
            }
        }

    }
}
