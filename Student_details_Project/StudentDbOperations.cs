using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_details_Project
{
    public class StudentDbOperations
    {
        public void AddStudent(Student student)
        {
            DbConnection dbConnection = new DbConnection();
            string sqlQuery = $"Insert into [dbo].[Students] ([Name], [Department]) values ('{student.Name}', '{student.Department}')";
            dbConnection.ExecuteQuery(sqlQuery);
        }

        public void UpdateStudent(Student student)
        {
            DbConnection dbConnection = new DbConnection();
            string sqlQuery = $"Update [dbo].[Students] set [Name] = {student.Name}, [Department] = {student.Department} where [Id] = {student.Id}";
            dbConnection.ExecuteQuery(sqlQuery);
        }
    }
}
