using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace UrbanApp
{
    class Program
    {
        public static Dictionary<string, int> acService = new Dictionary<string, int>();
        public static Dictionary<string, int> washingService = new Dictionary<string, int>();
        public static Dictionary<string, int> paintService = new Dictionary<string, int>();
        public static Dictionary<string, int> sallonService = new Dictionary<string, int>();
        public static Dictionary<string, double> totalService = new Dictionary<string, double>();

        public static void addAllAcServices()
        {
            acService.Add("Installation", 400);
            acService.Add("UnInstallation", 300);
            acService.Add("Deep clean", 500);
        }

        public static void addAllWashingServices()
        {
            washingService.Add("Front load Service", 400);
            washingService.Add("Top load Service", 500);
            washingService.Add("Gas refilling", 700);
        }

        public static void addAllPaintServices()
        {
            paintService.Add("Enamel painting", 75);
            paintService.Add("Interior painting", 40);
            paintService.Add("Exterior painting", 50);
        }
        public static void addAllSallonServices()
        {
            sallonService.Add("Hair cut", 200);
            sallonService.Add("Hair cut and shaving", 300);
            sallonService.Add("Beard trimming", 100);
        }
        public static void displayAcServices()
        {
            Console.WriteLine("These are the various services available in Air conditioner");
            foreach(var items in acService)
            {
                Console.WriteLine(items.Key + ": " + items.Value);
            }
        }
        public static void displayWashingServices()
        {
            Console.WriteLine("These are the various services available in Washing Machine");
            foreach (var items in washingService)
            {
                Console.WriteLine(items.Key + ": " + items.Value);
            }
        }
        public static void displayPaintServices()
        {
            Console.WriteLine("These are the various services available in Paint");
            foreach (var items in paintService)
            {
                Console.WriteLine(items.Key + ": " + items.Value);
            }
        }
        public static void displaySallonServices()
        {
            Console.WriteLine("These are the various services available in Sallon");
            foreach (var items in sallonService)
            {
                Console.WriteLine(items.Key + ": " + items.Value);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the service Booking app");
            Console.WriteLine("Enter the name:");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter the Address:");
            string userAddress=Console.ReadLine();

            Urban urbanUser1 = new Urban(userName, userAddress);
            addAllAcServices();
            addAllWashingServices();
            addAllPaintServices();
            addAllSallonServices();
            Urban.Service();
        }
    }

    public class Urban
    {
        private string userName;
        private string userAddress;
        private static double totalAmount = 0;
        public Urban(string userName, string userAddress)
        {
            this.userName = userName;
            this.userAddress = userAddress;
        }
        public static void Service()
        {
            Console.WriteLine("Choose the category:");
            Console.WriteLine("1. Air Conditioner");
            Console.WriteLine("2. Washing Machine");
            Console.WriteLine("3. Painting");
            Console.WriteLine("4. Sallon");
            Console.WriteLine("5. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Program.displayAcServices();
                    BookService(choice);
                    break;
                case 2:
                    Program.displayWashingServices();
                    BookService(choice);
                    break;
                case 3:
                    Program.displayPaintServices();
                    BookService(choice);
                    break;
                case 4:
                    Program.displaySallonServices();
                    BookService(choice);
                    break;

                case 5:
                    Greetings();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    Service();
                    break;
            }
        }
        public static void Greetings()
        {
            Console.WriteLine("Thank you for visiting. Please visit again!");
        }
        public static void BookAnotherService()
        {
            Console.WriteLine("Press 1 to book another service, 2 to generate the bill, or 3 to exit:");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Service();
                    break;
                case 2:
                    GenerateBill();
                    break;
                case 3:
                    Greetings();
                    break;
                default:
                    Console.WriteLine("Invalid option.Please enter a valid option");
                    BookAnotherService();
                    break;
            }

        }
        public static void BookAcService()
        {
            AcService acService1 = new AcService();
            string serviceName = acService1.GetServiceName();

            Console.WriteLine("Choose the " +serviceName +" you want to add:");
            string userOption = Console.ReadLine();

            if (Program.acService.Any(item => item.Key == userOption))
            {
                int value = Program.acService[userOption];
                Console.WriteLine("How Many Air conditioner need this service?");
                int noOfAirConditioner = Convert.ToInt32(Console.ReadLine());

                double totalValues = value * noOfAirConditioner;
                double totalValueWithGst = totalValues + totalValues * 0.05;
                Console.WriteLine(userOption + "has been added in the cart");
                // Console.WriteLine(choice , value);
                totalAmount += totalValueWithGst;
                Program.totalService.Add(userOption, totalValueWithGst);
                BookAnotherService();
            }
            else
            {
                Console.WriteLine("The entered service is not available, please enter another choice");
                BookAnotherService();
                //GetUserService();
            }

        }
        public static void BookWashingService()
        {
            WashingMachineService washingService1 = new WashingMachineService();
            string serviceName = washingService1.GetServiceName();
            Console.WriteLine($"Choose the {serviceName} you want to add:");
            string userOption = Console.ReadLine();

            if (Program.washingService.Any(item => item.Key == userOption))
            {
                int value = Program.washingService[userOption];
                Console.WriteLine("How Many Washing Machine need this service?");
                int noOfWashingMachine = Convert.ToInt32(Console.ReadLine());

                double totalValues = value * noOfWashingMachine;
                double totalValueWithGst = totalValues + totalValues * 0.05;
                Console.WriteLine($"{userOption} has been added in the cart");
                // Console.WriteLine(choice , value);
                totalAmount += totalValueWithGst;
                Program.totalService.Add(userOption, totalValueWithGst);
                BookAnotherService();
            }
            else
            {
                Console.WriteLine("The entered service is not available, please enter another choice");
                BookAnotherService();
                //GetUserService();
            }

        }
        public static void BookPaintService()
        {
            PaintService paintService1 = new PaintService();
            string serviceName = paintService1.GetServiceName();
            Console.WriteLine($"Choose the {serviceName} you want to add:");
            string userOption = Console.ReadLine();


            if (Program.paintService.Any(item => item.Key == userOption))
            {
                int value = Program.paintService[userOption];
                Console.WriteLine("How Many square feet ?");
                int noOfSquareFeet = Convert.ToInt32(Console.ReadLine());

                double totalValues = value * noOfSquareFeet;
                double totalValueWithGst = totalValues + totalValues * 0.05;
                Console.WriteLine($"{userOption} has been added in the cart");
                // Console.WriteLine(choice , value);
                totalAmount += totalValueWithGst;
                Program.totalService.Add(userOption, totalValueWithGst);
                BookAnotherService();
            }
            else
            {
                Console.WriteLine("The entered service is not available, please enter another choice");
                BookAnotherService();
                //GetUserService();
            }

        }
        public static void BookSallonService()
        {
            SallonService sallonService1 = new SallonService();
            string serviceName = sallonService1.GetServiceName();
            Console.WriteLine($"Choose the {serviceName} you want to add:");
            string userOption = Console.ReadLine();

            if(Program.sallonService.Any(item => item.Key == userOption))
            {
                int value = Program.sallonService[userOption];
                Console.WriteLine("How Many Person need this service ?");
                int noOfPersons = Convert.ToInt32(Console.ReadLine());

                double totalValues = value * noOfPersons;
                double totalValueWithGst = totalValues + totalValues * 0.05;
                Console.WriteLine($"{userOption} has been added in the cart");
                // Console.WriteLine(choice , value);
                totalAmount += totalValueWithGst;
                Program.totalService.Add(userOption, totalValueWithGst);
                BookAnotherService();
            }
            else
            {
                Console.WriteLine("The entered service is not available, please enter another choice");
                BookAnotherService();
                //GetUserService();
            }
        }
        public static void BookService(int choice)
        {
            switch (choice)
            {
                case 1:
                    {
                        BookAcService();
                        break;
                    }
                case 2:
                    {
                        BookWashingService();
                        break;
                    }
                case 3:
                    {
                        BookPaintService();
                        break;
                    }
                case 4:
                    {
                        BookSallonService();
                        break;
                    }
                case 5:
                    {
                        Greetings();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Option.Please enter a valid option");
                        break;
                    }
            }
        }

        public static void GenerateBill()
        {
            Console.WriteLine($"Thank you for choosing our services!");
            Console.WriteLine("Here is your bill:");

            foreach (var service in Program.totalService)
            {
                Console.WriteLine(service.Key + " " + service.Value);
            }

            Console.WriteLine($"Total Amount: {totalAmount}");
            Greetings();
        }
    }

    public abstract class Service
    {
        public abstract string GetServiceName(); 
    }

    public class AcService : Service
    { 
        public override string GetServiceName()
        {
            return "ACService";
        }
    }

    public class WashingMachineService : Service
    {
        public override string GetServiceName()
        {
            return "Washing Machine Service";
        }
    }

    public class PaintService : Service
    {
        public override string GetServiceName()
        {
            return "Paint Service";
        }
    }

    public class SallonService : Service
    {
        public override string GetServiceName()
        {
            return "Sallon Service";
        }
    }    
}

