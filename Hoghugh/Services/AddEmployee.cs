using Hoghugh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hoghugh.Services
{
    class AddEmployee
    { 
        
        static public void NewEmploye()
        {
            int empstocreat = 0;

            Console.WriteLine("how many employees do you want to add?");
            var empnumbers = Convert.ToInt32(Console.ReadLine());
            empstocreat = empnumbers;

            List<Employee> EmployeeList = new List<Employee>();
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
                EmployeeList.Add(new Employee(Name, LastName, Age, EmployeeIdNumber, TeamName, UserName, PassWord, BasicSalary));

                
            }
            


            foreach (Employee employee in EmployeeList)
            {
                Console.WriteLine("Employee : {0},{1},{3},{4},{5},{6},{7}", employee.Name, employee.LastName, employee.Age , employee.EmployeeIdNumber, employee.TeamName , employee.UserName , employee.PassWord , employee.BasicSalary);
            }
        }

    }
}
    
