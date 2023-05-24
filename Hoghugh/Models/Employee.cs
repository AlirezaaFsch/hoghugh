using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoghugh.Models
{
    class Employee 
    {
        public Employee()
        {

        }

        public Employee(string name, string lastname, int age, string idnumber, string team, string username, string password, double basicSalary )
        {
            this.Name = name;
            this.LastName = lastname;
            this.Age = age;
            this.EmployeeIdNumber = idnumber;
            this.TeamName = team;
            this.UserName = username;
            this.PassWord = password;
            this.BasicSalary = basicSalary;
        }

        public bool IsEmployee { get; set; }
        public double Salary { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string EmployeeIdNumber { get; set; }
        public string TeamName { get; set; }
        public double BasicSalary { get; set; }
        public double HoursInMonth { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }

    }
}
