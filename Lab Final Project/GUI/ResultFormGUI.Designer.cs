namespace Lab_Final_Project.GUI
{
    partial class ResultFormGUI
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
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "F2022065001",
            "Ahmad",
            "A"}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "F2022065002",
            "Ammara",
            "A+"}, -1);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "3",
            "F2022065003",
            "Alyana",
            "B"}, -1);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "4",
            "F2022065004",
            "Furqan",
            "C-"}, -1);
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Sr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StdName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Grade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_submitResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(239, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Complete Result";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Sr,
            this.ID,
            this.StdName,
            this.Grade});
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8});
            this.listView1.Location = new System.Drawing.Point(118, 77);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(473, 308);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Sr
            // 
            this.Sr.Text = "Sr. No";
            // 
            // ID
            // 
            this.ID.Text = "Student ID";
            this.ID.Width = 150;
            // 
            // StdName
            // 
            this.StdName.Text = "Student Name";
            this.StdName.Width = 160;
            // 
            // Grade
            // 
            this.Grade.Text = "Grade";
            this.Grade.Width = 100;
            // 
            // btn_submitResult
            // 
            this.btn_submitResult.BackColor = System.Drawing.Color.Sienna;
            this.btn_submitResult.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_submitResult.Location = new System.Drawing.Point(302, 391);
            this.btn_submitResult.Name = "btn_submitResult";
            this.btn_submitResult.Size = new System.Drawing.Size(124, 47);
            this.btn_submitResult.TabIndex = 2;
            this.btn_submitResult.Text = "Submit Result";
            this.btn_submitResult.UseVisualStyleBackColor = false;
            this.btn_submitResult.Click += new System.EventHandler(this.btn_submitResult_Click);
            // 
            // ResultFormGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_submitResult);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Name = "ResultFormGUI";
            this.Text = "ResultFormGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Sr;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader StdName;
        private System.Windows.Forms.ColumnHeader Grade;
        private System.Windows.Forms.Button btn_submitResult;
    }
}