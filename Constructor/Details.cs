using System;
namespace Cosntructor;

class Student
{
    string name;
    int rollno;
    int age;

    public Student(string name, int rollno, int age)   //Parameterised Constructor
    {
        this.name = name;
        this.rollno = rollno;
        this.age = age;
    }

    public Student()                                  //default constructor 
    {
        Console.WriteLine("This is default constructor");
    }

    public Student(Student s)                      //copy constructor
    {
        this.name = s.name;
        this.rollno = s.rollno;
        this.age = s.age;

    }

    public void Display()
    {
        Console.WriteLine(name + " " + rollno + " " + age);

    }
}

class Details {
    static void Main(string[] args)
    {
        Student s1 = new("Ram", 72, 21);
        //Student s4 = new("Ram", 72, 21);
        //Console.WriteLine(s1.name);
        //Console.WriteLine(s1.rollno);
        //Console.WriteLine(s1.age);
        s1.Display();
        Student s2 = new Student();

        Student s3 = new Student(s1);
        s3.Display();
    }
}
