namespace Lab_Final_Project
{
    partial class Form1
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
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_ass = new System.Windows.Forms.Button();
            this.btn_Res = new System.Windows.Forms.Button();
            this.transcript = new System.Windows.Forms.Button();
            this.teachercourses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(56, 78);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(250, 35);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Adding Assessment Form";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_ass
            // 
            this.btn_ass.Location = new System.Drawing.Point(366, 78);
            this.btn_ass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_ass.Name = "btn_ass";
            this.btn_ass.Size = new System.Drawing.Size(192, 35);
            this.btn_ass.TabIndex = 0;
            this.btn_ass.Text = "Assessment Form";
            this.btn_ass.UseVisualStyleBackColor = true;
            this.btn_ass.Click += new System.EventHandler(this.btn_ass_Click);
            // 
            // btn_Res
            // 
            this.btn_Res.Location = new System.Drawing.Point(610, 78);
            this.btn_Res.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Res.Name = "btn_Res";
            this.btn_Res.Size = new System.Drawing.Size(192, 35);
            this.btn_Res.TabIndex = 0;
            this.btn_Res.Text = "Result Form";
            this.btn_Res.UseVisualStyleBackColor = true;
            this.btn_Res.Click += new System.EventHandler(this.btn_Res_Click);
            // 
            // transcript
            // 
            this.transcript.Location = new System.Drawing.Point(840, 78);
            this.transcript.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.transcript.Name = "transcript";
            this.transcript.Size = new System.Drawing.Size(192, 35);
            this.transcript.TabIndex = 1;
            this.transcript.Text = "Student transcript";
            this.transcript.UseVisualStyleBackColor = true;
            this.transcript.Click += new System.EventHandler(this.transcript_Click);
            // 
            // teachercourses
            // 
            this.teachercourses.Location = new System.Drawing.Point(73, 146);
            this.teachercourses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.teachercourses.Name = "teachercourses";
            this.teachercourses.Size = new System.Drawing.Size(192, 35);
            this.teachercourses.TabIndex = 2;
            this.teachercourses.Text = "Adding Teacher Courses";
            this.teachercourses.UseVisualStyleBackColor = true;
            this.teachercourses.Click += new System.EventHandler(this.teachercourses_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.teachercourses);
            this.Controls.Add(this.transcript);
            this.Controls.Add(this.btn_Res);
            this.Controls.Add(this.btn_ass);
            this.Controls.Add(this.btn_add);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_ass;
        private System.Windows.Forms.Button btn_Res;
        private System.Windows.Forms.Button transcript;
        private System.Windows.Forms.Button teachercourses;
    }
}

