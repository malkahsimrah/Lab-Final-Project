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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            var addForm = new AddingAssessmentFormGUI();
            addForm.Owner = this;
            addForm.Show();
        }

        private void btn_ass_Click(object sender, EventArgs e)
        {
            var assForm = new AssessmentFormGUI();
            assForm.Owner = this;
            assForm.Show();
        }

        private void btn_Res_Click(object sender, EventArgs e)
        {
            var resForm = new ResultFormGUI();
            resForm.Owner = this;
            resForm.Show();
        }

        private void teachercourses_Click(object sender, EventArgs e)
        {
            var teachercour = new TeacherCourses();
            teachercour.Owner = this;
            teachercour.Show();

        }

        private void transcript_Click(object sender, EventArgs e)
        {
            var transcript = new StudentTranscript();
            transcript.Owner = this;
            transcript.Show();
        }
    }
}
