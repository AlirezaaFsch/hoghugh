using Hoghugh.DataBase;
using Hoghugh.Models;
using Hoghugh.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace Hoghugh.Services

{
    
    internal class EmployeeServices
    {
        private static Logger Logger = LogManager.GetCurrentClassLogger();
        public static Employee emp = new Employee();
 
        static public void UpdateEmployeeAcount(List<Employee> EmployeeList)
        {
            try
            {
                string emp_id = Console.ReadLine();
                EmployeeList = DataBaseServices.CsvToList();
                Logger.Info("Employee With " + emp_id + "Id Requested for Updating Profile");
                Console.Write("Enter Your Employee ID : ");

                var empinfo = EmployeeList.Where(e => e.EmployeeIdNumber == emp_id).FirstOrDefault();
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



                    var a = EmployeeList.Where(e => e.EmployeeIdNumber == emp_id).FirstOrDefault();
                    a.Name = emp.Name;
                    a.Age = emp.Age;
                    a.LastName = emp.LastName;
                    a.TeamName = emp.TeamName;
                    a.BasicSalary = emp.BasicSalary;
                    a.UserName = emp.UserName;
                    a.PassWord = emp.PassWord;
                    Console.WriteLine("Updated SuccessFully");
                }
                DataBaseServices.ListConvertorToFile(EmployeeList);
                EmployeeServicesMenu.EmployeeServices_SecondMenu(EmployeeList);
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
            }            
        }


        public static void SalaryCalculator(List<Employee> EmployeeList)
        {
            try 
            {
                Console.WriteLine("Enter Your Id Number");
                var Id = Console.ReadLine();
                var Emp_Info = EmployeeList.Where(e => e.EmployeeIdNumber == Id).FirstOrDefault();
                if (Emp_Info != null)
                {
                    Console.WriteLine("Enter Your Hours In Month");
                    emp.HoursInMonth = Convert.ToDouble( Console.ReadLine());

                    var a = EmployeeList.Where(e => e.EmployeeIdNumber == Id).FirstOrDefault();
                    a.HoursInMonth = emp.HoursInMonth;

                    var salary = a.HoursInMonth * a.BasicSalary;
                    a.Salary = salary;
                    var moz = a.Salary;
                    Console.WriteLine(salary);
                    Logger.Info("Salary Calculated ");
                    DataBaseServices.ListConvertorToFile(EmployeeList);
                }
            }
            catch (Exception ex) 
            {
                Logger.Error(ex.Message);
            }

        }
    }
}
