using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using Collaraton.UI.Utils;

namespace Collaraton.UI
{

    public partial class AdminForm : Form
    {
        private readonly EnumDefine.ProjectStatus[] projectStatusEnum = (EnumDefine.ProjectStatus[])Enum.GetValues(typeof(EnumDefine.ProjectStatus));
        private int currentProID = 0;

        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            //初始化项目状态
            cbx_ProjectStatus.Items.Clear();
            cbx_ProjectStatus.Items.Add("全部");
            foreach (EnumDefine.ProjectStatus status in projectStatusEnum)
            {
                cbx_ProjectStatus.Items.Add(status.ToString());
            }
            cbx_ProjectStatus.SelectedIndex = 0; // 默认选中“全部”

            //备份路径
            try
            {
                if (File.Exists("backup_path.config"))
                {
                    string backupPath = File.ReadAllText("backup_path.config");
                    txt_BackupPath.Text = backupPath;
                }
                else
                {
                    txt_BackupPath.Text = ""; // 无默认路径（符合你的需求）
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"读取备份路径配置失败：{ex.Message}", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_BackupPath.Text = ""; // 兜底为空
            }

            dgv_Projects.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv_Projects.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgv_ProCRUD.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv_ProCRUD.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            //加载项目数据
            LoadProjectData();

            //标签2
            LoadCreateUserToComboBox(); // 创建人下拉框
            LoadProStatusToCombox(); // 项目状态下拉框
            LoadProjectData_CRUD(); // 加载项目数据到标签2

        }

        //加载项目数据
        private void LoadProjectData()
        {
            dgv_Projects.DataSource = null;
            try
            {
                //关联用户表查询创建人（项目经理）名称
                string sql = @"
                    SELECT p.ID, p.ProjectName, p.ProjectDesc, p.Status, p.CreateTime, p.CreateUserID, u.UserName AS CreateUserName
                    FROM Projects p
                    LEFT JOIN Users u ON p.CreateUserID = u.ID
                    WHERE 1=1
                ";

                List<SqlParameter> parameters = new List<SqlParameter>(); // 改用List方便动态加参数
                string searchName = txt_SearchName.Text.Trim();

                if (!string.IsNullOrEmpty(searchName))
                {
                    sql += " AND p.ProjectName LIKE @SearchName";
                    parameters.Add(new SqlParameter("@SearchName", $"%{searchName}%"));
                }
                if (cbx_ProjectStatus.SelectedIndex != 0)
                {
                    int statusValue = cbx_ProjectStatus.SelectedIndex - 1;
                    sql += " AND p.Status = @Status";
                    parameters.Add(new SqlParameter("@Status", statusValue));
                }

                // 调用DBHelper查询数据
                DataTable dt = DBHelper.ExecuteQuery(sql, parameters.ToArray());
                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("暂无项目数据！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                // 枚举转换状态
                dt.Columns.Add("StatusText", typeof(string));
                foreach (DataRow row in dt.Rows)
                {
                    int status = Convert.ToInt32(row["Status"]);
                    // 用枚举映射状态文本
                    row["StatusText"] = Enum.IsDefined(typeof(EnumDefine.ProjectStatus), status)
                        ? ((EnumDefine.ProjectStatus)status).ToString()
                        : "未知状态";
                }
                // 绑定到DataGridView
                dgv_Projects.DataSource = dt;
                // 隐藏无用列
                dgv_Projects.Columns["Status"].Visible = false;
                dgv_Projects.Columns["CreateUserID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"加载项目数据失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //===========================备份===========================
        private void btn_ChoosePath_Click(object sender, EventArgs e)
        {
            try
            {
                using (FolderBrowserDialog fbd = new FolderBrowserDialog())
                {
                    fbd.SelectedPath = string.IsNullOrEmpty(txt_BackupPath.Text) ? "" : txt_BackupPath.Text;
                    fbd.Description = "选择备份文件保存的文件夹";

                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        txt_BackupPath.Text = fbd.SelectedPath;
                        File.WriteAllText("backup_path.config", fbd.SelectedPath);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"选择备份路径失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_BackupAll_Click(object sender, EventArgs e)
        {
            BackupProjectData(true);
        }
        private void btn_BackupSingle_Click_1(object sender, EventArgs e)
        {
            if (dgv_Projects.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选择要备份的项目记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int projectID = Convert.ToInt32(dgv_Projects.SelectedRows[0].Cells["ID"].Value);
            BackupProjectData(false, projectID);
        }

        private void BackupProjectData(bool isAll, int projectID = 0)
        {
            try
            {
                //验证备份路径
                string backupPath = txt_BackupPath.Text.Trim();
                if (string.IsNullOrEmpty(backupPath) || !Directory.Exists(backupPath))
                {
                    MessageBox.Show("请设置有效的备份路径！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //备份文件名
                string fileName = isAll
                                    ? $"项目整表备份_{DateTime.Now:yyyyMMdd_HHmmss}.txt"
                                    : $"项目单条备份_ID{projectID}_{DateTime.Now:yyyyMMdd_HHmmss}.txt";
                string fullPath = Path.Combine(backupPath, fileName);

                //查询数据
                string sql = isAll
                                ? "SELECT * FROM Projects"
                                : "SELECT * FROM Projects WHERE ID = @ID";
                SqlParameter[] parameters = isAll ? null : new SqlParameter[] { new SqlParameter("@ID", projectID) };
                DataTable dt = DBHelper.ExecuteQuery(sql, parameters);
                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("无备份数据！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //写入文件
                using (StreamWriter sw = new StreamWriter(fullPath, false, Encoding.UTF8))
                {
                    sw.WriteLine($"===== 项目数据备份 =====\r\n备份时间：{DateTime.Now:yyyy-MM-dd HH:mm:ss}\r\n备份类型：{(isAll ? "整表备份" : "单条备份")}\r\n备份路径：{fullPath}\r\n========================");
                    foreach (DataRow row in dt.Rows)
                    {
                        sw.WriteLine($"\r\n【项目ID：{row["ID"]}】");
                        foreach (DataColumn col in dt.Columns)
                        {
                            string value = row[col] == DBNull.Value ? "空" : row[col].ToString();
                            sw.WriteLine($"{col.ColumnName}：{value}");
                        }
                    }
                }
                MessageBox.Show($"备份成功！文件已保存至：{fullPath}", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"备份失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //========================搜索 / 刷新：标签1=========================
        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (btn_Search.Enabled)
            {
                LoadProjectData();
            }
        }
        private void btn_Refresh_Click_1(object sender, EventArgs e)
        {
            try
            {
                cbx_ProjectStatus.SelectedIndex = 0;
                txt_SearchName.Clear();
                LoadProjectData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"刷新失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //==========================标签2：项目管理=========================
        private void LoadCreateUserToComboBox()
        {
            try
            {
                string sql = "SELECT ID, UserName FROM [Users] WHERE Role = 2";
                DataTable dt = DBHelper.ExecuteQuery(sql, null);
                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("暂无管理员数据！请先添加管理员账号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                cbx_CreateUser.DataSource = dt;
                cbx_CreateUser.DisplayMember = "UserName";
                cbx_CreateUser.ValueMember = "ID";
                cbx_CreateUser.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"加载创建人数据失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadProStatusToCombox()
        {
            cbx_ProStatus.Items.Clear();

            DataTable dt = new DataTable();
            dt.Columns.Add("Value", typeof(int));
            dt.Columns.Add("Text", typeof(string));

            foreach (EnumDefine.ProjectStatus status in projectStatusEnum)
            {
                dt.Rows.Add((int)status, status.ToString());
            }
            cbx_ProStatus.DataSource = dt;
            cbx_ProStatus.DisplayMember = "Text";
            cbx_ProStatus.ValueMember = "Value";
        }
        //加载项目列表
        private void LoadProjectData_CRUD()
        {
            dgv_ProCRUD.SelectionChanged -= dgv_ProCRUD_SelectionChanged;

            dgv_ProCRUD.DataSource = null;
            try
            {
                string sql = @"
                    SELECT p.ID, p.ProjectName, p.ProjectDesc, p.Status, p.CreateTime, p.CreateUserID, u.UserName AS CreateUserName
                    FROM Projects p LEFT JOIN Users u ON p.CreateUserID = u.ID";
                DataTable dt = DBHelper.ExecuteQuery(sql, null);
                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("暂无项目数据！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                dt.Columns.Add("StatusText", typeof(string));
                foreach (DataRow row in dt.Rows)
                {
                    int status = row["Status"] == DBNull.Value ? 0 : Convert.ToInt32(row["Status"]);
                    row["StatusText"] = Enum.IsDefined(typeof(EnumDefine.ProjectStatus), status)
                        ? ((EnumDefine.ProjectStatus)status).ToString()
                        : "未知状态";
                }
                dgv_ProCRUD.DataSource = dt;

                foreach (DataGridViewColumn column in dgv_ProCRUD.Columns)
                {
                    if (column.DataPropertyName == "Status" || column.DataPropertyName == "CreateUserID")
                    {
                        column.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"加载项目数据失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // 重新绑定事件处理程序
                dgv_ProCRUD.SelectionChanged += dgv_ProCRUD_SelectionChanged;

                if (dgv_ProCRUD.Rows.Count > 0)
                {
                    dgv_ProCRUD.Rows[0].Selected = true;
                }
            }
        }

        //添加
        private void btn_AddPro_Click(object sender, EventArgs e)
        {
            try
            {
                string proName = txt_ProName.Text.Trim();
                if (string.IsNullOrEmpty(proName))
                {
                    MessageBox.Show("项目名称不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_ProName.Focus();
                    return;
                }

                string checkProSql = "SELECT COUNT(*) FROM Projects WHERE ProjectName = @ProjectName";
                SqlParameter[] checkParams = new SqlParameter[]
                {
                    new SqlParameter("@ProjectName", proName)
                };
                DataTable checkDt = DBHelper.ExecuteQuery(checkProSql, checkParams);
                int count = Convert.ToInt32(checkDt.Rows[0][0]);
                if (count > 0)
                {
                    MessageBox.Show("项目名称已存在，请更换！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_ProName.Focus();
                    return;
                }
                string proDesc = txt_ProDesc.Text.Trim();
                int proStatus = Convert.ToInt32(cbx_ProStatus.SelectedValue);
                string insertSql = @"
                    INSERT INTO Projects (ProjectName, ProjectDesc, Status, CreateUserID)
                    VALUES (@ProName, @ProDesc, @Status, @CreateUserID)
                ";
                SqlParameter[] insertParams = new SqlParameter[]
                {
                    new SqlParameter("@ProName", proName),
                    new SqlParameter("@ProDesc", proDesc),
                    new SqlParameter("@Status", proStatus),
                    new SqlParameter("@CreateUserID", cbx_CreateUser.SelectedValue)
                };
                int rows = DBHelper.ExecuteNonQuery(insertSql, insertParams);
                if (rows > 0)
                {
                    MessageBox.Show("新增项目成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearProInput();
                    LoadProjectData_CRUD();
                }
                else
                {
                    MessageBox.Show("新增项目失败，无数据插入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"新增项目失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //编辑
        private void btn_EditPro_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentProID == 0)
                {
                    MessageBox.Show("请先选择要编辑的项目记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string proName = txt_ProName.Text.Trim();
                if (string.IsNullOrEmpty(proName))
                {
                    MessageBox.Show("项目名称不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_ProName.Focus();
                    return;
                }
                string proDesc = txt_ProDesc.Text.Trim();
                int proStatus = Convert.ToInt32(cbx_ProStatus.SelectedValue);
                int createID = Convert.ToInt32(cbx_CreateUser.SelectedValue);
                string updateSql = @"
                    UPDATE Projects
                    SET ProjectName = @ProName,
                        ProjectDesc = @ProDesc,
                        Status = @Status,
                        CreateUserID = @CreateUserID
                    WHERE ID = @ProID
                ";
                SqlParameter[] updateParams = new SqlParameter[]
                {
                    new SqlParameter("@ProName", proName),
                    new SqlParameter("@ProDesc", proDesc),
                    new SqlParameter("@Status", proStatus),
                    new SqlParameter("@CreateUserID", createID),
                    new SqlParameter("@ProID", currentProID)
                };
                int rows = DBHelper.ExecuteNonQuery(updateSql, updateParams);
                if (rows > 0)
                {
                    MessageBox.Show("项目编辑成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearProInput();
                    LoadProjectData_CRUD();
                }
                else
                {
                    MessageBox.Show("项目编辑失败，无数据更新！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"项目编辑失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //删除
        private void btn_DelPro_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentProID == 0)
                {
                    MessageBox.Show("请先选择要删除的项目记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string checkSql = "SELECT COUNT(*) FROM Tasks WHERE ProjectID = @ProID";
                SqlParameter[] checkParams = new SqlParameter[]
                {
                    new SqlParameter("@ProID", currentProID)
                };
                DataTable checkDt = DBHelper.ExecuteQuery(checkSql, checkParams);
                int taskCount = Convert.ToInt32(checkDt.Rows[0][0]);
                if (taskCount > 0)
                {
                    MessageBox.Show($"该项目关联{taskCount}条任务，禁止删除！请先删除关联任务", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult result = MessageBox.Show("确认删除该项目？此操作不可撤销！", "确认删除", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result != DialogResult.Yes)
                {
                    return;
                }
                string deleteSql = "DELETE FROM Projects WHERE ID = @ProID";
                SqlParameter[] deleteParams = new SqlParameter[]
                {
                    new SqlParameter("@ProID", currentProID)
                };
                int rows = DBHelper.ExecuteNonQuery(deleteSql, deleteParams);
                if (rows > 0)
                {
                    MessageBox.Show("项目删除成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearProInput();
                    LoadProjectData_CRUD();
                }
                else
                {
                    MessageBox.Show("项目删除失败，无数据删除！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"项目删除失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //更新状态
        private void btn_UpdateStatus_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentProID == 0)
                {
                    MessageBox.Show("请先选择要修改的项目记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int newStatus = Convert.ToInt32(cbx_ProStatus.SelectedValue);
                string statusText = cbx_ProStatus.Text;
                DialogResult result = MessageBox.Show($"确定要将项目状态改为「{statusText}」吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result != DialogResult.Yes)
                {
                    return;
                }

                string updateSql = "UPDATE Projects SET Status = @Status WHERE ID = @ProID";
                SqlParameter[] updateParams = new SqlParameter[]
                {
                    new SqlParameter("@Status", newStatus),
                    new SqlParameter("@ProID", currentProID)
                };
                int rows = DBHelper.ExecuteNonQuery(updateSql, updateParams);
                if (rows > 0)
                {
                    MessageBox.Show("项目状态更新成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearProInput();
                    LoadProjectData_CRUD();
                }
                else
                {
                    MessageBox.Show("项目状态更新失败，无数据更新！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"项目状态更新失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearProInput()
        {
            txt_ProName.Clear();
            txt_ProDesc.Clear();
            cbx_ProStatus.SelectedIndex = 0;
            cbx_CreateUser.SelectedIndex = 0;
            currentProID = 0; // 重置选中项目ID
        }

        private void dgv_ProCRUD_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_ProCRUD.DataSource == null || dgv_ProCRUD.SelectedRows.Count == 0)
            {
                currentProID = 0;
                ClearProInput();
                return;
            }
            DataGridViewRow selectedRow = dgv_ProCRUD.SelectedRows[0];

            int tempProID = GetCellValueByDataPropertyName(selectedRow, "ID") == DBNull.Value ? 0
        : Convert.ToInt32(GetCellValueByDataPropertyName(selectedRow, "ID"));

            string tempProName = GetCellValueByDataPropertyName(selectedRow, "ProjectName") == DBNull.Value ? ""
                : GetCellValueByDataPropertyName(selectedRow, "ProjectName").ToString();

            string tempProDesc = GetCellValueByDataPropertyName(selectedRow, "ProjectDesc") == DBNull.Value ? ""
                : GetCellValueByDataPropertyName(selectedRow, "ProjectDesc").ToString();

            int tempCreateUserID = GetCellValueByDataPropertyName(selectedRow, "CreateUserID") == DBNull.Value ? 0
                : Convert.ToInt32(GetCellValueByDataPropertyName(selectedRow, "CreateUserID"));

            int tempProStatusValue = GetCellValueByDataPropertyName(selectedRow, "Status") == DBNull.Value ? 0
                : Convert.ToInt32(GetCellValueByDataPropertyName(selectedRow, "Status"));
            ClearProInput();

            currentProID = tempProID;
            txt_ProName.Text = tempProName;
            txt_ProDesc.Text = tempProDesc;

            //创建人
            for (int i = 0; i < cbx_CreateUser.Items.Count; i++)
            {
                DataRowView drv = (DataRowView)cbx_CreateUser.Items[i];
                int comboUserID = Convert.ToInt32(drv["ID"]);
                if (comboUserID == tempCreateUserID)
                {
                    cbx_CreateUser.SelectedIndex = i;
                    break;
                }
            }

            //项目状态
            for (int i = 0; i < cbx_ProStatus.Items.Count; i++)
            {
                DataRowView drv = (DataRowView)cbx_ProStatus.Items[i];
                int comboStatusValue = Convert.ToInt32(drv["Value"]);
                if (comboStatusValue == tempProStatusValue)
                {
                    cbx_ProStatus.SelectedIndex = i;
                    break;
                }
            }
        }
        private object GetCellValueByDataPropertyName(DataGridViewRow row, string dataPropertyName)
        {
            foreach (DataGridViewCell cell in row.Cells)
            {
                if (cell.OwningColumn.DataPropertyName == dataPropertyName)
                {
                    return cell.Value;
                }
            }
            return null;
        }
    }
}