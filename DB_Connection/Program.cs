using System;
using System.IO;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace DB_Connection
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("Data Source = localhost\\sqlexpress; Initial Catalog = sample_db; Integrated Security = True");
            conn.Open();
            Methods m1 = new Methods();
            //m1.CreateTable(conn);
            //m1.InsertDataIntoTable(conn);
            m1.ReadDataFromTable(conn);
            //m1.UpdateDataIntoTable(conn);
            //m1.DeleteDataFromTable(conn);
            conn.Close();
        }
    }
}