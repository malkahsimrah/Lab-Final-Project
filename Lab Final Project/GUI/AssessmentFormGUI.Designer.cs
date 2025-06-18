namespace Lab_Final_Project.GUI
{
    partial class AssessmentFormGUI
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
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "Yes",
            "Mid Term",
            "",
            "",
            "25",
            "25"}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "Yes",
            "Quiz"}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "Yes",
            "Final"}, -1);
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_attendance = new System.Windows.Forms.Button();
            this.btn_announcement = new System.Windows.Forms.Button();
            this.btn_grading = new System.Windows.Forms.Button();
            this.btn_assessment = new System.Windows.Forms.Button();
            this.lbl_sem = new System.Windows.Forms.Label();
            this.lbl_course = new System.Windows.Forms.Label();
            this.lbl_sem_header = new System.Windows.Forms.Label();
            this.lbl_courseAssessment = new System.Windows.Forms.Label();
            this.lbl_course_header = new System.Windows.Forms.Label();
            this.lv_courseAssessment = new System.Windows.Forms.ListView();
            this.Edit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Delete = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Assessment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SubAssessment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CalculationMethod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalMarks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Weightage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Calculate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Details = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_addRecord = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Sienna;
            this.btn_back.Location = new System.Drawing.Point(508, 59);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(86, 44);
            this.btn_back.TabIndex = 7;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.Sienna;
            this.btn_submit.Location = new System.Drawing.Point(416, 59);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(86, 44);
            this.btn_submit.TabIndex = 8;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_attendance
            // 
            this.btn_attendance.BackColor = System.Drawing.Color.Sienna;
            this.btn_attendance.Location = new System.Drawing.Point(324, 59);
            this.btn_attendance.Name = "btn_attendance";
            this.btn_attendance.Size = new System.Drawing.Size(86, 44);
            this.btn_attendance.TabIndex = 9;
            this.btn_attendance.Text = "Attendance";
            this.btn_attendance.UseVisualStyleBackColor = false;
            // 
            // btn_announcement
            // 
            this.btn_announcement.BackColor = System.Drawing.Color.Sienna;
            this.btn_announcement.Location = new System.Drawing.Point(209, 59);
            this.btn_announcement.Name = "btn_announcement";
            this.btn_announcement.Size = new System.Drawing.Size(109, 44);
            this.btn_announcement.TabIndex = 10;
            this.btn_announcement.Text = "Announcement";
            this.btn_announcement.UseVisualStyleBackColor = false;
            // 
            // btn_grading
            // 
            this.btn_grading.BackColor = System.Drawing.Color.Sienna;
            this.btn_grading.Location = new System.Drawing.Point(117, 59);
            this.btn_grading.Name = "btn_grading";
            this.btn_grading.Size = new System.Drawing.Size(86, 44);
            this.btn_grading.TabIndex = 11;
            this.btn_grading.Text = "Grading";
            this.btn_grading.UseVisualStyleBackColor = false;
            // 
            // btn_assessment
            // 
            this.btn_assessment.BackColor = System.Drawing.Color.Sienna;
            this.btn_assessment.Location = new System.Drawing.Point(25, 59);
            this.btn_assessment.Name = "btn_assessment";
            this.btn_assessment.Size = new System.Drawing.Size(86, 44);
            this.btn_assessment.TabIndex = 12;
            this.btn_assessment.Text = "Assessment";
            this.btn_assessment.UseVisualStyleBackColor = false;
            // 
            // lbl_sem
            // 
            this.lbl_sem.AutoSize = true;
            this.lbl_sem.Location = new System.Drawing.Point(469, 22);
            this.lbl_sem.Name = "lbl_sem";
            this.lbl_sem.Size = new System.Drawing.Size(38, 13);
            this.lbl_sem.TabIndex = 2;
            this.lbl_sem.Text = "S2025";
            // 
            // lbl_course
            // 
            this.lbl_course.AutoSize = true;
            this.lbl_course.Location = new System.Drawing.Point(98, 23);
            this.lbl_course.Name = "lbl_course";
            this.lbl_course.Size = new System.Drawing.Size(137, 13);
            this.lbl_course.TabIndex = 3;
            this.lbl_course.Text = "418-SE3118-F2022065-W1";
            // 
            // lbl_sem_header
            // 
            this.lbl_sem_header.AutoSize = true;
            this.lbl_sem_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sem_header.Location = new System.Drawing.Point(375, 20);
            this.lbl_sem_header.Name = "lbl_sem_header";
            this.lbl_sem_header.Size = new System.Drawing.Size(73, 16);
            this.lbl_sem_header.TabIndex = 4;
            this.lbl_sem_header.Text = "Semester";
            // 
            // lbl_courseAssessment
            // 
            this.lbl_courseAssessment.AutoSize = true;
            this.lbl_courseAssessment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_courseAssessment.Location = new System.Drawing.Point(22, 122);
            this.lbl_courseAssessment.Name = "lbl_courseAssessment";
            this.lbl_courseAssessment.Size = new System.Drawing.Size(136, 16);
            this.lbl_courseAssessment.TabIndex = 5;
            this.lbl_courseAssessment.Text = "Course Assesment";
            // 
            // lbl_course_header
            // 
            this.lbl_course_header.AutoSize = true;
            this.lbl_course_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_course_header.Location = new System.Drawing.Point(22, 20);
            this.lbl_course_header.Name = "lbl_course_header";
            this.lbl_course_header.Size = new System.Drawing.Size(56, 16);
            this.lbl_course_header.TabIndex = 6;
            this.lbl_course_header.Text = "Course";
            // 
            // lv_courseAssessment
            // 
            this.lv_courseAssessment.CheckBoxes = true;
            this.lv_courseAssessment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Edit,
            this.Delete,
            this.Assessment,
            this.SubAssessment,
            this.CalculationMethod,
            this.TotalMarks,
            this.Weightage,
            this.Calculate,
            this.Details});
            this.lv_courseAssessment.FullRowSelect = true;
            this.lv_courseAssessment.GridLines = true;
            this.lv_courseAssessment.HideSelection = false;
            listViewItem4.StateImageIndex = 0;
            listViewItem5.StateImageIndex = 0;
            listViewItem6.StateImageIndex = 0;
            this.lv_courseAssessment.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.lv_courseAssessment.Location = new System.Drawing.Point(25, 186);
            this.lv_courseAssessment.Name = "lv_courseAssessment";
            this.lv_courseAssessment.Size = new System.Drawing.Size(708, 170);
            this.lv_courseAssessment.TabIndex = 13;
            this.lv_courseAssessment.UseCompatibleStateImageBehavior = false;
            this.lv_courseAssessment.View = System.Windows.Forms.View.Details;
            // 
            // Edit
            // 
            this.Edit.Text = "Edit";
            this.Edit.Width = 38;
            // 
            // Delete
            // 
            this.Delete.Text = "Delete";
            this.Delete.Width = 51;
            // 
            // Assessment
            // 
            this.Assessment.Text = "Assessment";
            this.Assessment.Width = 76;
            // 
            // SubAssessment
            // 
            this.SubAssessment.Text = "Sub Assessment";
            this.SubAssessment.Width = 95;
            // 
            // CalculationMethod
            // 
            this.CalculationMethod.Text = "Calculation Method";
            this.CalculationMethod.Width = 115;
            // 
            // TotalMarks
            // 
            this.TotalMarks.Text = "Total Marks";
            this.TotalMarks.Width = 72;
            // 
            // Weightage
            // 
            this.Weightage.Text = "Weightage";
            this.Weightage.Width = 80;
            // 
            // Calculate
            // 
            this.Calculate.Text = "Calculate";
            this.Calculate.Width = 86;
            // 
            // Details
            // 
            this.Details.Text = "Details";
            this.Details.Width = 77;
            // 
            // btn_addRecord
            // 
            this.btn_addRecord.BackColor = System.Drawing.Color.Sienna;
            this.btn_addRecord.Location = new System.Drawing.Point(25, 141);
            this.btn_addRecord.Name = "btn_addRecord";
            this.btn_addRecord.Size = new System.Drawing.Size(116, 39);
            this.btn_addRecord.TabIndex = 14;
            this.btn_addRecord.Text = "Add New Record";
            this.btn_addRecord.UseVisualStyleBackColor = false;
            this.btn_addRecord.Click += new System.EventHandler(this.btn_addRecord_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(491, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total 25";
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.Sienna;
            this.btn_edit.Location = new System.Drawing.Point(147, 141);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(88, 39);
            this.btn_edit.TabIndex = 14;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Sienna;
            this.btn_delete.Location = new System.Drawing.Point(241, 141);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(70, 39);
            this.btn_delete.TabIndex = 14;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // AssessmentFormGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_addRecord);
            this.Controls.Add(this.lv_courseAssessment);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.btn_attendance);
            this.Controls.Add(this.btn_announcement);
            this.Controls.Add(this.btn_grading);
            this.Controls.Add(this.btn_assessment);
            this.Controls.Add(this.lbl_sem);
            this.Controls.Add(this.lbl_course);
            this.Controls.Add(this.lbl_sem_header);
            this.Controls.Add(this.lbl_courseAssessment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_course_header);
            this.Name = "AssessmentFormGUI";
            this.Text = "AssessmentFormGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_attendance;
        private System.Windows.Forms.Button btn_announcement;
        private System.Windows.Forms.Button btn_grading;
        private System.Windows.Forms.Button btn_assessment;
        private System.Windows.Forms.Label lbl_sem;
        private System.Windows.Forms.Label lbl_course;
        private System.Windows.Forms.Label lbl_sem_header;
        private System.Windows.Forms.Label lbl_courseAssessment;
        private System.Windows.Forms.Label lbl_course_header;
        private System.Windows.Forms.ListView lv_courseAssessment;
        private System.Windows.Forms.ColumnHeader Edit;
        private System.Windows.Forms.ColumnHeader Delete;
        private System.Windows.Forms.ColumnHeader Assessment;
        private System.Windows.Forms.ColumnHeader SubAssessment;
        private System.Windows.Forms.ColumnHeader CalculationMethod;
        private System.Windows.Forms.ColumnHeader TotalMarks;
        private System.Windows.Forms.ColumnHeader Weightage;
        private System.Windows.Forms.ColumnHeader Calculate;
        private System.Windows.Forms.ColumnHeader Details;
        private System.Windows.Forms.Button btn_addRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
    }
}