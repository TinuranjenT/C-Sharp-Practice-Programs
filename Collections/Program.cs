using System;
using System.Collections;
using System.Collections.Immutable;
using System.ComponentModel.Design.Serialization;
using System.Security.Cryptography.X509Certificates;

namespace Collections;

class Program
{

    public static void Print<T>(T value) //generic method
    {
        Console.WriteLine("Value from generic method " + value);
    }
    static void Main(string[] args)
    {
        //Non-Generic 
        ArrayList a1 = new ArrayList();  
        Console.WriteLine(a1.Add(2));   //returns the index at which the value is stored
        a1.Add(3);
        a1.Add("Tinu");
        a1.Add('a');

        int number = (int)a1[0];         //explicit type casting
        Console.WriteLine("The first element is " + number);

        Console.WriteLine("Iniial list");
        foreach (object o in a1)
        {
            Console.WriteLine(o);
        }

        a1.Insert(1, 5.6);
        Console.WriteLine("After inserting 5.6 at 1st index");
        for(int i=0; i<a1.Count; i++)
        {
            Console.WriteLine(a1[i]);
        }

        a1.Remove('a');
        Console.WriteLine("After removing 'a' ");
        foreach (object o in a1)
        {
            Console.WriteLine(o);
        }

        a1.RemoveAt(2);
        Console.WriteLine("After removing element at index 2");
        foreach (object o in a1)
        {
            Console.WriteLine(o);
        }

        a1.Add(4);
        a1.Add('E');
        a1.RemoveRange(0, 2);
        Console.WriteLine("After removing range of element from  index 0 to index 1");
        foreach (object o in a1)
        {
            Console.WriteLine(o);
        }

        Console.WriteLine("The number of elements in the array list is "+ a1.Count);


        Console.WriteLine("New Arraylist");
        ArrayList a2 = new ArrayList();
        a2.Add("Rahul");
        a2.Add("Subramani");
        a2.Add("Baveth");
        a2.Add("Hari");
        Console.WriteLine("Before sorting");
        foreach (string name in a2)
        {
            Console.WriteLine(name);
        }
        a2.Sort();
        Console.WriteLine("After sorting");
        foreach (string name in a2)
        {
            Console.WriteLine(name);
        }



      
        Hashtable h1 = new Hashtable();     //items are arranged in random order
        h1.Add(1, "Chennai");
        h1.Add(2, "Thiruvananthapuram");
        h1.Add(3, "Amaravati");
        
        foreach (DictionaryEntry e in h1)
        {
            Console.WriteLine( e.Key + " " +  e.Value );
        }

        Console.WriteLine("Retrieving a particular value based on the key");
        string city = h1[1].ToString();       //explicit type casting
        Console.WriteLine("The city " + city);

        Console.WriteLine("After sorting");

        SortedList s1 = new SortedList();      //arrange items in sorted order
        s1.Add("Tamilnadu", "Chennai");
        s1.Add("Kerala", "Thiruvananthapuram");
        s1.Add("Andhra Pradesh", "Amaravati");

        foreach (DictionaryEntry d in s1)
        {
            Console.WriteLine(d.Key+ " " + d.Value);
        }

        Console.WriteLine("The number of elements in the sorted list is " + s1.Count);

        Stack st1 = new Stack();
        st1.Push(2);
        st1.Push("Tinu");
        st1.Push(3.5);
        st1.Push('a');
        Console.WriteLine("Elements in the stack");
        foreach (var o in st1)
        {
            Console.WriteLine(o);
        }
        st1.Pop();
        Console.WriteLine("After removing one element from the stack");
        foreach (var o in st1)
        {
            Console.WriteLine(o);
        }
        Console.WriteLine("The element in the top is " + st1.Peek());



        Queue q1 = new Queue();
        q1.Enqueue(2);
        q1.Enqueue("ram");
        q1.Enqueue(3.9);
        q1.Enqueue('d');
        Console.WriteLine("Initial elements in the queue");
        foreach (var o in q1)
        {
            Console.WriteLine(o);
        }

        q1.Dequeue();
        Console.WriteLine("After removing an element in the queue");
        foreach (var o in q1)
        {
            Console.WriteLine(o);
        }
        Console.WriteLine("The number of elements in the queue is " + q1.Count);




        //Generic
        List <int> l1 = new List<int>();
        l1.Add(1000);
        l1.Add(2);
        l1.Add(450);
        l1.Add(5);

        Console.WriteLine("The first element in the list is "+ l1[0]); //no need of explicit type casting

        foreach (int i in l1)
        {
            Console.WriteLine(i);
        }
        l1.Sort();
        foreach (int i in l1)
        {
            Console.WriteLine(i);
        }

        Dictionary<string, int> d1= new Dictionary<string, int>();
        d1.Add("Rahul", 21);
        d1.Add("Rajesh", 23);
        d1.Add("Murugan", 29);
        d1.Add("Subramani", 30);

        foreach (var names in d1)
        {
            Console.WriteLine(names.Key + " " + names.Value);
        }
        d1.Remove("Rahul");
        foreach (var names in d1)
        {
            Console.WriteLine(names.Key + " " + names.Value);
        }


        SortedList<string, int> sl1= new SortedList<string, int>();
        sl1.Add("Rahul", 21);
        sl1.Add("Rajesh", 23);
        sl1.Add("Murugan", 29);
        sl1.Add("Subramani", 30);

        foreach(var names in sl1)
        {
            Console.WriteLine(names.Key + " " + names.Value);
        }
        sl1.Remove("Rahul");
        foreach (var names in sl1)
        {
            Console.WriteLine(names.Key + " " +names.Value);
        }

        Stack <string> sk1= new Stack<string>();
        sk1.Push("Saurav");
        sk1.Push("Virat");
        sk1.Push("Dhoni");
        sk1.Push("Raina");

        foreach(string name in sk1)
        {
            Console.WriteLine(name);
        }
        sk1.Pop();
        foreach (string name in sk1)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine("The element in the top is " + st1.Peek());


        Queue <string> queue= new Queue<string>();
        queue.Enqueue("hello");
        queue.Enqueue("welcome");
        queue.Enqueue("drive");
        queue.Enqueue("sample");

        foreach(var s in queue)
        {
            Console.WriteLine(s);
        }

        queue.Dequeue();

        foreach (var s in queue)
        {
            Console.WriteLine(s);
        }


        Print(10);           
        Print("Hello");


    }

   
}