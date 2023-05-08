using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hoghugh.Models;
using Hoghugh.Services;
using Hoghugh.View;

namespace Hoghugh.DataBase
{
    internal class DataBaceServices
    {
        public static Admin MyAdmin = new Admin();

        public static List<Employee> EmployeeList = new List<Employee>();



        static public void ListConvertorToFile()
        {
            System.IO.File.WriteAllLines("SavedList.txt", (IEnumerable<string>)MyAdmin.EmployeeList );
        }
    }
}
