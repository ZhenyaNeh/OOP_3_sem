using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Laba_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.Sleep(50);
            Book book1 = new Book("Белорусская", 20, 2020, 15, "Гарри Поттер", "Борис", "Мужчина", "Фантастика");
            Textbook book2 = new Textbook("Белорусская", 20, 2007, 15, "Гарри Поттер", "Борис", "Мужчина", "Фантастика");
            Magazine book3 = new Magazine("Белорусская", 20, 1997, 15, "Гарри Поттер", "Борис", "Мужчина", "Фантастика");
            Author atr = new Author("Белорусская", 20, 1997, 15, "Гарри Поттер", "Борис", "Мужчина");
            Magazine book4 = new Magazine(atr,  "Фантастика");

            Console.WriteLine(book1.ToString());
            Console.WriteLine(book2.ToString());
            Console.WriteLine(book3.ToString());
            Console.WriteLine(book4.ToString());

            Console.WriteLine($"Равны ли book1 и book2: {book1.Equals(book2)}");
            Author element1 = new Author("Белорусская", 20, 1997, 15, "Гарри Поттер", "Борис", "Мужчина");
            Console.WriteLine($"Равны ли book1 и element1: {book1.Equals(element1)}\n");

            Console.WriteLine($"Является ли издание элемента популярным: {book2.CheckPopularity()}");
            Console.WriteLine($"Является ли издание элемента популярным: {book3.CheckPopularity()}\n");

            PrintedEdition element_ref1 = new Book("Белорусская", 20, 1997, 15, "Гарри Поттер", "Борис", "Мужчина", "Фантастика");
            PrintedEdition element_ref2 = new Book("Белорусская", 20, 1997, 15, "Гарри Поттер", "Борис", "Мужчина", "Фантастика");
            Console.WriteLine($"Равны ли book1 и element_ref1: {book1.Equals(element_ref1)}");
            Console.WriteLine($"Является ли издание элемента популярным: {element_ref2.CheckPopularity()}\n");

            Console.WriteLine("-----------------Printed_IS-------------------");
            PrintedEdition[] all = new PrintedEdition[3];
            all[0] = new Book("Белорусская", 20, 1997, 15, "Гарри Поттер", "Борис", "Мужчина", "Фантастика");
            all[1] = new Magazine("Белорусская", 20, 1997, 15, "Гарри Поттер", "Борис", "Мужчина", "Фантастика");
            all[2] = new Textbook("Белорусская", 20, 1998, 15, "Гарри Поттер", "Борис", "Мужчина", "Фантастика");

            Printer printer = new Printer();
            printer.IAmPrinting(all[0]);
            printer.IAmPrinting(all[1]);
            printer.IAmPrinting(all[2]);

            Console.WriteLine("\n\n-----------------Strucе_Debt-------------------");
            ClassStuct.Student student1 = new ClassStuct.Student("Eugene Nehaychik", "Поит", 2, (int)ClassStuct.PopularEnum.popular, "Наыв", "gsagsg", "dffgdg", "fdhgjdg");
            ClassStuct.Student student2 = new ClassStuct.Student("Eugene Nehaychik", "Поит", 2, (int)ClassStuct.PopularEnum.average, "Наыв", "gsagsg", "dffgdg", "fdhgjdg");
            ClassStuct.Student student3 = new ClassStuct.Student("Eugene Nehaychik", "Поит", 2, (int)ClassStuct.PopularEnum.notPopular, "Наыв", "gsagsg", "dffgdg", "fdhgjdg");
            student1.GetInformation();
            student2.GetInformation();
            student3.GetInformation();
            

            Console.WriteLine("\n\n-----------------Library-------------------");
            Library lib = new Library();
            lib.AddElement(book1);
            lib.AddElement(book2);
            lib.AddElement(book3);
            lib.AddElement(all[2]);
            lib.PrintElements();

            Controle con = new Controle();
            con.Cost(lib.library);
            con.Count(lib.library);
            con.CheckYear(lib.library, 1997);
        }
    }
}
