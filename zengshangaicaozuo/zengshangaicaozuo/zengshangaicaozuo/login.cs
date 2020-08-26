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
using System.Security.Cryptography;


namespace zengshangaicaozuo
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        //引用App.config配置文件中的数据库连接字符串
        private static string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_username.Text.Trim()=="") {
                    label4.Text = "用户名不能为空";
                    txt_username.Focus();
                    return;
                }
                else if(txt_password.Text.Trim()=="")
                {
                    labelMessage.Text = "密码不能为空";
                    txt_password.Focus();
                    return;
                }
                string sqlStr = "select count(*) from user_info where username='"+txt_username.Text+"' and password='"+txt_password.Text+"'";
              
                SqlConnection xonn = new SqlConnection(connStr);//创建连接对象
                xonn.Open();//打开数据库连接
                SqlCommand cmd = new SqlCommand(sqlStr, xonn);//创建sql命令对象
                //判断SqlCommand对象的ExecuteScalar方法返回的参数是否大于0，大于0说明用户已经存在
                //cmd.Parameters.AddWithValue("@username", txt_username);
                //cmd.Parameters.AddWithValue("@password", txt_password);
               int i = Convert.ToInt32(cmd.ExecuteScalar());
                if (i > 0)
                {
                    Form1 form = new Form1();
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("登录失败");
                }

            }
            catch
            {
                MessageBox.Show("登录失败");
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            Register form = new Register();
            form.ShowDialog();
        }
    }
}
