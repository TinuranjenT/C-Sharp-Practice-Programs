using System;
namespace Overriding1;

public class Employee
{
    public virtual int salary()
    {
        int sal = 32000;
        return sal;
    }
}

public class Manager : Employee
{
   public override int salary()
    {
        int sal = 50000;
        return sal; 
    }
}


class Program
{
    static void Main(string[] args)
    {
        Employee e1 = new Employee();
        Console.WriteLine(e1.salary());
        Employee m1=new Manager();
        Console.WriteLine(m1.salary());
    }
}