using CsvHelper;
using Hoghugh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoghugh.View
{
    class LoginView 
    {
        
        public static Admin _obj = new Admin() ;
        public string user;
        public string pass;
        public int status = 0;
        public static Employee _objEmployee = new Employee() ;


        static public void FirstMainMenu()
        {
            Console.WriteLine("-------------------  Welcome  --------------------");
            Console.WriteLine(" Enter 1 For Admin Login Page  ");
            Console.WriteLine(" Enter 2 For Employee Login Page  ");
            Console.WriteLine(" Enter 3 For Exit  ");
            Console.Write("\nEnter Yout Choice : ");
            var choice = Convert.ToInt32(Console.ReadLine());
            if (choice.Equals(1))
            {
                AdminLogin();
            }
            if (choice.Equals(2)) 
            {
                EmployeeLogin();
            }
            else if (choice.Equals(3)) 
            {
                return;
            }
        }



        static public void AdminLogin()
        {
            int status = 0;
            Console.WriteLine("############################## Login View ##############################\n\n\n");

            Console.Write("\nEnter Username : ");
            var user = Console.ReadLine();
            Console.Write("\nEmter PassWord : ");
            var pass = Console.ReadLine();

            if (user != _obj.UserName || pass != _obj.PassWord)
            {
                Console.WriteLine("username or password is not correct");
                AdminLogin();
            }
            if (user == _obj.UserName && pass == _obj.PassWord)
            {
                Console.WriteLine("welcome");
            }


            Console.WriteLine("\n\n\n#######################################################################");
        }




        static public void EmployeeLogin()
        {
            Console.WriteLine("-------------- Employee Login --------------");

            Console.WriteLine("Enter 1 To Login");
            Console.WriteLine("Enter 2 To Exit Into Main Menu");

            Console.Write("\nEmter Your Choice :");
            var input = Convert.ToInt32(Console.ReadLine());
            if (input.Equals(1))
            {


                Console.Write("\nEnter Your UserName : ");
                var UserName = Console.ReadLine();
                Console.Write("\nEnter Your PassWord : ");
                var PassWord = Console.ReadLine();

                if (UserName == _objEmployee.UserName && PassWord == _objEmployee.PassWord)
                {
                    Console.WriteLine(" Welcome " + _objEmployee.Name + " ");
                    EmployeeServicesMenu.EmployeeServices_FirstMenu();
                    /*Console.Write("\nEnter Your Choice : ");
                    var choice = Convert.ToInt32(Console.ReadLine());
                    if (choice.Equals(1))
                    {
                        
                    }*/
                }
                if (UserName != _objEmployee.UserName || PassWord != _objEmployee.PassWord)
                {
                    Console.WriteLine(" UserName or PassWord is not Correct");
                    EmployeeLogin();
                }
            }
            if (input.Equals(2))
            {

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
}
