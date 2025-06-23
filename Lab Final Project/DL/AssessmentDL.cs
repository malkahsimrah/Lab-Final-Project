using Lab_Final_Project.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab_Final_Project.DL
{
    public class AssessmentDL
    {
        private DBConnection myConnection = new DBConnection();

        public List<CourseDTO> GetAllCoursesFromDB()
        {
            List<CourseDTO> courses = new List<CourseDTO>();
            string query = "SELECT CourseID, cName FROM Course WHERE CourseID IS NOT NULL";

            try
            {
                SqlCommand cmd = new SqlCommand(query, myConnection.SqlCon);
                myConnection.SqlCon.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    courses.Add(new CourseDTO
                    {
                        CourseID = reader["CourseID"].ToString(),
                        CourseName = reader["cName"].ToString()
                    });
                }

                return courses;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading courses: " + ex.Message);
                return new List<CourseDTO>();
            }
            finally
            {
                myConnection.SqlCon.Close();
            }
        }

        public List<AssessmentDTO> GetAssessmentsFromDB(string courseId)
        {
            List<AssessmentDTO> assessments = new List<AssessmentDTO>();
            string query = @"SELECT AssessmentID, CourseID, Semester, AssessmentType, HasSubAssessment, 
                                    CalculationMethod, TotalMarks, Weightage
                             FROM Assessment 
                             WHERE CourseID = @CourseID";

            try
            {
                SqlCommand cmd = new SqlCommand(query, myConnection.SqlCon);
                cmd.Parameters.AddWithValue("@CourseID", courseId);
                myConnection.SqlCon.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    assessments.Add(new AssessmentDTO
                    {
                        AssessmentID = Convert.ToInt32(reader["AssessmentID"]),
                        CourseID = reader["CourseID"].ToString(),
                        Semester = reader["Semester"].ToString(),
                        AssessmentType = reader["AssessmentType"].ToString(),
                        HasSubAssessment = Convert.ToBoolean(reader["HasSubAssessment"]),
                        CalculationMethod = reader["CalculationMethod"] == DBNull.Value ? null : reader["CalculationMethod"].ToString(),
                        TotalMarks = Convert.ToInt32(reader["TotalMarks"]),
                        Weightage = Convert.ToSingle(reader["Weightage"])
                    });
                }

                return assessments;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading assessments: " + ex.Message);
                return new List<AssessmentDTO>();
            }
            finally
            {
                myConnection.SqlCon.Close();
            }
        }

        public bool AddAssessmentToDB(AssessmentDTO assessment)
        {
            try
            {
                string query = @"INSERT INTO Assessment 
                                 (CourseID, Semester, AssessmentType, HasSubAssessment, CalculationMethod, TotalMarks, Weightage) 
                                 OUTPUT INSERTED.AssessmentID
                                 VALUES 
                                 (@CourseID, @Semester, @AssessmentType, @HasSubAssessment, @CalculationMethod, @TotalMarks, @Weightage)";

                SqlCommand cmd = new SqlCommand(query, myConnection.SqlCon);
                cmd.Parameters.AddWithValue("@CourseID", assessment.CourseID);
                cmd.Parameters.AddWithValue("@Semester", assessment.Semester);
                cmd.Parameters.AddWithValue("@AssessmentType", assessment.AssessmentType);
                cmd.Parameters.AddWithValue("@HasSubAssessment", assessment.HasSubAssessment);
                cmd.Parameters.AddWithValue("@CalculationMethod", (object)assessment.CalculationMethod ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@TotalMarks", assessment.TotalMarks);
                cmd.Parameters.AddWithValue("@Weightage", assessment.Weightage);

                myConnection.SqlCon.Open();
                assessment.AssessmentID = (int)cmd.ExecuteScalar();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding assessment: " + ex.Message);
                return false;
            }
            finally
            {
                myConnection.SqlCon.Close();
            }
        }

        public bool UpdateAssessment(AssessmentDTO assessment)
        {
            try
            {
                string query = @"UPDATE Assessment
                                 SET AssessmentType = @Type,
                                     HasSubAssessment = @HasSub,
                                     CalculationMethod = @Method,
                                     TotalMarks = @Marks,
                                     Weightage = @Weightage
                                 WHERE AssessmentID = @ID";

                SqlCommand cmd = new SqlCommand(query, myConnection.SqlCon);
                cmd.Parameters.AddWithValue("@Type", assessment.AssessmentType);
                cmd.Parameters.AddWithValue("@HasSub", assessment.HasSubAssessment);
                cmd.Parameters.AddWithValue("@Method", (object)assessment.CalculationMethod ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Marks", assessment.TotalMarks);
                cmd.Parameters.AddWithValue("@Weightage", assessment.Weightage);
                cmd.Parameters.AddWithValue("@ID", assessment.AssessmentID);

                myConnection.SqlCon.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating assessment: " + ex.Message);
                return false;
            }
            finally
            {
                myConnection.SqlCon.Close();
            }
        }

        public bool DeleteAssessment(int assessmentID)
        {
            try
            {
                string query = "DELETE FROM Assessment WHERE AssessmentID = @ID";
                SqlCommand cmd = new SqlCommand(query, myConnection.SqlCon);
                cmd.Parameters.AddWithValue("@ID", assessmentID);

                myConnection.SqlCon.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting assessment: " + ex.Message);
                return false;
            }
            finally
            {
                myConnection.SqlCon.Close();
            }
        }
    }
}
