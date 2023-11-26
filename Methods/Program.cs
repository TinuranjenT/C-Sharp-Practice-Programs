using System;
namespace Methods;

class Program
{
    static void MyMethod()
    {
        Console.WriteLine("Welcome to my method");
    }

    static int Subtraction(int a, int b)
    {
        return a - b;
    }

    static void Addition(int a, int b)
    {
        Console.WriteLine(a + b);
    }

    static double PiValue()
    {
        return 3.14;
    }

    static void MyMethod1(string s = "india")
    {
        Console.WriteLine(s);
    }
    static void Main(string[] args)
    {
        MyMethod();                             //method without argument and without return type
        MyMethod();
        Addition(2, 3);                        //method with argument and without return type
        int subres = Subtraction(5, 3);       //method with argument and with return type
        Console.WriteLine(subres);
        double pi = PiValue();               //method without argument and with return type
        Console.WriteLine(pi);
        MyMethod1();                        //default method

    }

}

