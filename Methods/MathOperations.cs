using System;
namespace Methods;

public class MathOperations
{
    //private readonly Testing _testing;
    //public MathOperations(Testing testing)
    //{
    //     _testing = testing;
    //}
    static void MyMethod()
    {
        Console.WriteLine("Welcome to my method");
    }

    public int Subtraction(int a, int b, Testing t)
    {
      //var greeting =  Testing.TempNumber();
        //Testing t1 = new Testing();
        var number =  t.TempNumber();
        return number - a - b;
    }

    public int Addition(int a, int b)
    {
        checked
        {
            return a + b;
        }
    }

    static double PiValue()
    {
        return 3.14;
    }
    

    static void MyMethod1(string s = "india")
    {
        Console.WriteLine(s);
    }
    public static void Main(string[] args)
    {
        //MyMethod();                                     //method without argument and without return type
        //MyMethod();
        //MathOperations add = new MathOperations();
        //int addResult = add.Addition(10, 20);
        //Console.WriteLine(addResult);

        Testing t1 = new Testing();
        t1.TempNumber();

        //method with argument and without return type
        //MathOperations sub = new MathOperations();
        //int subResult = sub.Subtraction(30, 10, _testing.TempNumber());       //method with argument and with return type
        //Console.WriteLine(subResult);
        //double pi = PiValue();                         //method without argument and with return type
        //Console.WriteLine(pi);
        //MyMethod1();                                   //default method

    }

}

