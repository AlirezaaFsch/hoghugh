using Hoghugh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoghugh.Services

{
    internal class EmployeeServices
    {
        public static Employee emp = new Employee();
        public static Admin MyAdmin = new Admin();
        static public void UpdateEmployeeAcount()
        {
            Console.Write("Enter Your Employee ID : ");
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



                MyAdmin.EmployeeList.Where(e => e.EmployeeIdNumber == emp_id).FirstOrDefault().EmployeeIdNumber = emp.EmployeeIdNumber;
                MyAdmin.EmployeeList.Where(e => e.EmployeeIdNumber == emp_id).FirstOrDefault().Name = emp.Name;
                MyAdmin.EmployeeList.Where(e => e.EmployeeIdNumber == emp_id).FirstOrDefault().Age = emp.Age;
                MyAdmin.EmployeeList.Where(e => e.EmployeeIdNumber == emp_id).FirstOrDefault().LastName = emp.LastName;
                MyAdmin.EmployeeList.Where(e => e.EmployeeIdNumber == emp_id).FirstOrDefault().TeamName = emp.TeamName;
                MyAdmin.EmployeeList.Where(e => e.EmployeeIdNumber == emp_id).FirstOrDefault().BasicSalary = emp.BasicSalary;
                MyAdmin.EmployeeList.Where(e => e.EmployeeIdNumber == emp_id).FirstOrDefault().UserName = emp.UserName;
                MyAdmin.EmployeeList.Where(e => e.EmployeeIdNumber == emp_id).FirstOrDefault().PassWord = emp.PassWord;
            }
        }


        public static void SalaryCalculator()
        {

        }
    }
}
