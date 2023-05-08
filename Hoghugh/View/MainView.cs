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
        public object getInput();
        public object initView();
        public object onOk();
        public object onError();





    }
    class MainMenu
    {
        static public void Main_menu()
        {

            Console.WriteLine("\n.................Empolyee Managment System.................\n\n");
            Console.WriteLine("Welcome To Main Menu, Please Enter Your Choice\n");
            Console.WriteLine("Press 1 to modify empolyees");           
            Console.WriteLine("Press 4 to exit Program");

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
            Console.WriteLine("Welcome To Empolyee, Please Enter Your Choice\n");
            Console.WriteLine("Press 1 to list all employees");
            Console.WriteLine("Press 2 to add a new employee");
            Console.WriteLine("Press 3 to Update employee");
            Console.WriteLine("Press 4 to Delete employee");
            Console.WriteLine("Press 5 to return to main menu");

            Console.WriteLine("\nEnter Your Choice :");
        }
    }
}
