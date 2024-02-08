using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace laba_06
{
    public static class redError
    {
        public static void redColor()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Ошибка!");
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
    internal class Program
    {
       

        static void Main(string[] args)
        {
            System.Threading.Thread.Sleep(50);

            Book book1 = new Book("Белорусская", 20, 2020, 15, "Гарри Поттер", "Борис", "Мужчина", "Фантастика");
            Textbook book2 = new Textbook("Белорусская", 20, 2007, 15, "Гарри Поттер", "Борис", "Мужчина", "Фантастика");
            Magazine book3 = new Magazine("Белорусская", 20, 1997, 15, "Гарри Поттер", "Борис", "Мужчина", "Фантастика");
            Author atr = new Author("Белорусская", 20, 1997, 15, "Гарри Поттер", "Борис", "Мужчина");
            Magazine book4 = new Magazine(atr, "Фантастика");

            book1.ToString();
            book2.ToString();
            book3.ToString();
            book4.ToString();

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

            Console.WriteLine("\n\n-----------------Struct_Debt-------------------");
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


            ////////////////////////////////Laba_06///////////////////////////////////////
            /*2)*/
            try
            {
                Book testException1 = new Book("Белорусская", -12, 2023, 15, "Гарри Поттер", "Борис", "Мужчина", "Фантастика");

            }
            catch (CountOfCopiesException ex)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write("Ошибка!");
                Console.BackgroundColor = ConsoleColor.Black;
                
                Console.WriteLine($"\n{ex.Message}");
                Console.WriteLine($"Значение {ex.Value} введено некорректно\n");
            }

            try
            {
                Book testException2 = new Book("Белорусская", 20, 2024, 15, "Гарри Поттер", "Борис", "Мужчина", "Фантастика");
            }
            catch (PublisherYearException ex)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write("Ошибка!");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine($"\n{ex.Message}\n");
            }

            try
            {
                Book testException3 = new Book("Белорусская", 20, 2023, -1, "Гарри Поттер", "Борис", "Мужчина", "Фантастика");
            }
            catch (CostException ex)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write("Ошибка!");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine($"\n{ex.Message}");
                Console.WriteLine($"Значение {ex.Value} введено некорректно\n");
            }

            try
            {
                Book testException4 = new Book("Белорусская", 20, 2023, 15, "", "Борис", "Man", "Фантастика");
            }
            catch (StringException ex)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write("Ошибка!");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine($"\n{ex.Message}\n");
            }

            try
            {
                Book testException5 = new Book("fefsgre", 20, 2023, 15, "gewr", "Борис", "Enpti", "Фантастика");
            }
            catch (TestException ex)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write("Ошибка!");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine($"\n {ex.Message} \n");
            }
            /*3)*///--------------------
            catch 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Использован Универсальный обработчик");
                Console.ForegroundColor = ConsoleColor.White;
            }
            /*4)*/
            finally
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Использован блок Finally\n");
                Console.ForegroundColor = ConsoleColor.White;
            }

            /*5)*/
            try
            {
                DoSomething();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Главный обработчик исключений снаружи DoSomething: {ex.Message}");
                Console.WriteLine($"{ex.TargetSite}");
                Console.WriteLine($"{ex.StackTrace}\n");
            }
            finally
            {
                Console.WriteLine("Исключения отловленны в Finally");
            }
            void DoSomething()
            {
                try
                {
                    int x = 10;
                    int y = 0;
                    int h = y / x;
                    int result = x / y;
                }
                catch (DivideByZeroException ex) 
                {
                    Console.WriteLine($"Обработчик исключений внутри DoSomething: {ex.Message}");
                    Console.WriteLine($"{ex.TargetSite}");
                    Console.WriteLine($"{ex.StackTrace}\n");
                    throw;
                }
            }

            int num = 25;
            Debug.Assert( num > 0, "Num меньше нуля" );

        }
    }
}
