using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_10
{
    public class MyClassCost
    {
        public int CostCheck { get; set; } = 0;
        public string Expensive { get; set; } = "";
        public MyClassCost(int costCheck, string epensive)
        {
            CostCheck = costCheck;
            Expensive = epensive;
        }

        public override string ToString()
        {
            return $"Cost Check: {CostCheck}" +
                   $"Expensive: {Expensive}";
        }
    }

    public class Book
    {
        public string NameBook { get; set; }
        public string Publish { get; set; }
        public string Autor { get; set; }
        public int Year { get; set; }
        public int CountPages { get; set; }
        public int Cost { get; set; }

        public Book (string nameBook, string publish, string autor, int year, int countPages, int cost)
        {
            NameBook = nameBook;
            Publish = publish;
            Autor = autor;
            Year = year;
            CountPages = countPages;
            Cost = cost;
        }

        public Book()
        {
            NameBook = "";
            Publish =  "";
            Autor = "";
            Year = 2000;
            CountPages = 100;
            Cost = 0;
        }

        public override string ToString()
        {
            return $"Name Book: {NameBook} \n" +
                   $"Publisher: {Publish} \n" +
                   $"Autor: {Autor} \n" +
                   $"Year: {Year} \n" +
                   $"CountPages: {CountPages} \n" +
                   $"Cost: {Cost}$ \n" ;
        }
    }
}
