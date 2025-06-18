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
    public partial class AddingAssessmentFormGUI : Form
    {
        public AddingAssessmentFormGUI()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            ResultFormGUI resultFormGUI = new ResultFormGUI();
            resultFormGUI.Show();
        }

        private void btn_addRecord_Click(object sender, EventArgs e)
        {

        }

        private void btn_Assessment_Click(object sender, EventArgs e)
        {
            AssessmentFormGUI assessmentFormGUI = new AssessmentFormGUI();
            assessmentFormGUI.Show();
        }
    }
}
