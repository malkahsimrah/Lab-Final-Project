namespace Lab_Final_Project.GUI
{
    partial class TeacherCoursesGUI
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "2389-F2022",
            "Software Design ",
            "F2022",
            "InProgress"}, -1, System.Drawing.SystemColors.Window, System.Drawing.Color.Sienna, null);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "481-F2021",
            "Software Construction &v Development",
            "F2021",
            "Copmlete"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "223-F2023",
            "Software Design",
            "F2023",
            "InProgress"}, -1, System.Drawing.SystemColors.Window, System.Drawing.Color.Sienna, null);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "189-F2024",
            "Software Development",
            "F2024",
            "Submit"}, -1);
            this.btn_assesment = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.grading = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btn_assesment
            // 
            this.btn_assesment.BackColor = System.Drawing.Color.Sienna;
            this.btn_assesment.Location = new System.Drawing.Point(51, 30);
            this.btn_assesment.Name = "btn_assesment";
            this.btn_assesment.Size = new System.Drawing.Size(86, 44);
            this.btn_assesment.TabIndex = 8;
            this.btn_assesment.Text = "Assesments";
            this.btn_assesment.UseVisualStyleBackColor = false;
            this.btn_assesment.Click += new System.EventHandler(this.btn_assesment_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Sienna;
            this.button2.Location = new System.Drawing.Point(515, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 44);
            this.button2.TabIndex = 10;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Sienna;
            this.button3.Location = new System.Drawing.Point(424, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 44);
            this.button3.TabIndex = 11;
            this.button3.Text = "Submit";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Sienna;
            this.button4.Location = new System.Drawing.Point(333, 30);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 44);
            this.button4.TabIndex = 12;
            this.button4.Text = "Attendence";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Sienna;
            this.button5.Location = new System.Drawing.Point(241, 30);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 44);
            this.button5.TabIndex = 13;
            this.button5.Text = "Annoucements";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // grading
            // 
            this.grading.BackColor = System.Drawing.Color.Sienna;
            this.grading.Location = new System.Drawing.Point(150, 30);
            this.grading.Name = "grading";
            this.grading.Size = new System.Drawing.Size(86, 44);
            this.grading.TabIndex = 14;
            this.grading.Text = "Grading";
            this.grading.UseVisualStyleBackColor = false;
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.StateImageIndex = 0;
            listViewItem4.StateImageIndex = 0;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.listView1.Location = new System.Drawing.Point(24, 95);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(624, 183);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Course ID";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Course Name";
            this.columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Semester";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Status";
            this.columnHeader4.Width = 150;
            // 
            // TeacherCoursesGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 376);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.grading);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_assesment);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TeacherCoursesGUI";
            this.Text = "TeacherCourses";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_assesment;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button grading;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}