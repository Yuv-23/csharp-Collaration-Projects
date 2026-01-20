using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Collaraton.UI
{
    public partial class LoginForm : Form
    {
        private string connStr = @"Data Source=CCX-330;Initial Catalog=CollabDB;User ID=pan;Password=123456;Connect Timeout=30";
        
        //当前登录用户信息
        public static int CurrentUserID;
        public static int role;

        private bool TestDBConnection()
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(connStr);
                conn.Open(); // 打开连接
                MessageBox.Show("数据库连接成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库连接失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                // 无论是否成功，最后关闭连接（关键！避免连接泄露）
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // 初始化身份下拉框
            cbxRole.Items.Clear();
            cbxRole.Items.Add("成员");
            cbxRole.Items.Add("项目经理");
            cbxRole.Items.Add("管理员");
            cbxRole.SelectedIndex = 0;

            // 可选：测试数据库连接
             //TestDBConnection();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //获取账号密码
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            //输入校验
            if (string.IsNullOrEmpty(txtUsername.Text.Trim()))
            {
                MessageBox.Show("请输入用户名！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                MessageBox.Show("请输入密码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbxRole.SelectedIndex == -1)
            {
                MessageBox.Show("请选择用户身份！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //数据库
            int selectRole = cbxRole.SelectedIndex; // 0=成员，1=项目经理，2=管理员
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string sql = "SELECT ID, Role FROM [Users] WHERE UserName = @UserName AND Password = @Password AND Role = @Role";

                    // 查询
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@UserName", txtUsername.Text.Trim());
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                    cmd.Parameters.AddWithValue("@Role", selectRole);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        // 登录成功，记录用户信息
                        CurrentUserID = Convert.ToInt32(reader["ID"]);
                        role = Convert.ToInt32(reader["Role"]);

                        // 跳转
                        if (role == 0) // 0=成员
                        {
                            MemberForm memberForm = new MemberForm();
                            memberForm.Show();
                        }
                        else if (role == 1) // 1=项目经理
                        {
                            ProjectManagerForm pmForm = new ProjectManagerForm(CurrentUserID);
                            pmForm.Show();
                        }
                        else
                        {
                            AdminForm memberForm = new AdminForm();
                            memberForm.Show();
                        }
                        this.Hide(); 
                    }
                    else
                    {
                        MessageBox.Show("用户名/密码/身份不匹配！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPassword.Clear(); 
                        txtUsername.Focus(); 
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("登录失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
