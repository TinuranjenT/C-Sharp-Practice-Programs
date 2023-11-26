using System;
namespace Countdown
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CountDown");

            Countdown d1 = new Countdown();
            Countdown d2 = new Countdown();

            //using thread
            //Thread thread1 = new Thread(() => d1.RunCountDown("CountDown1:", 5));
            //Thread thread2 = new Thread(() => d2.RunCountDown("CountDown2:", 10));
            //thread1.Start();
            //thread2.Start();


            //using task
            Task<bool> task1 = d1.RunCountDown("CountDown:1", 5);
            Task<bool> task2 = d2.RunCountDown("CountDown:2", 10);
            if (task1.Result)
            {
                Console.WriteLine("CountDown1:stopped");
            }
            if (task2.Result)
            {
                Console.WriteLine("CountDown2:stopped");
            }
        }
    }
    class Countdown
    {
        //public void RunCountDown(string name, int startSecond)
        //{
        //    Console.WriteLine(name + "started");
        //    for (int i = startSecond; i >= 0; i--)
        //    {
        //        Console.WriteLine(name + ":" + i);
        //        Thread.Sleep(2000);
        //    }
        //    Console.WriteLine(name + "stopped");
        //}

        public async Task<bool> RunCountDown(string name, int startSecond)
        {
            Console.WriteLine(name + "started");
            for (int i = startSecond; i >= 0; i--)
            {
                Console.WriteLine(name + ":" + i);
                await Task.Delay(2000);
            }
            return true;
        }
    }
}
   