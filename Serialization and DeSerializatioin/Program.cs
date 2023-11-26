using System;
using System.Text.Json;


namespace SerializationandDeSerialization
{ 
    class Student
    {
        public string name { get; set; }
        public int rollno {  get; set; }
        public string place {  get; set; }
    }
    class Program
    {
       static void Main(string[] args)
        {
            Student s1= new Student();
            s1.name = "Tinu";
            s1.rollno = 72;
            s1.place = "Thirumangalam";

            string jsonString = JsonSerializer.Serialize(s1);
            Console.WriteLine("JSON Format");
            Console.WriteLine(jsonString);

            Console.WriteLine("Deserialization");
            Student deserializedString = JsonSerializer.Deserialize<Student>(jsonString);
            Console.WriteLine($"Name: {deserializedString.name}");
            Console.WriteLine($"Roll No: {deserializedString.rollno}");
            Console.WriteLine($"Place: {deserializedString.place}");


        }

    }
   
}
