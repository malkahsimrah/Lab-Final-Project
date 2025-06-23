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
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_attendance = new System.Windows.Forms.Button();
            this.btn_announcement = new System.Windows.Forms.Button();
            this.btn_grading = new System.Windows.Forms.Button();
            this.btn_assessment = new System.Windows.Forms.Button();
            this.lbl_sem = new System.Windows.Forms.Label();
            this.lbl_sem_header = new System.Windows.Forms.Label();
            this.lbl_courseAssessment = new System.Windows.Forms.Label();
            this.lbl_course_header = new System.Windows.Forms.Label();
            this.btn_addRecord = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.cmb_courses = new System.Windows.Forms.ComboBox();
            this.dgv_assessment = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_assessment)).BeginInit();
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
            this.btn_grading.Click += new System.EventHandler(this.btn_grading_Click);
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
            this.label1.Location = new System.Drawing.Point(565, 521);
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
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
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
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // cmb_courses
            // 
            this.cmb_courses.FormattingEnabled = true;
            this.cmb_courses.Location = new System.Drawing.Point(93, 20);
            this.cmb_courses.Name = "cmb_courses";
            this.cmb_courses.Size = new System.Drawing.Size(200, 21);
            this.cmb_courses.TabIndex = 15;
            // 
            // dgv_assessment
            // 
            this.dgv_assessment.AllowUserToAddRows = false;
            this.dgv_assessment.AllowUserToDeleteRows = false;
            this.dgv_assessment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_assessment.Location = new System.Drawing.Point(25, 186);
            this.dgv_assessment.Name = "dgv_assessment";
            this.dgv_assessment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_assessment.Size = new System.Drawing.Size(876, 318);
            this.dgv_assessment.TabIndex = 16;
            // 
            // AssessmentFormGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 546);
            this.Controls.Add(this.dgv_assessment);
            this.Controls.Add(this.cmb_courses);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_addRecord);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.btn_attendance);
            this.Controls.Add(this.btn_announcement);
            this.Controls.Add(this.btn_grading);
            this.Controls.Add(this.btn_assessment);
            this.Controls.Add(this.lbl_sem);
            this.Controls.Add(this.lbl_sem_header);
            this.Controls.Add(this.lbl_courseAssessment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_course_header);
            this.Name = "AssessmentFormGUI";
            this.Text = "AssessmentFormGUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AssessmentFormGUI_FormClosing);
            this.Load += new System.EventHandler(this.AssessmentFormGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_assessment)).EndInit();
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
        private System.Windows.Forms.Label lbl_sem_header;
        private System.Windows.Forms.Label lbl_courseAssessment;
        private System.Windows.Forms.Label lbl_course_header;
        private System.Windows.Forms.Button btn_addRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ComboBox cmb_courses;
        private System.Windows.Forms.DataGridView dgv_assessment;
    }
}