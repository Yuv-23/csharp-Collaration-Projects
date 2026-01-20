namespace Collaraton.UI
{
    partial class ProjectManagerForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_AssignTask = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_AssignTaskList = new System.Windows.Forms.DataGridView();
            this.col_TaskID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TaskType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ExecutorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_StatusText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel_Assign = new System.Windows.Forms.TableLayoutPanel();
            this.txt_TaskName = new System.Windows.Forms.TextBox();
            this.lbl_TaskName = new System.Windows.Forms.Label();
            this.lbl_Project = new System.Windows.Forms.Label();
            this.cbx_Project = new System.Windows.Forms.ComboBox();
            this.lbl_User = new System.Windows.Forms.Label();
            this.cbx_AssignUser = new System.Windows.Forms.ComboBox();
            this.lbl_TaskDesc = new System.Windows.Forms.Label();
            this.txt_TaskDesc = new System.Windows.Forms.TextBox();
            this.btn_AssignTask = new System.Windows.Forms.Button();
            this.btn_RefreshAssign = new System.Windows.Forms.Button();
            this.lbl_TaskType = new System.Windows.Forms.Label();
            this.cbx_TaskType = new System.Windows.Forms.ComboBox();
            this.tabPage_AuditProgress = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_AuditTaskList = new System.Windows.Forms.DataGridView();
            this.col_AuditTaskID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AuditTaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AuditProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AuditSubmitMember = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AuditProgressDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AuditScreenshot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AuditDocument = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AuditSubmitTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel_Audit = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_ProgressDesc = new System.Windows.Forms.Label();
            this.txt_ProgressDesc = new System.Windows.Forms.TextBox();
            this.lbl_Screenshot = new System.Windows.Forms.Label();
            this.btn_ViewScreenshot = new System.Windows.Forms.Button();
            this.lbl_Document = new System.Windows.Forms.Label();
            this.btn_ViewDocument = new System.Windows.Forms.Button();
            this.btn_AuditReject = new System.Windows.Forms.Button();
            this.btn_AuditPass = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage_AssignTask.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AssignTaskList)).BeginInit();
            this.tableLayoutPanel_Assign.SuspendLayout();
            this.tabPage_AuditProgress.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AuditTaskList)).BeginInit();
            this.tableLayoutPanel_Audit.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_AssignTask);
            this.tabControl1.Controls.Add(this.tabPage_AuditProgress);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1174, 779);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_AssignTask
            // 
            this.tabPage_AssignTask.Controls.Add(this.tableLayoutPanel1);
            this.tabPage_AssignTask.Location = new System.Drawing.Point(8, 39);
            this.tabPage_AssignTask.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabPage_AssignTask.Name = "tabPage_AssignTask";
            this.tabPage_AssignTask.Size = new System.Drawing.Size(1158, 732);
            this.tabPage_AssignTask.TabIndex = 0;
            this.tabPage_AssignTask.Text = "任务分配";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgv_AssignTaskList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel_Assign, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.43243F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.56757F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1158, 732);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // dgv_AssignTaskList
            // 
            this.dgv_AssignTaskList.ColumnHeadersHeight = 46;
            this.dgv_AssignTaskList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_TaskID,
            this.col_TaskName,
            this.col_TaskType,
            this.col_ProjectName,
            this.col_ExecutorName,
            this.col_StatusText});
            this.dgv_AssignTaskList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_AssignTaskList.Location = new System.Drawing.Point(5, 241);
            this.dgv_AssignTaskList.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgv_AssignTaskList.MultiSelect = false;
            this.dgv_AssignTaskList.Name = "dgv_AssignTaskList";
            this.dgv_AssignTaskList.ReadOnly = true;
            this.dgv_AssignTaskList.RowHeadersVisible = false;
            this.dgv_AssignTaskList.RowHeadersWidth = 82;
            this.dgv_AssignTaskList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_AssignTaskList.Size = new System.Drawing.Size(1148, 487);
            this.dgv_AssignTaskList.TabIndex = 2;
            // 
            // col_TaskID
            // 
            this.col_TaskID.DataPropertyName = "TaskID";
            this.col_TaskID.HeaderText = "任务 ID";
            this.col_TaskID.MinimumWidth = 10;
            this.col_TaskID.Name = "col_TaskID";
            this.col_TaskID.ReadOnly = true;
            this.col_TaskID.Width = 80;
            // 
            // col_TaskName
            // 
            this.col_TaskName.DataPropertyName = "TaskName";
            this.col_TaskName.HeaderText = "任务名称";
            this.col_TaskName.MinimumWidth = 10;
            this.col_TaskName.Name = "col_TaskName";
            this.col_TaskName.ReadOnly = true;
            this.col_TaskName.Width = 200;
            // 
            // col_TaskType
            // 
            this.col_TaskType.DataPropertyName = "TaskType";
            this.col_TaskType.HeaderText = "任务类型";
            this.col_TaskType.MinimumWidth = 10;
            this.col_TaskType.Name = "col_TaskType";
            this.col_TaskType.ReadOnly = true;
            this.col_TaskType.Width = 200;
            // 
            // col_ProjectName
            // 
            this.col_ProjectName.DataPropertyName = "ProjectName";
            this.col_ProjectName.HeaderText = "所属项目";
            this.col_ProjectName.MinimumWidth = 10;
            this.col_ProjectName.Name = "col_ProjectName";
            this.col_ProjectName.ReadOnly = true;
            this.col_ProjectName.Width = 200;
            // 
            // col_ExecutorName
            // 
            this.col_ExecutorName.DataPropertyName = "ExecutorName";
            this.col_ExecutorName.HeaderText = "分配成员";
            this.col_ExecutorName.MinimumWidth = 10;
            this.col_ExecutorName.Name = "col_ExecutorName";
            this.col_ExecutorName.ReadOnly = true;
            this.col_ExecutorName.Width = 150;
            // 
            // col_StatusText
            // 
            this.col_StatusText.DataPropertyName = "StatusText";
            this.col_StatusText.HeaderText = "任务状态";
            this.col_StatusText.MinimumWidth = 10;
            this.col_StatusText.Name = "col_StatusText";
            this.col_StatusText.ReadOnly = true;
            this.col_StatusText.Width = 120;
            // 
            // tableLayoutPanel_Assign
            // 
            this.tableLayoutPanel_Assign.ColumnCount = 4;
            this.tableLayoutPanel_Assign.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.8937F));
            this.tableLayoutPanel_Assign.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.1063F));
            this.tableLayoutPanel_Assign.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.8937F));
            this.tableLayoutPanel_Assign.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.10629F));
            this.tableLayoutPanel_Assign.Controls.Add(this.txt_TaskName, 3, 1);
            this.tableLayoutPanel_Assign.Controls.Add(this.lbl_TaskName, 2, 1);
            this.tableLayoutPanel_Assign.Controls.Add(this.lbl_Project, 0, 0);
            this.tableLayoutPanel_Assign.Controls.Add(this.cbx_Project, 1, 0);
            this.tableLayoutPanel_Assign.Controls.Add(this.lbl_User, 2, 0);
            this.tableLayoutPanel_Assign.Controls.Add(this.cbx_AssignUser, 3, 0);
            this.tableLayoutPanel_Assign.Controls.Add(this.lbl_TaskDesc, 0, 2);
            this.tableLayoutPanel_Assign.Controls.Add(this.txt_TaskDesc, 1, 2);
            this.tableLayoutPanel_Assign.Controls.Add(this.btn_AssignTask, 1, 3);
            this.tableLayoutPanel_Assign.Controls.Add(this.btn_RefreshAssign, 2, 3);
            this.tableLayoutPanel_Assign.Controls.Add(this.lbl_TaskType, 0, 1);
            this.tableLayoutPanel_Assign.Controls.Add(this.cbx_TaskType, 1, 1);
            this.tableLayoutPanel_Assign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Assign.Location = new System.Drawing.Point(5, 4);
            this.tableLayoutPanel_Assign.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tableLayoutPanel_Assign.Name = "tableLayoutPanel_Assign";
            this.tableLayoutPanel_Assign.RowCount = 4;
            this.tableLayoutPanel_Assign.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_Assign.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_Assign.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_Assign.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_Assign.Size = new System.Drawing.Size(1148, 229);
            this.tableLayoutPanel_Assign.TabIndex = 1;
            // 
            // txt_TaskName
            // 
            this.txt_TaskName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_TaskName.Location = new System.Drawing.Point(737, 61);
            this.txt_TaskName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_TaskName.Name = "txt_TaskName";
            this.txt_TaskName.Size = new System.Drawing.Size(406, 35);
            this.txt_TaskName.TabIndex = 14;
            // 
            // lbl_TaskName
            // 
            this.lbl_TaskName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_TaskName.Location = new System.Drawing.Point(578, 57);
            this.lbl_TaskName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_TaskName.Name = "lbl_TaskName";
            this.lbl_TaskName.Size = new System.Drawing.Size(149, 56);
            this.lbl_TaskName.TabIndex = 12;
            this.lbl_TaskName.Text = "任务名称：";
            this.lbl_TaskName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Project
            // 
            this.lbl_Project.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Project.Location = new System.Drawing.Point(5, 0);
            this.lbl_Project.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Project.Name = "lbl_Project";
            this.lbl_Project.Size = new System.Drawing.Size(149, 56);
            this.lbl_Project.TabIndex = 0;
            this.lbl_Project.Text = "所属项目：";
            this.lbl_Project.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbx_Project
            // 
            this.cbx_Project.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_Project.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Project.Location = new System.Drawing.Point(164, 4);
            this.cbx_Project.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbx_Project.Name = "cbx_Project";
            this.cbx_Project.Size = new System.Drawing.Size(404, 32);
            this.cbx_Project.TabIndex = 1;
            this.cbx_Project.DropDown += new System.EventHandler(this.cbx_Project_DropDown);
            // 
            // lbl_User
            // 
            this.lbl_User.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_User.Location = new System.Drawing.Point(578, 0);
            this.lbl_User.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(149, 56);
            this.lbl_User.TabIndex = 2;
            this.lbl_User.Text = "分配成员：";
            this.lbl_User.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbx_AssignUser
            // 
            this.cbx_AssignUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_AssignUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_AssignUser.Location = new System.Drawing.Point(737, 4);
            this.cbx_AssignUser.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbx_AssignUser.Name = "cbx_AssignUser";
            this.cbx_AssignUser.Size = new System.Drawing.Size(406, 32);
            this.cbx_AssignUser.TabIndex = 3;
            this.cbx_AssignUser.DropDown += new System.EventHandler(this.cbx_AssignUser_DropDown);
            // 
            // lbl_TaskDesc
            // 
            this.lbl_TaskDesc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_TaskDesc.Location = new System.Drawing.Point(5, 114);
            this.lbl_TaskDesc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_TaskDesc.Name = "lbl_TaskDesc";
            this.lbl_TaskDesc.Size = new System.Drawing.Size(149, 57);
            this.lbl_TaskDesc.TabIndex = 6;
            this.lbl_TaskDesc.Text = "任务描述：";
            this.lbl_TaskDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_TaskDesc
            // 
            this.txt_TaskDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_TaskDesc.Location = new System.Drawing.Point(164, 118);
            this.txt_TaskDesc.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_TaskDesc.Multiline = true;
            this.txt_TaskDesc.Name = "txt_TaskDesc";
            this.txt_TaskDesc.Size = new System.Drawing.Size(404, 49);
            this.txt_TaskDesc.TabIndex = 7;
            this.txt_TaskDesc.TextChanged += new System.EventHandler(this.txt_TaskDesc_TextChanged);
            // 
            // btn_AssignTask
            // 
            this.btn_AssignTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AssignTask.Location = new System.Drawing.Point(419, 175);
            this.btn_AssignTask.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_AssignTask.Name = "btn_AssignTask";
            this.btn_AssignTask.Size = new System.Drawing.Size(149, 50);
            this.btn_AssignTask.TabIndex = 8;
            this.btn_AssignTask.Text = "分配任务";
            this.btn_AssignTask.Click += new System.EventHandler(this.btn_AssignTask_Click);
            // 
            // btn_RefreshAssign
            // 
            this.btn_RefreshAssign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_RefreshAssign.Location = new System.Drawing.Point(578, 175);
            this.btn_RefreshAssign.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_RefreshAssign.Name = "btn_RefreshAssign";
            this.btn_RefreshAssign.Size = new System.Drawing.Size(149, 50);
            this.btn_RefreshAssign.TabIndex = 9;
            this.btn_RefreshAssign.Text = "刷新列表";
            this.btn_RefreshAssign.Click += new System.EventHandler(this.btn_RefreshAssign_Click);
            // 
            // lbl_TaskType
            // 
            this.lbl_TaskType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_TaskType.AutoSize = true;
            this.lbl_TaskType.Location = new System.Drawing.Point(3, 73);
            this.lbl_TaskType.Name = "lbl_TaskType";
            this.lbl_TaskType.Size = new System.Drawing.Size(130, 24);
            this.lbl_TaskType.TabIndex = 11;
            this.lbl_TaskType.Text = "任务类型：";
            this.lbl_TaskType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbx_TaskType
            // 
            this.cbx_TaskType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_TaskType.FormattingEnabled = true;
            this.cbx_TaskType.Items.AddRange(new object[] {
            "开发任务",
            "测试任务",
            "设计任务",
            "文档任务",
            "修复任务",
            "其他任务"});
            this.cbx_TaskType.Location = new System.Drawing.Point(162, 60);
            this.cbx_TaskType.Name = "cbx_TaskType";
            this.cbx_TaskType.Size = new System.Drawing.Size(408, 32);
            this.cbx_TaskType.TabIndex = 13;
            // 
            // tabPage_AuditProgress
            // 
            this.tabPage_AuditProgress.Controls.Add(this.tableLayoutPanel2);
            this.tabPage_AuditProgress.Location = new System.Drawing.Point(8, 39);
            this.tabPage_AuditProgress.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabPage_AuditProgress.Name = "tabPage_AuditProgress";
            this.tabPage_AuditProgress.Size = new System.Drawing.Size(1158, 732);
            this.tabPage_AuditProgress.TabIndex = 1;
            this.tabPage_AuditProgress.Text = "进度审核";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.dgv_AuditTaskList, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel_Audit, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1158, 732);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // dgv_AuditTaskList
            // 
            this.dgv_AuditTaskList.ColumnHeadersHeight = 46;
            this.dgv_AuditTaskList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_AuditTaskID,
            this.col_AuditTaskName,
            this.col_AuditProjectName,
            this.col_AuditSubmitMember,
            this.col_AuditProgressDesc,
            this.col_AuditScreenshot,
            this.col_AuditDocument,
            this.col_AuditSubmitTime});
            this.dgv_AuditTaskList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_AuditTaskList.Location = new System.Drawing.Point(5, 187);
            this.dgv_AuditTaskList.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgv_AuditTaskList.Name = "dgv_AuditTaskList";
            this.dgv_AuditTaskList.ReadOnly = true;
            this.dgv_AuditTaskList.RowHeadersVisible = false;
            this.dgv_AuditTaskList.RowHeadersWidth = 82;
            this.dgv_AuditTaskList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_AuditTaskList.Size = new System.Drawing.Size(1148, 541);
            this.dgv_AuditTaskList.TabIndex = 2;
            // 
            // col_AuditTaskID
            // 
            this.col_AuditTaskID.DataPropertyName = "TaskID";
            this.col_AuditTaskID.HeaderText = "任务 ID";
            this.col_AuditTaskID.MinimumWidth = 10;
            this.col_AuditTaskID.Name = "col_AuditTaskID";
            this.col_AuditTaskID.ReadOnly = true;
            this.col_AuditTaskID.Width = 80;
            // 
            // col_AuditTaskName
            // 
            this.col_AuditTaskName.DataPropertyName = "TaskName";
            this.col_AuditTaskName.HeaderText = "任务名称";
            this.col_AuditTaskName.MinimumWidth = 10;
            this.col_AuditTaskName.Name = "col_AuditTaskName";
            this.col_AuditTaskName.ReadOnly = true;
            this.col_AuditTaskName.Width = 150;
            // 
            // col_AuditProjectName
            // 
            this.col_AuditProjectName.DataPropertyName = "ProjectName";
            this.col_AuditProjectName.HeaderText = "所属项目";
            this.col_AuditProjectName.MinimumWidth = 10;
            this.col_AuditProjectName.Name = "col_AuditProjectName";
            this.col_AuditProjectName.ReadOnly = true;
            this.col_AuditProjectName.Width = 180;
            // 
            // col_AuditSubmitMember
            // 
            this.col_AuditSubmitMember.DataPropertyName = "SubmitMember";
            this.col_AuditSubmitMember.HeaderText = "提交成员";
            this.col_AuditSubmitMember.MinimumWidth = 10;
            this.col_AuditSubmitMember.Name = "col_AuditSubmitMember";
            this.col_AuditSubmitMember.ReadOnly = true;
            this.col_AuditSubmitMember.Width = 120;
            // 
            // col_AuditProgressDesc
            // 
            this.col_AuditProgressDesc.DataPropertyName = "ProgressDesc";
            this.col_AuditProgressDesc.HeaderText = "进度描述";
            this.col_AuditProgressDesc.MinimumWidth = 10;
            this.col_AuditProgressDesc.Name = "col_AuditProgressDesc";
            this.col_AuditProgressDesc.ReadOnly = true;
            this.col_AuditProgressDesc.Width = 200;
            // 
            // col_AuditScreenshot
            // 
            this.col_AuditScreenshot.DataPropertyName = "ScreenshotPath";
            this.col_AuditScreenshot.HeaderText = "截图路径";
            this.col_AuditScreenshot.MinimumWidth = 10;
            this.col_AuditScreenshot.Name = "col_AuditScreenshot";
            this.col_AuditScreenshot.ReadOnly = true;
            this.col_AuditScreenshot.Width = 150;
            // 
            // col_AuditDocument
            // 
            this.col_AuditDocument.DataPropertyName = "DocPath";
            this.col_AuditDocument.HeaderText = "文档路径";
            this.col_AuditDocument.MinimumWidth = 10;
            this.col_AuditDocument.Name = "col_AuditDocument";
            this.col_AuditDocument.ReadOnly = true;
            this.col_AuditDocument.Width = 150;
            // 
            // col_AuditSubmitTime
            // 
            this.col_AuditSubmitTime.DataPropertyName = "SubmitTime";
            this.col_AuditSubmitTime.HeaderText = "提交时间";
            this.col_AuditSubmitTime.MinimumWidth = 10;
            this.col_AuditSubmitTime.Name = "col_AuditSubmitTime";
            this.col_AuditSubmitTime.ReadOnly = true;
            this.col_AuditSubmitTime.Width = 150;
            // 
            // tableLayoutPanel_Audit
            // 
            this.tableLayoutPanel_Audit.ColumnCount = 3;
            this.tableLayoutPanel_Audit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel_Audit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tableLayoutPanel_Audit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel_Audit.Controls.Add(this.lbl_ProgressDesc, 0, 0);
            this.tableLayoutPanel_Audit.Controls.Add(this.txt_ProgressDesc, 1, 0);
            this.tableLayoutPanel_Audit.Controls.Add(this.lbl_Screenshot, 0, 1);
            this.tableLayoutPanel_Audit.Controls.Add(this.btn_ViewScreenshot, 1, 1);
            this.tableLayoutPanel_Audit.Controls.Add(this.lbl_Document, 0, 2);
            this.tableLayoutPanel_Audit.Controls.Add(this.btn_ViewDocument, 1, 2);
            this.tableLayoutPanel_Audit.Controls.Add(this.btn_AuditReject, 2, 2);
            this.tableLayoutPanel_Audit.Controls.Add(this.btn_AuditPass, 2, 1);
            this.tableLayoutPanel_Audit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Audit.Location = new System.Drawing.Point(5, 4);
            this.tableLayoutPanel_Audit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tableLayoutPanel_Audit.Name = "tableLayoutPanel_Audit";
            this.tableLayoutPanel_Audit.RowCount = 3;
            this.tableLayoutPanel_Audit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_Audit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_Audit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_Audit.Size = new System.Drawing.Size(1148, 175);
            this.tableLayoutPanel_Audit.TabIndex = 1;
            // 
            // lbl_ProgressDesc
            // 
            this.lbl_ProgressDesc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_ProgressDesc.Location = new System.Drawing.Point(5, 14);
            this.lbl_ProgressDesc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_ProgressDesc.Name = "lbl_ProgressDesc";
            this.lbl_ProgressDesc.Size = new System.Drawing.Size(145, 29);
            this.lbl_ProgressDesc.TabIndex = 0;
            this.lbl_ProgressDesc.Text = "进度描述：";
            this.lbl_ProgressDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_ProgressDesc
            // 
            this.txt_ProgressDesc.BackColor = System.Drawing.SystemColors.Window;
            this.txt_ProgressDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_ProgressDesc.Location = new System.Drawing.Point(211, 4);
            this.txt_ProgressDesc.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_ProgressDesc.Multiline = true;
            this.txt_ProgressDesc.Name = "txt_ProgressDesc";
            this.txt_ProgressDesc.ReadOnly = true;
            this.txt_ProgressDesc.Size = new System.Drawing.Size(759, 50);
            this.txt_ProgressDesc.TabIndex = 1;
            // 
            // lbl_Screenshot
            // 
            this.lbl_Screenshot.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Screenshot.Location = new System.Drawing.Point(5, 61);
            this.lbl_Screenshot.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Screenshot.Name = "lbl_Screenshot";
            this.lbl_Screenshot.Size = new System.Drawing.Size(145, 52);
            this.lbl_Screenshot.TabIndex = 2;
            this.lbl_Screenshot.Text = "任务截图：";
            this.lbl_Screenshot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_ViewScreenshot
            // 
            this.btn_ViewScreenshot.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_ViewScreenshot.Location = new System.Drawing.Point(211, 65);
            this.btn_ViewScreenshot.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_ViewScreenshot.Name = "btn_ViewScreenshot";
            this.btn_ViewScreenshot.Size = new System.Drawing.Size(150, 44);
            this.btn_ViewScreenshot.TabIndex = 3;
            this.btn_ViewScreenshot.Text = "查看截图";
            this.btn_ViewScreenshot.Click += new System.EventHandler(this.btn_ViewScreenshot_Click);
            // 
            // lbl_Document
            // 
            this.lbl_Document.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Document.Location = new System.Drawing.Point(5, 119);
            this.lbl_Document.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Document.Name = "lbl_Document";
            this.lbl_Document.Size = new System.Drawing.Size(145, 52);
            this.lbl_Document.TabIndex = 4;
            this.lbl_Document.Text = "上传文档：";
            this.lbl_Document.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_ViewDocument
            // 
            this.btn_ViewDocument.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_ViewDocument.Location = new System.Drawing.Point(211, 123);
            this.btn_ViewDocument.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_ViewDocument.Name = "btn_ViewDocument";
            this.btn_ViewDocument.Size = new System.Drawing.Size(150, 44);
            this.btn_ViewDocument.TabIndex = 5;
            this.btn_ViewDocument.Text = "查看文档";
            this.btn_ViewDocument.Click += new System.EventHandler(this.btn_ViewDocument_Click);
            // 
            // btn_AuditReject
            // 
            this.btn_AuditReject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_AuditReject.Location = new System.Drawing.Point(980, 120);
            this.btn_AuditReject.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_AuditReject.Name = "btn_AuditReject";
            this.btn_AuditReject.Size = new System.Drawing.Size(163, 51);
            this.btn_AuditReject.TabIndex = 7;
            this.btn_AuditReject.Text = "审核驳回";
            this.btn_AuditReject.Click += new System.EventHandler(this.btn_AuditReject_Click);
            // 
            // btn_AuditPass
            // 
            this.btn_AuditPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_AuditPass.Location = new System.Drawing.Point(980, 62);
            this.btn_AuditPass.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_AuditPass.Name = "btn_AuditPass";
            this.btn_AuditPass.Size = new System.Drawing.Size(163, 50);
            this.btn_AuditPass.TabIndex = 6;
            this.btn_AuditPass.Text = "审核通过";
            this.btn_AuditPass.Click += new System.EventHandler(this.btn_AuditPass_Click);
            // 
            // ProjectManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 779);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ProjectManagerForm";
            this.Text = "项目经理端";
            this.Load += new System.EventHandler(this.ProjectManagerForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_AssignTask.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AssignTaskList)).EndInit();
            this.tableLayoutPanel_Assign.ResumeLayout(false);
            this.tableLayoutPanel_Assign.PerformLayout();
            this.tabPage_AuditProgress.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AuditTaskList)).EndInit();
            this.tableLayoutPanel_Audit.ResumeLayout(false);
            this.tableLayoutPanel_Audit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_AuditProgress;

        // 全局变量
        private System.Windows.Forms.TabPage tabPage_AssignTask;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgv_AssignTaskList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Assign;
        private System.Windows.Forms.Label lbl_Project;
        private System.Windows.Forms.ComboBox cbx_Project;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.ComboBox cbx_AssignUser;
        private System.Windows.Forms.Label lbl_TaskDesc;
        private System.Windows.Forms.TextBox txt_TaskDesc;
        private System.Windows.Forms.Button btn_AssignTask;
        private System.Windows.Forms.Button btn_RefreshAssign;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgv_AuditTaskList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Audit;
        private System.Windows.Forms.Label lbl_ProgressDesc;
        private System.Windows.Forms.TextBox txt_ProgressDesc;
        private System.Windows.Forms.Label lbl_Screenshot;
        private System.Windows.Forms.Button btn_ViewScreenshot;
        private System.Windows.Forms.Label lbl_Document;
        private System.Windows.Forms.Button btn_ViewDocument;
        private System.Windows.Forms.Button btn_AuditPass;
        private System.Windows.Forms.Button btn_AuditReject;
        private System.Windows.Forms.Label lbl_TaskName;
        private System.Windows.Forms.Label lbl_TaskType;
        private System.Windows.Forms.TextBox txt_TaskName;

        private System.Windows.Forms.ComboBox cbx_TaskType; 
        private System.Windows.Forms.DataGridViewTextBoxColumn col_AuditTaskID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_AuditTaskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_AuditProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_AuditSubmitMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_AuditProgressDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_AuditScreenshot;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_AuditDocument;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_AuditSubmitTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TaskID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TaskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TaskType;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ExecutorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_StatusText;
    }
}