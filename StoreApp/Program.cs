using System;
using System.Collections.Generic;
using System.Security;
using System.Security.Cryptography.X509Certificates;

namespace StoreApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to our store");
        Basket.OurStore();
    }
}

public  class Basket
{
    static Dictionary<string, int> items = new();

    public static void OurStore()
    {
        Console.WriteLine("Choose the option below");
        Console.WriteLine("1.AddItem");
        Console.WriteLine("2.DisplayItem");
        Console.WriteLine("3.Remove an Item");
        Console.WriteLine("4.Exit");

        int option =int.Parse(Console.ReadLine());

        switch(option) {

            case 1:
                {
                    AddItem();
                    break;
                }
            case 2:
                {
                    DisplayItem();
                    break;
                }
            case 3:
                {
                    RemoveItem();
                    break;
                }
            case 4:
                {
                    Console.WriteLine("Thank you for your purchase");
                    break;
                }
            default:
                {
                    Console.WriteLine("Invalid Option, Please enter a valid Input");
                    OurStore();
                    break;
                }
        }
    }

    public static void AddItem()
    {
        Console.WriteLine("Enter the name of the item");
        string itemName=Console.ReadLine();
        Console.WriteLine("Enter the quantity you want");
        int quantity=int.Parse(Console.ReadLine());

        items.Add(itemName, quantity);
        Console.WriteLine($"{itemName} is added {quantity}");

        OurStore();

    }

    public static void DisplayItem()
    {
        if (!items.Any())
        {
            Console.WriteLine("The cart is empty.Please add some items");
        }
        foreach(var item in items)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
        OurStore();
    }

    public static void RemoveItem()
    {
        Console.WriteLine("Enter the item you want to remove");
        string key = Console.ReadLine();
        if (items.ContainsKey(key))
        {
            items.Remove(key);
            Console.WriteLine($"{key} has been successfully removed");
        }
        else
        {
            Console.WriteLine("The given item is not found.Please enter a valid item");
        }
        OurStore();
    }
}
