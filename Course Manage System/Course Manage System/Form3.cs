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
    public partial class Form3 : Form
    {
        private SqlConnection conn = null;

        private SqlDataAdapter sda1 = null;
        private DataTable dt1 = null;

        private SqlDataAdapter sda2 = null;
        private DataTable dt2 = null;

        private SqlDataAdapter sda3 = null;
        private DataTable dt3 = null;

        private SqlDataAdapter sda4 = null;
        private DataTable dt4 = null;

        private SqlDataAdapter sda5 = null;
        private DataTable dt5 = null;

        private SqlDataAdapter sda6 = null;
        private DataTable dt6 = null;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            load();
        }

        private void load()
        {
            string str = @"Data Source=YE996\SQLEXPRESS;Initial Catalog=CourseDB;Persist Security Info=True;User ID=sa;Password=sqlserver";
            conn = new SqlConnection(str);
            conn.Open();

            string querystr1 = "select * from Student";
            sda1 = new SqlDataAdapter(querystr1, conn);
            dt1 = new DataTable();
            sda1.Fill(dt1);//将查到的数据传到DataTable中
            dataGridView1.DataSource = dt1;
            dataGridView1.Columns[5].DefaultCellStyle.Format = "yyyy-MM-dd";

            string querystr2 = "select * from Worker";
            sda2 = new SqlDataAdapter(querystr2, conn);
            dt2 = new DataTable();
            sda2.Fill(dt2);//将查到的数据传到DataTable中
            dataGridView2.DataSource = dt2;
            dataGridView2.Columns[5].DefaultCellStyle.Format = "yyyy-MM-dd";

            string querystr3 = "select * from Course";
            sda3 = new SqlDataAdapter(querystr3, conn);
            dt3 = new DataTable();
            sda3.Fill(dt3);//将查到的数据传到DataTable中
            dataGridView3.DataSource = dt3;
            dataGridView3.Columns[2].DefaultCellStyle.Format = "yyyy-MM-dd";
            dataGridView3.Columns[3].DefaultCellStyle.Format = "yyyy-MM-dd";

            string querystr4 = "select * from Lesson";
            sda4 = new SqlDataAdapter(querystr4, conn);
            dt4 = new DataTable();
            sda4.Fill(dt4);//将查到的数据传到DataTable中
            dataGridView4.DataSource = dt4;
            dataGridView4.Columns[4].DefaultCellStyle.Format = "yyyy-MM-dd";

            string querystr5 = "select * from Choose";
            sda5 = new SqlDataAdapter(querystr5, conn);
            dt5 = new DataTable();
            sda5.Fill(dt5);//将查到的数据传到DataTable中
            dataGridView5.DataSource = dt5;
            dataGridView5.Columns[2].DefaultCellStyle.Format = "yyyy-MM-dd";

            string querystr6 = "select * from Teach";
            sda6 = new SqlDataAdapter(querystr6, conn);
            dt6 = new DataTable();
            sda6.Fill(dt6);//将查到的数据传到DataTable中
            dataGridView6.DataSource = dt6;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommandBuilder scb = new SqlCommandBuilder(sda1);

            try
            {
                sda1.Update(dt1);

            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "保存失败！", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要删除改行吗？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {

                    string zhi = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//获取第一个单元格的值

                    int r = -1;
                    string del = "delete from Student where SNo=" + zhi;
                    using (SqlCommand sc = new SqlCommand(del, conn))
                    {
                        r = sc.ExecuteNonQuery();
                    }
                    string msg = r > 0 ? "删除成功" : "删除失败";
                    MessageBox.Show(msg);

                    SqlCommandBuilder scb = new SqlCommandBuilder(sda1);
                    string querystr = "select * from Student";
                    sda1 = new SqlDataAdapter(querystr, conn);
                    dt1 = new DataTable();
                    sda1.Fill(dt1);//将查到的数据传到DataTable中
                    dataGridView1.DataSource = dt1;
                }
                catch (Exception ee)
                {
                    MessageBox.Show(this, ee.Message, "保存失败！", MessageBoxButtons.OK);
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            SqlCommandBuilder scb = new SqlCommandBuilder(sda2);

            try
            {
                sda2.Update(dt2);

            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "保存失败！", MessageBoxButtons.OK);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要删除改行吗？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {

                    string zhi = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();//获取第一个单元格的值

                    int r = -1;
                    string del = "delete from Worker where WNo=" + zhi;
                    using (SqlCommand sc = new SqlCommand(del, conn))
                    {
                        r = sc.ExecuteNonQuery();
                    }
                    string msg = r > 0 ? "删除成功" : "删除失败";
                    MessageBox.Show(msg);

                    SqlCommandBuilder scb = new SqlCommandBuilder(sda2);
                    string querystr = "select * from Worker";
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
        }

        private void button5_Click(object sender, EventArgs e)
        {

            SqlCommandBuilder scb = new SqlCommandBuilder(sda3);

            try
            {
                sda3.Update(dt3);

            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "保存失败！", MessageBoxButtons.OK);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要删除改行吗？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {

                    string zhi = dataGridView3.SelectedRows[0].Cells[0].Value.ToString();//获取第一个单元格的值

                    int r = -1;
                    string del = "delete from Course where CNo=" + zhi;
                    using (SqlCommand sc = new SqlCommand(del, conn))
                    {
                        r = sc.ExecuteNonQuery();
                    }
                    string msg = r > 0 ? "删除成功" : "删除失败";
                    MessageBox.Show(msg);

                    SqlCommandBuilder scb = new SqlCommandBuilder(sda3);
                    string querystr = "select * from Course";
                    sda3 = new SqlDataAdapter(querystr, conn);
                    dt3 = new DataTable();
                    sda3.Fill(dt3);//将查到的数据传到DataTable中
                    dataGridView3.DataSource = dt3;
                }
                catch (Exception ee)
                {
                    MessageBox.Show(this, ee.Message, "保存失败！", MessageBoxButtons.OK);
                }

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            SqlCommandBuilder scb = new SqlCommandBuilder(sda4);

            try
            {
                sda4.Update(dt4);

            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "保存失败！", MessageBoxButtons.OK);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要删除改行吗？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {

                    string zhi = dataGridView4.SelectedRows[0].Cells[0].Value.ToString();//获取第一个单元格的值

                    int r = -1;
                    string del = "delete from Lesson where ClassNo=" + zhi;
                    using (SqlCommand sc = new SqlCommand(del, conn))
                    {
                        r = sc.ExecuteNonQuery();
                    }
                    string msg = r > 0 ? "删除成功" : "删除失败";
                    MessageBox.Show(msg);

                    SqlCommandBuilder scb = new SqlCommandBuilder(sda4);
                    string querystr = "select * from ClassNo";
                    sda4 = new SqlDataAdapter(querystr, conn);
                    dt4 = new DataTable();
                    sda4.Fill(dt4);//将查到的数据传到DataTable中
                    dataGridView4.DataSource = dt4;
                }
                catch (Exception ee)
                {
                    MessageBox.Show(this, ee.Message, "保存失败！", MessageBoxButtons.OK);
                }

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

            SqlCommandBuilder scb = new SqlCommandBuilder(sda5);

            try
            {
                sda5.Update(dt5);

            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "保存失败！", MessageBoxButtons.OK);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要删除改行吗？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {

                    string zhi = dataGridView5.SelectedRows[0].Cells[0].Value.ToString();//获取第一个单元格的值
                    string zhi2 = dataGridView5.SelectedRows[0].Cells[1].Value.ToString();//获取第二个单元格的值
                    int r = -1;
                    string del = "delete from Choose where SNo=" + zhi + "and ClassNo=" + zhi2;
                    using (SqlCommand sc = new SqlCommand(del, conn))
                    {
                        r = sc.ExecuteNonQuery();
                    }
                    string msg = r > 0 ? "删除成功" : "删除失败";
                    MessageBox.Show(msg);

                    SqlCommandBuilder scb = new SqlCommandBuilder(sda5);
                    string querystr = "select * from Choose";
                    sda5 = new SqlDataAdapter(querystr, conn);
                    dt5 = new DataTable();
                    sda5.Fill(dt5);//将查到的数据传到DataTable中
                    dataGridView5.DataSource = dt5;
                }
                catch (Exception ee)
                {
                    MessageBox.Show(this, ee.Message, "保存失败！", MessageBoxButtons.OK);
                }

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {

            SqlCommandBuilder scb = new SqlCommandBuilder(sda6);

            try
            {
                sda6.Update(dt6);

            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "保存失败！", MessageBoxButtons.OK);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要删除改行吗？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {

                    string zhi = dataGridView6.SelectedRows[0].Cells[0].Value.ToString();//获取第一个单元格的值
                    string zhi2 = dataGridView6.SelectedRows[0].Cells[1].Value.ToString();//获取第二个单元格的值
                    int r = -1;
                    string del = "delete from Teach where WNo=" + zhi + "ClassNo=" + zhi2;
                    using (SqlCommand sc = new SqlCommand(del, conn))
                    {
                        r = sc.ExecuteNonQuery();
                    }
                    string msg = r > 0 ? "删除成功" : "删除失败";
                    MessageBox.Show(msg);

                    SqlCommandBuilder scb = new SqlCommandBuilder(sda6);
                    string querystr = "select * from Teach";
                    sda6 = new SqlDataAdapter(querystr, conn);
                    dt6 = new DataTable();
                    sda6.Fill(dt6);//将查到的数据传到DataTable中
                    dataGridView6.DataSource = dt6;
                }
                catch (Exception ee)
                {
                    MessageBox.Show(this, ee.Message, "保存失败！", MessageBoxButtons.OK);
                }

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            load();
        }

        
    }
}
