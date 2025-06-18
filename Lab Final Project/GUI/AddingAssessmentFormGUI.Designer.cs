namespace Lab_Final_Project.GUI
{
    partial class AddingAssessmentFormGUI
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
            this.lbl_course_header = new System.Windows.Forms.Label();
            this.lbl_course = new System.Windows.Forms.Label();
            this.lbl_sem = new System.Windows.Forms.Label();
            this.lbl_sem_header = new System.Windows.Forms.Label();
            this.btn_Assessment = new System.Windows.Forms.Button();
            this.btn_grading = new System.Windows.Forms.Button();
            this.btn_announcement = new System.Windows.Forms.Button();
            this.btn_attendance = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_courseAssessment = new System.Windows.Forms.Label();
            this.btn_addRecord = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Assessment = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_calculation = new System.Windows.Forms.ComboBox();
            this.cb_subAssessment = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.txt_weightage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_course_header
            // 
            this.lbl_course_header.AutoSize = true;
            this.lbl_course_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_course_header.Location = new System.Drawing.Point(26, 24);
            this.lbl_course_header.Name = "lbl_course_header";
            this.lbl_course_header.Size = new System.Drawing.Size(56, 16);
            this.lbl_course_header.TabIndex = 0;
            this.lbl_course_header.Text = "Course";
            // 
            // lbl_course
            // 
            this.lbl_course.AutoSize = true;
            this.lbl_course.Location = new System.Drawing.Point(102, 27);
            this.lbl_course.Name = "lbl_course";
            this.lbl_course.Size = new System.Drawing.Size(137, 13);
            this.lbl_course.TabIndex = 0;
            this.lbl_course.Text = "418-SE3118-F2022065-W1";
            // 
            // lbl_sem
            // 
            this.lbl_sem.AutoSize = true;
            this.lbl_sem.Location = new System.Drawing.Point(473, 26);
            this.lbl_sem.Name = "lbl_sem";
            this.lbl_sem.Size = new System.Drawing.Size(38, 13);
            this.lbl_sem.TabIndex = 0;
            this.lbl_sem.Text = "S2025";
            // 
            // lbl_sem_header
            // 
            this.lbl_sem_header.AutoSize = true;
            this.lbl_sem_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sem_header.Location = new System.Drawing.Point(379, 24);
            this.lbl_sem_header.Name = "lbl_sem_header";
            this.lbl_sem_header.Size = new System.Drawing.Size(73, 16);
            this.lbl_sem_header.TabIndex = 0;
            this.lbl_sem_header.Text = "Semester";
            // 
            // btn_Assessment
            // 
            this.btn_Assessment.BackColor = System.Drawing.Color.Sienna;
            this.btn_Assessment.Location = new System.Drawing.Point(29, 63);
            this.btn_Assessment.Name = "btn_Assessment";
            this.btn_Assessment.Size = new System.Drawing.Size(86, 44);
            this.btn_Assessment.TabIndex = 1;
            this.btn_Assessment.Text = "Assessment";
            this.btn_Assessment.UseVisualStyleBackColor = false;
            this.btn_Assessment.Click += new System.EventHandler(this.btn_Assessment_Click);
            // 
            // btn_grading
            // 
            this.btn_grading.BackColor = System.Drawing.Color.Sienna;
            this.btn_grading.Location = new System.Drawing.Point(121, 63);
            this.btn_grading.Name = "btn_grading";
            this.btn_grading.Size = new System.Drawing.Size(86, 44);
            this.btn_grading.TabIndex = 1;
            this.btn_grading.Text = "Grading";
            this.btn_grading.UseVisualStyleBackColor = false;
            // 
            // btn_announcement
            // 
            this.btn_announcement.BackColor = System.Drawing.Color.Sienna;
            this.btn_announcement.Location = new System.Drawing.Point(213, 63);
            this.btn_announcement.Name = "btn_announcement";
            this.btn_announcement.Size = new System.Drawing.Size(109, 44);
            this.btn_announcement.TabIndex = 1;
            this.btn_announcement.Text = "Announcement";
            this.btn_announcement.UseVisualStyleBackColor = false;
            // 
            // btn_attendance
            // 
            this.btn_attendance.BackColor = System.Drawing.Color.Sienna;
            this.btn_attendance.Location = new System.Drawing.Point(328, 63);
            this.btn_attendance.Name = "btn_attendance";
            this.btn_attendance.Size = new System.Drawing.Size(86, 44);
            this.btn_attendance.TabIndex = 1;
            this.btn_attendance.Text = "Attendance";
            this.btn_attendance.UseVisualStyleBackColor = false;
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.Sienna;
            this.btn_submit.Location = new System.Drawing.Point(420, 63);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(86, 44);
            this.btn_submit.TabIndex = 1;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Sienna;
            this.btn_back.Location = new System.Drawing.Point(512, 63);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(86, 44);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            // 
            // lbl_courseAssessment
            // 
            this.lbl_courseAssessment.AutoSize = true;
            this.lbl_courseAssessment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_courseAssessment.Location = new System.Drawing.Point(26, 126);
            this.lbl_courseAssessment.Name = "lbl_courseAssessment";
            this.lbl_courseAssessment.Size = new System.Drawing.Size(136, 16);
            this.lbl_courseAssessment.TabIndex = 0;
            this.lbl_courseAssessment.Text = "Course Assesment";
            // 
            // btn_addRecord
            // 
            this.btn_addRecord.BackColor = System.Drawing.Color.Sienna;
            this.btn_addRecord.Location = new System.Drawing.Point(328, 357);
            this.btn_addRecord.Name = "btn_addRecord";
            this.btn_addRecord.Size = new System.Drawing.Size(116, 39);
            this.btn_addRecord.TabIndex = 1;
            this.btn_addRecord.Text = "Add New Record";
            this.btn_addRecord.UseVisualStyleBackColor = false;
            this.btn_addRecord.Click += new System.EventHandler(this.btn_addRecord_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assessment";
            // 
            // cmb_Assessment
            // 
            this.cmb_Assessment.FormattingEnabled = true;
            this.cmb_Assessment.Items.AddRange(new object[] {
            "Quiz",
            "Assignment",
            "Mid",
            "Final",
            "Presentation"});
            this.cmb_Assessment.Location = new System.Drawing.Point(236, 206);
            this.cmb_Assessment.Name = "cmb_Assessment";
            this.cmb_Assessment.Size = new System.Drawing.Size(121, 21);
            this.cmb_Assessment.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sub Assessment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(428, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Weightage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(91, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Calculation Method";
            // 
            // cmb_calculation
            // 
            this.cmb_calculation.FormattingEnabled = true;
            this.cmb_calculation.Items.AddRange(new object[] {
            "Average",
            "Best of 4",
            "Best of 3",
            "Best of 2"});
            this.cmb_calculation.Location = new System.Drawing.Point(236, 291);
            this.cmb_calculation.Name = "cmb_calculation";
            this.cmb_calculation.Size = new System.Drawing.Size(121, 21);
            this.cmb_calculation.TabIndex = 2;
            // 
            // cb_subAssessment
            // 
            this.cb_subAssessment.AutoSize = true;
            this.cb_subAssessment.Location = new System.Drawing.Point(236, 248);
            this.cb_subAssessment.Name = "cb_subAssessment";
            this.cb_subAssessment.Size = new System.Drawing.Size(44, 17);
            this.cb_subAssessment.TabIndex = 3;
            this.cb_subAssessment.Text = "Yes";
            this.cb_subAssessment.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(428, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Marks";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(540, 230);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(100, 20);
            this.txt_total.TabIndex = 4;
            // 
            // txt_weightage
            // 
            this.txt_weightage.Location = new System.Drawing.Point(540, 262);
            this.txt_weightage.Name = "txt_weightage";
            this.txt_weightage.Size = new System.Drawing.Size(100, 20);
            this.txt_weightage.TabIndex = 4;
            // 
            // AddingAssessmentFormGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.txt_weightage);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.cb_subAssessment);
            this.Controls.Add(this.cmb_calculation);
            this.Controls.Add(this.cmb_Assessment);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.btn_attendance);
            this.Controls.Add(this.btn_announcement);
            this.Controls.Add(this.btn_grading);
            this.Controls.Add(this.btn_addRecord);
            this.Controls.Add(this.btn_Assessment);
            this.Controls.Add(this.lbl_sem);
            this.Controls.Add(this.lbl_course);
            this.Controls.Add(this.lbl_sem_header);
            this.Controls.Add(this.lbl_courseAssessment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_course_header);
            this.Name = "AddingAssessmentFormGUI";
            this.Text = "Adding Assessment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_course_header;
        private System.Windows.Forms.Label lbl_course;
        private System.Windows.Forms.Label lbl_sem;
        private System.Windows.Forms.Label lbl_sem_header;
        private System.Windows.Forms.Button btn_Assessment;
        private System.Windows.Forms.Button btn_grading;
        private System.Windows.Forms.Button btn_announcement;
        private System.Windows.Forms.Button btn_attendance;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_courseAssessment;
        private System.Windows.Forms.Button btn_addRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Assessment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_calculation;
        private System.Windows.Forms.CheckBox cb_subAssessment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.TextBox txt_weightage;
    }
}