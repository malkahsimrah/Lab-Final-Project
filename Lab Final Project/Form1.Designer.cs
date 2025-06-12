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
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(37, 51);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(167, 23);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Adding Assessment Form";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_ass
            // 
            this.btn_ass.Location = new System.Drawing.Point(244, 51);
            this.btn_ass.Name = "btn_ass";
            this.btn_ass.Size = new System.Drawing.Size(128, 23);
            this.btn_ass.TabIndex = 0;
            this.btn_ass.Text = "Assessment Form";
            this.btn_ass.UseVisualStyleBackColor = true;
            this.btn_ass.Click += new System.EventHandler(this.btn_ass_Click);
            // 
            // btn_Res
            // 
            this.btn_Res.Location = new System.Drawing.Point(407, 51);
            this.btn_Res.Name = "btn_Res";
            this.btn_Res.Size = new System.Drawing.Size(128, 23);
            this.btn_Res.TabIndex = 0;
            this.btn_Res.Text = "Result Form";
            this.btn_Res.UseVisualStyleBackColor = true;
            this.btn_Res.Click += new System.EventHandler(this.btn_Res_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Res);
            this.Controls.Add(this.btn_ass);
            this.Controls.Add(this.btn_add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_ass;
        private System.Windows.Forms.Button btn_Res;
    }
}

