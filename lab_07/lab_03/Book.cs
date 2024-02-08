using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_07
{
    public class Book
    {
        public string Name { get; set; }
        public int CountPages { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }

        public Book (string name, int countPages, string author, int price)
        {
            Name = name;
            CountPages = countPages;
            Author = author;
            Price = price;
        }

        public override string ToString()
        {
            return $"Name: {Name} \n" +
                   $"CountPages: {CountPages} \n" +
                   $"Author: {Author} \n" +
                   $"Price: {Price} \n";
        }
    }
}
