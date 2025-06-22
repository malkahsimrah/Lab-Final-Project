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
        public AssessmentFormGUI()
        {
            InitializeComponent();
        }

        private void btn_addRecord_Click(object sender, EventArgs e)
        {
            AddingAssessmentFormGUI addingAssessmentForm = new AddingAssessmentFormGUI();
            addingAssessmentForm.Show();
        }


        private void btn_submit_Click(object sender, EventArgs e)
        {
            ResultFormGUI resultFormGUI = new ResultFormGUI();
            resultFormGUI.Show();

        }

        private void btn_assessment_Click(object sender, EventArgs e)
        {
            AssessmentMarkingGUI assessmentMarking = new AssessmentMarkingGUI();
            assessmentMarking.Show();
        }

        private void AssessmentFormGUI_Load(object sender, EventArgs e)
        {

        }

        private void lv_courseAssessment_SelectedIndexChanged(object sender, EventArgs e)
        {
           
         
            ListViewItem selectedItem = lv_courseAssessment.SelectedItems[0];

            // Check if the checkbox is checked (assuming CheckBoxes = true)
            if (selectedItem.Checked)
            {
                AssessmentMarkingGUI assessmentMarking = new AssessmentMarkingGUI();
                assessmentMarking.Show();
            }
        
    }
    }
}
