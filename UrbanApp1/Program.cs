//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace UrbanApp
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Welcome to the service Booking app");
//            User user1 = new User();
//            user1.UserDetails();

//        }
//    }

//    class User
//    {
//        private string userName;
//        private string userAddress;
//        static int defaultPassword = 123;

//        public User()
//        {
//            Console.WriteLine("User Object created");
//        }

//        public User(string name, string address)
//        {
//            userName = name;
//            userAddress = address;
//            Console.WriteLine($"User Object created with name:{userName}, address: {userAddress}");
//        }
//        public void UserDetails()
//        {
//            Console.WriteLine("Please enter your name:");
//            userName = Console.ReadLine();

//            Console.WriteLine("Enter the Address:");
//            userAddress = Console.ReadLine();
//            Service();
//        }
//        public void Service()
//        {
//            int selectedRole = DisplayRole();

//            switch (selectedRole)
//            {
//                case 1:
//                    {
//                        UserDashboard();
//                        break;
//                    }
//                case 2:
//                    {
//                        AdminDashboard(defaultPassword);
//                        break;
//                    }
//                case 3:
//                    {
//                        Console.WriteLine("Thank you for visiting, Please visit again");
//                        break;
//                    }
//                default:
//                    {
//                        Console.WriteLine("Invalid role\nPlease enter a valid role");
//                        Service();
//                        break;
//                    }
//            }

//        }
//        public static int DisplayRole()
//        {
//            Console.WriteLine("Choose the role");
//            Console.WriteLine("1. User");
//            Console.WriteLine("2. Admin");
//            Console.WriteLine("3. Exit");

//            int role = Convert.ToInt32(Console.ReadLine());
//            return role;
//        }
//         public static void UserDashboard()
//    {
//        int userOption = DisplayUserDashboard();
     
//        switch (userOption)
//        {
//            case 1:
//                {
//                    VariousServices();
//                    break;
//                }
//            case 2:
//                {
//                    BookServices();
//                    break;
//                }
//            case 3:
//                {
//                    Service();
//                    break;
//                }
//            case 4:
//                {
//                    Console.WriteLine("Thank you for visiting, Please visit again");
//                    break;
//                }
//            default:
//                {
//                    Console.WriteLine("Invalid option\nPlease enter a valid option");
//                    UserDashboard();
//                    break;
//                }
//        }
//    }

//    class Admin()
//    {

//    }
// }
