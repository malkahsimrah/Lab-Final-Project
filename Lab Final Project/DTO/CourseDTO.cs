using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Final_Project.DTO
{
        public class CourseDTO
        {
            public string CourseID { get; set; }
            public string CourseName { get; set; }
            public int CreditHours { get; set; }
            public string CourseType { get; set; }  // Theory or Lab
            public string Department { get; set; }

            public CourseDTO()
            {
            }

            public CourseDTO(string courseID, string title, int creditHours, string type, string department)
            {
                CourseID = courseID;
                CourseName = title;
                CreditHours = creditHours;
                CourseType = type;
                Department = department;
            }

            // Optional override to show course in ComboBox
            public override string ToString()
            {
                return $"{CourseID} - {CourseName}";
            }
        }
}
