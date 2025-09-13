using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProjectInOOP
{
    public class Customer:Operation
    {
        public int BorrowLimit { get; set; }
        public string PhoneNumber { get; set; }

        public List<Book>borrowedBooks=new List<Book>();

        public Customer (string name, int id,string phoneNumber,int borrowLimit ,string password,string email):base(id, name, password, email)
        {
            this.BorrowLimit = borrowLimit;
            this.PhoneNumber = phoneNumber;
        }

        public void CustomerInfo()
        {
            OperationInfo();
            Console.WriteLine($"borrowlimit :{this.BorrowLimit}");
            
        }
         public  void BorrowBook(Book book)
        {
            if (borrowedBooks.Count < BorrowLimit)
            {
                borrowedBooks.Add(book);
                Console.WriteLine($"{this.Name} borrowed {book.Name} book");
            }
            else
            {
                Console.WriteLine("you pass the borrow limit");
            }

        }

        public void ReturnBook(Book book)
        {
            if (borrowedBooks.Remove(book))
            {
                Console.WriteLine($"{this.Name} return {book.Name} book");
            }
            }
        public void BorrowedBookInfo()
        {
            Console.WriteLine("borrowed books:");
            foreach (Book book in borrowedBooks)
            {
                Console.WriteLine(book.Name);
            }
        }


    }
}
