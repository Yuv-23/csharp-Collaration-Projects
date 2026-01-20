using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Collaraton.UI.Utils;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Collaraton.UI
{
    public partial class MemberForm : Form
    {
        private readonly string connStr = "Data Source=CCX-330;Initial Catalog=CollabDB;User ID=pan;Password=123456;Connect Timeout=30";

        public MemberForm()
        {
            InitializeComponent();
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {
            //初始化关联任务下拉框
            InitRelateTaskCombox();

            //“我的任务”表格加载
            LoadMyTaskList();
        }

        //我的任务表格加载
        private void LoadMyTaskList()
        {
            dgvMyTasks.Columns.Clear();
            dgvMyTasks.Rows.Clear();

            // 列1：任务ID
            DataGridViewTextBoxColumn colTaskID = new DataGridViewTextBoxColumn();
            colTaskID.Name = "colTaskID";
            colTaskID.HeaderText = "任务ID";
            dgvMyTasks.Columns.Add(colTaskID);

            // 列2：任务名称
            DataGridViewTextBoxColumn colTaskName = new DataGridViewTextBoxColumn();
            colTaskName.Name = "colTaskName";
            colTaskName.HeaderText = "任务名称";
            colTaskName.Width = 150;
            dgvMyTasks.Columns.Add(colTaskName);

            // 列3：任务类型
            DataGridViewTextBoxColumn colTaskType = new DataGridViewTextBoxColumn();
            colTaskType.Name = "colTaskType";
            colTaskType.HeaderText = "任务类型";
            dgvMyTasks.Columns.Add(colTaskType);

            // 列4：任务状态
            DataGridViewTextBoxColumn colStatus = new DataGridViewTextBoxColumn();
            colStatus.Name = "colStatus";
            colStatus.HeaderText = "任务状态";
            dgvMyTasks.Columns.Add(colStatus);

            // 列5：已上传文档
            DataGridViewTextBoxColumn colDocUploaded = new DataGridViewTextBoxColumn();
            colDocUploaded.Name = "colDocUploaded";
            colDocUploaded.HeaderText = "已上传文档";
            dgvMyTasks.Columns.Add(colDocUploaded);

            // 列6：创建时间
            DataGridViewTextBoxColumn colCreateTime = new DataGridViewTextBoxColumn();
            colCreateTime.Name = "colCreateTime";
            colCreateTime.HeaderText = "创建时间";
            dgvMyTasks.Columns.Add(colCreateTime);

            dgvMyTasks.AutoGenerateColumns = false;

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string sql = "SELECT ID, TaskName, TaskType, Status, DocPath, CONVERT(VARCHAR(20), CreateTime, 23) AS CreateTime " +
                        "FROM Tasks WHERE ExecutorID=@ExecutorID";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ExecutorID", LoginForm.CurrentUserID);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        //============ 空值处理 =============
                        int taskId = reader["ID"] == DBNull.Value ? 0 : Convert.ToInt32(reader["ID"]);
                        string taskName = reader["TaskName"] == DBNull.Value ? "未命名任务" : reader["TaskName"].ToString();
                        string taskType = reader["TaskType"] == DBNull.Value ? "未分类" : reader["TaskType"].ToString();
                        int statusNum = reader["Status"] == DBNull.Value ? 0 : Convert.ToInt32(reader["Status"]);
                        string statusText = "未知状态"; // 默认值
                        if (statusNum == 0)
                        {
                            statusText = "未开始";
                        }
                        else if (statusNum == 1)
                        {
                            statusText = "进行中";
                        }
                        else if (statusNum == 2)
                        {
                            statusText = "已提交";
                        }
                        else if (statusNum == 3)
                        {
                            statusText = "已审核";
                        }
                        else if (statusNum == 4)
                        {
                            statusText = "驳回";
                        }

                        //文档上传状态
                        string docUploaded = (reader["DocPath"] == DBNull.Value || string.IsNullOrEmpty(reader["DocPath"].ToString()))
                    ? "否" : "是";
                        string createTime = reader["CreateTime"] == DBNull.Value ? "未知时间" : reader["CreateTime"].ToString();

                        dgvMyTasks.Rows.Add(taskId, taskName, taskType, statusText, docUploaded, createTime);
                    }
                    reader.Close();
                    if (dgvMyTasks.Rows.Count == 0)
                    {
                        MessageBox.Show("暂无任务数据，请先提交任务！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"加载任务列表失败：{ex.Message}\n错误详情：{ex.InnerException?.Message}",
                    "数据库错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dgvMyTasks.CellClick += new DataGridViewCellEventHandler(dgvMyTasks_CellClick);
        }

        //任务操作按钮点击事件
        private void dgvMyTasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dgvMyTasks.Columns[e.ColumnIndex].Name == "colAction")
            {
                DataGridViewRow row = dgvMyTasks.Rows[e.RowIndex];
                int taskId = Convert.ToInt32(row.Cells["colTaskID"].Value);
                string statusText = row.Cells["colStatus"].Value.ToString();

                if (statusText == "未开始")
                {
                    if (MessageBox.Show("确认开始此任务？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        UpdateTaskStatus(taskId, 1); 
                    }
                }
                else if (statusText == "进行中")
                {
                    MessageBox.Show("请在'提交进度'选项卡中提交任务进度", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // 更新任务状态
        private void UpdateTaskStatus(int taskId, int status)
        {
            try
            {
                string sql = "UPDATE Tasks SET Status = @Status WHERE ID = @TaskID AND ExecutorID = @ExecutorID";
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@TaskID", taskId);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@ExecutorID", LoginForm.CurrentUserID);

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        string statusText = status == 1 ? "进行中" : "未开始";
                        MessageBox.Show($"任务状态已更新为【{statusText}】！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadMyTaskList();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"更新任务状态失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 打开成员界面时自动加载
        private void InitRelateTaskCombox()
        {
            cbxSubmitTask.Items.Clear();
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string sql = "SELECT ID, TaskName, Status FROM Tasks WHERE ExecutorID=@ExecutorID AND Status IN (0, 1)"; SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ExecutorID", LoginForm.CurrentUserID);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string taskId = reader["ID"].ToString();
                        string taskName = reader["TaskName"] == DBNull.Value ? "未命名任务" : reader["TaskName"].ToString();
                        int status = Convert.ToInt32(reader["Status"]);
                        string statusText = status == 0 ? "未开始" : "进行中";
                        cbxSubmitTask.Items.Add($"{taskId}|{taskName} [{statusText}]");
                    }
                    reader.Close();

                    if (cbxSubmitTask.Items.Count > 0)
                        cbxSubmitTask.SelectedIndex = 0;
                    else
                        MessageBox.Show("没有可提交进度的任务！请先开始一个任务。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("加载关联任务失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //============================提交任务 Tab ==========================

        //上传文档
        private bool Upload_Document(int taskId)
        {
            //校验
            if(string.IsNullOrEmpty(txtDocPath.Text.Trim()))
            {
                MessageBox.Show("请选择要上传的文档！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //解析
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string sql = "UPDATE Tasks SET DocPath=@DocPath WHERE ID=@TaskID AND ExecutorID=@ExecutorID";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@DocPath", txtDocPath.Text.Trim());
                    cmd.Parameters.AddWithValue("@TaskID", taskId);
                    cmd.Parameters.AddWithValue("@ExecutorID", LoginForm.CurrentUserID);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("文档上传成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtDocPath.Text = ""; // 清空路径
                        return true; // 上传成功返回true
                    }
                    else
                    {
                        MessageBox.Show("文档上传失败：未找到该任务或无权限修改！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("上传文档异常：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //选择文档
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter= "常用文档|*.doc;*.docx;*.xls;*.xlsx;*.ppt;*.pptx;*.pdf;*.txt|所有文件|*.*";
            openFileDialog.Title = "选择要上传的文档";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtDocPath.Text = openFileDialog.FileName;
            }
        }

        //显示截图和路径
        private void btnSelectScreenshot_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "图片文件|*.jpg;*.jpeg;*.png;*.bmp;*.gif|所有文件|*.*";
                openFileDialog.Title = "选择截图文件";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtScreenshotPath.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnSubmitTask_Click(object sender, EventArgs e)
        {
            //校验
            if (cbxSubmitTask.SelectedItem == null)
            {
                MessageBox.Show("请选择要提交进度的任务！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string selectedTask = cbxSubmitTask.SelectedItem.ToString();
            string[] parts = selectedTask.Split('|');
            if (parts.Length < 2 || !int.TryParse(parts[0], out int taskId))
            {
                MessageBox.Show("任务ID解析失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string progressDesc = txtTaskDesc.Text.Trim();
            string screenshotPath = txtScreenshotPath.Text.Trim();
            if (string.IsNullOrEmpty(progressDesc))
            {
                MessageBox.Show("请填写进度描述！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaskDesc.Focus();
                return;
            }

            if (!string.IsNullOrEmpty(txtDocPath.Text.Trim()))
            {
                Upload_Document(taskId); 
            }

            try
            {
                string sql = @"
                    UPDATE Tasks 
                    SET Status = 2, 
                        TaskDesc = @TaskDesc,
                        ScreenshotPath = @ScreenshotPath,
                        SubmitTime = GETDATE()
                    WHERE ID = @TaskID AND ExecutorID = @ExecutorID";

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@TaskDesc", progressDesc),
                    new SqlParameter("@ScreenshotPath", string.IsNullOrEmpty(screenshotPath) ? (object)DBNull.Value : screenshotPath),
                    new SqlParameter("@TaskID", taskId),
                    new SqlParameter("@ExecutorID", LoginForm.CurrentUserID)
                };

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddRange(parameters);
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("任务进度提交成功！等待项目经理审核。", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTaskDesc.Clear();
                        txtScreenshotPath.Clear();
                        LoadMyTaskList();
                        InitRelateTaskCombox();
                    }
                    else
                    {
                        MessageBox.Show("提交失败：未找到该任务或无权限修改！", "失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"提交进度异常：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //=============================================================

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void tabSubmitTask_Click(object sender, EventArgs e)
        {

        }

        private void tableSubmitTotal_Paint(object sender, PaintEventArgs e)
        {
        }

        private void dgvReportPreview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //========================= 导出报告 PDF ==========================
        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            if(dgvMyTasks.Rows.Count == 0)
            {
                MessageBox.Show("没有任务数据可导出！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //选择保存路径
            using(SaveFileDialog sfd=new SaveFileDialog())
            {
                sfd.Filter = "PDF文件|*.pdf";
                sfd.Title = "选择保存报告的路径";
                sfd.FileName = "成员任务报告.pdf";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // 1. 初始化PDF文档
                        Document document = new Document(PageSize.A4, 30, 30, 40, 40);
                        PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(sfd.FileName, FileMode.Create));
                        document.Open();

                        // 2. 解决中文显示 + 字体样式（包含下划线）
                        BaseFont chineseBaseFont = BaseFont.CreateFont(@"C:\Windows\Fonts\simsun.ttc,1", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

                        // 标题字体：加粗 + 下划线 + 18号字
                        iTextSharp.text.Font titleFont = new iTextSharp.text.Font(
                            chineseBaseFont,
                            18,
                            iTextSharp.text.Font.BOLD | iTextSharp.text.Font.UNDERLINE // 这里设置下划线
                        );

                        // 其他字体
                        iTextSharp.text.Font headerFont = new iTextSharp.text.Font(chineseBaseFont, 12, iTextSharp.text.Font.BOLD);
                        iTextSharp.text.Font contentFont = new iTextSharp.text.Font(chineseBaseFont, 10, iTextSharp.text.Font.NORMAL);
                        iTextSharp.text.Font timeFont = new iTextSharp.text.Font(chineseBaseFont, 10, iTextSharp.text.Font.ITALIC);

                        // 3. 添加标题（带下划线）
                        Paragraph title = new Paragraph("成员个人任务进度报告", titleFont);
                        title.Alignment = Element.ALIGN_CENTER;
                        title.SpacingAfter = 30; // 标题下方留白
                        document.Add(title);

                        // 4. 添加生成时间
                        Paragraph timePara = new Paragraph($"报告生成时间：{DateTime.Now:yyyy-MM-dd HH:mm:ss}", timeFont);
                        timePara.Alignment = Element.ALIGN_RIGHT;
                        timePara.SpacingAfter = 20;
                        document.Add(timePara);

                        // 5. 构建任务表格
                        int columnCount = dgvMyTasks.Columns.Count;
                        PdfPTable table = new PdfPTable(columnCount);
                        table.WidthPercentage = 100;
                        table.SpacingBefore = 10; 
                        table.DefaultCell.MinimumHeight = 25; 

                        // 适配列宽
                        float[] columnWidths = GetColumnWidths(columnCount);
                        table.SetWidths(columnWidths);

                        // 6. 添加表头
                        foreach (DataGridViewColumn column in dgvMyTasks.Columns)
                        {
                            PdfPCell headerCell = new PdfPCell(new Phrase(column.HeaderText, headerFont));
                            headerCell.BackgroundColor = BaseColor.LIGHT_GRAY; 
                            headerCell.HorizontalAlignment = Element.ALIGN_CENTER; 
                            headerCell.VerticalAlignment = Element.ALIGN_MIDDLE; 
                            headerCell.BorderWidth = 1;
                            table.AddCell(headerCell);
                        }

                        // 7. 添加表格内容
                        foreach (DataGridViewRow row in dgvMyTasks.Rows)
                        {
                            if (row.IsNewRow) continue;

                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                string cellText = cell.Value == DBNull.Value || cell.Value == null
                                    ? "无" : cell.Value.ToString();

                                PdfPCell contentCell = new PdfPCell(new Phrase(cellText, contentFont));
                                contentCell.HorizontalAlignment = Element.ALIGN_CENTER;
                                contentCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                                contentCell.BorderWidth = 0.5f;
                                table.AddCell(contentCell);
                            }
                        }

                        document.Add(table);

                        document.Close();
                        writer.Close();

                        MessageBox.Show($"个人任务报告导出成功！\n文件路径：{sfd.FileName}",
                            "导出成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // 导出后自动打开文件
                        if (MessageBox.Show("是否立即打开生成的PDF文件？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            Process.Start(sfd.FileName);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"导出PDF失败：{ex.Message}\n{ex.StackTrace}",
                            "导出错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private float[] GetColumnWidths(int columnCount)
        {
            float[] widths = new float[columnCount];
            float baseWidth = 100f / columnCount; // 平均分配宽度
            for (int i = 0; i < columnCount; i++)
            {
                widths[i] = baseWidth;
            }
            return widths;
        }
    }
}