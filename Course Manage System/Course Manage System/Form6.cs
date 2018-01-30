using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Course_Manage_System
{
    public partial class Form6 : Form
    {
        private SqlConnection conn = null;
        private SqlDataAdapter sda = null;
        private DataTable dt = null;
        List<string> list1 = new List<string>();//姓名
        List<string> list2 = new List<string>();//课程名
        List<string> list3 = new List<string>();//任课教师
        List<string> list4 = new List<string>();//班级
        string sNo = "";//根据姓名查找其学号

        public Form6()
        {
            InitializeComponent();
            //comboBox1.SelectedIndexChanged -= new EventHandler(comboBox1_SelectedIndexChanged);
            comboBox1.SelectedIndex = -1;
            //comboBox1.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);
        }
        

        private void button1_Click(object sender, EventArgs e)//添加课程（）
        {
            string str = @"Data Source=YE996\SQLEXPRESS;Initial Catalog=CourseDB;Persist Security Info=True;User ID=sa;Password=sqlserver";
            conn = new SqlConnection(str);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            

            string inTime = DateTime.Now.ToString("yyyy-mm-dd");//添加的时间
            //MessageBox.Show(inTime);
            string cName = comboBox2.Text.ToString();//课程名称
            string classNo = comboBox4.Text.ToString();//班级号
            
            int num1;
            //if (sNo.Length > 5)
            //    MessageBox.Show(chStr);
            string questr = "select * from Lesson where ClassNo = " + classNo;
            SqlDataAdapter s = new SqlDataAdapter(questr, conn);
            DataTable d = new DataTable();
            s.Fill(d);
            int length = (int)d.Rows[0][1];
            if (length < (int)d.Rows[0][2])//表示可以选
            {
                cmd.CommandText = "update lesson set Length = " + (length + 1) + "where ClassNo = " + classNo;//更新班级人数
                num1 = cmd.ExecuteNonQuery();
                if (num1 > 0)
                {
                    MessageBox.Show("成功！", "提示");
                }
                else
                {
                    MessageBox.Show("失败！", "提示");
                }
                
                cmd.CommandText = "insert into Choose values ('" + sNo + "','" + classNo + "','" + cName + "','" + inTime + "')";//插入选课记录
                num1 = cmd.ExecuteNonQuery();
                if (num1 > 0)
                {
                    MessageBox.Show("成功！", "提示");
                }
                else
                {
                    MessageBox.Show("失败！", "提示");
                }
                
            }
            else
                MessageBox.Show("该班级人数已满");
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)//退出
        {
            try
            {
                this.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString(), "");
            }
        }


        private void Form6_Load(object sender, EventArgs e)
        {           
            string str = @"Data Source=YE996\SQLEXPRESS;Initial Catalog=CourseDB;Persist Security Info=True;User ID=sa;Password=sqlserver";
            conn = new SqlConnection(str);
            conn.Open();
            string querystr = "select * from Student";
            sda = new SqlDataAdapter(querystr, conn);
            dt = new DataTable();
            sda.Fill(dt);//将查到的数据传到DataTable中    
            list1.Add("--请选择--");
            list2.Add("--请选择--");
            comboBox2.DataSource = list2;
            list3.Add("--请选择--");
            comboBox3.DataSource = list3;
            list4.Add("--请选择--");
            comboBox4.DataSource = list4;
            foreach (DataRow dr in dt.Rows)
                list1.Add(dr["Name"].ToString());
            comboBox1.DataSource = list1;
            comboBox1.DisplayMember = "Name";
            conn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)//选择人后显示可选课程
        {
            string sName = comboBox1.Text.Trim();
            string c, st,stu;
            if (string.Equals(sName, "--请选择--"))
                return;
            //MessageBox.Show(sName);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                stu = dt.Rows[i][1].ToString().Trim();
                if (string.Equals(stu,sName))
                {
                    sNo = dt.Rows[i][0].ToString().Trim();//学生学号
                    //MessageBox.Show(sNo);
                    break;
                }
            }

            string querystr2 = "select * from Course";
            SqlDataAdapter sda2 = new SqlDataAdapter(querystr2, conn);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);//将查到的数据传到DataTable中
            list2.Clear();
            list2.Add("--请选择--");
            BindingSource bs = new BindingSource();
            bs.DataSource = list2;
            try
            {
                string str = "select * from ChooseClass";
                SqlDataAdapter s = new SqlDataAdapter(str, conn);
                DataTable d = new DataTable();
                s.Fill(d);
                foreach (DataRow dr in dt2.Rows)
                {
                    bool exist = false;
                    string cName = dr["CName"].ToString().Trim();//课程名字
                    //MessageBox.Show(cName);
                    for (int i = 0; i < d.Rows.Count; i++)
                    {
                        c = d.Rows[i][1].ToString().Trim();//选了的课程
                        if (string.Equals(cName,c))//该生有选此门课则不能显示
                        {
                            st = d.Rows[i][0].ToString().Trim();
                            if (string.Equals(sName,st))
                            {
                                exist = true;
                                break;
                            }
                        }
                    }
                    if (!exist)//没有选此门课则可以显示
                    {
                        list2.Add(cName);
                        //bs.ResetBindings(false);
                    }
                }
            }catch(Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
            }
            comboBox2.DataSource = null;
            comboBox2.DataSource = list2;
            
            bs.ResetBindings(false);
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)//选择课程后显示可选的任课老师
        {
            string cName = comboBox2.Text.Trim();//选择的课程
            string c;
            string querystr2 = "select * from ClassSpeaker";
            SqlDataAdapter sda3 = new SqlDataAdapter(querystr2, conn);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);//将查到的数据传到DataTable中
            list3.Clear();
            list3.Add("--请选择--");
            BindingSource bs = new BindingSource();
            bs.DataSource = list3;

            foreach(DataRow dr in dt3.Rows)
            {
                c = dr[2].ToString().Trim();
                if(string.Equals(cName,c))//该课程是该老师教授的
                {
                    list3.Add(dr[1].ToString().Trim());
                }
            }
            list3 = list3.Distinct<string>().ToList();
            comboBox3.DataSource = null;
            comboBox3.DataSource = list3;

            bs.ResetBindings(false);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)//选择好老师后显示班级
        {
            string tName = comboBox3.Text.Trim();//选择的老师
            string c;
            string querystr3 = "select * from ClassSpeaker";
            SqlDataAdapter sda4 = new SqlDataAdapter(querystr3, conn);
            DataTable dt4 = new DataTable();
            sda4.Fill(dt4);//将查到的数据传到DataTable中
            list4.Clear();
            list4.Add("--请选择--");
            BindingSource bs = new BindingSource();
            bs.DataSource = list4;

            foreach (DataRow dr in dt4.Rows)
            {
                c = dr[1].ToString().Trim();//老师
                if (string.Equals(tName, c))//该课程是该老师教授的
                {
                    list4.Add(dr[0].ToString().Trim());
                }
            }
            list4 = list4.Distinct<string>().ToList();
            comboBox4.DataSource = null;
            comboBox4.DataSource = list4;

            bs.ResetBindings(false);
        }      

    }
}
