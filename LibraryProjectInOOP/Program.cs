using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProjectInOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("c#", 11111, "Ahmed", "programming", 1500, "2021");
            Book book2 = new Book("English", 22222, "Adel", "Education", 1000, "2022");

            Owner owner = new Owner("yara", "3333", "owner@mylibrary.com");

            Operation operation = new Operation(444, "Menna", "6666", "operation@mylibrary.com");

            Customer customer = new Customer("Heba", 999777, "0100000", 2, "3333333", "customer@yara.com");
          
            {


                List<Book> books = new List<Book> { book1, book2 };

                Console.WriteLine("Books is:");
                foreach (Book book in books)
                {
                    book.BookInfo();

                }

                Console.WriteLine("=====================================");

                Console.WriteLine("owner information ");
                owner.OwnerInfo();
                Console.WriteLine("=====================================");

                Console.WriteLine("operation information is:");
                operation.OperationInfo();
                Console.WriteLine("=====================================");

                Console.WriteLine("customer information is:");
                customer.CustomerInfo();
                Console.WriteLine("=====================================");
                customer.BorrowedBookInfo();
                customer.BorrowBook(book2);
               customer.BorrowBook(book1);
                customer.BorrowBook(book2);
                customer.ReturnBook(book2);

                Console.ReadLine();

            }
        }
    }
}
