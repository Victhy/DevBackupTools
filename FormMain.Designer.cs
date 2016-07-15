namespace VicthyCopy
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonRun = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonSet = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonConnect = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonExit = new System.Windows.Forms.ToolStripButton();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripLabelTask = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelTask = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusCompleted = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelCompleted = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridMain = new System.Windows.Forms.DataGridView();
            this.menuDeleteRow = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuDeleteRow = new System.Windows.Forms.ToolStripMenuItem();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsChoiced = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSourceDir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDistinationDir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastExecuted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProjectType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripMain.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMain)).BeginInit();
            this.menuDeleteRow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMain
            // 
            this.toolStripMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(213)))), ((int)(((byte)(250)))));
            this.toolStripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonRun,
            this.toolStripLabel1,
            this.toolStripButtonSet,
            this.toolStripLabel4,
            this.toolStripButtonConnect,
            this.toolStripLabel2,
            this.toolStripSeparator1,
            this.toolStripLabel3,
            this.toolStripButtonExit});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(784, 71);
            this.toolStripMain.TabIndex = 0;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // toolStripButtonRun
            // 
            this.toolStripButtonRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRun.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRun.Image")));
            this.toolStripButtonRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRun.Name = "toolStripButtonRun";
            this.toolStripButtonRun.Size = new System.Drawing.Size(68, 68);
            this.toolStripButtonRun.ToolTipText = "Copy now";
            this.toolStripButtonRun.Click += new System.EventHandler(this.toolStripButtonRun_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(12, 68);
            this.toolStripLabel1.Text = " ";
            // 
            // toolStripButtonSet
            // 
            this.toolStripButtonSet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSet.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSet.Image")));
            this.toolStripButtonSet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSet.Name = "toolStripButtonSet";
            this.toolStripButtonSet.Size = new System.Drawing.Size(68, 68);
            this.toolStripButtonSet.Text = "toolStripButton2";
            this.toolStripButtonSet.ToolTipText = "Settings";
            this.toolStripButtonSet.Click += new System.EventHandler(this.toolStripButtonSet_Click);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(12, 68);
            this.toolStripLabel4.Text = " ";
            // 
            // toolStripButtonConnect
            // 
            this.toolStripButtonConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonConnect.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonConnect.Image")));
            this.toolStripButtonConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonConnect.Name = "toolStripButtonConnect";
            this.toolStripButtonConnect.Size = new System.Drawing.Size(68, 68);
            this.toolStripButtonConnect.Text = "toolStripButton1";
            this.toolStripButtonConnect.Click += new System.EventHandler(this.toolStripButtonConnect_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(12, 68);
            this.toolStripLabel2.Text = " ";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 71);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(12, 68);
            this.toolStripLabel3.Text = " ";
            // 
            // toolStripButtonExit
            // 
            this.toolStripButtonExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonExit.Image")));
            this.toolStripButtonExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExit.Name = "toolStripButtonExit";
            this.toolStripButtonExit.Size = new System.Drawing.Size(68, 68);
            this.toolStripButtonExit.Text = "toolStripButton3";
            this.toolStripButtonExit.ToolTipText = "Eixt";
            this.toolStripButtonExit.Click += new System.EventHandler(this.toolStripButtonExit_Click);
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelTask,
            this.labelTask,
            this.toolStripStatusCompleted,
            this.labelCompleted,
            this.toolStripStatusMessage,
            this.labelMessage});
            this.statusStripMain.Location = new System.Drawing.Point(0, 427);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(784, 22);
            this.statusStripMain.TabIndex = 1;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // toolStripLabelTask
            // 
            this.toolStripLabelTask.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabelTask.Name = "toolStripLabelTask";
            this.toolStripLabelTask.Size = new System.Drawing.Size(38, 17);
            this.toolStripLabelTask.Text = "Task:";
            // 
            // labelTask
            // 
            this.labelTask.AutoSize = false;
            this.labelTask.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTask.ForeColor = System.Drawing.Color.Green;
            this.labelTask.Name = "labelTask";
            this.labelTask.Size = new System.Drawing.Size(130, 17);
            this.labelTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusCompleted
            // 
            this.toolStripStatusCompleted.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusCompleted.Name = "toolStripStatusCompleted";
            this.toolStripStatusCompleted.Size = new System.Drawing.Size(72, 17);
            this.toolStripStatusCompleted.Text = "Completed:";
            // 
            // labelCompleted
            // 
            this.labelCompleted.AutoSize = false;
            this.labelCompleted.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompleted.ForeColor = System.Drawing.Color.Green;
            this.labelCompleted.Name = "labelCompleted";
            this.labelCompleted.Size = new System.Drawing.Size(130, 17);
            this.labelCompleted.Text = "                ";
            this.labelCompleted.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusMessage
            // 
            this.toolStripStatusMessage.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusMessage.Name = "toolStripStatusMessage";
            this.toolStripStatusMessage.Size = new System.Drawing.Size(58, 17);
            this.toolStripStatusMessage.Text = "Message:";
            // 
            // labelMessage
            // 
            this.labelMessage.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.ForeColor = System.Drawing.Color.Green;
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(58, 17);
            this.labelMessage.Text = "                 ";
            this.labelMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridMain
            // 
            this.dataGridMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridMain.AutoGenerateColumns = false;
            this.dataGridMain.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(213)))), ((int)(((byte)(250)))));
            this.dataGridMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridMain.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridMain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(213)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colIsChoiced,
            this.colProjectName,
            this.colSourceDir,
            this.colDistinationDir,
            this.colLastExecuted,
            this.colProjectType});
            this.dataGridMain.ContextMenuStrip = this.menuDeleteRow;
            this.dataGridMain.DataSource = this.projectsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(213)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridMain.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridMain.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridMain.EnableHeadersVisualStyles = false;
            this.dataGridMain.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(213)))), ((int)(((byte)(250)))));
            this.dataGridMain.Location = new System.Drawing.Point(0, 71);
            this.dataGridMain.Name = "dataGridMain";
            this.dataGridMain.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(213)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridMain.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridMain.RowHeadersVisible = false;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(179)))), ((int)(((byte)(212)))));
            this.dataGridMain.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridMain.RowTemplate.Height = 35;
            this.dataGridMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridMain.Size = new System.Drawing.Size(784, 356);
            this.dataGridMain.TabIndex = 2;
            this.dataGridMain.TabStop = false;
            this.dataGridMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMain_CellContentClick);
            this.dataGridMain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMain_CellDoubleClick);
            // 
            // menuDeleteRow
            // 
            this.menuDeleteRow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuDeleteRow.Font = new System.Drawing.Font("Georgia", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuDeleteRow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuDeleteRow});
            this.menuDeleteRow.Name = "menuDeleteRow";
            this.menuDeleteRow.Size = new System.Drawing.Size(198, 26);
            this.menuDeleteRow.Text = "Delete selected row";
            // 
            // toolStripMenuDeleteRow
            // 
            this.toolStripMenuDeleteRow.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuDeleteRow.Image")));
            this.toolStripMenuDeleteRow.Name = "toolStripMenuDeleteRow";
            this.toolStripMenuDeleteRow.Size = new System.Drawing.Size(197, 22);
            this.toolStripMenuDeleteRow.Text = "Delete selected row";
            this.toolStripMenuDeleteRow.Click += new System.EventHandler(this.toolStripMenuDeleteRow_Click);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = false;
            this.colId.Width = 120;
            // 
            // colIsChoiced
            // 
            this.colIsChoiced.DataPropertyName = "IsChoiced";
            this.colIsChoiced.HeaderText = "  #";
            this.colIsChoiced.Name = "colIsChoiced";
            this.colIsChoiced.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIsChoiced.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colIsChoiced.Width = 50;
            // 
            // colProjectName
            // 
            this.colProjectName.DataPropertyName = "ProjectName";
            this.colProjectName.HeaderText = "Project Name";
            this.colProjectName.Name = "colProjectName";
            this.colProjectName.Width = 180;
            // 
            // colSourceDir
            // 
            this.colSourceDir.DataPropertyName = "SourceDir";
            this.colSourceDir.HeaderText = "Source Dir";
            this.colSourceDir.Name = "colSourceDir";
            this.colSourceDir.Width = 200;
            // 
            // colDistinationDir
            // 
            this.colDistinationDir.DataPropertyName = "DistinationDir";
            this.colDistinationDir.HeaderText = "Distination Dir";
            this.colDistinationDir.Name = "colDistinationDir";
            this.colDistinationDir.Width = 200;
            // 
            // colLastExecuted
            // 
            this.colLastExecuted.DataPropertyName = "LastExecuted";
            this.colLastExecuted.HeaderText = "Last Executed";
            this.colLastExecuted.Name = "colLastExecuted";
            this.colLastExecuted.Width = 150;
            // 
            // colProjectType
            // 
            this.colProjectType.DataPropertyName = "ProjectType";
            this.colProjectType.HeaderText = "ProjectType";
            this.colProjectType.Name = "colProjectType";
            this.colProjectType.Visible = false;
            // 
            // projectsBindingSource
            // 
            this.projectsBindingSource.DataSource = typeof(VicthyCopy.Projects);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 449);
            this.Controls.Add(this.dataGridMain);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.toolStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project backup tools";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMain)).EndInit();
            this.menuDeleteRow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton toolStripButtonRun;
        private System.Windows.Forms.ToolStripButton toolStripButtonSet;
        private System.Windows.Forms.ToolStripButton toolStripButtonExit;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.DataGridView dataGridMain;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.BindingSource projectsBindingSource;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLabelTask;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusCompleted;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusMessage;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton toolStripButtonConnect;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsChoiced;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSourceDir;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDistinationDir;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastExecuted;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjectType;
        private System.Windows.Forms.ToolStripStatusLabel labelTask;
        private System.Windows.Forms.ToolStripStatusLabel labelCompleted;
        private System.Windows.Forms.ContextMenuStrip menuDeleteRow;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuDeleteRow;
        public System.Windows.Forms.ToolStripStatusLabel labelMessage;
    }
}

