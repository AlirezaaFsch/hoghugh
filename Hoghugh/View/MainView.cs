using Hoghugh.DataBase;
using Hoghugh.Models;
using Hoghugh.Services;
using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hoghugh.View
{

        internal class MainMenu
    {
        private static Logger Logger = LogManager.GetCurrentClassLogger();
        static public void Main_menu()
        {
            try
            {
                Console.WriteLine("\n.................Empolyee Managment System.................\n\n");
                Console.WriteLine("Welcome To Main Menu, Please Enter Your Choice\n");
                Console.WriteLine("Press 1 to Modify Empolyees");
                Console.WriteLine("Press 4 to Exit Program");

                Console.Write("\nEnter Your Choice : ");
                var choice = Convert.ToInt32(Console.ReadLine());


                if (choice.Equals(1))
                {
                    EmployeeModifyMenu.EmployeeModify_menu();

                }
                else if (choice.Equals(4))
                {
                    LoginView.FirstMainMenu();
                }
            }
            catch (Exception ex) 
            {
                Logger.Error(ex.Message);
            }

        }

    }

    class EmployeeModifyMenu
    {
        private static Logger Logger = LogManager.GetCurrentClassLogger();
        static public void EmployeeModify_menu() 
        {
            try
            {            
            List<Employee> EmployeeList = new List<Employee>();
            EmployeeList = DataBaseServices.CsvToList();
            Console.WriteLine("1 Press");
            Console.Clear();
            Console.WriteLine("\n.................Empolyee Managment System.................\n\n");
            Console.WriteLine("Welcome To Empolyee Managment System, Please Enter Your Choice\n");
            Console.WriteLine("Press 1 to list all employees");
            Console.WriteLine("Press 2 to add a new employee");
            Console.WriteLine("Press 3 to Update employee");
            Console.WriteLine("Press 4 to Delete employee");
            Console.WriteLine("Press 5 to return to main menu");

            Console.WriteLine("\nEnter Your Choice :");
            var choice_2 = Convert.ToInt32(Console.ReadLine());
                switch (choice_2)
                {
                    case 1:
                        AdminsServices.ListAll(EmployeeList);
                        break;

                    case 2:
                        AdminsServices.NewEmployee(EmployeeList);
                        break;

                    case 3:
                        AdminsServices.UpdateEmployee(EmployeeList);
                        break;

                    case 4:
                        AdminsServices.DeleteEmployee(EmployeeList);
                        break;

                    default:
                        Console.WriteLine("Your Choice Is Not Available, Enter Again");
                        EmployeeModify_menu();
                        break;
                }
               
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
            }

        }
    }


    class EmployeeServicesMenu
    {
        private static Logger Logger = LogManager.GetCurrentClassLogger();
        static public void EmployeeServices_FirstMenu(List<Employee> EmployeeList) 
        {
            try
            {
                Console.WriteLine("\n ---------------- Employee -----------------\n\n");
                Console.WriteLine("Press 1 To Services Menu");
                Console.WriteLine("Press 2 To Exit To Main Menu");

                Console.Write("\nEnter Your Choice :");
                var choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        EmployeeServices_SecondMenu(EmployeeList);
                        break;

                    case 2:
                        LoginView.FirstMainMenu();
                        break;
                }
            }
            catch (Exception ex) 
            {
                Logger.Error(ex.Message);
            }

        }


        static public void EmployeeServices_SecondMenu(List<Employee> EmployeeList) 
        {
            try
            {
                
                EmployeeList = DataBaseServices.CsvToList();

                Console.WriteLine("\n --------------- Employee Services Menu ----------------\n\n");
                Console.WriteLine("Press 1 To Update Your Acount");
                Console.WriteLine("Press 2 To Enter Your Hours Worked In Months");
                Console.WriteLine("Press 3 To Exist To Main Menu");

                Console.Write("\nEnter Your Choice :");
                var choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        EmployeeServices.UpdateEmployeeAcount(EmployeeList);
                        DataBaseServices.ListConvertorToFile(EmployeeList);                        
                        EmployeeServices_SecondMenu(EmployeeList);                        
                        break;

                    case 2:
                        EmployeeServices.SalaryCalculator(EmployeeList);
                        break;

                    case 3:
                        EmployeeServices_FirstMenu(EmployeeList);
                        break;
                }
            }
            catch (Exception ex) 
            {
                Logger.Error(ex.Message);
            }

        }
    }



}
