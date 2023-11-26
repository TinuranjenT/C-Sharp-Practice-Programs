using System;
namespace IDisposableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //UnManagedResources unManagedResources = new UnManagedResources();
            //unManagedResources.Dispose();


            //Automatically call the dispose method.After crossing the braces, it automatically closes the unused objects
            using (UnManagedResources unManagedResources = new UnManagedResources())
            {

            }   
        }
    }
}