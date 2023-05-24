using CsvHelper;
using Hoghugh.DataBase;
using Hoghugh.Models;
using NLog;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hoghugh.View
{
    class LoginView
    {
        private static Logger Logger = LogManager.GetCurrentClassLogger();

        



        static public void FirstMainMenu()
        {
            try
            {
                List<Employee> EmployeeList = new List<Employee>();
                EmployeeList = DataBaseServices.CsvToList();

                Console.WriteLine("-------------------  Welcome  --------------------");
                Console.WriteLine(" Enter 1 For Admin Login Page  ");
                Console.WriteLine(" Enter 2 For Employee Login Page  ");
                Console.WriteLine(" Enter 3 For Exit  ");
                Console.Write("\nEnter Yout Choice : ");
                var choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AdminLogin(EmployeeList);
                        break;
                    case 2:
                        EmployeeLogin(EmployeeList);
                        break;
                    case 3:

                        break;
                }
            }
            catch (Exception ex) 
            {
                Logger.Error(ex.Message);
            }

        }



        static public void AdminLogin(List<Employee> EmployeeList)
        {
           var _obj = new Admin();
            try
            {
                Logger.Info("Attemp Login As Admin");
                Console.WriteLine("-------------------------------Login View----------------------------\n\n\n");

                Console.Write("\nEnter Username : ");
                var user = Console.ReadLine();
                Console.Write("\nEmter PassWord : ");
                var pass = Console.ReadLine();

                if (user != _obj.UserName || pass != _obj.PassWord)
                {
                    Console.WriteLine("username or password is not correct");
                    Logger.Error("Login Request Failed", DateTime.Now);
                    FirstMainMenu();
                }
                if (user == _obj.UserName && pass == _obj.PassWord)
                {
                    Console.WriteLine("welcome");
                    Logger.Info("Admin Login Succesful", _obj, DateTime.Now);
                    while (true)
                    {
                        MainMenu.Main_menu();
                    }
                }

            }
            catch (Exception ex)
            {
                Logger.Error(ex.ToString(), ex);
            }
        }




        static public void EmployeeLogin(List<Employee> EmployeeList)
        {
            try
            {                
                EmployeeList = DataBaseServices.CsvToList();
                Employee employee = new Employee();
                Console.WriteLine("-------------- Employee Login --------------");

                Console.WriteLine("Enter 1 To Login");
                Console.WriteLine("Enter 2 To Exit Into Main Menu");

                Console.Write("\nEmter Your Choice :");
                var input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.Write("\nEnter Your UserName : ");
                        var UserName = Console.ReadLine();
                        Console.Write("\nEnter Your PassWord : ");
                        var PassWord = Console.ReadLine();
                        var Emp_Info_UserName = EmployeeList.Where(e => e.UserName == UserName).FirstOrDefault();
                        var Emp_Info_PassWord = EmployeeList.Where(e => e.PassWord == PassWord).FirstOrDefault();
                        var Emp_Id = EmployeeList.Where(e => e.EmployeeIdNumber == employee.EmployeeIdNumber).FirstOrDefault();
                        Logger.Info("Employee login Attemp", UserName, PassWord); 

                        if (Emp_Info_UserName != null && Emp_Info_PassWord != null)
                        {
                            Console.WriteLine(" Welcome " );
                            Logger.Info("Employee Login Succesful", UserName, DateTime.Now);
                            EmployeeServicesMenu.EmployeeServices_FirstMenu(EmployeeList);
                            
                            
                        }
                        else if (UserName != employee.UserName || PassWord != employee.PassWord)
                        {
                            Console.WriteLine(" UserName or PassWord is not Correct");
                            Logger.Error("UserName or PassWord is not Correct");
                            EmployeeLogin(EmployeeList);
                        }
                        break;
                        
                    case 2:
                        FirstMainMenu();
                        break;
                }
               
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
            }

           


        }



    }





    /* static public void onError()
   / {

        if (user != _obj.UserName && pass != _obj.PassWord)
        {
            Console.WriteLine("username or password is not correct");
        }         

    }

    static public void onOk()
    {
        if (user == _obj.UserName || pass == _obj.PassWord)
        {
            Console.WriteLine("welcome");
        }

    }

    static public void onSubmit()
    {
        throw new NotImplementedException();
    }*/



}
