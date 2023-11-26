using System;
using System.Threading;
namespace Multithreading;

class Program
{
    static void Main(string[] args)
    {
        Thread mainThread = Thread.CurrentThread;
       // Console.WriteLine(mainThread);
        mainThread.Name = "Main Thread";

        Thread threadObject1 = new Thread(Example1);
        Thread threadObject2 = new Thread(Example2);

        Console.WriteLine("Thread state before start:" + threadObject1.ThreadState);

        threadObject1.Start();
        if (threadObject1.IsAlive)
        {
            Console.WriteLine("Thread is still running");
        }
        //Thread.Sleep(2000);
        //threadObject1.Suspend();
        //Console.WriteLine("Thread is suspended");

        //Thread.Sleep(2000);
        //threadObject1.Resume();
        //Console.WriteLine("Thread is resumed");
        //Console.WriteLine("Thread state before start:" + threadObject1.ThreadState);
        threadObject2.Start();
        threadObject1.Join();
        threadObject2.Join();
        //Example1();
        //Example2();
        Console.WriteLine("Thread state after join:" + threadObject1.ThreadState);
        Console.WriteLine("Main thread finished");
        //Console.WriteLine("Aborting the thread");
        //threadObject1.Abort();

    }
    static void Example1()
    {
        Console.WriteLine("Thread 1 started");
        for(int i = 0; i <= 5; i++)
        {
            Console.WriteLine("Thread 1 is executing");
            Thread.Sleep(3000);
        }
    }
    static void Example2()
    {
        Console.WriteLine("Thread 2 started");
        for(int i = 0;i <= 5; i++)
        {
            Console.WriteLine("Thread 2 is executing");
            Thread.Sleep(3000);
        }
    }
}