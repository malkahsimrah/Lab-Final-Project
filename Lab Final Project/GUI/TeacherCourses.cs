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
    public partial class TeacherCourses : Form
    {
        public TeacherCourses()
        {
            InitializeComponent();
        }

        private void btn_assesment_Click(object sender, EventArgs e)
        {
            AssessmentFormGUI assessmentFormGUI = new AssessmentFormGUI();
            assessmentFormGUI.Show();
        }
    }
}
