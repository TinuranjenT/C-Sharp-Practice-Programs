using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace UrbanApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the service Booking app");
        Urban.UserDetails();
        //Urban.Service();
    }
}

public class Urban
{
    private static string userName;
    private static string userAddress;

    static int defaultPassword = 123;
    static double totalAmount = 0;

    static Dictionary<string, int> acService = new Dictionary<string, int>();
    static Dictionary<string, int> washingService = new Dictionary<string, int>();
    static Dictionary<string, int> paintService = new Dictionary<string, int>();
    static Dictionary<string, int> sallonService = new Dictionary<string, int>();
    static Dictionary<string, double> totalService = new Dictionary<string, double>();

    public static void UserDetails()
    {
        Console.WriteLine("Please enter your name:");
        string userName = Console.ReadLine();

        Console.WriteLine("Enter the Address:");
        string userAddress = Console.ReadLine();
        Service();
    }
    public static string GetName() 
    {
        return userName;
    }
    public static string GetAddress()
    {
        return userAddress;
    }
    public static void Service()
    {
        int selectedRole = DisplayRole();

        switch (selectedRole)
        {
            case 1:
                {
                    UserDashboard();
                    break;
                }
            case 2:
                {
                    AdminDashboard(defaultPassword);
                    break;
                }
            case 3:
                {
                    //Greetings();
                    Console.WriteLine("Thank you for visiting, Please visit again");
                    break;
                }
            default:
                {
                    Console.WriteLine("Invalid role\nPlease enter a valid role");
                    Service();
                    break;
                }
        } 
    }
    public static void Greetings()
    {
        Console.WriteLine("Thank you for visiting, Please visit again");
    }

    public static int DisplayRole()
    {
        Console.WriteLine("Choose the role");
        Console.WriteLine("1. User");
        Console.WriteLine("2. Admin");
        Console.WriteLine("3. Exit");

        int role = Convert.ToInt32(Console.ReadLine());
        return role;
    }
    public static void VariousServices()
    {
        int displayOption=AvailableService();
      
        switch (displayOption)
        {
            case 1:
                {
                    DisplayAcService();
                    break;
                }
            case 2:
                {
                    DisplayWashingService();
                    break;
                }
            case 3:
                {
                    DisplayPaintService();
                    break;
                }
            case 4:
                {
                    DisplaySallonService();
                    break;
                }
            case 5:
                {
                    Console.WriteLine("Thank you for visiting, Please visit again");
                    break;
                }
            default:
                {
                    Console.WriteLine("Invalid option\n Please enter a valid option");
                    VariousServices();
                    break;
                }
        }
    }
    //public static void ExitMessage()
    //{
    //    Console.WriteLine("Thank you for visiting, Please visit again");
    //}

    public static int AvailableService()
    {
        Console.WriteLine("These are the various categories of services available!");
        Console.WriteLine("Choose the category you want to see");
        Console.WriteLine("1.Air Conditioner");
        Console.WriteLine("2.Washing Machine");
        Console.WriteLine("3.Painting");
        Console.WriteLine("4.Sallon");
        Console.WriteLine("5.exit");

        int option = Convert.ToInt32(Console.ReadLine());
        return option;
    }
    public static void UserDashboard()
    {
        int userOption = DisplayUserDashboard();
     
        switch (userOption)
        {
            case 1:
                {
                    VariousServices();
                    break;
                }
            case 2:
                {
                    BookServices();
                    break;
                }
            case 3:
                {
                    Service();
                    break;
                }
            case 4:
                {
                    Console.WriteLine("Thank you for visiting, Please visit again");
                    break;
                }
            default:
                {
                    Console.WriteLine("Invalid option\nPlease enter a valid option");
                    UserDashboard();
                    break;
                }
        }
    }

    public static int DisplayUserDashboard()
    {
        Console.WriteLine("Welcome to the user dashboard");
        Console.WriteLine("Enter the choice");
        Console.WriteLine("1.Display the services");
        Console.WriteLine("2.Book the services");
        Console.WriteLine("3.Go to the role page");
        Console.WriteLine("4.Exit the page");

        int option = Convert.ToInt32(Console.ReadLine());
        return option;  
    }

    public static void AdminDashboard(int defaultPassword)
    {
        Console.WriteLine("Enter the password");
        int UserPassword = Convert.ToInt32(Console.ReadLine());

        if (defaultPassword == UserPassword)
        {
            int managerOption = DisplayManagerDashboard();
           
            switch (managerOption)
            {
                case 1:
                    {
                        VariousServices();
                        break;
                    }
                case 2:
                    {
                        AddServices();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Modify");
                        break;
                    }
                case 4:
                    {
                        Service();
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Thank you for visiting, Please visit again");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid option\nPlease enter a valid option");
                        AdminDashboard(defaultPassword);
                        break;
                    }
            }

        }
        else
        {
            Console.WriteLine("Incorrect password. Please enter the valid Password");
            AdminDashboard(defaultPassword);
        }

    }

    public static int DisplayManagerDashboard()
    {
        Console.WriteLine("Welcome to the manager dashboard");
        Console.WriteLine("Enter the choice");
        Console.WriteLine("1.Display the services");
        Console.WriteLine("2.Add the services");
        Console.WriteLine("3.Modify the service");
        Console.WriteLine("4.Go to the role page");
        Console.WriteLine("5.exit");

        int option = Convert.ToInt32(Console.ReadLine());
        return option;
    }

    public static void AddServices()
    {
        int selectedOption = ListOfServices();
        switch (selectedOption)
        {
            case 1:
                {
                    AddAcService();
                    break;
                }
            case 2:
                {
                    AddWashingService();
                    break;
                }
            case 3:
                {
                    AddPaintService();
                    break;
                }
            case 4:
                {
                    AddSallonService();
                    break;
                }
            case 5:
                {
                    AdminDashboard(defaultPassword);
                    break;
                }
            case 6:
                {
                    Service();
                    break;
                }
        }
    }

    public static int ListOfServices()
    {
        Console.WriteLine("In which category do you want to add services ?");
        Console.WriteLine("1.Air Conditioner");
        Console.WriteLine("2.Washing Machine");
        Console.WriteLine("3.Painting");
        Console.WriteLine("4.Sallon");
        Console.WriteLine("5.Move to Manager Dashboard");
        Console.WriteLine("6.Go to the role page");

        int addOption = Convert.ToInt32(Console.ReadLine());
        return addOption;
    }

    public static void AddAnotherService()
    {
        Console.WriteLine("Press 1 to add another services or 2 to exit");
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
                    Console.WriteLine("Thank you for adding the service");
                    Service();

                    break;
                }
            default:
                {
                    Console.WriteLine("Invalid input. please enter a valid input");
                    break;
                }
        }

        }

    public static void AddAcService()
    {
        Console.WriteLine("Welcome to the page");
        Console.WriteLine("You can add Ac Services here");

        //Console.WriteLine("Enter the name of the service");
        //string serviceName = Console.ReadLine();
        string serviceName =GetServiceName();

        //Console.WriteLine("Enter the amount");
        //int amount = int.Parse(Console.ReadLine());
        int amount = GetServiceAmount();

        acService.Add(serviceName, amount);
        Console.WriteLine($"{serviceName} is added with an amount of {amount}");
        AddAnotherService();

        //Console.WriteLine("Press 1 to add another services or 2 to exit");
        //int option=Convert.ToInt32(Console.ReadLine());
        //switch (option)
        //{
        //    case 1:
        //        {
        //            AddServices();
        //            break;
        //        }
        //    case 2:
        //        {
        //            Console.WriteLine("Thank you for adding the service");
        //            Service();

        //            break;
        //        }
        //    default:
        //        {
        //            Console.WriteLine("Invalid input. please enter a valid input");
        //            break;
        //        }
        //}
        //AddServices();

    }
    public static string GetServiceName()
    {
        Console.WriteLine("Enter the name of the service");
        string serviceName = Console.ReadLine();
        if(string.IsNullOrEmpty(serviceName))
        {
            Console.WriteLine("Please enter a valid service name");
            GetServiceName();
        }
        return serviceName;
    }
    public static int GetServiceAmount()
    {
        Console.WriteLine("Enter the amount");
        int amount = int.Parse(Console.ReadLine());
        if(amount < 0)
        {
            Console.WriteLine("Invalid amount.Please enter a valdi amount");
            GetServiceAmount();
        }
        return amount;

    }

    public static void AddWashingService()
    {
        Console.WriteLine("Welcome to the page");
        Console.WriteLine("You can add Washing Machine Services here");

        string serviceName = GetServiceName();

        //Console.WriteLine("Enter the name of the service");
        //string serviceName = Console.ReadLine();

        int amount = GetServiceAmount();

        //Console.WriteLine("Enter the amount");
        //int amount = int.Parse(Console.ReadLine());

        washingService.Add(serviceName, amount);
        Console.WriteLine($"{serviceName} is added with an amount of {amount}");
        AddAnotherService();

        //AddServices();

    }
    public static void AddSallonService()
    {
        Console.WriteLine("Welcome to the page");
        Console.WriteLine("You can add Sallon Services here");

        string serviceName = GetServiceName();

        //Console.WriteLine("Enter the name of the service");
        //string serviceName = Console.ReadLine();
        int amount = GetServiceAmount();

        //Console.WriteLine("Enter the amount");
        //int amount = int.Parse(Console.ReadLine());

        sallonService.Add(serviceName, amount);
        Console.WriteLine($"{serviceName} is added with an amount of {amount}");
        AddAnotherService();
        //AddServices();

    }
    public static void AddPaintService()
    {
        Console.WriteLine("Welcome to the page");
        Console.WriteLine("You can add Paint Services here");

        //Console.WriteLine("Enter the name of the service");
        //string serviceName = Console.ReadLine();
        string serviceName = GetServiceName();

        //Console.WriteLine("Enter the amount");
        //int amount = int.Parse(Console.ReadLine());
        int amount = GetServiceAmount();

        paintService.Add(serviceName, amount);
        Console.WriteLine($"{serviceName} is added with an amount of {amount}");
        AddAnotherService();
        //AddServices();
    }

    public static void NoService()
    {
        Console.WriteLine("Press 1 to see other category of services or 2 to exit");
        int option = Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
            case 1:
                {
                    VariousServices();
                    break;
                }
            case 2:
                {
                    Console.WriteLine("Thank you for visiting, Please visit again");
                    break;
                }
            default:
                {
                    Console.WriteLine("Invalid Option . Please enter a valid option");
                    NoService();
                    break;
                }
        }

    }
    public static void SeeOtherServices()
    {
        Console.WriteLine("Press 1 to see other services or 2 to go to the User Dashboard or 3 to exit");
        int option = Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
            case 1:
                {
                    VariousServices();
                    break;
                }
            case 2:
                {
                    UserDashboard();
                    break;
                }
            case 3:
                {
                    Console.WriteLine("Thank you for visiting, Please visit again");
                    break;
                }
            default:
                {
                    Console.WriteLine("Invalid Option/nPlease enter a valid option");
                    break;
                }
        }

    }
    public static void DisplayAcService()
    {
        Console.WriteLine("You have selected the Ac category");
        if (!acService.Any())
        {
            Console.WriteLine("There is no service available right now to display for this particular category");
            NoService();
        }
        else 
        { 
        Console.WriteLine("These are the various services available for this category");
        foreach (var item in acService)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
        SeeOtherServices();
        //Console.WriteLine("Press 1 to see other services or 2 to exit");
        //int option = Convert.ToInt32(Console.ReadLine());
        //    switch (option)
        //    {
        //        case 1:
        //            {
        //                VariousServices();
        //                break;
        //            }
        //        case 2:
        //            {
        //                Console.WriteLine("Thank you for visiting, Please visit again");
        //                break;
        //            }
        //        default:
        //            {
        //                Console.WriteLine("Invalid Option/nPlease enter a valid option");
        //                break;
        //            }
        //    }
        }
    }
    public static void DisplayWashingService()
    {
        Console.WriteLine("You have selected the Washing Machine category");
        if (!washingService.Any())
        {
            Console.WriteLine("There is no service available right now to display for this particular category");
            NoService();
            //Console.WriteLine("There is no service available right now, please choose after some time");
        }
        else
        {
            Console.WriteLine("These are the various services available for this category");
            foreach (var item in washingService)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
        SeeOtherServices();
        //UserDashboard();
    }
    public static void DisplayPaintService()
    {
        Console.WriteLine("You have selected the Paint category");
        if (!paintService.Any())
        {
            Console.WriteLine("There is no service available right now to display for this particular category");
            NoService();
            //Console.WriteLine("There is no service available right now, please choose after some time");
        }
        else
        {
            Console.WriteLine("These are the various services available for this category");
            foreach (var item in paintService)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
        SeeOtherServices();
        //UserDashboard();
    }
    public static void DisplaySallonService()
    {
        Console.WriteLine("You have selected the Sallon category");
        if (!sallonService.Any())
        {
            Console.WriteLine("There is no service available right now to display for this particular category");
            NoService();
            //Console.WriteLine("There is no service available right now, please choose after some time");
        }
        else
        {
            Console.WriteLine("These are the various services available for this category");
            foreach (var item in sallonService)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
        SeeOtherServices();
        //UserDashboard();
    }
    public static void BookServices()
    {
        int bookOption = BookingWindow();
       

        switch (bookOption)
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
                    AdminDashboard(defaultPassword);
                    break;
                }
            case 6:
                {
                    Service();
                    break;
                }
            case 7:
                {
                    TotalBill();
                    break;
                }
            default:
                {
                    Console.WriteLine("Invalid Option/nPlease enter a valid option");
                    BookServices();
                    break;
                }
        }

    }

    public static int BookingWindow()
    {
        Console.WriteLine("This is book service");
        Console.WriteLine("What service you want to book");
        Console.WriteLine("1.Air Conditioner");
        Console.WriteLine("2.Washing Machine");
        Console.WriteLine("3.Painting");
        Console.WriteLine("4.Sallon");
        Console.WriteLine("5.Move to Manager Dashboard");
        Console.WriteLine("6.Go to the role page");
        Console.WriteLine("7.Generate bill");

        int bookOption = Convert.ToInt32(Console.ReadLine());
        return bookOption;

    }

    public static void BookAnotherService()
    {
        Console.WriteLine("Press 1 to Book another service or 2 to generate bill");
        int option = Convert.ToInt32(Console.ReadLine());

        switch (option)
        {
            case 1:
                {
                    BookServices();
                    break;
                }
            case 2:
                {
                    TotalBill();
                    break;
                }

        }

    }

    //public static string GetUserService()
    //{
    //    Console.WriteLine("Enter the service you want");
    //    string choice = Console.ReadLine();
    //    return choice; 

    //}
    public static void BookAcService()
    {
        Console.WriteLine("Thank you for choosing Ac services");
        //DisplayAcService();
        if (!acService.Any())
        {
            Console.WriteLine("There is no service available right now, please choose after some time");
        }
        else
        {
            Console.WriteLine("These are the services available, choose any one");
            foreach (var item in acService)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            //string choice = GetUserService();

            Console.WriteLine("Enter the service you want");
            string choice = Console.ReadLine();

            if (acService.ContainsKey(choice))
            {
                int value = acService[choice];
                Console.WriteLine("How Many Air conditioner need this service?");
                int noOfAirConditioner = Convert.ToInt32(Console.ReadLine());

                double totalValue = value * noOfAirConditioner;
                double totalValueWithGst = totalValue + totalValue * 0.05;
                Console.WriteLine($"{choice} has been added in the cart");
               // Console.WriteLine(choice , value);
                totalAmount += totalValueWithGst;
                totalService.Add(choice, totalValueWithGst);
            }
            else
            {
                Console.WriteLine("The entered service is not available, please enter another choice");
                //GetUserService();
            }
            //Console.WriteLine("Press 1 to Book another service or 2 to generate bill");
            //int option = Convert.ToInt32(Console.ReadLine());

            //switch (option)
            //{
            //    case 1:
            //        {
            //            BookServices();
            //            break;
            //        }
            //    case 2:
            //        {
            //            TotalBill();
            //            break;
            //        }

            //}//BookServices();
            BookAnotherService();
        }

    }

    public static void BookWashingService()
    {
        Console.WriteLine("Thank you for choosing Washing machine services");
        if (!washingService.Any())
        {
            Console.WriteLine("There is no service available right now, please choose after some time");
        }
        else
        {
            Console.WriteLine("These are the services available, choose any one");
            foreach (var item in washingService)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            Console.WriteLine("Enter the service");
            string choice = Console.ReadLine();

            if (washingService.ContainsKey(choice))
            {
                int value = washingService[choice];
                Console.WriteLine("How Many Washing Machine need this service?");
                int noOfWashingMachine = Convert.ToInt32(Console.ReadLine());

                double totalValue = value * noOfWashingMachine;
                double totalValueWithGst = totalValue + totalValue * 0.05;
               // double totalValue = value + value * 0.05;
                Console.WriteLine($"{choice} has been added in the cart");
                totalAmount += totalValueWithGst;
                totalService.Add(choice, totalValueWithGst);
            }
            else
            {
                Console.WriteLine("The entered service is not available, please enter another choice");
            }

            //BookServices();
            BookAnotherService();
        }
    }
    public static void BookPaintService()
    {
        Console.WriteLine("Thank you for choosing Paint services");
        if (!paintService.Any())
        {
            Console.WriteLine("There is no service available right now, please choose after some time");
        }
        else
        {
            Console.WriteLine("These are the services available, choose any one");
            foreach (var item in paintService)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            Console.WriteLine("Enter the service");
            string choice = Console.ReadLine();

            if (paintService.ContainsKey(choice))
            {
                int value = paintService[choice];
                Console.WriteLine("Enter the square feet:");

                double noOfSquareFeet = Convert.ToDouble(Console.ReadLine());

                double totalValue = value * noOfSquareFeet;
                double totalValueWithGst = totalValue + totalValue * 0.05;
                //double totalValue = value + value * 0.05;

                Console.WriteLine($"{choice} has been added in the cart");
                totalAmount += totalValueWithGst;
                totalService.Add(choice, totalValueWithGst);
            }
            else
            {
                Console.WriteLine("The entered service is not available, please enter another choice");
            }
            //BookServices();
            BookAnotherService();
        }

    }
    public static void BookSallonService()
    {
        Console.WriteLine("Thank you for choosing Sallon services");
        if (!sallonService.Any())
        {
            Console.WriteLine("There is no service available right now, please choose after some time");
        }
        else
        {
            Console.WriteLine("These are the services available, choose any one");
            foreach (var item in sallonService)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            Console.WriteLine("Enter the service");
            string choice = Console.ReadLine();

            if (sallonService.ContainsKey(choice))
            {
                int value = sallonService[choice];
                Console.WriteLine("How Many Person need this service?");
                int noOfPerson = Convert.ToInt32(Console.ReadLine());

                double totalValue = value * noOfPerson;
                double totalValueWithGst = totalValue + totalValue * 0.05;
                //double totalValue = value + value * 0.05;
                Console.WriteLine($"{choice}  has been added");
                totalAmount += totalValue;
                totalService.Add(choice, totalValueWithGst);
            }
            else
            {
                Console.WriteLine("The entered service is not available, please enter another choice");
            }
            //BookServices();
            BookAnotherService();
        }

    }

    public static void TotalBill()
    {
        Console.WriteLine("Thank you for choosing these services");
        Console.WriteLine("Here is the bill with the total amount");
        if (!totalService.Any())
        {
            Console.WriteLine("No service has been added.Please add some services");
            BookServices();
        }
        else
        {
            string userName = GetName();
            string userAddress = GetAddress();
            Console.WriteLine($"Thank you {userName} for choosing these services.Here is the total bill");
            foreach (var item in totalService)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }
            Console.WriteLine($"The total amount is {totalAmount}");
            Console.WriteLine($"The delievery address is {userAddress}");
            Console.WriteLine("Thank you, Visit again");
        }
    }
}