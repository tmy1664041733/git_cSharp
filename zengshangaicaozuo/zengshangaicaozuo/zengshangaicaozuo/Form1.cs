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

namespace zengshangaicaozuo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        private void TextBoxNull()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBoxNull();
            ds = SqlDesigner.ExecuteDataSet("select * from Score");
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            //labelshow();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int i = 0;
            string sql;
            try
            {
                sql = "insert into Score (Sno,Sname,Sclass,SChinese,SMath,SEnglish) values ('"
                + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','"  + textBox6.Text + "')";
                i = SqlDesigner.ExecuteNoQuery(sql);
            }
            catch {
                MessageBox.Show("添加失败");
            }
            if (i > 0)
            {
                MessageBox.Show("添加成功");
            }
            else {
                MessageBox.Show("添加失败");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int i = 0;
            string sql;
            try
            {
                sql = "delete  from Score where Sno = '"
                + textBox1.Text + "'";
                i = SqlDesigner.ExecuteNoQuery(sql);
            }
            catch
            {
                MessageBox.Show("删除失败");
            }
            if (i > 0)
            {
                MessageBox.Show("删除成功");
            }
            else
            {
                MessageBox.Show("删除失败");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int i = 0;
            string sql;
            try
            {
                sql = "update  Score set Sname='" + textBox2.Text + "',Sclass= '" + textBox3.Text +"',SChinese= '" + textBox4.Text + "',SMath= '" + textBox5.Text + "',SEnglish= '" + textBox6.Text + "'"
               +"where Sno='"+textBox1.Text+"'";
                i = SqlDesigner.ExecuteNoQuery(sql);
            }
            catch
            {
                MessageBox.Show("修改失败");
            }
            if (i > 0)
            {
                MessageBox.Show("修改成功");
            }
            else
            {
                MessageBox.Show("修改失败");
            }
        }

    

       
    }
}
