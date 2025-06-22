using Lab_Final_Project.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Final_Project
{
    public partial class StudentTranscriptGUI : Form
    {
        private LoginGUI loginGUI; // Declare an instance of LoginGUI

        public StudentTranscriptGUI()
        {
            InitializeComponent();
            loginGUI = new LoginGUI(); // Initialize the LoginGUI instance
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void StudentTranscriptGUI_Load(object sender, EventArgs e)
        {

        }

        private void StudentTranscriptGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to close this form?",
                "Confirm Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                loginGUI.Show();  // Show the login form
            }
            else
            {
                e.Cancel = true;  // Cancel the close
            }
        }

    }
}
