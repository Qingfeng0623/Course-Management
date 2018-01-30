using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Course_Manage_System
{
    public partial class Form5 : Form
    {
        
        private SqlConnection conn = null;
        /*private SqlDataAdapter sda = null;
        private DataTable dt = null;

        private SqlDataAdapter sda2 = null;
        private DataTable dt2 = null;*/
        public Form5()
        {
            InitializeComponent();
        }

        //private void Form5_Load(object sender, EventArgs e)
        /*{
            // TODO:  这行代码将数据加载到表“courseDBDataSet2.Choose”中。根据需要移动或删除它。
            this.chooseTableAdapter.Fill(this.courseDBDataSet2.Choose);
            // TODO:  这行代码将数据加载到表“courseDBDataSet2.Student”中。根据需要移动或删除它。
            this.studentTableAdapter.Fill(this.courseDBDataSet2.Student);

            string str = @"Data Source=YE996\SQLEXPRESS;Initial Catalog=CourseDB;Persist Security Info=True;User ID=sa;Password=sqlserver";
            conn = new SqlConnection(str);
            conn.Open();
            string querystr = "select * from Student";
            sda = new SqlDataAdapter(querystr,conn);
            dt = new DataTable();
            sda.Fill(dt);//将查到的数据传到DataTable中
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[5].DefaultCellStyle.Format = "yyyy-MM-dd";

            querystr = "select * from Choose";
            sda2 = new SqlDataAdapter(querystr, conn);
            dt2 = new DataTable();
            sda2.Fill(dt2);
            dataGridView2.DataSource = dt2;
            dataGridView2.Columns[2].DefaultCellStyle.Format = "yyyy-MM-dd";
        }*/

        public string getTreeNumRandom()
        {
            Random ro = new Random();
            int iResult;
            int iUp = 999;
            int iDown = 100;
            iResult = ro.Next(iDown, iUp);
            //Response.Write(iResult.ToString());
            return iResult.ToString().Trim();
        }

        private void button1_Click(object sender, EventArgs e)//添加
        {
            string sNo = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + getTreeNumRandom();
            //MessageBox.Show(sNo);
            string sName = textBox1.Text.ToString().Trim();
            string sex = comboBox2.Text.ToString().Trim();
            string id = textBox3.Text.ToString().Trim();
            string contact = textBox4.Text.ToString().Trim();
            //dateTimePicker1.Value = dateTimePicker1.Value.AddMonths(1);
            string bir = dateTimePicker1.Value.ToString("yyyy-mm-dd");//+ dateTimePicker1.Value.ToString().Substring(5, 2) + dateTimePicker1.Value.ToString().Substring(8,2);
            MessageBox.Show(bir);
            string other = textBox5.Text.ToString();
            string str = @"Data Source=YE996\SQLEXPRESS;Initial Catalog=CourseDB;Persist Security Info=True;User ID=sa;Password=sqlserver";
            conn = new SqlConnection(str);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into Student values ('" + sNo + "','" + sName + "','" + sex + "','" + id + "','" + contact + "','" + bir + "','" + other + "')";//
            MessageBox.Show(cmd.CommandText); 
            int num1 = cmd.ExecuteNonQuery();
            if (num1 > 0)
            {
                MessageBox.Show("成功！", "提示");
            }
            else
            {
                MessageBox.Show("失败！", "提示");
            }
            conn.Close();
        }


        private void button7_Click(object sender, EventArgs e)//退出
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)//清除
        {
            textBox1.Text = "";
            comboBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        //private void button3_Click(object sender, EventArgs e)
        /*{
            SqlCommandBuilder scb = new SqlCommandBuilder(sda2);

            try
            {
                sda2.Update(dt2);
            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "保存失败！", MessageBoxButtons.OK);
            }
        }*/

        //private void button4_Click(object sender, EventArgs e)
        /*{
            if(MessageBox.Show("确定要删除改行吗？","询问",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                
                string zhi = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//获取第一个单元格的值
                
                int r = -1;
                string del = "delete from Student where SNo=" + zhi;
                    using(SqlCommand sc = new SqlCommand(del,conn))
                    {
                        r = sc.ExecuteNonQuery();
                    }
                    string msg = r > 0 ? "删除成功" : "删除失败";
                    MessageBox.Show(msg);
                
                SqlCommandBuilder scb = new SqlCommandBuilder(sda);
                string querystr = "select * from Student";
                sda = new SqlDataAdapter(querystr, conn);
                dt = new DataTable();
                sda.Fill(dt);//将查到的数据传到DataTable中
                dataGridView1.DataSource = dt;
                }
                catch(Exception ee)
                {
                    MessageBox.Show(this, ee.Message, "保存失败！", MessageBoxButtons.OK);
                }

            }
        }*/

        //private void button5_Click(object sender, EventArgs e)
        /*{
            if (MessageBox.Show("确定要删除改行吗？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    
                    string zhi1 = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();//获取第一个单元格的值
                    string zhi2 = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();//获取第二个单元格的值
                    MessageBox.Show(zhi1);
                    MessageBox.Show(zhi2);
                    int r = -1;
                    string del = "delete from Choose where SNo=" + zhi1 + "and ClassNo=" + zhi2;
                    using (SqlCommand sc = new SqlCommand(del, conn))
                    {
                        r = sc.ExecuteNonQuery();
                    }
                    string msg = r > 0 ? "删除成功" : "删除失败";
                    MessageBox.Show(msg);
                    SqlCommandBuilder scb = new SqlCommandBuilder(sda2);
                    string querystr = "select * from Choose";
                    sda2 = new SqlDataAdapter(querystr, conn);
                    dt2 = new DataTable();
                    sda2.Fill(dt2);//将查到的数据传到DataTable中
                    dataGridView2.DataSource = dt2;
                }
                catch (Exception ee)
                {
                    MessageBox.Show(this, ee.Message, "保存失败！", MessageBoxButtons.OK);
                }

            }
        }*/

        //private void button6_Click(object sender, EventArgs e)//清除
        /*{
            textBox1.Text = "";
            comboBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            dateTimePicker1.Text="2000/1/1";

        }*/

        //private void button7_Click(object sender, EventArgs e)//退出
        /*{
            try
            {
                this.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString(), "");
            }
        }*/      
        
        

    }
}
