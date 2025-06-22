using Lab_Final_Project.BL;
using Lab_Final_Project.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Final_Project.GUI
{
    public partial class LoginGUI : Form
    {
        loginDTO loginDTO;
        loginBL loginBL;
        public LoginGUI()
        {
            InitializeComponent();
            loginDTO = new loginDTO();
            loginBL = new loginBL();
        }

        public loginDTO LoginDTO { get => loginDTO; set => loginDTO = value; }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text.Trim();
            string password = txt_password.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and Password cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            loginDTO = new loginDTO(username, password);
            loginBL.VerifyUser(loginDTO).Show(this);

            this.Hide();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();
            txt_username.Focus();

        }
    }
}
