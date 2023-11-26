using System;
namespace DataTypes;

class Program
{
    static void Main(string[] args)
    {
        int num = 45;                              //4
        char c = 'a';                              //2
        float f = 4.55323F;                        //4
        double d = 7.483434534D;                   //8
        string name = "Tinu";                      //2 per char
        bool myBool = true;                        //1 bit
        long num2 = 8987656561234567654;           //8

        Console.WriteLine(num);
        Console.WriteLine(c);
        Console.WriteLine(f);
        Console.WriteLine(d);
        Console.WriteLine(name);
        Console.WriteLine(myBool);
        Console.WriteLine(num2);

        int sizeofInt = sizeof(int);
        Console.WriteLine(sizeofInt);
        int sizeofChar = sizeof(char);
        Console.WriteLine(sizeofChar);
        int sizeofFloat = sizeof(float);
        Console.WriteLine(sizeofFloat);
        int sizeofDouble = sizeof(double);
        Console.WriteLine(sizeofDouble);
        int sizeofLong = sizeof(long);
        Console.WriteLine(sizeofLong);
        int sizeofBool = sizeof(bool);
        Console.WriteLine(sizeofBool);
       
    }
}
