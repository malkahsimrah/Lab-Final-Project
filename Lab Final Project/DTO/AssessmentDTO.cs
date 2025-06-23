using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Final_Project.DTO
{
    public class AssessmentDTO
    {
        public int AssessmentID { get; set; }  // Optional for insertion
        public string CourseID { get; set; }
        public string Semester { get; set; }
        public string AssessmentType { get; set; }
        public bool HasSubAssessment { get; set; }
        public string CalculationMethod { get; set; }
        public int TotalMarks { get; set; }
        public float Weightage { get; set; }

        public AssessmentDTO()
        {

        }
    }
}

