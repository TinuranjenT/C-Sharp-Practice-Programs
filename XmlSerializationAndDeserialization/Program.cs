using System.Xml.Serialization;

namespace XmlSerializationAndDeserialization
{
    public class Program
    { 
        static void Main(string[] args)
        {
            
            Student student = new Student();
            student.Id = 1;
            student.Name = "John";
            student.Department = "CSE";
            

            string filePath = @"C:\\Users\\tinu\\Documents\\Student.XML";

            Student.ToXML(student, filePath);
            Console.WriteLine("Serialization Completed");

            Student deserializedStudent = Student.XMLToObject(filePath);
            Console.WriteLine($"Deserialized Student: Id: {deserializedStudent.Id}, " +
                $"Name: {deserializedStudent.Name}, " +
                $"Department: {deserializedStudent.Department}");

        }
    }
}