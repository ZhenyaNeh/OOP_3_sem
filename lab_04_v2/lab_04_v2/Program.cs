using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab_04_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.Sleep(50);
            Book book1 = new Book("Белорусская", 2000, 10, "Борис", "Мужчина", "Фантастика");
            Textbook book2 = new Textbook("Белорусская", 3000, 20, "Борис", "Мужчина", "Фантастика");
            Magazine book3 = new Magazine("Белорусская", 2000, 10, "Борис", "Мужчина", "Фантастика");
            Author atr = new Author("Белорусская", 2000, 10, "Борис", "Мужчина");
            Magazine book4 = new Magazine(atr,  "Фантастика");

            Console.WriteLine(book1.ToString());
            Console.WriteLine(book2.ToString());
            Console.WriteLine(book3.ToString());
            Console.WriteLine(book4.ToString());

            Console.WriteLine($"Равны ли book1 и book2: {book1.Equals(book2)}");
            Author element1 = new Author("Белорусская", 2000, 10, "Борис", "Мужчина");
            Console.WriteLine($"Равны ли book1 и element1: {book1.Equals(element1)}\n");

            Console.WriteLine($"Является ли издание элемента популярным: {book2.CheckPopularity()}");
            Console.WriteLine($"Является ли издание элемента популярным: {book3.CheckPopularity()}\n");
            Console.WriteLine($"Является ли издание элемента популярным: {((ICheckPopularity)book3).CheckPopularity() }\n");


            PrintedEdition element_ref1 = new Book("Белорусская", 2000, 10, "Борис", "Мужчина", "Фантастика");
            PrintedEdition element_ref2 = new Book("Белорусская", 4000, 30, "Борис", "Мужчина", "Фантастика");
            Console.WriteLine($"Равны ли book1 и element_ref1: {book1.Equals(element_ref1)}");
            Console.WriteLine($"Является ли издание элемента популярным: {element_ref2.CheckPopularity()}\n");

            Console.WriteLine("-----------------Printed_IS-------------------");
            PrintedEdition[] all = new PrintedEdition[3];
            all[0] = new Book("Белорусская", 4000, 25, "Борис", "Мужчина", "Фантастика");
            all[1] = new Magazine("Фрузенская", 10000, 40, "Ульяна", "Женщина", "Убиство в восточном экспрессе");
            all[2] = new Textbook("Свободное", 3000, 23, "Саша", "Женщина", "Таянье льдов");

            Printer printer = new Printer();
            printer.IAmPrinting(all[0]);
            printer.IAmPrinting(all[1]);
            printer.IAmPrinting(all[2]);
        }
    }
}
