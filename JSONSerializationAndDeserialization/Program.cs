using Newtonsoft.Json;
using System;
using System.IO;
namespace JSONSerializationAndDeserialization
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student[] students = StudentDataSeeds.GetData();
                
            Console.WriteLine("Serialization");
            string objToJSON = JsonConvert.SerializeObject(students);

            SaveStudentDetails(objToJSON);

            Console.WriteLine("DeSerialization");
            Student[] studentsFromJSON = JsonConvert.DeserializeObject<Student[]>(objToJSON);
            foreach(var student in studentsFromJSON)
            {
                Console.WriteLine("Id:" + student.Id);
                Console.WriteLine("Name:" + student.Name);
                Console.WriteLine("Department:" + student.Department);
            }

        }
        public static void SaveStudentDetails(string objToJSON)
        {
            string filePath = "C:\\MyData\\data.json";
            File.WriteAllText(filePath, objToJSON);
            Console.WriteLine("File has been successfully saved");
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
    }
}
