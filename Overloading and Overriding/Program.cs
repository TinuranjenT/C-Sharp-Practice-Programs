using System;
namespace Overloading;

class Add
{
    public int Addition(int num1, int num2)
    {
        return (num1 + num2);
    }
    public int Addition(int num1, int num2, int num3)
    {
        return (num1 + num2 + num3);
    }
    public float Addition(float num1, float num2)
    {
        return (num1 + num2);
    }
    public string Addition(string value1, string value2)
    {
        return (value1 + " " + value2);
    }
}

class Program
{
    
    static void Main(string[] args) 
    {
        Add obj = new Add();
        Console.WriteLine(obj.Addition(3, 2));
        Console.WriteLine(obj.Addition(3, 2, 8));
        Console.WriteLine(obj.Addition(3.2F, 3.3F));
        Console.WriteLine(obj.Addition("Hello", "world"));
       //Console.ReadLine();

    }
}

