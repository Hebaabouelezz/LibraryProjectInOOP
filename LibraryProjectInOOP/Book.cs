using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProjectInOOP
{
    public class Book
    {
        public string Name{  get;private set; }
        public int Id {  get;private set; }
        public string Author {  get;private set; }
        public string Catagory {  get;private set; }
        public double Price {  get;private set; }
        public string Year {  get;private set; }

        public Book(string name,int id,string author,string catagory,double price,string year)
        {
            this.Name = name;
            this.Id = id;
            this.Author = author;
            this.Catagory = catagory;
            this.Price = price;
            this.Year = year;
        }

        public void BookInfo()
        {
            Console.WriteLine($"Book name {this.Name} ,his Id {this.Id} ,his Author {this.Author} , his Catagory {this.Catagory} , his Price {this.Price} , in {this.Year} ");
        }
    }
}
