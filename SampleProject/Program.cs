using System;
namespace SampleProject;

class Square
{
    public int side;
    static int count = 0;

    public Square() {
        count++;
        Console.WriteLine(count);
    }
    public Square(int side)
    {
        this.side = side;
    }
    public virtual int Area()
    {
        return side * side;
    }
    //public int Area(int length, int breadth)
    //{
    //    return length * breadth;
    //}
}

class Rectangle : Square
{
    int length;
    public Rectangle(int length, int side) : base(side)
    {
        this.length = length;
    }

    public override int Area()
    {
        return length * side;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Square s1 = new Square(3);
        int area=s1.Area();
        Console.WriteLine(area);
        Square r1 = new Rectangle(5,3);
        int area2=r1.Area();
        Console.WriteLine(area2);

        Square s3 = new Square();
        Square s4 = new Square();







    }
}