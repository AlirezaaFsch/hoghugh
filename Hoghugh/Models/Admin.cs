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
        public int UserName { get; set; }
        public int PassWord { get; set; }
        

    }
}
