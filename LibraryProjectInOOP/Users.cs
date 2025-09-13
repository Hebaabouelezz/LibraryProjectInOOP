using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProjectInOOP
{
    public abstract class Users
    {
        public  string Name { get; }
        
        

        public Users(string name)
        {
           this.Name = name;
           

        }

        public void UserInfo() {

            Console.WriteLine($"Name :{this.Name}");
        }
    }
}
