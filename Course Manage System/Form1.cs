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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            load();
        }

        private void load()
        {
            // TODO:  这行代码将数据加载到表“courseDBDataSet12.ClassSpeaker”中。您可以根据需要移动或删除它。
            this.classSpeakerTableAdapter.Fill(this.courseDBDataSet12.ClassSpeaker);
            // TODO:  这行代码将数据加载到表“courseDataSet11.Course”中。您可以根据需要移动或删除它。
            this.courseTableAdapter.Fill(this.courseDataSet11.Course);
            try
            {
                dataGridView1.Columns[1].DefaultCellStyle.Format = "yyyy-MM-dd";
                dataGridView1.Columns[2].DefaultCellStyle.Format = "yyyy-MM-dd";
                // TODO:  这行代码将数据加载到表“courseDBDataSet1.ClassSpeaker”中。您可以根据需要移动或删除它。
                this.classSpeakerTableAdapter.Fill(this.courseDBDataSet1.ClassSpeaker);
                // TODO:  这行代码将数据加载到表“courseDataSet1.Course”中。您可以根据需要移动或删除它。
                this.courseTableAdapter.Fill(this.courseDataSet1.Course);
                // TODO:  这行代码将数据加载到表“courseDBDataSet.ChooseClass”中。您可以根据需要移动或删除它。
                //this.chooseClassTableAdapter.Fill(this.courseDBDataSet.ChooseClass);

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            load();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        


    }
}
