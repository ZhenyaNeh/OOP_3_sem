using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //СТРОКИ
            //а. Объявите строковые литералы. Сравните их.
            string str_1 = "Hello";
            string str_2 = "World";

            if (str_1 == str_2)
                Console.WriteLine($"Строка {str_1} равна {str_2}");
            else
                Console.WriteLine($"Строка {str_1} не равна {str_2}");


            /*b. Создайте три строки на основе String. Выполните: сцепление, копирование, выделение
            подстроки, разделение строки на слова, вставки подстроки в заданную позицию, 
            удаление заданной подстроки. Продемонстрируйте интерполирование строк.*/
            String str_3 = "First";
            String str_4 = "Second";
            String str_5 = "HelloWorld!!!";
            String str_Copy;
            String str_6 = "Many words in one string";

            Console.WriteLine($"Сцепление: {str_3 + str_4}");
            str_Copy = str_4;
            Console.WriteLine($"Копирование: {str_Copy}");
            Console.WriteLine($"Выделение подстроки (с 3 позиции 3 символа 'HelloWorld!!!'): {str_5.Substring(3, 3)}");
            Console.WriteLine("Разделение на слова: ");
            String[] word_Separation = str_6.Split(' ');
            foreach (var sub in word_Separation)
                Console.WriteLine(sub);
            Console.WriteLine($"\nВставка в заданную позицию: {str_5.Insert(10, str_4)}");

            Console.WriteLine($"Удаление подстроки: {str_5.Remove(0, 5)}\n\n");

            /*c. Создайте пустую и null строку. Продемонстрируйте использование метода string.IsNullOrEmpty.
             * Продемонстрируйте что еще можно выполнить с такими строками*/
            string str7 = "";
            string str8 = null;
            string str9 = "   \t   ";
            Console.WriteLine("Это null или пустотаz:");
            string answer_1 = (String.IsNullOrEmpty(str7)) ? "yes" : "no";
            Console.WriteLine(answer_1);

            string answer_2 = (String.IsNullOrEmpty(str8)) ? "yes" : "no";
            Console.WriteLine(answer_2);

            string answer_3 = (String.IsNullOrEmpty(str9)) ? "yes\n" : "no\n";
            Console.WriteLine(answer_3);

            /*d. Создайте строку на основе StringBuilder. Удалите определенные позиции и добавьте 
             * новые символы в начало и конец строки. */

            StringBuilder str_buld = new StringBuilder("Hello Tod! Wait a bit...");
            str_buld.Remove(10, 14);
            Console.WriteLine($"{str_buld}\n");

            str_buld.Insert(0, "Wait a bit... ");
            Console.WriteLine($"{str_buld}\n");

            str_buld.Append(" How are you?");
            Console.WriteLine($"{str_buld}\n");
        }
    }
}
