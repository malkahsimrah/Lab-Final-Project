using Lab_Final_Project.DL;
using Lab_Final_Project.DTO;
using System.Collections.Generic;

namespace Lab_Final_Project.BL
{
    public class AssessmentBL
    {
        private AssessmentDL assessmentDL = new AssessmentDL();

        public List<CourseDTO> GetAllCourses()
        {
            return assessmentDL.GetAllCoursesFromDB();
        }

        public List<AssessmentDTO> GetAssessmentsByCourse(string courseId)
        {
            return assessmentDL.GetAssessmentsFromDB(courseId);
        }

        public bool AddAssessment(AssessmentDTO assessment)
        {
            return assessmentDL.AddAssessmentToDB(assessment);
        }

        public bool UpdateAssessment(AssessmentDTO updatedAssessment)
        {
            return assessmentDL.UpdateAssessment(updatedAssessment);
        }

        public bool DeleteAssessment(int assessmentID)
        {
            return assessmentDL.DeleteAssessment(assessmentID);
        }
    }
}
