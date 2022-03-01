using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
namespace ExaminationApp
{
    internal class DataAccess
    {
       public static int UserIdToken;
        public List<Student> getAllStudents()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnVal("ExaminationSystem")))
            {
               return connection.Query<Student>("dbo.selectAllStudents").ToList();
            }
        }

        // get current student
        public Student getStudent()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnVal("ExaminationSystem")))
            {
                Console.WriteLine(UserIdToken);
                Console.WriteLine("===========");
                return connection.QuerySingle<Student>("dbo.selectStudent @nID", new {nId=UserIdToken});
            }
        }

        public List<Instructor> getAllInstructors()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnVal("ExaminationSystem")))
            {
                return connection.Query<Instructor>("dbo.selectAllInstructors").ToList();
            }
        }
        // get current Instructor
        public Instructor getInstructor()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnVal("ExaminationSystem")))
            {
                Console.WriteLine(UserIdToken);
                Console.WriteLine("===========");
                return connection.QuerySingle<Instructor>("dbo.selectInstructor @nID", new { nId = UserIdToken });
            }
        }

        // get Courses Grade
        public List<StudentGrades> getStudentGrades(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnVal("ExaminationSystem")))
            {
                
                return connection.Query<StudentGrades>("dbo.getStudentGrades @stdId", new { stdId = id }).ToList();

            }
        }
        // get Student Courses

        public List<StudentGrades> getStudentCourses()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnVal("ExaminationSystem")))
            {
                return connection.Query<StudentGrades>("dbo.viewStudentsCoursesGrades").ToList();

            }
        }

        // get Student Courses

        public List<Courses> GetCourses()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnVal("ExaminationSystem")))
            {
                return connection.Query<Courses>("dbo.selectAllCourses").ToList();

            }
        }


        public List<Exam> GetExamQuestionsAndChoices(int crs_id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnVal("ExaminationSystem")))
            {
                var QuesAndChoices = connection.Query<Exam>("dbo.GenerateExam @courseId", new { courseId = crs_id }).ToList();
                return QuesAndChoices;
            }
        }



        public void InsertStudentAnswer(string st_ans, int q_id, int st_id, int exam_id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnVal("ExaminationSystem")))
            {
                List<St_Answer> answers = new List<St_Answer>();
                answers.Add(new St_Answer { St_ans = st_ans, Q_id = q_id, St_id = st_id, Exam_id = exam_id });
                connection.Execute("dbo.insertStudentAnswer @St_ans, @Q_id, @St_id, @Exam_id", new { St_ans = st_ans, Q_id = q_id, St_id = st_id, Exam_id = exam_id });
            }
        }

        public void InsertStudentExam(int exam_duration, DateTime start_time, int crs_id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnVal("ExaminationSystem")))
            {
                List<Exam> exams = new List<Exam>();
                exams.Add(new Exam {Exam_Duration = exam_duration, Start_time=start_time, Crs_id= crs_id});
                connection.Execute("dbo.insertExam @ExamDuration, @ExamStartDate ,@courseID ", new { ExamDuration = exam_duration, ExamStartDate = start_time, courseID = crs_id });
            }
        }

        public List<StudentCourses> GetExamGrade(int crs_id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnVal("ExaminationSystem")))
            {
                var QuesAndChoices = connection.Query<StudentCourses>("dbo.ExamCorrection @studentId ,@examId ", new { courseId = crs_id }).ToList();
                return QuesAndChoices;
            }
        }
    }
}
