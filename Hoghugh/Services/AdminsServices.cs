using Hoghugh.DataBase;
using Hoghugh.Models;
using NLog;
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
        private static Logger Logger = LogManager.GetCurrentClassLogger();               
        static public List<Employee> NewEmployee(List<Employee> EmployeeList)
        {
            try
            {
                var emp = new Employee();

                int empstocreat = 0;

                Console.WriteLine("how many employees do you want to add?");
                var empnumbers = Convert.ToInt32(Console.ReadLine());
                empstocreat = empnumbers;


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
                    var Emp_info = EmployeeList.Where(e => e.EmployeeIdNumber == EmployeeIdNumber).FirstOrDefault();
                    Logger.Info("Employee Created {@Employee} at {now}", Emp_info, DateTime.Now);

                    Console.WriteLine("New Employee With Id number:" + emp.EmployeeIdNumber + "Added");
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
            }
            DataBaseServices.ListConvertorToFile(EmployeeList);
            return EmployeeList;


        }



        static public void ListAll(List<Employee> EmployeeList)
        {
            try
            {
                Console.WriteLine("------------List Of Employees-------------");
                //List<Employee> employeeList = MyAdmin.EmployeeList;
                foreach (Employee employee in EmployeeList)
                {
                    Console.WriteLine($"Employee : {employee.Name},{employee.LastName},{employee.EmployeeIdNumber},{employee.TeamName},{employee.UserName},{employee.PassWord},{employee.BasicSalary}");
                }
                Logger.Info("Requested The List Of All Employees", DateTime.Now);
            }
            catch (Exception ex) 
            {
                Logger.Error(ex.Message);
            }
            //Console.WriteLine("Enter your choice");
            //Console.ReadLine(); 

        }






        static public void DeleteEmployee(List<Employee> EmployeeList)
        {
            try
            {
                Console.WriteLine("Enter The Employee ID Number");
                string IdNumber_Remover = Console.ReadLine();
                var emp_info = EmployeeList.Where(e => e.EmployeeIdNumber == IdNumber_Remover).FirstOrDefault();
                if (emp_info != null)
                {
                    EmployeeList.RemoveAll(e => e.EmployeeIdNumber == IdNumber_Remover);
                    Console.WriteLine("employee succesfully deleted");
                    DataBaseServices.ListConvertorToFile(EmployeeList);
                    Logger.Info("Employee Deleted {@Employee} at {now}", emp_info);
                }
                else
                {
                    Console.WriteLine("Employee With ID  " + IdNumber_Remover + "  Doesnt Exist");
                    DeleteEmployee(EmployeeList);
                    Logger.Error("Employee with id : " + IdNumber_Remover + " Doesnt Exist");
                }
            }
            catch (Exception ex) 
            {
                Logger.Error(ex.Message);
            }


            //Console.WriteLine("employee succesfully deleted");
            /*Console.WriteLine("Enter your Choice");
            Console.ReadLine();*/

        }








        static public void UpdateEmployee(List<Employee> EmployeeList)
        {
            var emp = new Employee();
            try
            {
               
                Console.Write("Enter Empolyee_ID for Update Empolyee Profile : ");
                string emp_id = Console.ReadLine();
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



                    var a = EmployeeList.Where(e => e.EmployeeIdNumber == emp_id).FirstOrDefault();//.EmployeeIdNumber = emp.EmployeeIdNumber;
                    a.Name = emp.Name;
                    a.Age = emp.Age;
                    a.LastName = emp.LastName;
                    a.TeamName = emp.TeamName;
                    a.BasicSalary = emp.BasicSalary;
                    a.UserName = emp.UserName;
                    a.PassWord = emp.PassWord;

                    DataBaseServices.ListConvertorToFile(EmployeeList);

                    Logger.Info("Employee Updated {@Employee} at {now}", empinfo, DateTime.Now);
                }
                else
                {
                    Logger.Error("Employee With " + emp_id + " ID Doesnt exist", DateTime.Now);
                    UpdateEmployee(EmployeeList);
                }
            }
            catch (Exception ex) 
            {
                Logger.Error(ex);
            }

            //Console.WriteLine("enter your choice");
            //Console.ReadLine();
        }
    }
}
