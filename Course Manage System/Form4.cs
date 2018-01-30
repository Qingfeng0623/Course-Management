using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Course_Manage_System
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            load();
        }

        private void load()
        {
            dataGridView4.Columns[4].DefaultCellStyle.Format = "yyyy-MM-dd";
            // TODO:  这行代码将数据加载到表“courseDBDataSet11.ClassSpeaker”中。您可以根据需要移动或删除它。
            this.classSpeakerTableAdapter.Fill(this.courseDBDataSet11.ClassSpeaker);
            try
            {
                // TODO:  这行代码将数据加载到表“courseDBDataSet1.ClassState”中。您可以根据需要移动或删除它。
                this.classStateTableAdapter.Fill(this.courseDBDataSet1.ClassState);
                // TODO:  这行代码将数据加载到表“courseDBDataSet1.CourseState”中。您可以根据需要移动或删除它。
                this.courseStateTableAdapter.Fill(this.courseDBDataSet1.CourseState);
                // TODO:  这行代码将数据加载到表“courseDBDataSet1.ClassSpeaker”中。您可以根据需要移动或删除它。
                this.classSpeakerTableAdapter.Fill(this.courseDBDataSet1.ClassSpeaker);
                // TODO:  这行代码将数据加载到表“courseDBDataSet1.ChooseClass”中。您可以根据需要移动或删除它。
                this.chooseClassTableAdapter.Fill(this.courseDBDataSet1.ChooseClass);
            }
            catch (Exception ee)
            {
                //MessageBox.Show(this, ee.Message, "加载失败！", MessageBoxButtons.OK);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            load();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }

        
    }
}
