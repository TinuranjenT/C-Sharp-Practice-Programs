using System;
using System.Data.SqlClient;

namespace Student_details_Project
{
    public class DbConnection
    {
        public string connectionString = "Server=(LocalDB)\\MSSQLLocalDB;Database=Student;Trusted_Connection=true;";
        public SqlConnection sqlConnection;

        public void ExecuteQuery(string sql)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                using (var sqlCommand = new SqlCommand(sql))
                {
                    sqlCommand.Connection = connection;
                    sqlCommand.CommandType = System.Data.CommandType.Text;
                    sqlCommand.CommandText = sql;
                    sqlCommand.ExecuteNonQuery();
                }
                //connection.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

    }
}
