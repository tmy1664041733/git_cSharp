using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
namespace zengshangaicaozuo
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        //引用App.config配置文件中的数据库连接字符串
        //private static string conStrs = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        private static string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "insert into user_info (username,password) values ('" + ReUsername.Text + "','" + RePassword.Text + "')";
                SqlConnection conn = new SqlConnection(connStr);//定义数据库连接对象
                conn.Open();//打开数据库连接
                SqlCommand cmd = new SqlCommand(sql, conn);//定义sql命令执行对象
                if (Convert.ToInt32(cmd.ExecuteNonQuery()) > 0)
                {
                    MessageBox.Show("注册成功");
                }
                else
                {
                    MessageBox.Show("注册失败");
                }
            }
            catch {
                MessageBox.Show("程序出错");
            }
           

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
