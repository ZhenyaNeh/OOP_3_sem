using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_10
{
    static internal class StaticClass
    {
        public static void Show(this string message, IEnumerable<Book> list)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"{message}");
            Console.ForegroundColor = ConsoleColor.White;
            if (list == null)
            {
                Console.WriteLine("нету");
            }
            else
            {
                foreach (var element in list)
                {
                    Console.WriteLine(element);
                }
            }
        }

        public static void Show(this string message, IEnumerable<string> list)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"{message}");
            Console.ForegroundColor = ConsoleColor.White;
            if (list == null)
            {
                Console.WriteLine("нету");
            }
            else
            {
                foreach (var element in list)
                {
                    Console.WriteLine(element);
                }
            }
        }

    }
}
