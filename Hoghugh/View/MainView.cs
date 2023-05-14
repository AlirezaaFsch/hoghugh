using Hoghugh.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoghugh.View
{
    interface MainView
    {
        public void setViewModel(object obj);
    }
    class MainMenu
    {
        static public void Main_menu()
        {

            Console.WriteLine("\n.................Empolyee Managment System.................\n\n");
            Console.WriteLine("Welcome To Main Menu, Please Enter Your Choice\n");
            Console.WriteLine("Press 1 to Modify Empolyees");           
            Console.WriteLine("Press 4 to Exit Program");

            Console.Write("\nEnter Your Choice : ");
            
        }

    }

    class EmployeeModifyMenu
    {
        static public void EmployeeModify_menu() 
        {
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
        }
    }


    class EmployeeServicesMenu
    {
        static public void EmployeeServices_FirstMenu() 
        {
            Console.WriteLine("\n ---------------- Employee -----------------\n\n");
            Console.WriteLine("Press 1 To Services Menu");
            Console.WriteLine("Press 2 To Exit To Main Menu");

            Console.Write("\nEnter Your Choice :");
            var choice = Convert.ToInt32(Console.ReadLine());
            if (choice.Equals(1))
            {
                EmployeeServices_SecondMenu();
            }
            if (choice.Equals(2))
            {
                LoginView.FirstMainMenu();
            }

        }


        static public void EmployeeServices_SecondMenu() 
        {
            Console.WriteLine("\n --------------- Employee Services Menu ----------------\n\n");
            Console.WriteLine("Press 1 To Update Your Acount");
            Console.WriteLine("Press 2 To Enter Your Hours Worked In Months");

            Console.Write("\nEnter Your Choice :");
            var choice = Convert.ToInt32(Console.ReadLine());
            if (choice.Equals(1)) 
            {
                EmployeeServices.UpdateEmployeeAcount();
            }

        }
    }


}
