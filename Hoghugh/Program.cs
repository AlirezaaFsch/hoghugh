using Hoghugh.Services;
using Hoghugh.View;
using System;
using System.Xml.Serialization;
using Hoghugh.Models;
using System.Security.Cryptography.X509Certificates;
using Hoghugh.DataBase;
using System.Collections.Generic;
using NLog;

namespace Hoghugh
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {                
                LoginView.FirstMainMenu();
            }                                     
         }        
    }
}
