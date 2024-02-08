using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace lab_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CollectionType<int> myCollection = new CollectionType<int>();
            myCollection.AddList(1);
            myCollection.AddList(2);
            myCollection.AddList(3);
            myCollection.AddList(4);
            myCollection.AddList(5);
            myCollection += 6;
            myCollection -= 6;
            myCollection.ShowList();
            try
            {
                myCollection.RemoveListElement(10);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("Указано неверное значение!");
            }

            CollectionType<string> myStr = new CollectionType<string>();
            myStr.AddList("abc");
            myStr.AddList("abcd");
            myStr.AddList("abcde");
            myStr.AddList("abcdef");
            myStr.AddList("abcdefg");
            myStr += "abcdefgh";
            myStr -= "abcdefgh";
            myStr.ShowList();
            try
            {
                myStr.RemoveListElement("ijugiuy");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("Указано неверное значение!");
            }

            CollectionTypeForBook<Book> myBook = new CollectionTypeForBook<Book>();
            myBook.AddList(new Book("Гарри Поттер и философский камень", 630, "Джоан Роулинг", 10));
            myBook.AddList(new Book("Гарри Поттер и Тайная комната", 700, "Джоан Роулинг", 10));
            myBook.AddList(new Book("Гарри Поттер и узник Азкабана", 629, "Джоан Роулинг", 10));
            myBook.AddList(new Book("Гарри Поттер и Кубок огня", 567, "Джоан Роулинг", 10));
            myBook.AddList(new Book("Гарри Поттер и Орден Феникса", 673, "Джоан Роулинг", 10));
            myBook += new Book("Гарри Поттер и Принц-полукровка", 673, "Джоан Роулинг", 10);
            myBook.ShowList();

            myBook.SaveAndRead();
        }
    }
}
