using System;
using System.Globalization;

namespace Static;

class Student
{
    public string name;           //non-static data members
    public int rollno;
    public static string CollegeName;  //static data members
    public static string Department;

    //public void SetStudent(String name, int rollno)
    //{
    //    this.name = name;
    //    this.rollno = rollno;
    //}

    public Student(string name, int rollno)       //constructor
    {
        this.name = name;
        this.rollno = rollno;
    }
    static Student()         //static constructor
    {
        Department = "ECE";
        CollegeName = "National Engineering College";
    }
    //public static void DisplayStudentDetails()         //static method
    //{
    //    Console.WriteLine(Department + " " + CollegeName);
    //}


    public void DisplayStudentDetails()
    {
        Console.WriteLine("Name:" + name + ", Roll no:" + rollno + ", Department:" + Department + ", CollegeName:" + CollegeName);
    }

}

class Information
{
    static void Main(string[] args)
    {
        //Student s1 = new Student(); 
        //s1.SetStudent("Rajesh", 21);
        Student s1 = new("Rajesh", 21);
        s1.DisplayStudentDetails();                            //access non-static method using object

        Student s2 = new("Ram", 23);
        s2.DisplayStudentDetails();
        //Console.WriteLine(Student.CollegeName);

        /* Student.DisplayStudentDetails(); */     //access static method

    }
}
