namespace Система_для_работы_с_данными_о_студентах
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number_Zach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number_Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number_Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course1_Lections = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course1_Exams = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course1_Study_Practice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course1_Course_Work = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course2_Lections = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course2_Exams = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course2_Study_Practice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course2_Course_Work = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course3_Lections = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course3_Exams = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course3_Internship = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course3_Graduate_Work = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Просмотр данных";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Работа с данными";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nname,
            this.Surname,
            this.Patronymic,
            this.BirthDate,
            this.Number_Zach,
            this.Number_Group,
            this.Number_Course,
            this.Course1_Lections,
            this.Course1_Exams,
            this.Course1_Study_Practice,
            this.Course1_Course_Work,
            this.Course2_Lections,
            this.Course2_Exams,
            this.Course2_Study_Practice,
            this.Course2_Course_Work,
            this.Course3_Lections,
            this.Course3_Exams,
            this.Course3_Internship,
            this.Course3_Graduate_Work});
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(756, 388);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Nname
            // 
            this.Nname.HeaderText = "Имя";
            this.Nname.Name = "Nname";
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Фамилия";
            this.Surname.Name = "Surname";
            // 
            // Patronymic
            // 
            this.Patronymic.HeaderText = "Фамилия";
            this.Patronymic.Name = "Patronymic";
            // 
            // BirthDate
            // 
            this.BirthDate.HeaderText = "Дата рождения";
            this.BirthDate.Name = "BirthDate";
            // 
            // Number_Zach
            // 
            this.Number_Zach.HeaderText = "Номер зачётки";
            this.Number_Zach.Name = "Number_Zach";
            // 
            // Number_Group
            // 
            this.Number_Group.HeaderText = "Номер группы";
            this.Number_Group.Name = "Number_Group";
            // 
            // Number_Course
            // 
            this.Number_Course.HeaderText = "Номер курса";
            this.Number_Course.Name = "Number_Course";
            // 
            // Course1_Lections
            // 
            this.Course1_Lections.HeaderText = "Курс1-Лекции";
            this.Course1_Lections.Name = "Course1_Lections";
            // 
            // Course1_Exams
            // 
            this.Course1_Exams.HeaderText = "Курс1-Экзамены";
            this.Course1_Exams.Name = "Course1_Exams";
            // 
            // Course1_Study_Practice
            // 
            this.Course1_Study_Practice.HeaderText = "Курс1-Учебная практика";
            this.Course1_Study_Practice.Name = "Course1_Study_Practice";
            // 
            // Course1_Course_Work
            // 
            this.Course1_Course_Work.HeaderText = "Курс1-Курсовая работа";
            this.Course1_Course_Work.Name = "Course1_Course_Work";
            // 
            // Course2_Lections
            // 
            this.Course2_Lections.HeaderText = "Курс2-Лекции";
            this.Course2_Lections.Name = "Course2_Lections";
            // 
            // Course2_Exams
            // 
            this.Course2_Exams.HeaderText = "Курс2-Экзамена";
            this.Course2_Exams.Name = "Course2_Exams";
            // 
            // Course2_Study_Practice
            // 
            this.Course2_Study_Practice.HeaderText = "Курс2-Учебная практика";
            this.Course2_Study_Practice.Name = "Course2_Study_Practice";
            // 
            // Course2_Course_Work
            // 
            this.Course2_Course_Work.HeaderText = "Курс2-Курсовая работа";
            this.Course2_Course_Work.Name = "Course2_Course_Work";
            // 
            // Course3_Lections
            // 
            this.Course3_Lections.HeaderText = "Курс3-Лекции";
            this.Course3_Lections.Name = "Course3_Lections";
            // 
            // Course3_Exams
            // 
            this.Course3_Exams.HeaderText = "Курс3-Экзамены";
            this.Course3_Exams.Name = "Course3_Exams";
            // 
            // Course3_Internship
            // 
            this.Course3_Internship.HeaderText = "Курс3-Производственная практика";
            this.Course3_Internship.Name = "Course3_Internship";
            // 
            // Course3_Graduate_Work
            // 
            this.Course3_Graduate_Work.HeaderText = "Курс3-Дипломная работа";
            this.Course3_Graduate_Work.Name = "Course3_Graduate_Work";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Система для работы с данными о студентах внутри учебного плана";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number_Zach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number_Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number_Course;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course1_Lections;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course1_Exams;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course1_Study_Practice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course1_Course_Work;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course2_Lections;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course2_Exams;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course2_Study_Practice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course2_Course_Work;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course3_Lections;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course3_Exams;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course3_Internship;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course3_Graduate_Work;
    }
}

