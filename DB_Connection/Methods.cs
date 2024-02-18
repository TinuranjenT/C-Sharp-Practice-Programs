using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DB_Connection
{
     class Methods
    {
       
        public void CreateTable(SqlConnection conn)
        {
            
            SqlCommand createCmd = new SqlCommand("create table student_Information(id int, name varchar(20), department varchar(20))", conn);
            createCmd.ExecuteNonQuery();
            Console.WriteLine("Table created");
        }
        
        public void InsertDataIntoTable(SqlConnection conn) 
        {

            Console.WriteLine("Enter the Id");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the Department:");
            string department = Console.ReadLine();

            SqlCommand cmd = new SqlCommand("Insert into student_details_1 values(@id,@name, @department)", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@department", department);

            int noOfRows = cmd.ExecuteNonQuery();
            Console.WriteLine(noOfRows + " row inserted");

        }
        public void ReadDataFromTable(SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand("select * from student_details_1", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr[0] + "\t" + dr[1] + "\t" + dr[2] + "\t");
            }
            dr.Close();
        }
        public void UpdateDataIntoTable(SqlConnection conn)
        {
            SqlCommand cmd2 = new SqlCommand("update student_details_1 set name ='Easwar', department = 'Mech' where id = 2", conn);
            int rowUpdated = cmd2.ExecuteNonQuery();
            Console.WriteLine(rowUpdated + " row updated");
        }
        public void DeleteDataFromTable(SqlConnection conn)
        {
            SqlCommand cmd3 = new SqlCommand("delete from student_details_1 where id = 2", conn);
            int rowDeleted = cmd3.ExecuteNonQuery();
            Console.WriteLine(rowDeleted + " row deleted");
        }
    }
}
