using System;
using System.Collections;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using Hoghugh.Models;
using Hoghugh.Services;
using Hoghugh.View;

namespace Hoghugh.DataBase
{
    internal class DataBaseServices
    {
        public static Admin MyAdmin = new Admin();

        



        static public void ListConvertorToFile(List<Employee> EmployeeList)
        {
            var output = "C:\\Users\\Academy 7\\Desktop\\New folder\\hoghugh\\Employee.csv";
            using var writer = new StreamWriter(output);
            using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
            csv.WriteRecords(EmployeeList);
        }

        public static List<Employee> CsvToList()
        {
            var input = "C:\\Users\\Academy 7\\Desktop\\New folder\\hoghugh\\Employee.csv";
            using var reader = new StreamReader(input);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            List<Employee> employees = csv.GetRecords<Employee>().ToList();
            List<Employee> EmployeeList = employees;
            return EmployeeList;
        }
    }
}
