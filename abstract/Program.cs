using System;
namespace abstracts;

abstract class Shapes
{
    public abstract void area(int r);                  //abstract method
    public void display()                              //Non-abstract method
    {
        Console.WriteLine("This is display method");
    }
    public static void greeting()                      //static method
    {
        Console.WriteLine("This is static method");
    }
}

class Circle : Shapes
{
   public override void area(int r)
    {
        Console.WriteLine("Area of Circle is "+Math.PI * r * r);
    }
}

class Square : Shapes
{
    public override void area(int s)
    {
        Console.WriteLine("Area of Square is "+4 * s);
    }
}



class Program
{
    static void Main(string[] args)
    {
        Shapes s1 = new Circle();
        s1.area(2);

        Shapes s2 = new Square();
        s2.area(4);

        Shapes s3 = new Square();  //accessing the non abstract method of the abstract class
        s3.display();

        Shapes.greeting();        //static method can be accessed directly using class name
        

    }
}


