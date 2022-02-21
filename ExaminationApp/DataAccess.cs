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
        public List<Student> getAllStudents(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnVal("ExaminationSystem")))
            {
               return connection.Query<Student>("dbo.selectStudent @nID", new {nId=id}).ToList();
            }
        }
    }
}
