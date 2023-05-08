using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hoghugh.Services;
using Hoghugh.Models;

namespace Hoghugh.Services 
{
    class RemoveEmployee 
    {
        static public void DeleteEmployee()
        {
            Console.WriteLine("Enter The Employee ID Number");
            var IdNumber_Remover = Console.ReadLine();
            //EmployeeList (e => e.EmployeeIdNumber = IdNumber_Remover);  
        }
    }
}
