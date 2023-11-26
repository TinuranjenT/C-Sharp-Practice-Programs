using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using System.Threading.Tasks;
using System.Text.Json;

namespace StudentDetails
{
    class Student
    {
        public string name;
        public string department;
        public long  phoneNo;

        public Student(string name, string department, long phoneno)
        {
            this.name = name;
            this.department = department;
            this.phoneNo = phoneno;
        }
        public async Task<bool> SaveStudentDetails()
        {
            string filePath = $"C:\\MyData\\{name}.txt";
            string[] details = { name, department, phoneNo.ToString() };
            File.WriteAllLines(filePath, details);
            Console.WriteLine($"{name} details has been successfully added");
            return true;
        }
        static void Main(string[] args)
        {
            //Student s1 = new Student("Rahul", "CSE", 9739231943);
            //Task<bool> task1 = s1.SaveStudentDetails();
            //s1.DisplayResult(task1.Result);

            //Student s2 = new Student("Ram", "IT", 9858737536);
            //Task<bool> task2 = s2.SaveStudentDetails();
            //s2.DisplayResult(task2.Result);


            //Student s3 = new Student("Arjun", "ECE", 9345678765);
            //Task<bool> task3 = s3.SaveStudentDetails();
            //s3.DisplayResult(task3.Result);

            //Student s4 = new Student("Balamurugan", "Civi", 7648387528);
            //Task<bool> task4 = s4.SaveStudentDetails();
            //s4.DisplayResult(task4.Result);

            //Student s5 = new Student("Ganapathy", "EEE", 7643686864);
            //Task<bool> task5 = s5.SaveStudentDetails();
            //s5.DisplayResult(task5.Result);

            //Student s6 = new Student("Easwar", "Mech", 7634765456);
            //Task<bool> task6 = s6.SaveStudentDetails();
            //s6.DisplayResult(task6.Result);

            //Student s7 = new Student("Vishal", "ECE", 9473839393);
            //Task<bool> task7 = s7.SaveStudentDetails();
            //s7.DisplayResult(task7.Result);

            //Student s8 = new Student("Mani", "Civil", 9483939303);
            //Task<bool> task8 = s8.SaveStudentDetails();
            //s8.DisplayResult(task8.Result);

            //Student s9 = new Student("Palani", "Mech", 7534565836);
            //Task<bool> task9 = s9.SaveStudentDetails();
            //s9.DisplayResult(task7.Result);

            //Student s10 = new Student("Sakthi", "Civil", 9374839303);
            //Task<bool> task10 = s10.SaveStudentDetails();
            //s10.DisplayResult(task10.Result);

            //Console.WriteLine("All the student details has been added");

            Student[] students = {
                new Student("Rahul", "CSE", 9739231943),
                new Student("Ram", "IT", 9858737536),
                new Student("Arjun", "ECE", 9345678765),
                new Student("Balamurugan", "Civi", 7648387528),
                new Student("Ganapathy", "EEE", 7643686864),
                new Student("Easwar", "Mech", 7634765456),
                new Student("Vishal", "ECE", 9473839393),
                new Student("Mani", "Civil", 9483939303),
                new Student("Palani", "Mech", 7534565836),
                new Student("Sakthi", "Civil", 9374839303)
            };

            foreach (var student in students)
            {
                Task<bool> task = student.SaveStudentDetails();
               
            }
            Console.WriteLine("All the student details have been added");

        }
    }
}