using System.Collections;
using System.Linq;
using System.Runtime.InteropServices;

class Program
{
    class DepartmentClass
    {
        public int DepartmentId;
        public string Name;
    }

    class EmployeeClass
    {
        public int EmployeeId;
        public string EmployeeName;
        public int DepartmentId;
    }

    static void Main(string[] args)
    {
        #region
        //The three Parts of a LINQ Query
        //1.Data source

        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };

        //2.Query Creation

        var numQuery =
            from num in numbers
            where (num % 2 == 0)
            select num;

        //3.Query execution
        foreach (int num in numQuery)
        {
            Console.WriteLine(num);
        }

        #endregion

        #region

        //Query syntax and method syntax

        //Query syntax or comprehension syntax
        var numQuery1 =
            from num in numbers
            where (num % 2) == 0
            select num;

        //Method syntax or Lamda syntax
        var numMethod = numbers.Where(n => n % 2 == 0);
        #endregion

        #region
        List<int> marks = new List<int>();
        marks.Add(90);
        marks.Add(80);
        marks.Add(70);
        marks.Add(84);
        marks.Add(72);

        //IEnumerable<int> greaterThanSeventy = from num in marks //For filter-where operator
        //                                      where (num > 70)
        //                                      select num;

        var number1 = marks.Where(n => n > 70);


        foreach (int num in number1)
        {
            Console.WriteLine(num + " ");
        }

        ArrayList arrayList = new ArrayList();
        arrayList.Add(1);
        arrayList.Add("Tinu");
        arrayList.Add(4);
        arrayList.Add("Rahul");
        var onlyString = arrayList.OfType<string>();  //ofType

        foreach(string str in onlyString)
        {
            Console.WriteLine(str);
        }

        #endregion

        #region
        //join
        List<DepartmentClass> departments = new List<DepartmentClass>();
        departments.Add(new DepartmentClass { DepartmentId = 1, Name = "CSE" });
        departments.Add(new DepartmentClass { DepartmentId = 2, Name = "IT" });
        departments.Add(new DepartmentClass { DepartmentId = 3, Name = "ECE" });

        List<EmployeeClass> employees = new List<EmployeeClass>();
        employees.Add(new EmployeeClass { DepartmentId = 1, EmployeeId = 1, EmployeeName = "Rahul" });
        employees.Add(new EmployeeClass { DepartmentId = 2, EmployeeId = 2, EmployeeName = "Hari" });
        employees.Add(new EmployeeClass { DepartmentId = 1, EmployeeId = 3, EmployeeName = "Baveth" });

        var list = (from e in employees
                    join d in departments on e.DepartmentId equals d.DepartmentId
                    select new
                    {
                        EmployeeName = e.EmployeeName,
                        DepartmentName = d.Name
                    });
        foreach (var e in list)
        {
            Console.WriteLine("Employee Name = {0} , Department Name = {1}", e.EmployeeName, e.DepartmentName);
        }
        #endregion

        #region
        List<string> words = new List<string>();  //projection operation
        words.Add("an");
        words.Add("apple");
        words.Add("movie");
        words.Add("mobile");

        var query = from word in words select word.Substring(0, 1); //using select clause

        foreach (string s in query)
        {
            Console.WriteLine(s);
        }
        #endregion

        #region
        //sorting
        int[] arr = { 1, -4, 3, 5, -8, 9, 8 };  
        var asc = from num in arr                     //Ascending
                  orderby num
                  select num;
        foreach(int n in asc)
        {
            Console.WriteLine(n);
        }
        var desc = from num in arr                  //Descending               
                   orderby num descending
                   select num;
        foreach (int n in desc)
        {
            Console.WriteLine(n);
        }

        var noOfElements = arr.Count();
        Console.WriteLine(noOfElements);
        #endregion

        #region
        List <int> studentAge= new List<int>();
        studentAge.Add(21);
        studentAge.Add(16);
        studentAge.Add(24);
        studentAge.Add(25);

        //bool eleigibleForVote = studentName.All(s => s > 18);
        //Console.WriteLine(eleigibleForVote);

        bool eleigibleForVote = studentAge.Any(s => s > 18);
        Console.WriteLine(eleigibleForVote);

        bool isSixteenPresent = studentAge.Contains(16);
        Console.WriteLine(isSixteenPresent);

        var avgAge = studentAge.Average();
        Console.WriteLine(avgAge);

        var oldest= studentAge.Max();
        Console.WriteLine(oldest);

        var sumOfAge = studentAge.Sum();
        Console.WriteLine("Sum of age " + sumOfAge);

        Console.WriteLine(studentAge.ElementAt(2));
        Console.WriteLine(studentAge.ElementAtOrDefault(1));

        /*Console.WriteLine(studentAge.ElementAt(5));*/ //Index out of range exception
        Console.WriteLine("Element at 5th index is " + studentAge.ElementAtOrDefault(5));  //returns zero

        Console.WriteLine(studentAge.First(i => i < 18));
        Console.WriteLine(studentAge.FirstOrDefault(i => i < 16));

        Console.WriteLine(studentAge.Last(i => i < 18));
        Console.WriteLine(studentAge.LastOrDefault(i => i > 16));

        //Console.WriteLine(studentAge.Single(i => i < 23)); //Throw more than one match exception

        Console.WriteLine(studentAge.Single(i => i < 18));
        Console.WriteLine(studentAge.SingleOrDefault(i => i < 16));

        List<int> Age= new List<int>();
        Age.Add(21);
        Age.Add(16);
        Age.Add(24);
        Age.Add(25);

        Console.WriteLine(studentAge.SequenceEqual(Age));

        IEnumerable<int> number = new List<int> { 1, 2, 3, 4, 5 };
        var evenNumbers = number.Where(n => n % 2 == 0);



        #endregion

        #region

        List<int> myList1 = new List<int>()
        { 1,2,3};
        List<int> myList2 = new List<int>()
        { 4,5 };

        var totalList = myList1.Concat(myList2);      //concat

        foreach(int n in totalList)
        {
            Console.WriteLine(n);
        }


        List<int> empList = new List<int>();
        var newList1 = empList.DefaultIfEmpty();     //defaultIfEmpty
        var newList2 = empList.DefaultIfEmpty(30);

        Console.WriteLine(newList1.Count());
        Console.WriteLine(newList1.ElementAt(0));
        Console.WriteLine(newList2.Count());
        Console.WriteLine(newList2.ElementAt(0));


        var emptyList = Enumerable.Empty<int>();

        Console.WriteLine("Count of emptyList: " + emptyList.Count());

        var Collection = Enumerable.Range(5, 5); // 1st-startingElement, 2nd-howManyELements
        for(int i = 0; i < Collection.Count(); i++)
        {
            Console.WriteLine(Collection.ElementAt(i));
        }

        var Collection1 = Enumerable.Repeat(5, 5);      //Repeat 
        for(int i = 0; i < Collection1.Count();i++)
        {
            Console.WriteLine(Collection1.ElementAt(i));
        }

        List<int> testList = new List<int>() { 1, 2, 3, 2, 4, 3, 5, 3, 2 };
        var distinctList1= testList.Distinct();         //Distinct

        foreach(var num in distinctList1)
        {
            Console.WriteLine(num);
        }

        List<int> list1 = new List<int>() { 1, 2, 3, 4, 5, 6 };
        List<int> list2 = new List<int>() { 4, 5, 6, 7, 8, 9 };
        var result = list1.Except(list2);
        Console.WriteLine("Except");
        foreach(int n in result)
        { 
            Console.WriteLine(n);
        }
        Console.WriteLine("Intersect");
        var result1 = list1.Intersect(list2);    //intersect
        foreach(int n in result1)
        {
            Console.WriteLine(n);
        }

        Console.WriteLine("Union");
        var result2 = list1.Union(list2);         //union
        foreach(int n in result2)
        {
            Console.WriteLine(n);
        }
        //Partition operators

        Console.WriteLine("Skip");
        var skipList1 = list1.Skip(2);      //skip
        foreach(var n in skipList1)
        {
            Console.WriteLine(n);
        }

        Console.WriteLine("SkipWhile");
        var skipList2 = list1.SkipWhile(x => x < 3);      //skipWhile
        foreach(var n in skipList2)
        {
            Console.WriteLine(n);
        }


        Console.WriteLine("Take");
        var takeList1 = list1.Take(2);
        foreach(var n in takeList1)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("TakeWhile");
        var takeList2 = list1.TakeWhile(x => x < 3);
        foreach(var n in takeList2)
        {
            Console.WriteLine(n);
        }

        #endregion







    }
}







