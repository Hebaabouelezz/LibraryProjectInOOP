using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProjectInOOP
{
    public class Operation:Owner
    {
       public int Id { get; set; }
        public Operation(int id,string name, string password, string email) : base(name,password,email)
        {

            this.Id = id;
        }

        public void OperationInfo()
        {
            OwnerInfo();
            Console.WriteLine($"Id :{this.Id}");

        }
    }
}
