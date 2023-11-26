using System;
using System.Runtime.Serialization.Json;

namespace operators;

class Program
{
    static void Main(string[] args)
    {

        //Arithmetic Operators
        int a = 10;
        int b = 20;
        int sum = a + b;                   //addition
        Console.WriteLine(sum);
        int diff = b - a;                  //subtraction
        Console.WriteLine(diff);
        int product = a * b;               //Multiplication
        Console.WriteLine(product);
        int divide = b / a;                //division
        Console.WriteLine(divide);
        int rem = b % a;                   //remainder
        Console.WriteLine(rem);
        int c = 8, d = 4;
        c++;                              //post-increment
        Console.WriteLine(c);
        d--;                              //post-decrement
        Console.WriteLine(d);
        int incr = ++c;                  //pre-increment
        Console.WriteLine(incr);
        int decr = --d;                  //pre-decrement
        Console.WriteLine(decr);


        //Assignment Operator

        int num1 = 5;
        Console.WriteLine(num1);

        num1 += 10;
        Console.WriteLine(num1);

        num1 -= 10;
        Console.WriteLine(num1);

        num1 *= 10;
        Console.WriteLine(num1);

        num1 /= 10;
        Console.WriteLine(num1);

        num1 %= 10;
        Console.WriteLine(num1);

        int s = 3;
        Console.WriteLine(s &= 5);                //bitwise and

        int f = 3; 
        Console.WriteLine(f |= 4);               //bitwise or

        int g = 3;
        Console.WriteLine(g ^= 5);               //bitwise ex-or

        //comparision operator
        int x = 3;
        int y = 4;
        Console.WriteLine(x == y);
        Console.WriteLine(x != y);
        Console.WriteLine(x > y);
        Console.WriteLine(x < y);
        Console.WriteLine(x >= y);
        Console.WriteLine(x <= y);

        //Logical operator

        int j = 5, k = 4;
        if (j > 0 && k > 0)                                   //logical and
        {
            Console.WriteLine("condition true");
        }
        else
        {
            Console.WriteLine("condition false");
        }

        if (j < 0 || k > 0)                                 //logical or
        {
            Console.WriteLine("condition true");
        }
        else
        {
            Console.WriteLine("condtition false");
        }
        Console.WriteLine(!(j > k));                      //logical not

        int max = (j > k) ? j : k;                        //Ternary operator
        Console.WriteLine(max);
     






    }
}