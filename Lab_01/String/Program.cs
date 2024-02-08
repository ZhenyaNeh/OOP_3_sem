using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //СТРОКИ
            //а. Объявите строковые литералы. Сравните их.
            string str1 = "Hello";
            string str2 = "World";

            Console.WriteLine("--------------------------------------------------------------");
            if (str1 == str2)
                Console.WriteLine($"Строка {str1} равна {str2}");
            else
                Console.WriteLine($"Строка {str1} не равна {str2}");

            /*b. Создайте три строки на основе String. Выполните: сцепление, копирование, выделение подстроки,
             * разделение строки на слова, вставки подстроки в заданную позицию, удаление заданной
               подстроки. Продемонстрируйте интерполирование строк.*/
            String str3 = "First";
            String str4 = "Second";
            String str5 = "Third";
            String strBuff;
            String str6 = "Many words  in one string";

            Console.WriteLine($"Сцепление: {str3 + str4}");

            strBuff = str4;
            Console.WriteLine($"Копирование: {strBuff}");

            Console.WriteLine($"Выделение подстроки (с 1 по 3 позицию из строки 'Third'): {str5.Substring(1, 3)}");

            Console.WriteLine("Разделение на слова: ");
            String[] wordsFromString = str6.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (String s in wordsFromString)
                Console.WriteLine(s);

            Console.WriteLine($"\nВставка в заданную позицию (строку Second в строку First со 2 позиции): {str3.Insert(2, str4)}");
            Console.WriteLine($"Удаление подстроки (с 0 по 11 символ из строки 'Many words in one string'): {str6.Remove(0, 11)}");

            /*c. Создайте пустую и null строку. Продемонстрируйте использование метода string.IsNullOrEmpty.
             * Продемонстрируйте что еще можно выполнить с такими строками*/
            string str7 = "";
            string str8 = null;
            string str9 = "   \t   ";

            if (String.IsNullOrEmpty(str7))
                Console.WriteLine("Str7 пустая или null-строка");
            else
                Console.WriteLine("Str7 не null-строка или не пустая");


            if (String.IsNullOrEmpty(str8))
                Console.WriteLine("Str8 пустая или null-строка");
            else
                Console.WriteLine("Str8 не null-строка или не пустая");

            if (String.IsNullOrEmpty(str9))
                Console.WriteLine("Str9 пустая или null-строка");
            else
                Console.WriteLine("Str9 не null-строка или не пустая");

            if (String.IsNullOrWhiteSpace(str7))
                Console.WriteLine("Str7 пустая или null-строка или строка из пробелов");
            else
                Console.WriteLine("Str7 не null-строка или не пустая");

            if (String.IsNullOrWhiteSpace(str8))
                Console.WriteLine("Str8 пустая или null-строка или строка из пробелов");
            else
                Console.WriteLine("Str8 не null-строка или не пустая");

            if (String.IsNullOrWhiteSpace(str9))
                Console.WriteLine("Str9 пустая или null-строка или строка из пробелов");
            else
                Console.WriteLine("Str9 не null-строка или не пустая");
            /*d. Создайте строку на основе StringBuilder. Удалите определенные позиции и добавьте 
             * новые символы в начало и конец строки. */

            StringBuilder str10 = new StringBuilder(" an old");
            str10.Remove(2, 5);
            str10.Insert(0, "This is");
            str10.Append(" new string");
            Console.WriteLine(str10);

        }
    }
}
