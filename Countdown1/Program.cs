using System;
using System.Threading;

namespace Countdown1
{
    class Program
    {
        static void Main(string[] args)
        {
            CountDownTimer countDownTimer1 = new CountDownTimer();
            CountDownTimer countDownTimer2 = new CountDownTimer();

            //using thread
            ////Thread thread1 = new Thread(() => CountDown("CountDown:1 ", 5));
            ////Thread thread2 = new Thread(() => CountDown("CountDown:2 ", 10));
            ////thread1.Start();
            ////thread2.Start();

            //using task
            Task<bool> task1 = countDownTimer1.CountDown("CountDown1", 5);
            Task<bool> task2 = countDownTimer2.CountDown("CountDown2", 10);
            if (task1.Result)
            {
                Console.WriteLine("Countdowm 1 stopped");
            }
            if (task2.Result)
            {
                Console.WriteLine("Countdowm 2 stopped");
            }

            Console.WriteLine("Main thread exiting.");
        }

        //public static void CountDown(string name, int n)
        //{
        //    Console.WriteLine(name + " is started..");
        //    for (int i = n; i >= 0; i--)
        //    {
        //        Console.WriteLine(name + ":" + i);
        //        Thread.Sleep(2000);
        //    }
        //    Console.WriteLine(name + "stopped");

        //}
       
    }
    public class CountDownTimer
    {
        public  async Task<bool> CountDown(string name, int n)
        {
            Console.WriteLine(name + " is started..");
            for (int i = n; i >= 0; i--)
            {
                Console.WriteLine(name + ":" + i);
                await Task.Delay(1000);
            }
            return true;
        }

    }
}