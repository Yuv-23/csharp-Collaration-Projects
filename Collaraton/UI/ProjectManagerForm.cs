using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using Collaraton.UI.Utils;
using System.CodeDom.Compiler;

namespace Collaraton.UI
{
    public partial class ProjectManagerForm : Form
    {
        //全局变量
        private int currentManagerID = 0;
        private int currentAuditTaskID = 0;//审核任务ID
        private string currentScreenshotPath = "";//当前截图路径
        private string currentDocumentPath = "";//当前文档路径

        public ProjectManagerForm(int managerID)
        {
            InitializeComponent();
            currentManagerID = managerID;

            dgv_AssignTaskList.AutoGenerateColumns = false;
            dgv_AuditTaskList.AutoGenerateColumns = false;

            dgv_AuditTaskList.SelectionChanged += dgv_AuditTaskList_SelectionChanged;

        }

        // 窗体加载：初始化下拉框+加载数据
        private void ProjectManagerForm_Load(object sender, EventArgs e)
        {
            LoadProjectToComboBox(); // 加载项目下拉框
            LoadMemberToComboBox(); // 加载成员下拉框
            LoadTaskTypes();        // 加载任务类型
            LoadAssignTaskList();    // 加载已分配任务列表
            LoadAuditTaskList();     // 加载待审核任务列表
        }

        // 加载项目到下拉框
        private void LoadProjectToComboBox()
        {
            try
            {
                string sql = "SELECT ID, ProjectName FROM Projects ORDER BY ProjectName";
                DataTable dt = DBHelper.ExecuteQuery(sql, null);
                if (dt != null && dt.Rows.Count > 0)
                {
                    cbx_Project.Items.Clear();
                    cbx_Project.DataSource = null;

                    cbx_Project.DataSource = dt;
                    cbx_Project.DisplayMember = "ProjectName";
                    cbx_Project.ValueMember = "ID";
                    cbx_Project.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"加载项目失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 加载成员到下拉框
        private void LoadMemberToComboBox()
        {
            try
            {
                string sql = "SELECT ID, UserName FROM Users WHERE Role = 0";
                DataTable dt = DBHelper.ExecuteQuery(sql, null);
                if (dt != null && dt.Rows.Count > 0)
                {
                    cbx_AssignUser.DataSource = dt;
                    cbx_AssignUser.DisplayMember = "UserName";
                    cbx_AssignUser.ValueMember = "ID";
                    cbx_AssignUser.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"加载成员失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 加载任务类型
        private void LoadTaskTypes()
        {
            try
            {
                string sql = "SELECT DISTINCT TaskType FROM Tasks WHERE TaskType IS NOT NULL";
                DataTable dt = DBHelper.ExecuteQuery(sql, null);

                cbx_TaskType.Items.Clear();
                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        if (!string.IsNullOrEmpty(row["TaskType"].ToString()))
                            cbx_TaskType.Items.Add(row["TaskType"].ToString());
                    }
                }

                string[] defaultTypes = { "开发任务", "测试任务", "设计任务", "文档任务", "修复任务", "其他任务" };
                foreach (string type in defaultTypes)
                {
                    if (!cbx_TaskType.Items.Contains(type))
                        cbx_TaskType.Items.Add(type);
                }

                if (cbx_TaskType.Items.Count > 0)
                    cbx_TaskType.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"加载任务类型失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);

                cbx_TaskType.Items.Clear();
                cbx_TaskType.Items.AddRange(new object[] {
                "开发任务", "测试任务", "设计任务",
                "文档任务", "修复任务", "其他任务"});
            }
        }

        // 加载已分配任务列表
        private void LoadAssignTaskList()
        {
            dgv_AssignTaskList.DataSource = null;
            try
            {
                string sql = @"
                    SELECT 
                        t.ID AS TaskID,         
                        t.TaskName,     
                        t.TaskType,
                        p.ProjectName,
                        u.UserName AS ExecutorName,
                        t.Status,                
                        CASE t.Status 
                            WHEN 0 THEN '未开始' 
                            WHEN 1 THEN '进行中' 
                            WHEN 2 THEN '已提交' 
                            WHEN 3 THEN '已审核' 
                            WHEN 4 THEN '驳回' 
                            ELSE '未知' END AS StatusText
                    FROM Tasks t
                    LEFT JOIN Projects p ON t.ProjectID = p.ID
                    LEFT JOIN Users u ON t.ExecutorID = u.ID
                    WHERE t.AllocatorID = @AllocatorID
                    ORDER BY t.CreateTime";

                SqlParameter[] param = new SqlParameter[] { new SqlParameter("@AllocatorID", currentManagerID) };
                DataTable dt = DBHelper.ExecuteQuery(sql, param);

                if (dt != null && dt.Rows.Count > 0)
                {
                    dgv_AssignTaskList.DataSource = dt;

                    if (dgv_AssignTaskList.Rows.Count > 0)
                    {
                        dgv_AssignTaskList.Rows[0].Selected = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"加载任务列表失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 加载待审核任务列表
        private void LoadAuditTaskList()
        {
            dgv_AuditTaskList.DataSource = null;
            try
            {
                string sql = @"
                             SELECT 
                        t.ID AS TaskID,           
                        t.TaskName,      
                        p.ProjectName,            
                        u.UserName AS SubmitMember,   
                        t.TaskDesc AS ProgressDesc,
                        t.ScreenshotPath,
                        t.DocPath,
                        t.SubmitTime 
                    FROM Tasks t
                    LEFT JOIN Projects p ON t.ProjectID = p.ID
                    LEFT JOIN Users u ON t.ExecutorID = u.ID   
                    WHERE t.Status = 2 AND t.AllocatorID = @AllocatorID
                    ORDER BY t.SubmitTime DESC"; 
                SqlParameter[] param = new SqlParameter[] { new SqlParameter("@AllocatorID", currentManagerID) };
                DataTable dt = DBHelper.ExecuteQuery(sql, param);
                dgv_AuditTaskList.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"加载审核列表失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 分配任务按钮
        private void btn_AssignTask_Click(object sender, EventArgs e)
        {
            try
            {
                string taskType = cbx_TaskType.Text.Trim();
                string taskName = txt_TaskName.Text.Trim();
                if (string.IsNullOrEmpty(taskType))
                {
                    MessageBox.Show("请选择或输入任务类型！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbx_TaskType.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(taskName))
                {
                    MessageBox.Show("任务名称不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_TaskName.Focus();
                    return;
                }
                if (cbx_Project.SelectedValue == null)
                {
                    MessageBox.Show("请选择所属项目！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbx_Project.Focus();
                    return;
                }
                if (cbx_AssignUser.SelectedValue == null)
                {
                    MessageBox.Show("请选择分配成员！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbx_AssignUser.Focus();
                    return;
                }

                int projectID;
                int executorID;

                if (!int.TryParse(cbx_Project.SelectedValue.ToString(), out projectID))
                {
                    MessageBox.Show("项目选择无效！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(cbx_AssignUser.SelectedValue.ToString(), out executorID))
                {
                    MessageBox.Show("成员选择无效！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string taskDesc = txt_TaskDesc.Text.Trim();

                string sql = @"
                    INSERT INTO Tasks (TaskType, TaskName, TaskDesc, ExecutorID, AllocatorID, ProjectID, Status, CreateTime)
                    VALUES (@TaskType, @TaskName, @TaskDesc, @ExecutorID, @AllocatorID, @ProjectID, 0, GETDATE())";

                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@TaskType", taskType),
                    new SqlParameter("@TaskName", taskName),
                    new SqlParameter("@TaskDesc", taskDesc),
                    new SqlParameter("@ExecutorID", executorID),
                    new SqlParameter("@AllocatorID", currentManagerID),
                    new SqlParameter("@ProjectID", projectID)
                };

                int rows = DBHelper.ExecuteNonQuery(sql, param);
                if (rows > 0)
                {
                    MessageBox.Show("任务分配成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearAssignInput();

                    LoadAssignTaskList();
                }
                else
                {
                    MessageBox.Show("任务分配失败，请重试！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"分配任务失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 清空分配任务输入框
        private void ClearAssignInput()
        {
            if (cbx_TaskType.Items.Count > 0)
                cbx_TaskType.SelectedIndex = 0;
            else
                cbx_TaskType.Text = "";

            txt_TaskName.Clear();
            txt_TaskDesc.Clear();
        }

        // 刷新分配任务列表
        private void btn_RefreshAssign_Click(object sender, EventArgs e)
        {
            try
            {
                ClearAssignInput();  
                LoadAssignTaskList(); 
                MessageBox.Show("列表刷新成功！当前任务数：" + dgv_AssignTaskList.Rows.Count, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"刷新列表失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 审核列表选中行：回显进度信息
        private void dgv_AuditTaskList_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgv_AuditTaskList.SelectedRows.Count == 0)
                {
                    currentAuditTaskID = 0;
                    txt_ProgressDesc.Clear();
                    currentScreenshotPath = "";
                    currentDocumentPath = "";
                    return;
                }
                DataGridViewRow row = dgv_AuditTaskList.SelectedRows[0];

                currentAuditTaskID = row.Cells["col_AuditTaskID"].Value == DBNull.Value ? 0 : Convert.ToInt32(row.Cells["col_AuditTaskID"].Value);
                txt_ProgressDesc.Text = row.Cells["col_AuditProgressDesc"].Value == DBNull.Value ? "" : row.Cells["col_AuditProgressDesc"].Value.ToString();
                currentScreenshotPath = row.Cells["col_AuditScreenshot"].Value == DBNull.Value ? "" : row.Cells["col_AuditScreenshot"].Value.ToString();
                currentDocumentPath = row.Cells["col_AuditDocument"].Value == DBNull.Value ? "" : row.Cells["col_AuditDocument"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"选中行失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                currentAuditTaskID = 0;
            }
        }

        // 查看截图
        private void btn_ViewScreenshot_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentScreenshotPath) || !System.IO.File.Exists(currentScreenshotPath))
            {
                MessageBox.Show("暂无截图或截图文件不存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Process.Start(currentScreenshotPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"打开截图失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 查看文档
        private void btn_ViewDocument_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentDocumentPath) || !System.IO.File.Exists(currentDocumentPath))
            {
                MessageBox.Show("暂无文档或文档文件不存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Process.Start(currentDocumentPath); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"打开文档失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 审核通过
        private void btn_AuditPass_Click(object sender, EventArgs e)
        {
            if (currentAuditTaskID == 0)
            {
                MessageBox.Show("请先选择要审核的任务！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("确认审核通过该任务？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                string sql = "UPDATE Tasks SET Status = 3, AuditTime = GETDATE(), AuditBy = @AuditBy WHERE ID = @TaskID";
                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@TaskID", currentAuditTaskID),
                    new SqlParameter("@AuditBy", currentManagerID)
                };

                int rows = DBHelper.ExecuteNonQuery(sql, param);
                if (rows > 0)
                {
                    MessageBox.Show("审核通过！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAuditTaskList();  // 刷新审核列表
                    LoadAssignTaskList(); // 刷新任务列表
                    ClearAuditSelection(); // 清除选择
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"审核失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 清除审核选择
        private void ClearAuditSelection()
        {
            currentAuditTaskID = 0;
            txt_ProgressDesc.Clear();
            currentScreenshotPath = "";
            currentDocumentPath = "";

            if (dgv_AuditTaskList.SelectedRows.Count > 0)
                dgv_AuditTaskList.ClearSelection();
        }

        // 审核驳回
        private void btn_AuditReject_Click(object sender, EventArgs e)
        {
            if (currentAuditTaskID == 0)
            {
                MessageBox.Show("请先选择要审核的任务！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("确认驳回该任务？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                string sql = "UPDATE Tasks SET Status = 4, AuditTime = GETDATE(), AuditBy = @AuditBy WHERE ID = @TaskID";
                SqlParameter[] param = new SqlParameter[]
                   {
                        new SqlParameter("@TaskID", currentAuditTaskID),
                        new SqlParameter("@AuditBy", currentManagerID)
                   };

                int rows = DBHelper.ExecuteNonQuery(sql, param);
                if (rows > 0)
                {
                    MessageBox.Show("审核驳回！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAuditTaskList(); 
                    LoadAssignTaskList(); 
                    ClearAuditSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"驳回失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbx_Project_DropDown(object sender, EventArgs e)
        {
            if (cbx_Project.Items.Count == 0)
            {
                LoadProjectToComboBox();
            }
        }

        private void cbx_AssignUser_DropDown(object sender, EventArgs e)
        {
            if (cbx_AssignUser.Items.Count == 0)
            {
                LoadMemberToComboBox();
            }
        }

        private void txt_TaskDesc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}