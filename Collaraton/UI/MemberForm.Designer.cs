namespace Collaraton.UI
{
    partial class MemberForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMyTasks = new System.Windows.Forms.TabPage();
            this.tableTask = new System.Windows.Forms.TableLayoutPanel();
            this.dgvMyTasks = new System.Windows.Forms.DataGridView();
            this.colTaskID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTaskType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDocUploaded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTaskList = new System.Windows.Forms.Label();
            this.btnExportPdf = new System.Windows.Forms.Button();
            this.tabSubmitTask = new System.Windows.Forms.TabPage();
            this.tableSubmitTotal = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSelectDoc = new System.Windows.Forms.Label();
            this.cbxDocType = new System.Windows.Forms.ComboBox();
            this.lblDocType = new System.Windows.Forms.Label();
            this.cbxSubmitTask = new System.Windows.Forms.ComboBox();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.lblTaskType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScreenshot = new System.Windows.Forms.Label();
            this.cbxTaskType = new System.Windows.Forms.ComboBox();
            this.panelScreenshot = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtScreenshotPath = new System.Windows.Forms.TextBox();
            this.btnSelectScreenshot = new System.Windows.Forms.Button();
            this.txtTaskDesc = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSelectDoc = new System.Windows.Forms.Button();
            this.txtDocPath = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabMyTasks.SuspendLayout();
            this.tableTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyTasks)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.tabSubmitTask.SuspendLayout();
            this.tableSubmitTotal.SuspendLayout();
            this.panelScreenshot.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblStatus);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Size = new System.Drawing.Size(1174, 779);
            this.splitContainer1.SplitterDistance = 692;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMyTasks);
            this.tabControl1.Controls.Add(this.tabSubmitTask);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.ItemSize = new System.Drawing.Size(120, 30);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1174, 692);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabMyTasks
            // 
            this.tabMyTasks.Controls.Add(this.tableTask);
            this.tabMyTasks.Location = new System.Drawing.Point(8, 38);
            this.tabMyTasks.Name = "tabMyTasks";
            this.tabMyTasks.Padding = new System.Windows.Forms.Padding(3);
            this.tabMyTasks.Size = new System.Drawing.Size(1158, 646);
            this.tabMyTasks.TabIndex = 0;
            this.tabMyTasks.Text = "我的任务";
            this.tabMyTasks.UseVisualStyleBackColor = true;
            // 
            // tableTask
            // 
            this.tableTask.BackColor = System.Drawing.Color.White;
            this.tableTask.ColumnCount = 1;
            this.tableTask.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableTask.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableTask.Controls.Add(this.dgvMyTasks, 0, 1);
            this.tableTask.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableTask.Location = new System.Drawing.Point(3, 3);
            this.tableTask.Name = "tableTask";
            this.tableTask.RowCount = 2;
            this.tableTask.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableTask.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableTask.Size = new System.Drawing.Size(1152, 640);
            this.tableTask.TabIndex = 0;
            // 
            // dgvMyTasks
            // 
            this.dgvMyTasks.AllowUserToAddRows = false;
            this.dgvMyTasks.BackgroundColor = System.Drawing.Color.White;
            this.dgvMyTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTaskID,
            this.colTaskName,
            this.colTaskType,
            this.colStatus,
            this.colDocUploaded,
            this.colCreateTime});
            this.dgvMyTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMyTasks.GridColor = System.Drawing.Color.White;
            this.dgvMyTasks.Location = new System.Drawing.Point(3, 83);
            this.dgvMyTasks.Name = "dgvMyTasks";
            this.dgvMyTasks.ReadOnly = true;
            this.dgvMyTasks.RowHeadersVisible = false;
            this.dgvMyTasks.RowHeadersWidth = 82;
            this.dgvMyTasks.RowTemplate.Height = 37;
            this.dgvMyTasks.Size = new System.Drawing.Size(1146, 554);
            this.dgvMyTasks.TabIndex = 1;
            this.dgvMyTasks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReportPreview_CellContentClick);
            // 
            // colTaskID
            // 
            this.colTaskID.HeaderText = "任务 ID";
            this.colTaskID.MinimumWidth = 10;
            this.colTaskID.Name = "colTaskID";
            this.colTaskID.ReadOnly = true;
            this.colTaskID.Width = 160;
            // 
            // colTaskName
            // 
            this.colTaskName.HeaderText = "任务名称";
            this.colTaskName.MinimumWidth = 10;
            this.colTaskName.Name = "colTaskName";
            this.colTaskName.ReadOnly = true;
            this.colTaskName.Width = 200;
            // 
            // colTaskType
            // 
            this.colTaskType.HeaderText = "任务类型";
            this.colTaskType.MinimumWidth = 10;
            this.colTaskType.Name = "colTaskType";
            this.colTaskType.ReadOnly = true;
            this.colTaskType.Width = 200;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "任务状态";
            this.colStatus.MinimumWidth = 10;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 180;
            // 
            // colDocUploaded
            // 
            this.colDocUploaded.HeaderText = "已上传文档";
            this.colDocUploaded.MinimumWidth = 10;
            this.colDocUploaded.Name = "colDocUploaded";
            this.colDocUploaded.ReadOnly = true;
            this.colDocUploaded.Width = 300;
            // 
            // colCreateTime
            // 
            this.colCreateTime.HeaderText = "创建时间";
            this.colCreateTime.MinimumWidth = 10;
            this.colCreateTime.Name = "colCreateTime";
            this.colCreateTime.ReadOnly = true;
            this.colCreateTime.Width = 200;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel6.Controls.Add(this.lblTaskList, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnExportPdf, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1146, 74);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // lblTaskList
            // 
            this.lblTaskList.AutoSize = true;
            this.lblTaskList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTaskList.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTaskList.Location = new System.Drawing.Point(3, 0);
            this.lblTaskList.Name = "lblTaskList";
            this.lblTaskList.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTaskList.Size = new System.Drawing.Size(968, 74);
            this.lblTaskList.TabIndex = 1;
            this.lblTaskList.Text = "我的任务列表";
            this.lblTaskList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnExportPdf
            // 
            this.btnExportPdf.BackColor = System.Drawing.Color.LightGreen;
            this.btnExportPdf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExportPdf.Location = new System.Drawing.Point(977, 3);
            this.btnExportPdf.Name = "btnExportPdf";
            this.btnExportPdf.Size = new System.Drawing.Size(166, 68);
            this.btnExportPdf.TabIndex = 0;
            this.btnExportPdf.Text = "打印进度";
            this.btnExportPdf.UseVisualStyleBackColor = false;
            this.btnExportPdf.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // tabSubmitTask
            // 
            this.tabSubmitTask.Controls.Add(this.tableSubmitTotal);
            this.tabSubmitTask.Location = new System.Drawing.Point(8, 38);
            this.tabSubmitTask.Name = "tabSubmitTask";
            this.tabSubmitTask.Padding = new System.Windows.Forms.Padding(3);
            this.tabSubmitTask.Size = new System.Drawing.Size(1158, 646);
            this.tabSubmitTask.TabIndex = 1;
            this.tabSubmitTask.Text = "提交进度";
            this.tabSubmitTask.UseVisualStyleBackColor = true;
            this.tabSubmitTask.Click += new System.EventHandler(this.tabSubmitTask_Click);
            // 
            // tableSubmitTotal
            // 
            this.tableSubmitTotal.ColumnCount = 2;
            this.tableSubmitTotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.52778F));
            this.tableSubmitTotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.47222F));
            this.tableSubmitTotal.Controls.Add(this.button1, 1, 6);
            this.tableSubmitTotal.Controls.Add(this.lblSelectDoc, 0, 5);
            this.tableSubmitTotal.Controls.Add(this.cbxDocType, 1, 4);
            this.tableSubmitTotal.Controls.Add(this.lblDocType, 0, 4);
            this.tableSubmitTotal.Controls.Add(this.cbxSubmitTask, 1, 0);
            this.tableSubmitTotal.Controls.Add(this.lblTaskName, 0, 0);
            this.tableSubmitTotal.Controls.Add(this.lblTaskType, 0, 1);
            this.tableSubmitTotal.Controls.Add(this.label1, 0, 2);
            this.tableSubmitTotal.Controls.Add(this.lblScreenshot, 0, 3);
            this.tableSubmitTotal.Controls.Add(this.cbxTaskType, 1, 1);
            this.tableSubmitTotal.Controls.Add(this.panelScreenshot, 1, 3);
            this.tableSubmitTotal.Controls.Add(this.txtTaskDesc, 1, 2);
            this.tableSubmitTotal.Controls.Add(this.tableLayoutPanel2, 1, 5);
            this.tableSubmitTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableSubmitTotal.Location = new System.Drawing.Point(3, 3);
            this.tableSubmitTotal.Name = "tableSubmitTotal";
            this.tableSubmitTotal.RowCount = 7;
            this.tableSubmitTotal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.26343F));
            this.tableSubmitTotal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.26342F));
            this.tableSubmitTotal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.15855F));
            this.tableSubmitTotal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.75899F));
            this.tableSubmitTotal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.16412F));
            this.tableSubmitTotal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.75899F));
            this.tableSubmitTotal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.63249F));
            this.tableSubmitTotal.Size = new System.Drawing.Size(1152, 640);
            this.tableSubmitTotal.TabIndex = 0;
            this.tableSubmitTotal.Paint += new System.Windows.Forms.PaintEventHandler(this.tableSubmitTotal_Paint);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(970, 573);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 64);
            this.button1.TabIndex = 18;
            this.button1.Text = "提交";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnSubmitTask_Click);
            // 
            // lblSelectDoc
            // 
            this.lblSelectDoc.AutoSize = true;
            this.lblSelectDoc.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSelectDoc.Font = new System.Drawing.Font("微软雅黑", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSelectDoc.Location = new System.Drawing.Point(3, 489);
            this.lblSelectDoc.Name = "lblSelectDoc";
            this.lblSelectDoc.Size = new System.Drawing.Size(123, 81);
            this.lblSelectDoc.TabIndex = 14;
            this.lblSelectDoc.Text = "文档选择";
            this.lblSelectDoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxDocType
            // 
            this.cbxDocType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxDocType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDocType.Font = new System.Drawing.Font("微软雅黑", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxDocType.FormattingEnabled = true;
            this.cbxDocType.Items.AddRange(new object[] {
            "需求文档",
            "测试报告",
            "代码包",
            "会议纪要",
            "其他"});
            this.cbxDocType.Location = new System.Drawing.Point(251, 408);
            this.cbxDocType.Name = "cbxDocType";
            this.cbxDocType.Size = new System.Drawing.Size(898, 43);
            this.cbxDocType.TabIndex = 13;
            // 
            // lblDocType
            // 
            this.lblDocType.AutoSize = true;
            this.lblDocType.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDocType.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.lblDocType.Location = new System.Drawing.Point(3, 405);
            this.lblDocType.Name = "lblDocType";
            this.lblDocType.Size = new System.Drawing.Size(123, 84);
            this.lblDocType.TabIndex = 12;
            this.lblDocType.Text = "文档类型";
            this.lblDocType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxSubmitTask
            // 
            this.cbxSubmitTask.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxSubmitTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxSubmitTask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSubmitTask.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.cbxSubmitTask.FormattingEnabled = true;
            this.cbxSubmitTask.Location = new System.Drawing.Point(251, 3);
            this.cbxSubmitTask.Name = "cbxSubmitTask";
            this.cbxSubmitTask.Size = new System.Drawing.Size(898, 43);
            this.cbxSubmitTask.TabIndex = 11;
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTaskName.Font = new System.Drawing.Font("微软雅黑", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTaskName.Location = new System.Drawing.Point(3, 0);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(150, 72);
            this.lblTaskName.TabIndex = 2;
            this.lblTaskName.Text = "选择任务：";
            this.lblTaskName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTaskType
            // 
            this.lblTaskType.AutoSize = true;
            this.lblTaskType.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTaskType.Font = new System.Drawing.Font("微软雅黑", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTaskType.Location = new System.Drawing.Point(3, 72);
            this.lblTaskType.Name = "lblTaskType";
            this.lblTaskType.Size = new System.Drawing.Size(204, 72);
            this.lblTaskType.TabIndex = 3;
            this.lblTaskType.Text = "当前任务状态：";
            this.lblTaskType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 180);
            this.label1.TabIndex = 4;
            this.label1.Text = "任务描述";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScreenshot
            // 
            this.lblScreenshot.AutoSize = true;
            this.lblScreenshot.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblScreenshot.Font = new System.Drawing.Font("微软雅黑", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblScreenshot.Location = new System.Drawing.Point(3, 324);
            this.lblScreenshot.Name = "lblScreenshot";
            this.lblScreenshot.Size = new System.Drawing.Size(123, 81);
            this.lblScreenshot.TabIndex = 5;
            this.lblScreenshot.Text = "任务截图";
            this.lblScreenshot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxTaskType
            // 
            this.cbxTaskType.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbxTaskType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTaskType.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.cbxTaskType.FormattingEnabled = true;
            this.cbxTaskType.Items.AddRange(new object[] {
            "未开始",
            "进行中",
            "已提交",
            "已审核",
            "驳回"});
            this.cbxTaskType.Location = new System.Drawing.Point(251, 75);
            this.cbxTaskType.Name = "cbxTaskType";
            this.cbxTaskType.Size = new System.Drawing.Size(302, 43);
            this.cbxTaskType.TabIndex = 8;
            // 
            // panelScreenshot
            // 
            this.panelScreenshot.Controls.Add(this.tableLayoutPanel1);
            this.panelScreenshot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelScreenshot.Location = new System.Drawing.Point(251, 327);
            this.panelScreenshot.Name = "panelScreenshot";
            this.panelScreenshot.Size = new System.Drawing.Size(898, 75);
            this.panelScreenshot.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.14922F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.85078F));
            this.tableLayoutPanel1.Controls.Add(this.txtScreenshotPath, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSelectScreenshot, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(898, 75);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtScreenshotPath
            // 
            this.txtScreenshotPath.BackColor = System.Drawing.Color.LightGray;
            this.txtScreenshotPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtScreenshotPath.Location = new System.Drawing.Point(156, 3);
            this.txtScreenshotPath.Name = "txtScreenshotPath";
            this.txtScreenshotPath.ReadOnly = true;
            this.txtScreenshotPath.Size = new System.Drawing.Size(739, 39);
            this.txtScreenshotPath.TabIndex = 0;
            // 
            // btnSelectScreenshot
            // 
            this.btnSelectScreenshot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelectScreenshot.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.btnSelectScreenshot.Location = new System.Drawing.Point(3, 3);
            this.btnSelectScreenshot.Name = "btnSelectScreenshot";
            this.btnSelectScreenshot.Size = new System.Drawing.Size(147, 69);
            this.btnSelectScreenshot.TabIndex = 1;
            this.btnSelectScreenshot.Text = "选择截图";
            this.btnSelectScreenshot.UseVisualStyleBackColor = true;
            this.btnSelectScreenshot.Click += new System.EventHandler(this.btnSelectScreenshot_Click);
            // 
            // txtTaskDesc
            // 
            this.txtTaskDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTaskDesc.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.txtTaskDesc.Location = new System.Drawing.Point(251, 147);
            this.txtTaskDesc.Multiline = true;
            this.txtTaskDesc.Name = "txtTaskDesc";
            this.txtTaskDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTaskDesc.Size = new System.Drawing.Size(898, 174);
            this.txtTaskDesc.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(251, 492);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(898, 75);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.37668F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.62332F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.btnSelectDoc, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtDocPath, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(892, 69);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // btnSelectDoc
            // 
            this.btnSelectDoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelectDoc.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.btnSelectDoc.Location = new System.Drawing.Point(3, 3);
            this.btnSelectDoc.Name = "btnSelectDoc";
            this.btnSelectDoc.Size = new System.Drawing.Size(148, 63);
            this.btnSelectDoc.TabIndex = 1;
            this.btnSelectDoc.Text = "选择文档";
            this.btnSelectDoc.UseVisualStyleBackColor = true;
            this.btnSelectDoc.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDocPath
            // 
            this.txtDocPath.BackColor = System.Drawing.Color.LightGray;
            this.txtDocPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDocPath.Location = new System.Drawing.Point(157, 3);
            this.txtDocPath.Name = "txtDocPath";
            this.txtDocPath.ReadOnly = true;
            this.txtDocPath.Size = new System.Drawing.Size(732, 39);
            this.txtDocPath.TabIndex = 2;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.ForeColor = System.Drawing.Color.DarkGray;
            this.lblStatus.Location = new System.Drawing.Point(0, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(298, 24);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "当前状态：未执行任何操作";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(131, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "label5";
            // 
            // MemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 779);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MemberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "成员中心";
            this.Load += new System.EventHandler(this.MemberForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabMyTasks.ResumeLayout(false);
            this.tableTask.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyTasks)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tabSubmitTask.ResumeLayout(false);
            this.tableSubmitTotal.ResumeLayout(false);
            this.tableSubmitTotal.PerformLayout();
            this.panelScreenshot.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMyTasks;
        private System.Windows.Forms.TableLayoutPanel tableTask;
        private System.Windows.Forms.DataGridView dgvMyTasks;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaskID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaskType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocUploaded;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreateTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label lblTaskList;
        private System.Windows.Forms.Button btnExportPdf;
        private System.Windows.Forms.TabPage tabSubmitTask;
        private System.Windows.Forms.TableLayoutPanel tableSubmitTotal;
        private System.Windows.Forms.Label lblTaskName;
        private System.Windows.Forms.Label lblTaskType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScreenshot;
        private System.Windows.Forms.ComboBox cbxTaskType;
        private System.Windows.Forms.Panel panelScreenshot;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtScreenshotPath;
        private System.Windows.Forms.Button btnSelectScreenshot;
        private System.Windows.Forms.TextBox txtTaskDesc;
        private System.Windows.Forms.ComboBox cbxSubmitTask;
        private System.Windows.Forms.Label lblSelectDoc;
        private System.Windows.Forms.ComboBox cbxDocType;
        private System.Windows.Forms.Label lblDocType;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnSelectDoc;
        private System.Windows.Forms.TextBox txtDocPath;
        private System.Windows.Forms.Button button1;
    }
}