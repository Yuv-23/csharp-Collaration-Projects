namespace Collaraton.UI
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_Backup = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_BackupPath = new System.Windows.Forms.TextBox();
            this.btn_ChoosePath = new System.Windows.Forms.Button();
            this.btn_BackupAll = new System.Windows.Forms.Button();
            this.btn_BackupSingle = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SearchName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_ProjectStatus = new System.Windows.Forms.ComboBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_Projects = new System.Windows.Forms.DataGridView();
            this.col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ProjectDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_StatusText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CreateUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage_ProjectCRUD = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_ProOperate = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_Operate = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_ProName = new System.Windows.Forms.Label();
            this.txt_ProName = new System.Windows.Forms.TextBox();
            this.lbl_CreateUser = new System.Windows.Forms.Label();
            this.cbx_CreateUser = new System.Windows.Forms.ComboBox();
            this.lbl_ProDesc = new System.Windows.Forms.Label();
            this.txt_ProDesc = new System.Windows.Forms.TextBox();
            this.lbl_ProStatus = new System.Windows.Forms.Label();
            this.cbx_ProStatus = new System.Windows.Forms.ComboBox();
            this.btn_DelPro = new System.Windows.Forms.Button();
            this.btn_AddPro = new System.Windows.Forms.Button();
            this.btn_EditPro = new System.Windows.Forms.Button();
            this.btn_UpdateStatus = new System.Windows.Forms.Button();
            this.lbl_Tips = new System.Windows.Forms.Label();
            this.dgv_ProCRUD = new System.Windows.Forms.DataGridView();
            this.col_ProID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ProName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ProDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ProStatusText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ProCreateUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ProCreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ProCreateUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ProStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox_Backup.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Projects)).BeginInit();
            this.tabPage_ProjectCRUD.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox_ProOperate.SuspendLayout();
            this.tableLayoutPanel_Operate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProCRUD)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabPage_ProjectCRUD);
            this.TabControl.Controls.Add(this.tabPage3);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1174, 779);
            this.TabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1158, 732);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "项目列表";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox_Backup, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.725639F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.6859F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.58846F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1158, 732);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox_Backup
            // 
            this.groupBox_Backup.Controls.Add(this.tableLayoutPanel3);
            this.groupBox_Backup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Backup.Location = new System.Drawing.Point(5, 629);
            this.groupBox_Backup.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox_Backup.Name = "groupBox_Backup";
            this.groupBox_Backup.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox_Backup.Size = new System.Drawing.Size(1148, 99);
            this.groupBox_Backup.TabIndex = 3;
            this.groupBox_Backup.TabStop = false;
            this.groupBox_Backup.Text = "数据备份";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 171F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 171F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 171F));
            this.tableLayoutPanel3.Controls.Add(this.txt_BackupPath, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_ChoosePath, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_BackupAll, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_BackupSingle, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(5, 32);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1138, 63);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // txt_BackupPath
            // 
            this.txt_BackupPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_BackupPath.Location = new System.Drawing.Point(5, 14);
            this.txt_BackupPath.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_BackupPath.Name = "txt_BackupPath";
            this.txt_BackupPath.Size = new System.Drawing.Size(0, 35);
            this.txt_BackupPath.TabIndex = 0;
            // 
            // btn_ChoosePath
            // 
            this.btn_ChoosePath.BackColor = System.Drawing.Color.MistyRose;
            this.btn_ChoosePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ChoosePath.Location = new System.Drawing.Point(630, 4);
            this.btn_ChoosePath.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_ChoosePath.Name = "btn_ChoosePath";
            this.btn_ChoosePath.Size = new System.Drawing.Size(161, 55);
            this.btn_ChoosePath.TabIndex = 1;
            this.btn_ChoosePath.Text = "选择路径";
            this.btn_ChoosePath.UseVisualStyleBackColor = false;
            this.btn_ChoosePath.Click += new System.EventHandler(this.btn_ChoosePath_Click);
            // 
            // btn_BackupAll
            // 
            this.btn_BackupAll.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btn_BackupAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_BackupAll.Location = new System.Drawing.Point(801, 4);
            this.btn_BackupAll.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_BackupAll.Name = "btn_BackupAll";
            this.btn_BackupAll.Size = new System.Drawing.Size(161, 55);
            this.btn_BackupAll.TabIndex = 2;
            this.btn_BackupAll.Text = "全部备份";
            this.btn_BackupAll.UseVisualStyleBackColor = false;
            this.btn_BackupAll.Click += new System.EventHandler(this.btn_BackupAll_Click);
            // 
            // btn_BackupSingle
            // 
            this.btn_BackupSingle.BackColor = System.Drawing.Color.Honeydew;
            this.btn_BackupSingle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_BackupSingle.Location = new System.Drawing.Point(972, 4);
            this.btn_BackupSingle.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_BackupSingle.Name = "btn_BackupSingle";
            this.btn_BackupSingle.Size = new System.Drawing.Size(161, 55);
            this.btn_BackupSingle.TabIndex = 3;
            this.btn_BackupSingle.Text = "单条备份";
            this.btn_BackupSingle.UseVisualStyleBackColor = false;
            this.btn_BackupSingle.Click += new System.EventHandler(this.btn_BackupSingle_Click_1);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.18921F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.06739F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.38687F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.96211F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.69721F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.69721F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_SearchName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbx_ProjectStatus, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Search, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Refresh, 5, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1148, 63);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.Location = new System.Drawing.Point(5, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "项目名称：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_SearchName
            // 
            this.txt_SearchName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_SearchName.Location = new System.Drawing.Point(121, 14);
            this.txt_SearchName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_SearchName.Name = "txt_SearchName";
            this.txt_SearchName.Size = new System.Drawing.Size(289, 35);
            this.txt_SearchName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.Location = new System.Drawing.Point(420, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 63);
            this.label2.TabIndex = 2;
            this.label2.Text = "项目状态：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbx_ProjectStatus
            // 
            this.cbx_ProjectStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbx_ProjectStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_ProjectStatus.Location = new System.Drawing.Point(539, 15);
            this.cbx_ProjectStatus.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbx_ProjectStatus.Name = "cbx_ProjectStatus";
            this.cbx_ProjectStatus.Size = new System.Drawing.Size(295, 32);
            this.cbx_ProjectStatus.TabIndex = 3;
            // 
            // btn_Search
            // 
            this.btn_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Search.Location = new System.Drawing.Point(882, 4);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(124, 55);
            this.btn_Search.TabIndex = 4;
            this.btn_Search.Text = "查询";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Refresh.Location = new System.Drawing.Point(1016, 4);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(127, 55);
            this.btn_Refresh.TabIndex = 5;
            this.btn_Refresh.Text = "刷新";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click_1);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1148F));
            this.tableLayoutPanel4.Controls.Add(this.dgv_Projects, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(5, 75);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1148, 546);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // dgv_Projects
            // 
            this.dgv_Projects.ColumnHeadersHeight = 46;
            this.dgv_Projects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ID,
            this.col_ProjectName,
            this.col_ProjectDesc,
            this.col_StatusText,
            this.col_CreateTime,
            this.col_CreateUserName});
            this.dgv_Projects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Projects.Location = new System.Drawing.Point(5, 4);
            this.dgv_Projects.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgv_Projects.Name = "dgv_Projects";
            this.dgv_Projects.ReadOnly = true;
            this.dgv_Projects.RowHeadersVisible = false;
            this.dgv_Projects.RowHeadersWidth = 82;
            this.dgv_Projects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Projects.Size = new System.Drawing.Size(1138, 538);
            this.dgv_Projects.TabIndex = 0;
            // 
            // col_ID
            // 
            this.col_ID.DataPropertyName = "ID";
            this.col_ID.HeaderText = "项目ID";
            this.col_ID.MinimumWidth = 10;
            this.col_ID.Name = "col_ID";
            this.col_ID.ReadOnly = true;
            this.col_ID.Width = 80;
            // 
            // col_ProjectName
            // 
            this.col_ProjectName.DataPropertyName = "ProjectName";
            this.col_ProjectName.HeaderText = "项目名称";
            this.col_ProjectName.MinimumWidth = 10;
            this.col_ProjectName.Name = "col_ProjectName";
            this.col_ProjectName.ReadOnly = true;
            this.col_ProjectName.Width = 200;
            // 
            // col_ProjectDesc
            // 
            this.col_ProjectDesc.DataPropertyName = "ProjectDesc";
            this.col_ProjectDesc.HeaderText = "项目描述";
            this.col_ProjectDesc.MinimumWidth = 10;
            this.col_ProjectDesc.Name = "col_ProjectDesc";
            this.col_ProjectDesc.ReadOnly = true;
            this.col_ProjectDesc.Width = 300;
            // 
            // col_StatusText
            // 
            this.col_StatusText.DataPropertyName = "StatusText";
            this.col_StatusText.HeaderText = "项目状态";
            this.col_StatusText.MinimumWidth = 10;
            this.col_StatusText.Name = "col_StatusText";
            this.col_StatusText.ReadOnly = true;
            this.col_StatusText.Width = 200;
            // 
            // col_CreateTime
            // 
            this.col_CreateTime.DataPropertyName = "CreateTime";
            this.col_CreateTime.HeaderText = "创建时间";
            this.col_CreateTime.MinimumWidth = 10;
            this.col_CreateTime.Name = "col_CreateTime";
            this.col_CreateTime.ReadOnly = true;
            this.col_CreateTime.Width = 180;
            // 
            // col_CreateUserName
            // 
            this.col_CreateUserName.DataPropertyName = "CreateUserName";
            this.col_CreateUserName.HeaderText = "创建人";
            this.col_CreateUserName.MinimumWidth = 10;
            this.col_CreateUserName.Name = "col_CreateUserName";
            this.col_CreateUserName.ReadOnly = true;
            this.col_CreateUserName.Width = 200;
            // 
            // tabPage_ProjectCRUD
            // 
            this.tabPage_ProjectCRUD.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage_ProjectCRUD.Controls.Add(this.tableLayoutPanel5);
            this.tabPage_ProjectCRUD.Location = new System.Drawing.Point(8, 39);
            this.tabPage_ProjectCRUD.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabPage_ProjectCRUD.Name = "tabPage_ProjectCRUD";
            this.tabPage_ProjectCRUD.Size = new System.Drawing.Size(1158, 732);
            this.tabPage_ProjectCRUD.TabIndex = 1;
            this.tabPage_ProjectCRUD.Text = "项目管理";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tabPage3.Location = new System.Drawing.Point(8, 39);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1158, 732);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "用户权限管理";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.dgv_ProCRUD, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.groupBox_ProOperate, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1158, 732);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // groupBox_ProOperate
            // 
            this.groupBox_ProOperate.Controls.Add(this.tableLayoutPanel_Operate);
            this.groupBox_ProOperate.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_ProOperate.Location = new System.Drawing.Point(5, 4);
            this.groupBox_ProOperate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox_ProOperate.Name = "groupBox_ProOperate";
            this.groupBox_ProOperate.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox_ProOperate.Size = new System.Drawing.Size(1148, 248);
            this.groupBox_ProOperate.TabIndex = 1;
            this.groupBox_ProOperate.TabStop = false;
            this.groupBox_ProOperate.Text = "项目操作";
            // 
            // tableLayoutPanel_Operate
            // 
            this.tableLayoutPanel_Operate.ColumnCount = 4;
            this.tableLayoutPanel_Operate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.76596F));
            this.tableLayoutPanel_Operate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.23404F));
            this.tableLayoutPanel_Operate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.76596F));
            this.tableLayoutPanel_Operate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.23404F));
            this.tableLayoutPanel_Operate.Controls.Add(this.lbl_ProName, 0, 0);
            this.tableLayoutPanel_Operate.Controls.Add(this.txt_ProName, 1, 0);
            this.tableLayoutPanel_Operate.Controls.Add(this.lbl_CreateUser, 2, 0);
            this.tableLayoutPanel_Operate.Controls.Add(this.cbx_CreateUser, 3, 0);
            this.tableLayoutPanel_Operate.Controls.Add(this.lbl_ProDesc, 0, 1);
            this.tableLayoutPanel_Operate.Controls.Add(this.txt_ProDesc, 1, 1);
            this.tableLayoutPanel_Operate.Controls.Add(this.lbl_ProStatus, 2, 1);
            this.tableLayoutPanel_Operate.Controls.Add(this.cbx_ProStatus, 3, 1);
            this.tableLayoutPanel_Operate.Controls.Add(this.btn_DelPro, 3, 2);
            this.tableLayoutPanel_Operate.Controls.Add(this.btn_AddPro, 0, 2);
            this.tableLayoutPanel_Operate.Controls.Add(this.btn_EditPro, 1, 2);
            this.tableLayoutPanel_Operate.Controls.Add(this.btn_UpdateStatus, 2, 2);
            this.tableLayoutPanel_Operate.Controls.Add(this.lbl_Tips, 1, 3);
            this.tableLayoutPanel_Operate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Operate.Location = new System.Drawing.Point(5, 32);
            this.tableLayoutPanel_Operate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tableLayoutPanel_Operate.Name = "tableLayoutPanel_Operate";
            this.tableLayoutPanel_Operate.RowCount = 4;
            this.tableLayoutPanel_Operate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_Operate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_Operate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_Operate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_Operate.Size = new System.Drawing.Size(1138, 212);
            this.tableLayoutPanel_Operate.TabIndex = 0;
            // 
            // lbl_ProName
            // 
            this.lbl_ProName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_ProName.Location = new System.Drawing.Point(5, 0);
            this.lbl_ProName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_ProName.Name = "lbl_ProName";
            this.lbl_ProName.Size = new System.Drawing.Size(135, 53);
            this.lbl_ProName.TabIndex = 0;
            this.lbl_ProName.Text = "项目名称：";
            this.lbl_ProName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_ProName
            // 
            this.txt_ProName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_ProName.Location = new System.Drawing.Point(150, 9);
            this.txt_ProName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_ProName.Name = "txt_ProName";
            this.txt_ProName.Size = new System.Drawing.Size(413, 35);
            this.txt_ProName.TabIndex = 1;
            // 
            // lbl_CreateUser
            // 
            this.lbl_CreateUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_CreateUser.Location = new System.Drawing.Point(573, 0);
            this.lbl_CreateUser.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_CreateUser.Name = "lbl_CreateUser";
            this.lbl_CreateUser.Size = new System.Drawing.Size(135, 53);
            this.lbl_CreateUser.TabIndex = 2;
            this.lbl_CreateUser.Text = "创建人：";
            this.lbl_CreateUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbx_CreateUser
            // 
            this.cbx_CreateUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbx_CreateUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_CreateUser.Location = new System.Drawing.Point(718, 10);
            this.cbx_CreateUser.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbx_CreateUser.Name = "cbx_CreateUser";
            this.cbx_CreateUser.Size = new System.Drawing.Size(415, 32);
            this.cbx_CreateUser.TabIndex = 3;
            // 
            // lbl_ProDesc
            // 
            this.lbl_ProDesc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_ProDesc.Location = new System.Drawing.Point(5, 53);
            this.lbl_ProDesc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_ProDesc.Name = "lbl_ProDesc";
            this.lbl_ProDesc.Size = new System.Drawing.Size(135, 53);
            this.lbl_ProDesc.TabIndex = 4;
            this.lbl_ProDesc.Text = "项目描述：";
            this.lbl_ProDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_ProDesc
            // 
            this.txt_ProDesc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_ProDesc.Location = new System.Drawing.Point(150, 57);
            this.txt_ProDesc.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_ProDesc.Multiline = true;
            this.txt_ProDesc.Name = "txt_ProDesc";
            this.txt_ProDesc.Size = new System.Drawing.Size(413, 45);
            this.txt_ProDesc.TabIndex = 5;
            // 
            // lbl_ProStatus
            // 
            this.lbl_ProStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_ProStatus.Location = new System.Drawing.Point(573, 53);
            this.lbl_ProStatus.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_ProStatus.Name = "lbl_ProStatus";
            this.lbl_ProStatus.Size = new System.Drawing.Size(135, 53);
            this.lbl_ProStatus.TabIndex = 6;
            this.lbl_ProStatus.Text = "项目状态：";
            this.lbl_ProStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbx_ProStatus
            // 
            this.cbx_ProStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbx_ProStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_ProStatus.Location = new System.Drawing.Point(718, 63);
            this.cbx_ProStatus.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbx_ProStatus.Name = "cbx_ProStatus";
            this.cbx_ProStatus.Size = new System.Drawing.Size(415, 32);
            this.cbx_ProStatus.TabIndex = 7;
            // 
            // btn_DelPro
            // 
            this.btn_DelPro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DelPro.BackColor = System.Drawing.Color.LavenderBlush;
            this.btn_DelPro.Location = new System.Drawing.Point(983, 110);
            this.btn_DelPro.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_DelPro.Name = "btn_DelPro";
            this.btn_DelPro.Size = new System.Drawing.Size(150, 45);
            this.btn_DelPro.TabIndex = 11;
            this.btn_DelPro.Text = "删除";
            this.btn_DelPro.UseVisualStyleBackColor = false;
            this.btn_DelPro.Click += new System.EventHandler(this.btn_DelPro_Click);
            // 
            // btn_AddPro
            // 
            this.btn_AddPro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_AddPro.BackColor = System.Drawing.Color.LavenderBlush;
            this.btn_AddPro.Location = new System.Drawing.Point(5, 110);
            this.btn_AddPro.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_AddPro.Name = "btn_AddPro";
            this.btn_AddPro.Size = new System.Drawing.Size(135, 45);
            this.btn_AddPro.TabIndex = 9;
            this.btn_AddPro.Text = "新增";
            this.btn_AddPro.UseVisualStyleBackColor = false;
            this.btn_AddPro.Click += new System.EventHandler(this.btn_AddPro_Click);
            // 
            // btn_EditPro
            // 
            this.btn_EditPro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_EditPro.BackColor = System.Drawing.Color.LavenderBlush;
            this.btn_EditPro.Location = new System.Drawing.Point(281, 110);
            this.btn_EditPro.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_EditPro.Name = "btn_EditPro";
            this.btn_EditPro.Size = new System.Drawing.Size(150, 45);
            this.btn_EditPro.TabIndex = 10;
            this.btn_EditPro.Text = "编辑";
            this.btn_EditPro.UseVisualStyleBackColor = false;
            this.btn_EditPro.Click += new System.EventHandler(this.btn_EditPro_Click);
            // 
            // btn_UpdateStatus
            // 
            this.btn_UpdateStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_UpdateStatus.BackColor = System.Drawing.Color.LavenderBlush;
            this.btn_UpdateStatus.Location = new System.Drawing.Point(573, 110);
            this.btn_UpdateStatus.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_UpdateStatus.Name = "btn_UpdateStatus";
            this.btn_UpdateStatus.Size = new System.Drawing.Size(135, 45);
            this.btn_UpdateStatus.TabIndex = 12;
            this.btn_UpdateStatus.Text = "修改状态";
            this.btn_UpdateStatus.UseVisualStyleBackColor = false;
            this.btn_UpdateStatus.Click += new System.EventHandler(this.btn_UpdateStatus_Click);
            // 
            // lbl_Tips
            // 
            this.lbl_Tips.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Tips.ForeColor = System.Drawing.Color.Red;
            this.lbl_Tips.Location = new System.Drawing.Point(150, 159);
            this.lbl_Tips.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Tips.Name = "lbl_Tips";
            this.lbl_Tips.Size = new System.Drawing.Size(413, 53);
            this.lbl_Tips.TabIndex = 8;
            this.lbl_Tips.Text = "操作提示：先选中行再编辑/删除";
            this.lbl_Tips.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgv_ProCRUD
            // 
            this.dgv_ProCRUD.ColumnHeadersHeight = 46;
            this.dgv_ProCRUD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ProID,
            this.col_ProName,
            this.col_ProDesc,
            this.col_ProStatusText,
            this.col_ProCreateUserName,
            this.col_ProCreateTime,
            this.col_ProCreateUserID,
            this.col_ProStatus});
            this.dgv_ProCRUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ProCRUD.Location = new System.Drawing.Point(5, 260);
            this.dgv_ProCRUD.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgv_ProCRUD.Name = "dgv_ProCRUD";
            this.dgv_ProCRUD.ReadOnly = true;
            this.dgv_ProCRUD.RowHeadersVisible = false;
            this.dgv_ProCRUD.RowHeadersWidth = 82;
            this.dgv_ProCRUD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ProCRUD.Size = new System.Drawing.Size(1148, 468);
            this.dgv_ProCRUD.TabIndex = 2;
            // 
            // col_ProID
            // 
            this.col_ProID.DataPropertyName = "ID";
            this.col_ProID.HeaderText = "项目ID";
            this.col_ProID.MinimumWidth = 10;
            this.col_ProID.Name = "col_ProID";
            this.col_ProID.ReadOnly = true;
            this.col_ProID.Width = 80;
            // 
            // col_ProName
            // 
            this.col_ProName.DataPropertyName = "ProjectName";
            this.col_ProName.HeaderText = "项目名称";
            this.col_ProName.MinimumWidth = 10;
            this.col_ProName.Name = "col_ProName";
            this.col_ProName.ReadOnly = true;
            this.col_ProName.Width = 200;
            // 
            // col_ProDesc
            // 
            this.col_ProDesc.DataPropertyName = "ProjectDesc";
            this.col_ProDesc.HeaderText = "项目描述";
            this.col_ProDesc.MinimumWidth = 10;
            this.col_ProDesc.Name = "col_ProDesc";
            this.col_ProDesc.ReadOnly = true;
            this.col_ProDesc.Width = 300;
            // 
            // col_ProStatusText
            // 
            this.col_ProStatusText.DataPropertyName = "StatusText";
            this.col_ProStatusText.HeaderText = "项目状态";
            this.col_ProStatusText.MinimumWidth = 10;
            this.col_ProStatusText.Name = "col_ProStatusText";
            this.col_ProStatusText.ReadOnly = true;
            this.col_ProStatusText.Width = 200;
            // 
            // col_ProCreateUserName
            // 
            this.col_ProCreateUserName.DataPropertyName = "CreateUserName";
            this.col_ProCreateUserName.HeaderText = "创建人";
            this.col_ProCreateUserName.MinimumWidth = 10;
            this.col_ProCreateUserName.Name = "col_ProCreateUserName";
            this.col_ProCreateUserName.ReadOnly = true;
            this.col_ProCreateUserName.Width = 200;
            // 
            // col_ProCreateTime
            // 
            this.col_ProCreateTime.DataPropertyName = "CreateTime";
            this.col_ProCreateTime.HeaderText = "创建时间";
            this.col_ProCreateTime.MinimumWidth = 10;
            this.col_ProCreateTime.Name = "col_ProCreateTime";
            this.col_ProCreateTime.ReadOnly = true;
            this.col_ProCreateTime.Width = 180;
            // 
            // col_ProCreateUserID
            // 
            this.col_ProCreateUserID.DataPropertyName = "CreateUserID";
            this.col_ProCreateUserID.HeaderText = "创建人ID";
            this.col_ProCreateUserID.MinimumWidth = 10;
            this.col_ProCreateUserID.Name = "col_ProCreateUserID";
            this.col_ProCreateUserID.ReadOnly = true;
            this.col_ProCreateUserID.Visible = false;
            this.col_ProCreateUserID.Width = 200;
            // 
            // col_ProStatus
            // 
            this.col_ProStatus.DataPropertyName = "Status";
            this.col_ProStatus.HeaderText = "状态值";
            this.col_ProStatus.MinimumWidth = 10;
            this.col_ProStatus.Name = "col_ProStatus";
            this.col_ProStatus.ReadOnly = true;
            this.col_ProStatus.Visible = false;
            this.col_ProStatus.Width = 200;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1174, 779);
            this.Controls.Add(this.TabControl);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AdminForm";
            this.Text = "管理员界面";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox_Backup.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Projects)).EndInit();
            this.tabPage_ProjectCRUD.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.groupBox_ProOperate.ResumeLayout(false);
            this.tableLayoutPanel_Operate.ResumeLayout(false);
            this.tableLayoutPanel_Operate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProCRUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage_ProjectCRUD;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_ProjectStatus;
        private System.Windows.Forms.TextBox txt_SearchName;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DataGridView dgv_Projects;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ProjectDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_StatusText;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CreateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CreateUserName;
        private System.Windows.Forms.GroupBox groupBox_Backup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txt_BackupPath;
        private System.Windows.Forms.Button btn_ChoosePath;
        private System.Windows.Forms.Button btn_BackupAll;
        private System.Windows.Forms.Button btn_BackupSingle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.DataGridView dgv_ProCRUD;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ProID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ProName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ProDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ProStatusText;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ProCreateUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ProCreateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ProCreateUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ProStatus;
        private System.Windows.Forms.GroupBox groupBox_ProOperate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Operate;
        private System.Windows.Forms.Label lbl_ProName;
        private System.Windows.Forms.TextBox txt_ProName;
        private System.Windows.Forms.Label lbl_CreateUser;
        private System.Windows.Forms.ComboBox cbx_CreateUser;
        private System.Windows.Forms.Label lbl_ProDesc;
        private System.Windows.Forms.TextBox txt_ProDesc;
        private System.Windows.Forms.Label lbl_ProStatus;
        private System.Windows.Forms.ComboBox cbx_ProStatus;
        private System.Windows.Forms.Button btn_DelPro;
        private System.Windows.Forms.Button btn_AddPro;
        private System.Windows.Forms.Button btn_EditPro;
        private System.Windows.Forms.Button btn_UpdateStatus;
        private System.Windows.Forms.Label lbl_Tips;
    }
}