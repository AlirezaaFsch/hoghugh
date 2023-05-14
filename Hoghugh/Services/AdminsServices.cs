using Hoghugh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Hoghugh.Services
{
    internal class AdminsServices
    {
        //public static List<Employee> EmployeeList = new List<Employee>();
        public static Admin MyAdmin = new Admin();

        public static List<Employee> EmployeeList = new List<Employee>();

        public static Employee emp = new Employee();





        static public void NewEmployee()
        {
            //Admin MyAdmin = new Admin();
            int empstocreat = 0;

            Console.WriteLine("how many employees do you want to add?");
            var empnumbers = Convert.ToInt32(Console.ReadLine());
            empstocreat = empnumbers;

            // List<Employee> EmployeeList = new List<Employee>();
            //Ad = EmployeeList;
            for (int i = 0; i < empstocreat; i++)
            {
                Console.WriteLine("enter first name");
                var Name = Console.ReadLine();

                Console.WriteLine("enter last name");
                var LastName = Console.ReadLine();

                Console.WriteLine("enter age");
                
                int Age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter ID number");
                string EmployeeIdNumber = Console.ReadLine();

                Console.WriteLine("enter team name");
                var TeamName = Console.ReadLine();

                Console.WriteLine("Enter Basic Salary");
                double BasicSalary = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter Username");
                string UserName = Console.ReadLine();

                Console.WriteLine("Enter PassWord");
                string PassWord = Console.ReadLine();
                MyAdmin.EmployeeList.Add(new Employee(Name, LastName, Age, EmployeeIdNumber, TeamName, UserName, PassWord, BasicSalary));


                Console.WriteLine("New Employee With Id number:" + emp.EmployeeIdNumber + "Added"); 
            }     


        }



        static public void ListAll()
        {
            Console.WriteLine("------------List Of Employees-------------");
            List<Employee> employeeList = MyAdmin.EmployeeList;
            foreach (Employee employee in employeeList)
            {
                Console.WriteLine($"Employee : {employee.Name},{employee.LastName},{employee.EmployeeIdNumber},{employee.TeamName},{employee.UserName},{employee.PassWord},{employee.BasicSalary}");
            }
            //Console.WriteLine("Enter your choice");
            //Console.ReadLine(); 

        }






        static public void DeleteEmployee()
        {
            Console.WriteLine("Enter The Employee ID Number");
            string IdNumber_Remover = Console.ReadLine();
            var emp_info = MyAdmin.EmployeeList.Where(e => e.EmployeeIdNumber == IdNumber_Remover);
            if (emp_info != null)
            {
                MyAdmin.EmployeeList.RemoveAll(e => e.EmployeeIdNumber == IdNumber_Remover);
                Console.WriteLine("employee succesfully deleted");
            }
            else 
            {
                Console.WriteLine("Employee With " + emp.EmployeeIdNumber + "Doesnt Exist");
                DeleteEmployee();
            }
            
            
            //Console.WriteLine("employee succesfully deleted");
            /*Console.WriteLine("Enter your Choice");
            Console.ReadLine();*/ 
            
        }








        static public void UpdateEmployee()
        {
            Console.Write("Enter Empolyee_ID for Update Empolyee Profile : ");
            string emp_id = Console.ReadLine();
            var empinfo = MyAdmin.EmployeeList.Where(e => e.EmployeeIdNumber == emp_id);
            if (empinfo != null)
            {
                emp.EmployeeIdNumber = emp_id;
                Console.Write("Enter Name : ");
                emp.Name = Console.ReadLine();
                Console.Write("Enter LastName : ");
                emp.LastName = Console.ReadLine();
                Console.Write("Enter Age : ");
                emp.Age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Team : ");
                emp.TeamName = Console.ReadLine();
                Console.Write("Enter Basic Salary : ");
                emp.BasicSalary = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter New UserName : ");
                emp.UserName = Console.ReadLine();
                Console.Write("Enter New PassWord : ");
                emp.PassWord = Console.ReadLine();



                var a = MyAdmin.EmployeeList.Where(e => e.EmployeeIdNumber == emp_id).FirstOrDefault();//.EmployeeIdNumber = emp.EmployeeIdNumber;
                a.Name = emp.Name;
                a.Age = emp.Age;
                a.LastName = emp.LastName;
                a.TeamName = emp.TeamName;
                a.BasicSalary = emp.BasicSalary;
                a.UserName = emp.UserName;
                a.PassWord = emp.PassWord;
            }
            else 
            {
                Console.WriteLine("Employee With " + emp_id + " ID Doesnt exist");
                UpdateEmployee();
            }
            //Console.WriteLine("enter your choice");
            //Console.ReadLine();
        }
    }
}
