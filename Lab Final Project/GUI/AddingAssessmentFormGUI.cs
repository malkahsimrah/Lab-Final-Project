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
    public partial class AddingAssessmentFormGUI : Form
    {
        private readonly string courseId;

        public AssessmentFormGUI AssessmentFormGUI { get; }

        public AddingAssessmentFormGUI(string courseId)
        {
            InitializeComponent();
            this.courseId = courseId;
        }

        private void AddingAssessmentFormGUI_Load(object sender, EventArgs e)
        {
            lbl_course.Text = courseId;
            lbl_sem.Text = GetCurrentSemester(); // or fetch it from DB if dynamic
        }

        private string GetCurrentSemester()
        {
            // Replace this with actual semester logic if needed
            return "S2025";
        }

        private void btn_addRecord_Click(object sender, EventArgs e)
        {
            try
            {
                //if (cmb_Assessment.SelectedIndex == -1 || cmb_calculation.SelectedIndex == -1)
                //{
                //    MessageBox.Show("Please select assessment type and calculation method.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}

                string assessmentType = cmb_Assessment.SelectedItem.ToString();
                string calculationMethod = cmb_calculation.SelectedItem.ToString();
                bool hasSubAssessment = cb_subAssessment.Checked;

                if (!int.TryParse(txt_total.Text.Trim(), out int totalMarks))
                {
                    MessageBox.Show("Enter a valid number for total marks.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!float.TryParse(txt_weightage.Text.Trim(), out float weightage))
                {
                    MessageBox.Show("Enter a valid number for weightage.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                AssessmentDTO assessment = new AssessmentDTO
                {
                    CourseID = courseId,
                    Semester = lbl_sem.Text.Trim(),
                    AssessmentType = assessmentType,
                    HasSubAssessment = hasSubAssessment,
                    CalculationMethod = calculationMethod,
                    TotalMarks = totalMarks,
                    Weightage = weightage
                };

                AssessmentBL bl = new AssessmentBL();
                bool isAdded = bl.AddAssessment(assessment);

                if (isAdded)
                {
                    MessageBox.Show("Assessment added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to add assessment.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            // Optional: trigger the same logic
            //btn_addRecord_Click_1(sender, e);
        }

        private void btn_Assessment_Click(object sender, EventArgs e)
        {
            // Optional navigation logic
        }

        private void ClearFormFields()
        {
            cmb_Assessment.SelectedIndex = -1;
            cmb_calculation.SelectedIndex = -1;
            cb_subAssessment.Checked = false;
            txt_total.Clear();
            txt_weightage.Clear();
        }

        private void AddingAssessmentFormGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to close this form?",
                "Confirm Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

    }
}
