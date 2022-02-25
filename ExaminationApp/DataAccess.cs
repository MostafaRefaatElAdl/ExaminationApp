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
        public List<StudentGrades> getStudentGrades()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnVal("ExaminationSystem")))
            {
                return connection.Query<StudentGrades>("dbo.viewStudentsCoursesGrades").ToList();

            }
        }

        // get Exam Dictionary
        //public List<Questions> GetExamQuestions()
        //{
        //    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnVal("ExaminationSystem")))
        //    {
        //        return connection.Query<Questions>("dbo.generateExamQuetions @courseId", new { courseId = 1 }).ToList();
        //    }
        //}

        //public List<Q_Choices> GetExamQuestionsChoices()
        //{
        //    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnVal("ExaminationSystem")))
        //    {
        //        var outPut = connection.Query<Q_Choices>("dbo.generateExamQuetions @courseId", new { courseId = 1 }).ToList();
        //        return outPut;
        //    }
        //}

        public List<Exam> GetExamQuestionsAndChoices()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnVal("ExaminationSystem")))
            {
                var QuesAndChoices = connection.Query<Exam>("dbo.generateExamQuetions @courseId", new { courseId = 1 }).ToList();
                return QuesAndChoices;
            }
        }
    }
}
