using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http.Json;
using Student_details_Project;
using System.Data.SqlClient;

public class Program
{
    private static void Main(string[] args)
    {
        Student[] students = StudentDataSeeds.GetData();

        foreach (Student student in students)
        {
            Console.WriteLine(student.Name);
            Console.WriteLine(student.Department);

            StudentDbOperations studentDbOperations = new StudentDbOperations();
            studentDbOperations.AddStudent(student);


            Console.WriteLine("Inserted to DB");
        }

    }

}