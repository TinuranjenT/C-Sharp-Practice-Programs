using System;
namespace Inheritance;

class Shape
{
    public int width;
    public int height;
    public int side;
    public int radius;
    public void SetWidth(int w)
    {
        width = w;
    }
    public void SetHeight(int h)
    {
        height = h;
    }
    public void SetSide(int s)
    {
        side = s;
    }
    public void SetRadius(int a)
    {
        radius = a;
    }
}

class Rectangle : Shape
{
    public int AreaOfRectangle()
    {
        return width * height;
    }
}

class Square : Rectangle
{
    public int AreaOfSquare()
    {
        return side * side;
    }
}

class Circle : Shape
{
    public double AreaOfCircle()
    {
        return Math.PI * radius * radius;
    }
}
interface IA
{
    int SetValue1(int a);
}
interface IB
{
    int SetValue2(int b);
}
class Triangle : IA, IB                   //Multiple
{
    public int SetValue1(int a)
    {
        return a*a;
    }

    public int SetValue2(int b)
    {
        return b * b;
    }

    
}


class Area{
    static void Main(string[] args)
    {
       Rectangle r1= new Rectangle();
        r1.SetWidth(10);
        r1.SetHeight(5);
        Console.WriteLine(r1.AreaOfRectangle());

        Square s1=new Square();
        s1 .SetSide(10);
        Console.WriteLine(s1.AreaOfSquare());

        Circle c1=new Circle();
        c1.SetRadius(3);
        Console.WriteLine(c1.AreaOfCircle());

        Triangle t1 = new Triangle();
        Console.WriteLine(t1.SetValue1(2));
        Console.WriteLine(t1.SetValue2(3));

        

    }
}


