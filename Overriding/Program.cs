using System;
namespace Override;

class Class1
{
    public virtual int Add(int num1, int num2)
    {
        return (num1 + num2);
    }
}
class Class2 : Class1
{
    public override int Add(int num1, int num2)
    {
        if (num1 <= 0 || num2 <= 0)
        {
            Console.WriteLine("Values could not be less than zero or equals to zero");
            Console.WriteLine("Enter First value : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second value:");
            num2 = Convert.ToInt32(Console.ReadLine());
            
        }
       return num1+num2;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Class1 obj1= new Class1();
        Console.WriteLine( "class1 method Add :" + obj1.Add(-5, 4));
        Class1 obj2 = new Class2();
        Console.WriteLine("class2 method Add :" + obj2.Add(-3, 3));
        Console.ReadLine();
    }
}
