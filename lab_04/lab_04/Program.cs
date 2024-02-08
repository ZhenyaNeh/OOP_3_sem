using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Textbook book = new Textbook(3000, "Белорусское", "Яна", 560, "Fantastic");
            Textbook book1 = new Textbook(3000, "Белорусское", "Яна", 560, "Fantastic");
            Author book2 = new Author(3000, "Белорусское", "Яна");
            Console.WriteLine(book.ToString());
            Console.WriteLine($"Равны ли book и book {book.Equals(book1)}");
            Console.WriteLine($"Равны ли book и book {book.Equals(book2)}\n");

            PrintedEdition element = new Book(2000, "Белорусское", "Яна", 560, "Fantastic");
            PrintedEdition element1 = new Textbook(3000, "Белорусское", "Егор Поле", 4688, "Fantastic");
            Console.WriteLine($"Равны ли book и book {element.Equals(element1)}");

            Console.WriteLine($"является ли издание элемента популярным: {element.Popular()}");
            Console.WriteLine($"является ли издание элемента популярным: {element1.Popular()}\n");


            Console.WriteLine("-----------------Printed_IS-------------------");
            PrintedEdition[] all = new PrintedEdition[3];
            all[0] = new Book(3000, "Белорусское", "Егор Поле", 4688, "Fantastic");
            all[1] = new Magazine(5000, "Свободное", "Татьяна Брива", 6626, "Fantastic");
            all[2] = new Textbook(6000, "Минское", "Трафим Лувр", 7488, "Fantastic");

            Printer printer = new Printer();
            printer.IAmPrinting(all[2]);
            printer.IAmPrinting(all[1]);
            printer.IAmPrinting(all[0]);
        }
    }
}
