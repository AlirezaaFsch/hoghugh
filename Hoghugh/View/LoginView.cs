using Hoghugh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoghugh.View
{
    class LoginView : MainView
    {
        
        private User _obj;
        public object getInput()
        {
            throw new NotImplementedException();
        }

        public object initView()
        {

            Console.WriteLine("############################## Login View ##############################\n\n\n");

            Console.WriteLine("Enter Username and Password In Line seprate with #");
            var input =  Console.ReadLine().Split('#');
            _obj.username = input[0];
            _obj.password = input[1];

            Console.WriteLine("\n\n\n#######################################################################");
            return null;
        }

        public object onError()
        {
            if (_obj.username != "Admin" || _obj.password != "Admin")
            {
                Console.WriteLine("username or password is not correct");
            }
            return null;
            
        }

        public object onOk()
        {
            if (_obj.username == "Admin" && _obj.password == "Admin")
            {
                Console.WriteLine("welcome");
            }
            return null;
        }

        public object onSubmit()
        {
            throw new NotImplementedException();
        }

        public void setViewModel(object obj)
        {
            _obj = (User)obj;
        }
    }
}
