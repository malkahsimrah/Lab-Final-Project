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
    public partial class AssessmentFormGUI : Form
    {
        private AssessmentBL assessmentBL;

        public AssessmentFormGUI()
        {
            InitializeComponent();
            assessmentBL = new AssessmentBL();
        }

        private void AssessmentFormGUI_Load(object sender, EventArgs e)
        {
            LoadCoursesIntoComboBox();
            cmb_courses.SelectedIndexChanged += cmb_courses_SelectedIndexChanged;
        }

        private void LoadCoursesIntoComboBox()
        {
            var courses = assessmentBL.GetAllCourses();  // List<CourseDTO>
            cmb_courses.DataSource = courses;
            cmb_courses.DisplayMember = "CourseName";
            cmb_courses.ValueMember = "CourseID";
        }

        private void cmb_courses_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCourseId = cmb_courses.SelectedValue?.ToString();
            if (!string.IsNullOrWhiteSpace(selectedCourseId))
            {
                LoadAssessmentData(selectedCourseId);
            }
        }

        private void LoadAssessmentData(string courseId)
        {
            var assessments = assessmentBL.GetAssessmentsByCourse(courseId);
            dgv_assessment.DataSource = assessments;
        }

        private void btn_addRecord_Click(object sender, EventArgs e)
        {
            string selectedCourseId = cmb_courses.SelectedValue?.ToString();
            if (!string.IsNullOrWhiteSpace(selectedCourseId))
            {
                using (AddingAssessmentFormGUI addForm = new AddingAssessmentFormGUI(selectedCourseId))
                {
                    if (addForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadAssessmentData(selectedCourseId); // Reload data after successful addition
                    }
                }
            }
        }


        private void btn_grading_Click(object sender, EventArgs e)
        {

        }

        private void AssessmentFormGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                    "Are you sure you want to close this form?",
                    "Confirm Exit",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
);

            if (result == DialogResult.Yes)
            {
                this.Owner.Show();  // Show the login form
            }
            else
            {
                e.Cancel = true;  // Cancel the close
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dgv_assessment.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dgv_assessment.SelectedRows[0];
                try
                {
                    AssessmentDTO updated = new AssessmentDTO
                    {
                        AssessmentID = Convert.ToInt32(row.Cells["AssessmentID"].Value),
                        CourseID = cmb_courses.SelectedValue.ToString(),
                        Semester = row.Cells["Semester"].Value?.ToString(),
                        AssessmentType = row.Cells["AssessmentType"].Value?.ToString(),
                        HasSubAssessment = Convert.ToBoolean(row.Cells["HasSubAssessment"].Value),
                        CalculationMethod = row.Cells["CalculationMethod"].Value?.ToString(),
                        TotalMarks = Convert.ToInt32(row.Cells["TotalMarks"].Value),
                        Weightage = float.Parse(row.Cells["Weightage"].Value.ToString())
                    };

                    if (assessmentBL.UpdateAssessment(updated))
                    {
                        MessageBox.Show("Assessment updated successfully.");
                        LoadAssessmentData(updated.CourseID);
                    }
                    else
                    {
                        MessageBox.Show("Failed to update assessment.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select one row to edit.");
            }
        }


        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgv_assessment.SelectedRows.Count == 1)
            {
                var result = MessageBox.Show("Are you sure you want to delete this assessment?",
                                             "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgv_assessment.SelectedRows[0].Cells["AssessmentID"].Value);
                    if (assessmentBL.DeleteAssessment(id))
                    {
                        MessageBox.Show("Assessment deleted successfully.");
                        LoadAssessmentData(cmb_courses.SelectedValue.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete assessment.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

    }
}

