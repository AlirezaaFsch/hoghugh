using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoghugh.Models
{
    internal class Admin : User
    {
        public List<Employee> EmployeeList = new List<Employee>();
        public string UserName = "Admin";
        public string PassWord = "Admin";

    }
}
