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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("请输入用户名！","WARNING");
            }
            if(textBox2.Text == "")
            {
                MessageBox.Show("请输入密码！", "WARNING");
            }
            if(textBox1.Text != "" && textBox2.Text != "")
            {
                string str = @"Data Source=YE996\SQLEXPRESS;Initial Catalog=CourseDB;Persist Security Info=True;User ID=sa;Password=sqlserver";
                try 
                {
                    SqlConnection conn = new SqlConnection(str);
                    conn.Open();
                    
                    string loginstr = "Select password from login where username='" + textBox1.Text + "'";
                    SqlCommand cmd = new SqlCommand(loginstr, conn);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                        string inPassword = textBox2.Text.Trim();
                        string password = Convert.ToString(sdr[0]).Trim();
                        if (inPassword == password)
                        {
                            if(textBox1.Text == "s1")
                            {
                                Form3 form3 = new Form3();
                                form3.Show();
                            }
                            if(textBox1.Text == "s2")
                            {
                                Form4 form4 = new Form4();
                                form4.Show();
                            }
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("登录失败！", "");
                            textBox1.Text = "";
                            textBox2.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("输入的用户名不存在！", "");
                    }
                    sdr.Close();
                    conn.Close();
                }
                catch(Exception ee)
                {
                    MessageBox.Show("数据库连接失败！" + ee.ToString());
                }
                    
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

    }
}
