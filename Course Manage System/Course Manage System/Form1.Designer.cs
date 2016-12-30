namespace Course_Manage_System
{
    partial class HomePage
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.courseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.courseDataSet11 = new Course_Manage_System.CourseDataSet1();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.classSpeakerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseDBDataSet1 = new Course_Manage_System.CourseDBDataSet1();
            this.classSpeakerTableAdapter = new Course_Manage_System.CourseDBDataSet1TableAdapters.ClassSpeakerTableAdapter();
            this.classSpeakerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.classSpeakerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.courseDBDataSet11 = new Course_Manage_System.CourseDBDataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseDataSet1 = new Course_Manage_System.CourseDataSet1();
            this.courseTableAdapter = new Course_Manage_System.CourseDataSet1TableAdapters.CourseTableAdapter();
            this.courseDBDataSet12 = new Course_Manage_System.CourseDBDataSet1();
            this.classSpeakerBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.班级DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.课程名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.教师姓名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classSpeakerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classSpeakerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classSpeakerBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDBDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDBDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classSpeakerBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label8.Font = new System.Drawing.Font("仿宋", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(264, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(445, 60);
            this.label8.TabIndex = 17;
            this.label8.Text = "余家头培训机构";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNameDataGridViewTextBoxColumn,
            this.startDaDataGridViewTextBoxColumn,
            this.endDaDataGridViewTextBoxColumn,
            this.chourDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.courseBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(63, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(740, 256);
            this.dataGridView1.TabIndex = 0;
            // 
            // courseBindingSource1
            // 
            this.courseBindingSource1.DataMember = "Course";
            this.courseBindingSource1.DataSource = this.courseDataSet11;
            // 
            // courseDataSet11
            // 
            this.courseDataSet11.DataSetName = "CourseDataSet1";
            this.courseDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.linkLabel1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(12, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(67, 33);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Link";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // classSpeakerBindingSource
            // 
            this.classSpeakerBindingSource.DataMember = "ClassSpeaker";
            this.classSpeakerBindingSource.DataSource = this.courseDBDataSet1;
            // 
            // courseDBDataSet1
            // 
            this.courseDBDataSet1.DataSetName = "CourseDBDataSet1";
            this.courseDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classSpeakerTableAdapter
            // 
            this.classSpeakerTableAdapter.ClearBeforeFill = true;
            // 
            // classSpeakerBindingSource1
            // 
            this.classSpeakerBindingSource1.DataMember = "ClassSpeaker";
            this.classSpeakerBindingSource1.DataSource = this.courseDBDataSet1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.班级DataGridViewTextBoxColumn,
            this.课程名,
            this.教师姓名DataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.classSpeakerBindingSource3;
            this.dataGridView2.Location = new System.Drawing.Point(179, 467);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(439, 220);
            this.dataGridView2.TabIndex = 21;
            // 
            // classSpeakerBindingSource2
            // 
            this.classSpeakerBindingSource2.DataMember = "ClassSpeaker";
            this.classSpeakerBindingSource2.DataSource = this.courseDBDataSet11;
            // 
            // courseDBDataSet11
            // 
            this.courseDBDataSet11.DataSetName = "CourseDBDataSet1";
            this.courseDBDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(32, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 31);
            this.label1.TabIndex = 22;
            this.label1.Text = "课程";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(102, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 23;
            this.label2.Text = "上课老师";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Course_Manage_System.Properties.Resources.refresh;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(108, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 39);
            this.button1.TabIndex = 24;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.courseDataSet1;
            // 
            // courseDataSet1
            // 
            this.courseDataSet1.DataSetName = "CourseDataSet1";
            this.courseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // courseDBDataSet12
            // 
            this.courseDBDataSet12.DataSetName = "CourseDBDataSet1";
            this.courseDBDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classSpeakerBindingSource3
            // 
            this.classSpeakerBindingSource3.DataMember = "ClassSpeaker";
            this.classSpeakerBindingSource3.DataSource = this.courseDBDataSet12;
            // 
            // 班级DataGridViewTextBoxColumn
            // 
            this.班级DataGridViewTextBoxColumn.DataPropertyName = "班级";
            this.班级DataGridViewTextBoxColumn.HeaderText = "班级";
            this.班级DataGridViewTextBoxColumn.Name = "班级DataGridViewTextBoxColumn";
            this.班级DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 课程名
            // 
            this.课程名.DataPropertyName = "课程名";
            this.课程名.HeaderText = "课程名";
            this.课程名.Name = "课程名";
            this.课程名.ReadOnly = true;
            // 
            // 教师姓名DataGridViewTextBoxColumn
            // 
            this.教师姓名DataGridViewTextBoxColumn.DataPropertyName = "教师姓名";
            this.教师姓名DataGridViewTextBoxColumn.HeaderText = "教师姓名";
            this.教师姓名DataGridViewTextBoxColumn.Name = "教师姓名DataGridViewTextBoxColumn";
            this.教师姓名DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cNameDataGridViewTextBoxColumn
            // 
            this.cNameDataGridViewTextBoxColumn.DataPropertyName = "CName";
            this.cNameDataGridViewTextBoxColumn.HeaderText = "课程名";
            this.cNameDataGridViewTextBoxColumn.Name = "cNameDataGridViewTextBoxColumn";
            this.cNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startDaDataGridViewTextBoxColumn
            // 
            this.startDaDataGridViewTextBoxColumn.DataPropertyName = "StartDa";
            this.startDaDataGridViewTextBoxColumn.HeaderText = "开课日期";
            this.startDaDataGridViewTextBoxColumn.Name = "startDaDataGridViewTextBoxColumn";
            this.startDaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endDaDataGridViewTextBoxColumn
            // 
            this.endDaDataGridViewTextBoxColumn.DataPropertyName = "EndDa";
            this.endDaDataGridViewTextBoxColumn.HeaderText = "结课日期";
            this.endDaDataGridViewTextBoxColumn.Name = "endDaDataGridViewTextBoxColumn";
            this.endDaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chourDataGridViewTextBoxColumn
            // 
            this.chourDataGridViewTextBoxColumn.DataPropertyName = "Chour";
            this.chourDataGridViewTextBoxColumn.HeaderText = "课时";
            this.chourDataGridViewTextBoxColumn.Name = "chourDataGridViewTextBoxColumn";
            this.chourDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "费用";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1044, 714);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classSpeakerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classSpeakerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classSpeakerBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDBDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDBDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classSpeakerBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CourseDataSet1 courseDataSet1;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private CourseDataSet1TableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private CourseDBDataSet1 courseDBDataSet1;
        private System.Windows.Forms.BindingSource classSpeakerBindingSource;
        private CourseDBDataSet1TableAdapters.ClassSpeakerTableAdapter classSpeakerTableAdapter;
        private System.Windows.Forms.BindingSource classSpeakerBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private CourseDBDataSet1 courseDBDataSet11;
        private System.Windows.Forms.BindingSource classSpeakerBindingSource2;
        //private System.Windows.Forms.DataGridViewTextBoxColumn cNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private CourseDataSet1 courseDataSet11;
        private System.Windows.Forms.BindingSource courseBindingSource1;
        private CourseDBDataSet1 courseDBDataSet12;
        private System.Windows.Forms.BindingSource classSpeakerBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn 班级DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 课程名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 教师姓名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}

