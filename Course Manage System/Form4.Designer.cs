namespace Course_Manage_System
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.学生姓名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.班级DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.课程DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chooseClassBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.courseDBDataSet1 = new Course_Manage_System.CourseDBDataSet1();
            this.chooseClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.班级DataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.课程名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.当前人数DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.班级容量DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.上课时间DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.地点DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classStateBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.classStateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classSpeakerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.courseDBDataSet11 = new Course_Manage_System.CourseDBDataSet1();
            this.courseStateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classSpeakerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chooseClassTableAdapter = new Course_Manage_System.CourseDBDataSet1TableAdapters.ChooseClassTableAdapter();
            this.classSpeakerTableAdapter = new Course_Manage_System.CourseDBDataSet1TableAdapters.ClassSpeakerTableAdapter();
            this.courseStateTableAdapter = new Course_Manage_System.CourseDBDataSet1TableAdapters.CourseStateTableAdapter();
            this.classStateTableAdapter = new Course_Manage_System.CourseDBDataSet1TableAdapters.ClassStateTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.courseTableAdapter1 = new Course_Manage_System.CourseDataSet1TableAdapters.CourseTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseClassBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseClassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classStateBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classStateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classSpeakerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDBDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseStateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classSpeakerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.学生姓名DataGridViewTextBoxColumn,
            this.班级DataGridViewTextBoxColumn,
            this.课程DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.chooseClassBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(104, 55);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(348, 120);
            this.dataGridView1.TabIndex = 2;
            // 
            // 学生姓名DataGridViewTextBoxColumn
            // 
            this.学生姓名DataGridViewTextBoxColumn.DataPropertyName = "学生姓名";
            this.学生姓名DataGridViewTextBoxColumn.HeaderText = "学生姓名";
            this.学生姓名DataGridViewTextBoxColumn.Name = "学生姓名DataGridViewTextBoxColumn";
            this.学生姓名DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 班级DataGridViewTextBoxColumn
            // 
            this.班级DataGridViewTextBoxColumn.DataPropertyName = "班级";
            this.班级DataGridViewTextBoxColumn.HeaderText = "班级";
            this.班级DataGridViewTextBoxColumn.Name = "班级DataGridViewTextBoxColumn";
            this.班级DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 课程DataGridViewTextBoxColumn
            // 
            this.课程DataGridViewTextBoxColumn.DataPropertyName = "课程";
            this.课程DataGridViewTextBoxColumn.HeaderText = "课程";
            this.课程DataGridViewTextBoxColumn.Name = "课程DataGridViewTextBoxColumn";
            this.课程DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chooseClassBindingSource1
            // 
            this.chooseClassBindingSource1.DataMember = "ChooseClass";
            this.chooseClassBindingSource1.DataSource = this.courseDBDataSet1;
            // 
            // courseDBDataSet1
            // 
            this.courseDBDataSet1.DataSetName = "CourseDBDataSet1";
            this.courseDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chooseClassBindingSource
            // 
            this.chooseClassBindingSource.DataMember = "ChooseClass";
            this.chooseClassBindingSource.DataSource = this.courseDBDataSet1;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AllowUserToOrderColumns = true;
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.班级DataGridViewTextBoxColumn2,
            this.课程名,
            this.当前人数DataGridViewTextBoxColumn,
            this.班级容量DataGridViewTextBoxColumn,
            this.上课时间DataGridViewTextBoxColumn,
            this.地点DataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.classStateBindingSource1;
            this.dataGridView4.Location = new System.Drawing.Point(104, 229);
            this.dataGridView4.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowTemplate.Height = 27;
            this.dataGridView4.Size = new System.Drawing.Size(588, 120);
            this.dataGridView4.TabIndex = 5;
            // 
            // 班级DataGridViewTextBoxColumn2
            // 
            this.班级DataGridViewTextBoxColumn2.DataPropertyName = "班级";
            this.班级DataGridViewTextBoxColumn2.HeaderText = "班级";
            this.班级DataGridViewTextBoxColumn2.Name = "班级DataGridViewTextBoxColumn2";
            this.班级DataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // 课程名
            // 
            this.课程名.DataPropertyName = "课程名";
            this.课程名.HeaderText = "课程名";
            this.课程名.Name = "课程名";
            this.课程名.ReadOnly = true;
            // 
            // 当前人数DataGridViewTextBoxColumn
            // 
            this.当前人数DataGridViewTextBoxColumn.DataPropertyName = "当前人数";
            this.当前人数DataGridViewTextBoxColumn.HeaderText = "当前人数";
            this.当前人数DataGridViewTextBoxColumn.Name = "当前人数DataGridViewTextBoxColumn";
            this.当前人数DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 班级容量DataGridViewTextBoxColumn
            // 
            this.班级容量DataGridViewTextBoxColumn.DataPropertyName = "班级容量";
            this.班级容量DataGridViewTextBoxColumn.HeaderText = "班级容量";
            this.班级容量DataGridViewTextBoxColumn.Name = "班级容量DataGridViewTextBoxColumn";
            this.班级容量DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 上课时间DataGridViewTextBoxColumn
            // 
            this.上课时间DataGridViewTextBoxColumn.DataPropertyName = "上课时间";
            this.上课时间DataGridViewTextBoxColumn.HeaderText = "上课时间";
            this.上课时间DataGridViewTextBoxColumn.Name = "上课时间DataGridViewTextBoxColumn";
            this.上课时间DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 地点DataGridViewTextBoxColumn
            // 
            this.地点DataGridViewTextBoxColumn.DataPropertyName = "地点";
            this.地点DataGridViewTextBoxColumn.HeaderText = "地点";
            this.地点DataGridViewTextBoxColumn.Name = "地点DataGridViewTextBoxColumn";
            this.地点DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classStateBindingSource1
            // 
            this.classStateBindingSource1.DataMember = "ClassState";
            this.classStateBindingSource1.DataSource = this.courseDBDataSet1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(208, 374);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "登记学员";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(84, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "选课信息";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(84, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "班级信息";
            // 
            // classStateBindingSource
            // 
            this.classStateBindingSource.DataMember = "ClassState";
            this.classStateBindingSource.DataSource = this.courseDBDataSet1;
            // 
            // classSpeakerBindingSource1
            // 
            this.classSpeakerBindingSource1.DataMember = "ClassSpeaker";
            this.classSpeakerBindingSource1.DataSource = this.courseDBDataSet11;
            // 
            // courseDBDataSet11
            // 
            this.courseDBDataSet11.DataSetName = "CourseDBDataSet1";
            this.courseDBDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseStateBindingSource
            // 
            this.courseStateBindingSource.DataMember = "CourseState";
            this.courseStateBindingSource.DataSource = this.courseDBDataSet1;
            // 
            // classSpeakerBindingSource
            // 
            this.classSpeakerBindingSource.DataMember = "ClassSpeaker";
            this.classSpeakerBindingSource.DataSource = this.courseDBDataSet1;
            // 
            // chooseClassTableAdapter
            // 
            this.chooseClassTableAdapter.ClearBeforeFill = true;
            // 
            // classSpeakerTableAdapter
            // 
            this.classSpeakerTableAdapter.ClearBeforeFill = true;
            // 
            // courseStateTableAdapter
            // 
            this.courseStateTableAdapter.ClearBeforeFill = true;
            // 
            // classStateTableAdapter
            // 
            this.classStateTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::Course_Manage_System.Properties.Resources.refresh;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(16, 10);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 31);
            this.button2.TabIndex = 11;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // courseTableAdapter1
            // 
            this.courseTableAdapter1.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Navy;
            this.button3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(366, 374);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 38);
            this.button3.TabIndex = 12;
            this.button3.Text = "登记课程";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Course_Manage_System.Properties.Resources._5546d03a6e14e8b9c6dc650250abdc3b;
            this.ClientSize = new System.Drawing.Size(728, 434);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form4";
            this.Text = "服务台";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseClassBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseClassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classStateBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classStateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classSpeakerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDBDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseStateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classSpeakerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CourseDBDataSet1 courseDBDataSet1;
        private System.Windows.Forms.BindingSource chooseClassBindingSource;
        private CourseDBDataSet1TableAdapters.ChooseClassTableAdapter chooseClassTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学生姓名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 班级DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 课程DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource classSpeakerBindingSource;
        private CourseDBDataSet1TableAdapters.ClassSpeakerTableAdapter classSpeakerTableAdapter;
        private System.Windows.Forms.BindingSource courseStateBindingSource;
        private CourseDBDataSet1TableAdapters.CourseStateTableAdapter courseStateTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.BindingSource classStateBindingSource;
        private CourseDBDataSet1TableAdapters.ClassStateTableAdapter classStateTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private CourseDBDataSet1 courseDBDataSet11;
        private System.Windows.Forms.BindingSource classSpeakerBindingSource1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource classStateBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 班级DataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 课程名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 当前人数DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 班级容量DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 上课时间DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 地点DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private CourseDataSet1TableAdapters.CourseTableAdapter courseTableAdapter1;
        private System.Windows.Forms.BindingSource chooseClassBindingSource1;
        private System.Windows.Forms.Button button3;

    }
}