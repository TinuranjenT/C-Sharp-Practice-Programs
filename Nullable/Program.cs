using System;

namespace Nullable;

class Program
{
    class Person
    {
        public string name ;
    }
    static void Main(string[] args)
    {
        int? x = 100;
        int? y = 100;
        bool check = false;
        if (x == y)
        {
            check = true;
            Console.WriteLine(check.ToString());
        }
        if (x != y)
        {
            Console.WriteLine(check.ToString());
        }
        int? z = x * y;
        Console.WriteLine(z.ToString());


        //null coalescing operator
        int? a = null;
        //int b = 5;
        int? result = a ?? 5;  
        Console.WriteLine(result);

        int? c = 5;
        int d = c ?? 0;                   //assign nullable type to a non nullable type
        Console.WriteLine("value of d is " + d);


        int? q = null;
        int r = 5;
        if (q < r)
        {
            Console.WriteLine("q is less than r");
        }
        else if (q == r)
        {
            Console.WriteLine("q is equal to r");
        }
        else if (q > r)
        {
            Console.WriteLine("q is less than r");
        }
        else
        {
            Console.WriteLine("not able to compare");
        }
        //safe navigation
        //Person person = new Person();
        //person.name = "Tinu";
        Person person = null;
        string nameWithoutSafeNavigation = (person != null) ? person.name : null;
        string nameWithNavigation = person?.name;  //safe navigation operator or elvis operator
        
        Console.WriteLine("name without safe navigation " + nameWithoutSafeNavigation);
        Console.WriteLine("name with safe navigation " + nameWithNavigation);



        //Reading the file
        string filePath = @"C:\\MyData\\name.txt";
            string content2 = File.ReadAllText(filePath);
        Console.WriteLine(content2);

        string[] lines = File.ReadAllLines(filePath);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }

        //Writing text in the file
        string data1 = "Welcome to this page";
        File.WriteAllText(filePath, data1);
        Console.WriteLine("File has been written successfully");

        string[] data2 = { "apple", "orange", "grapes", "pomegranate" };
        File.WriteAllLines(filePath, data2);
        Console.WriteLine("File has been written successfully");


        //Appending text in the file
        string data3 = "This is added data";
        File.AppendAllText(filePath, data3);
        Console.WriteLine("Text has been successfully added");

        string[] data4 = { "This is added data1", "This is added data2" };
        File.AppendAllLines(filePath, data4);
        Console.WriteLine("Lines has been successfully added");

        //Copy method
        string destinationFilePath = @"C:\\MyData\\created.txt";
        bool overwrite = true;
        File.Copy(filePath, destinationFilePath, overwrite);
        Console.WriteLine("File copied");

        //Delete method
        File.Delete(destinationFilePath);

        //Exist method
        bool doesFileExists = File.Exists(destinationFilePath);
        Console.WriteLine(doesFileExists);

        //GetCreationTime
        DateTime fileCreatedDate = File.GetCreationTime(filePath);
        Console.WriteLine("File created on " +  fileCreatedDate);

    }
}


