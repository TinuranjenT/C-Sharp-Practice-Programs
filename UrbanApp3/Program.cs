using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace UrbanApp
{
    class Program
    {   
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the service Booking app");
            Console.WriteLine("Enter the name:");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter the Address:");
            string userAddress = Console.ReadLine();

            Urban urbanUser1 = new Urban(userName, userAddress);
            Urban.AddAcServices();
            Urban.AddWashingServices();
            Urban.AddPaintServices();
            Urban.AddSallonServices();
            Urban.Role();
        }
    }

    public class Urban
    {
        private string userName;
        private string userAddress;
        private static double totalAmount = 0;
        public static Dictionary<string, int> acService = new Dictionary<string, int>();
        public static Dictionary<string, int> washingService = new Dictionary<string, int>();
        public static Dictionary<string, int> paintService = new Dictionary<string, int>();
        public static Dictionary<string, int> sallonService = new Dictionary<string, int>();
        public static Dictionary<string, double> totalService = new Dictionary<string, double>();
        public Urban(string userName, string userAddress)
        {
            this.userName = userName;
            this.userAddress = userAddress;
        }
        public static void AddAcServices()
        {
            acService.Add("Installation", 400);
            acService.Add("UnInstallation", 300);
            acService.Add("Deep clean", 500);
        }

        public static void AddWashingServices()
        {
            washingService.Add("Front load Service", 400);
            washingService.Add("Top load Service", 500);
            washingService.Add("Gas refilling", 700);
        }

        public static  void AddPaintServices()
        {
            paintService.Add("Enamel painting", 75);
            paintService.Add("Interior painting", 40);
            paintService.Add("Exterior painting", 50);
        }
        public static void AddSallonServices()
        {
            sallonService.Add("Hair cut", 200);
            sallonService.Add("Hair cut and shaving", 300);
            sallonService.Add("Beard trimming", 100);
        }
        public static void AddNewService(int choice)
        {
            Console.WriteLine("Enter the name of the service you want to add:");
            string serviceName = Console.ReadLine();
            Console.WriteLine("Enter the amount for that service");
            int amount = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        AddNewAcServices(serviceName, amount);
                        break;
                    }
                case 2:
                    {
                        AddNewWashingServices(serviceName, amount);
                        break;
                    }
                case 3:
                    {
                        AddNewPaintServices(serviceName, amount);
                        break;
                    }
                case 4:
                    {
                        AddNewSallonServices(serviceName, amount);
                        break;
                    }
                   
            }

        }
       
        public static void AddAnotherService()
        {
            Console.WriteLine("Press 1 to add another service or 2 to go to the role page 2 to exit");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    {
                        AddServices();
                        break;
                    }
                case 2:
                    {
                        Role();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Thank you for visiting, Please visit again");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid role\nPlease enter a valid role");
                        AddAnotherService();
                        break;
                    }
            }

        }
        public static void AddNewAcServices(string serviceName, int amount)
        {
            acService.Add(serviceName, amount);
            Console.WriteLine("Thank you for adding services in AirConditioner");
            AddAnotherService();
        }
        public static void AddNewWashingServices(string serviceName, int amount)
        {
            washingService.Add(serviceName, amount);
            Console.WriteLine("Thank you for adding services in Washing Machine");
            AddAnotherService();
        }
        public static void AddNewPaintServices(string serviceName, int amount)
        {
            paintService.Add(serviceName, amount);
            Console.WriteLine("Thank you for adding services in Paint");
            AddAnotherService();
        }
        public static void AddNewSallonServices(string serviceName, int amount)
        {
            sallonService.Add(serviceName, amount);
            Console.WriteLine("Thank you for adding services in Sallon");
            AddAnotherService();
        }
        public static void DisplayAcServices()
        {
            Console.WriteLine("These are the various services available in Air conditioner");
            foreach (var items in acService)
            {
                Console.WriteLine(items.Key + ": " + items.Value);
            }
        }
        public static void DisplayWashingServices()
        {
            Console.WriteLine("These are the various services available in Washing Machine");
            foreach (var items in washingService)
            {
                Console.WriteLine(items.Key + ": " + items.Value);
            }
        }
        public static void DisplayPaintServices()
        {
            Console.WriteLine("These are the various services available in Paint");
            foreach (var items in paintService)
            {
                Console.WriteLine(items.Key + ": " + items.Value);
            }
        }
        public static void DisplaySallonServices()
        {
            Console.WriteLine("These are the various services available in Sallon");
            foreach (var items in sallonService)
            {
                Console.WriteLine(items.Key + ": " + items.Value);
            }
        }
        public static void Role()
        {
            try
            {
                Console.WriteLine("Choose the role:");
                Console.WriteLine("1. User");
                Console.WriteLine("2. Admin");
                Console.WriteLine("3. Exit");

                int role = Convert.ToInt32(Console.ReadLine());

                switch (role)
                {
                    case 1:
                        UserDashboard();
                        break;
                    case 2:
                        AdminDashboard();
                        break;
                    case 3:
                        Console.WriteLine("Thank you for visiting, Please visit again");
                        break;
                    default:
                        Console.WriteLine("Invalid role\nPlease enter a valid role");
                        Role();
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected exception occurred: {ex.Message}");
            }
        }

        public static void Service()
        {
            try
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
                        DisplayAcServices();
                        BookService(choice);
                        break;
                    case 2:
                        DisplayWashingServices();
                        BookService(choice);
                        break;
                    case 3:
                        DisplayPaintServices();
                        BookService(choice);
                        break;
                    case 4:
                        DisplaySallonServices();
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
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected exception occurred: {ex.Message}");
            }
        }

        public static void UserDashboard()
        {
            Console.WriteLine("Welcome to the user dashboard");
            Console.WriteLine("These are the various categories of services available. Choose the category you want to book..");
            Service();
        }
        public static void AddServices()
        {
            Console.WriteLine("1. Air Conditioner");
            Console.WriteLine("2. Washing Machine");
            Console.WriteLine("3. Painting");
            Console.WriteLine("4. Sallon");
            Console.WriteLine("5. Exit");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddNewService(choice);
                    break;
                case 2:
                    AddNewService(choice);
                    break;
                case 3:
                    AddNewService(choice);
                    break;
                case 4:
                    AddNewService(choice);
                    break;
                case 5:
                    Greetings();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    AddServices();
                    break;
            }
        }
        public static void AdminDashboard()
        {

            Console.WriteLine("Welcome to the Admin dashboard");
            Console.WriteLine("Choose the category of service you want to add");
            AddServices();
        }
        public static void Greetings()
        {
            Console.WriteLine("Thank you for visiting. Please visit again!");
        }
        public static void BookAnotherService()
        {
            try
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
                        Console.WriteLine("Invalid option. Please enter a valid option");
                        BookAnotherService();
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected exception occurred: {ex.Message}");
            }
        }

        public static void BookAcService()
        {
            AcService acService1 = new AcService();
            string serviceName = acService1.GetServiceName();

            Console.WriteLine("Choose the " + serviceName + " you want to book:");
            string userOption = Console.ReadLine();

            if (acService.Any(item => item.Key == userOption))
            {
                int value = acService[userOption];
                Console.WriteLine("How Many Air conditioner need this service?");

                try
                {
                    int noOfAirConditioner = Convert.ToInt32(Console.ReadLine());

                    double totalValues = value * noOfAirConditioner;
                    double totalValueWithGst = totalValues + totalValues * 0.05;
                    Console.WriteLine($"{userOption} has been added in the cart");
                    totalAmount += totalValueWithGst;
                    totalService.Add(userOption, totalValueWithGst);
                    BookAnotherService();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An exception occurred: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("The entered service is not available, please enter another choice");
                BookAcService();
                //GetUserService();
            }
        }

        public static void BookWashingService()
        {
            WashingMachineService washingService1 = new WashingMachineService();
            string serviceName = washingService1.GetServiceName();
            Console.WriteLine($"Choose the {serviceName} you want to book:");
            string userOption = Console.ReadLine();

            if (washingService.Any(item => item.Key == userOption))
            {
                int value = washingService[userOption];
                Console.WriteLine($"How Many Washing Machine need this service?");

                try
                {
                    int noOfWashingMachine = Convert.ToInt32(Console.ReadLine());

                    if (noOfWashingMachine < 0)
                    {
                        Console.WriteLine("Invalid input. Please enter a non-negative number.");
                    }
                    else
                    {
                        double totalValues = value * noOfWashingMachine;
                        double totalValueWithGst = totalValues + totalValues * 0.05;
                        Console.WriteLine($"{userOption} has been added in the cart");
                        totalAmount += totalValueWithGst;
                        totalService.Add(userOption, totalValueWithGst);
                        BookAnotherService();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An exception occurred: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("The entered service is not available, please enter another choice");
                BookAnotherService();
            }
        }

        public static void BookPaintService()
        {
            PaintService paintService1 = new PaintService();
            string serviceName = paintService1.GetServiceName();
            Console.WriteLine($"Choose the {serviceName} you want to book:");
            string userOption = Console.ReadLine();

            if (paintService.Any(item => item.Key == userOption))
            {
                int value = paintService[userOption];
                Console.WriteLine("How Many square feet?");

                try
                {
                    int noOfSquareFeet = Convert.ToInt32(Console.ReadLine());

                    if (noOfSquareFeet < 0)
                    {
                        Console.WriteLine("Invalid input. Please enter a non-negative number.");   
                    }
                    else
                    {
                        double totalValues = value * noOfSquareFeet;
                        double totalValueWithGst = totalValues + totalValues * 0.05;
                        Console.WriteLine($"{userOption} has been added in the cart");
                        totalAmount += totalValueWithGst;
                        totalService.Add(userOption, totalValueWithGst);
                        BookAnotherService();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An exception occurred: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("The entered service is not available, please enter another choice");
                BookAnotherService();
            }
        }

        public static void BookSallonService()
        {
            SallonService sallonService1 = new SallonService();
            string serviceName = sallonService1.GetServiceName();
            Console.WriteLine($"Choose the {serviceName} you want to book:");
            string userOption = Console.ReadLine();

            if (sallonService.Any(item => item.Key == userOption))
            {
                int value = sallonService[userOption];
                Console.WriteLine("How Many Person need this service?");

                try
                {
                    int noOfPersons = Convert.ToInt32(Console.ReadLine());

                    if (noOfPersons < 0)
                    {
                        Console.WriteLine("Invalid input. Please enter a non-negative number.");
                        // Handle the case where the input is not valid
                    }
                    else
                    {
                        double totalValues = value * noOfPersons;
                        double totalValueWithGst = totalValues + totalValues * 0.05;
                        Console.WriteLine($"{userOption} has been added in the cart");
                        totalAmount += totalValueWithGst;
                        totalService.Add(userOption, totalValueWithGst);
                        BookAnotherService();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An exception occurred: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("The entered service is not available, please enter another choice");
                BookAnotherService();
            }
        }

        public static void BookService(int choice)
        {
            try
            {
                switch (choice)
                {
                    case 1:
                        BookAcService();
                        break;
                    case 2:
                        BookWashingService();
                        break;
                    case 3:
                        BookPaintService();
                        break;
                    case 4:
                        BookSallonService();
                        break;
                    case 5:
                        Greetings();
                        break;
                    default:
                        Console.WriteLine("Invalid Option. Please enter a valid option.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected exception occurred: {ex.Message}");
            }
        }


        public static void GenerateBill()
        {
            try
            {
                Console.WriteLine($"Thank you for choosing our services! ");
                Console.WriteLine("Here is your bill:");

                foreach (var service in totalService)
                {
                    Console.WriteLine(service.Key + " " + service.Value);
                }

                Console.WriteLine($"Total Amount: {totalAmount}");
                Greetings();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected exception occurred: {ex.Message}");
            }
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


