using System;
using System.Security.Cryptography;

namespace Interface;

interface IShapes
{
    void area(int a, int b);
}
interface IColour
{
    void colour();
}
class Rectangle : IShapes, IColour
{
    public void area(int a, int b)
    {
        int area = a * b;
        Console.WriteLine("Area of rectangle is "+ area);
    }
    public void colour()
    {
        Console.WriteLine("Red Rectangle");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle r1=new Rectangle();
        r1.area(4, 6);
       r1.colour();
       

    }
}


