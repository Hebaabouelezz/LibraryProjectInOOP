using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProjectInOOP
{
    public class Owner:Users
    {
        public string Password { get; set; }
        public string Email { get; set; }

        public Owner(string name,string password, string email):base(name) {
        
           this. Password = password;
           this. Email = email;
        }

        public override void UserInfo()
        {
           base.UserInfo();
            Console.WriteLine($"password :{this.Password}, Email :{this.Email}");

        }
    }
}

