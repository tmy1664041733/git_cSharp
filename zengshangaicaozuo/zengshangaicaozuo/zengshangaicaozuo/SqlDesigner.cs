using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Security.Cryptography;
namespace zengshangaicaozuo
{
    class SqlDesigner
    {
        //引用App.config配置文件中的数据库连接字符串
        private static string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        /// <summary>
        /// 返回受影响的数据行数
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int ExecuteNoQuery(string sql)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    return cmd.ExecuteNonQuery();

                }
            }
        }
        /// <summary>
        /// 返回一个数据集
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataSet ExecuteDataSet(string sql)
        {
            using (SqlConnection xonn = new SqlConnection(connStr))//定义连接对象
            {
                xonn.Open();//打开数据库连接
                using (SqlCommand cmd = xonn.CreateCommand())//创建一个执行sql对象
                {
                    cmd.CommandText = sql;//把sql语句赋值给sql对象
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);//执行连接
                    DataSet dataset = new DataSet();//定义存储查询结果的容器
                    adapter.Fill(dataset);//将数据存储到数据容器
                    return dataset;//输出数据查询
                }
            }
        }
        public static object ExecuteScalar(string sql)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    return cmd.ExecuteScalar();
                }
            }
        }
        /// <summary>
        /// md5加密
        /// </summary>
        /// <param name="strPwd"></param>
        /// <returns></returns>
        public static string GetMD5(string strPwd)
        {
            string pwd = "";
            //实例化一个md5对象
            MD5 md5 = MD5.Create();
            // 加密后是一个字节类型的数组
            byte[] s = md5.ComputeHash(Encoding.UTF8.GetBytes(strPwd));
            //翻转生成的MD5码  
            s.Reverse();
            //通过使用循环，将字节类型的数组转换为字符串，此字符串是常规字符格式化所得
            //只取MD5码的一部分，这样恶意访问者无法知道取的是哪几位
            for (int i = 3; i < s.Length - 1; i++)
            {
                //将得到的字符串使用十六进制类型格式。格式后的字符是小写的字母，如果使用大写（X）则格式后的字符是大写字符
                //进一步对生成的MD5码做一些改造
                pwd = pwd + (s[i] < 198 ? s[i] + 28 : s[i]).ToString("X");
            }
            return pwd;
        }
    }
}
