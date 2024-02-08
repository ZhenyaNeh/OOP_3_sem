using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace lab_09
{
    static class MyMrthod 
    {
        public static void Print (this HashSet<int> element)
        {
            Console.WriteLine("\nВывод в консоль (HashSet)");
            foreach (var num in element)
                Console.WriteLine(num);
        }

        public static void Print(this List<int> element)
        {
            Console.WriteLine("\nВывод в консоль (List)");
            foreach (var num in element)
                Console.WriteLine(num);
        }

        public static HashSet<int> RemoveRange(this HashSet<int> element, int firstElement, int countElement)
        {
            if (element.Count < 0 || element.Count < firstElement)
                throw new ArgumentOutOfRangeException();

            firstElement--;
            var el = element.ToList();
            var count = el.Count;

            for(int i = firstElement, j = 0; i < count && j < countElement; i++, j++)
            {
                el.RemoveAt(firstElement);
            }
            element = el.ToHashSet();
            
            return element;
        }

        public static void ContColl(this List<int> element, int check)
        {
            if (element.Contains(check))
                Console.WriteLine($"Коллекция содержит элемент ({check})");
            else
                Console.WriteLine($"Коллекция не содержит элемент ({check})");
        }
    }
}
