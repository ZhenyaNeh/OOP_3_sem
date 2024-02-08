using System;
using My_Name;

namespace laba_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Создайте несколько объектов вашего типа. Выполните вызов 
           конструкторов, свойств, методов, сравнение объекты, проверьте тип 
           созданного объекта и т.п. */
            Book book_1 = new Book("Jule Vern", "Путешествие к центру Земли", "Belarus", 18, "Hard cover");
            Book book_2 = new Book();
            Book book_3 = new Book(1);

            Console.WriteLine(book_1.ToString());
            Console.WriteLine("------------------------------------------");
            Console.WriteLine(book_2.ToString());
            Console.WriteLine("------------------------------------------");
            Console.WriteLine(book_3.ToString());
            Console.WriteLine("------------------------------------------");

            Console.WriteLine($"book_1 равен book_2? - {book_1.Equals(book_2)}");
            Console.WriteLine($"Тип book_1 - {book_1.GetType()}");

            string name_Old_Biding_Type = book_1.name_Biding_Type;
            Console.WriteLine($"\n Изменим тип оплетки in book_1: {book_1.name_Biding_Type}");
            book_1.Chenge_Biding_Type(ref name_Old_Biding_Type, "light cover");
            Console.WriteLine($"Now book_1: {name_Old_Biding_Type}\n");

            string name_Old_Autors = book_1.name_Autors;
            Console.WriteLine($"\n Изменим тип оплетки in book_1: {book_1.name_Autors}");
            book_1.Chenge_Autors(out name_Old_Autors, "evgesha");
            Console.WriteLine($"Now book_1: {name_Old_Autors}\n");

            /*Создайте массив объектов вашего типа. И выполните задание, 
            выделенное курсивом в таблице.*/
            Console.WriteLine("------------------------------------------");
            var books = new Book[6];
            books[0] = new Book("Jule Vern", "Путешествие к центру Земли", "Belarus", 18, "Hard cover", 1864, 600);
            books[1] = new Book("Jule Vern", "Вокруг света за 80 дней", "Belarus", 25, "light cover", 1872, 698);
            books[2] = new Book("Jule Vern", "Двадцать тысяч льё под водой", "Belarus", 24, "Hard cover", 1970, 248);
            books[3] = new Book("Mark Tven", "Что такое человек?", "Belarus", 14, "Hard cover", 1906, 500);
            books[4] = new Book("Mark Tven", "Таинственный незнакомец", "Belarus", 25, "light cover", 1916, 1);
            books[5] = new Book("Mark Tven", "Приключения Тома Сойера", "Rassia", 34, "Hard cover", 1876, 365);

            //a) список книг заданного автора;
            string check_Autor = "Jule Vern";

            Console.WriteLine($"У выбранного автора ({check_Autor}) есть произведения: \n");
            foreach (var book in books)
                if (book.name_Autors == check_Autor)
                {
                    Console.WriteLine(book.name_Bookssssss);
                }
            Console.WriteLine('\n');

            //список книг, выпущенных после заданного года
            int check_Year_After = 1900;

            Console.WriteLine($"Произведения выпущенные после {check_Year_After}: \n");
            foreach (var book in books)
                if (book.name_Publishing_Year > check_Year_After)
                {
                    Console.WriteLine(book.name_Bookssssss);
                }
            Console.WriteLine('\n');

            
        }
    }
}
   