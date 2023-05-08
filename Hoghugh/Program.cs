using Hoghugh.Services;
using Hoghugh.View;
using System;
using System.Xml.Serialization;
using Hoghugh.Models;
using System.Security.Cryptography.X509Certificates;

namespace Hoghugh
{
    class Program
    {
        static void Main(string[] args)
        {

        
        
            
            
                while (true) { 
                MainMenu.Main_menu();
                var choice = Convert.ToInt32( Console.ReadLine());                                                     
                    

                        if (choice.Equals(1))
                        {
                            EmployeeModifyMenu.EmployeeModify_menu();
                            var choice_2 = Convert.ToInt32(Console.ReadLine());
                            if (choice_2.Equals(1))
                            {
                                AdminsServices.ListAll();
                            }
                            else if (choice_2.Equals(2))
                            {
                                AdminsServices.NewEmployee();
                            }
                            else if (choice_2.Equals(3))
                            {
                                AdminsServices.UpdateEmployee();
                            }
                            else if (choice_2.Equals(4))
                            {
                                AdminsServices.DeleteEmployee();
                            }
                            else if (choice_2.Equals(5))
                            {
                                
                            }
                            
                        }
                        else if (choice.Equals(4)) 
                        {
                            return;
                        }


                    
                    
                }
               
                
            
        }
    }
}
