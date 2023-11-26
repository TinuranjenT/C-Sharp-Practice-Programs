using System;
namespace InputOutput;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your name");
        string name=Console.ReadLine();
        Console.WriteLine(name);    

        Console.WriteLine("Enter your age");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(age);



    }
}

