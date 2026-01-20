using System;
using System.Data;
using System.Data.SqlClient;


namespace Collaraton.UI.Utils
{
    // 数据库操作工具类（封装增删改查）
    public static class DBHelper
    {
        private static readonly string connStr = "Data Source=CCX-330;Initial Catalog=CollabDB;User ID=pan;Password=123456;Connect Timeout=30";

        public static int ExecuteNonQuery(string sql, SqlParameter[] parameters = null)
        {
            if (string.IsNullOrEmpty(sql))
                throw new ArgumentNullException("SQL语句不能为空");

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (parameters != null && parameters.Length > 0)
                    cmd.Parameters.AddRange(parameters);

                try
                {
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("执行SQL失败：" + ex.Message, ex);
                }
            }
        }

        public static DataTable ExecuteQuery(string sql, SqlParameter[] parameters = null)
        {
            if (string.IsNullOrEmpty(sql))
                throw new ArgumentNullException("SQL语句不能为空");

            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (parameters != null && parameters.Length > 0)
                    cmd.Parameters.AddRange(parameters);

                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {
                    throw new Exception("查询数据失败：" + ex.Message, ex);
                }
            }
        }
    }
}