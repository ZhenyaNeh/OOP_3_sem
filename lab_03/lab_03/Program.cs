using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_03
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List.LinkedList<int> list1 = new List.LinkedList<int>();
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            Console.WriteLine(list1.ToString());

            List.LinkedList<int> list2 = new List.LinkedList<int>();
            list2.Add(1);
            list2.Add(2);
            list2.Add(4);
            Console.WriteLine(list2.ToString());

            Console.WriteLine(list1[1]); // индексатор

            // использование оператора >> для удаления элемента из list1 по индексу 0
            list1 = list1 >> 0;
            Console.WriteLine(list1.ToString());

            // использование оператора + для добавления элемента 5 в list2 на позицию 2 по индексу 1
            list2 = list2 + (5, 1);
            Console.WriteLine(list2.ToString());

            // использование оператора != для проверки на неравенство множеств
            bool notEqual = list1 != list2;
            Console.WriteLine("Списки не равны? " + notEqual);

            bool notEqual2 = list1 != list1;
            Console.WriteLine("Списки не равны? " + notEqual2);

            //////////////////////////////////////////////////////////

            Production prod1 = new Production
            {
                OrganizationName = "BSTU"
            };

            Production prod2 = new Production("EPAM");

            List.Developer dev1 = new List.Developer
            {
                Name = "Ковалева Е.А",
                Department = "IT"
            };
            List.Developer dev2 = new List.Developer("Соколов Ю.М.", "IT");

            //////////////////////////////////////////////////////////

            Console.WriteLine(StatisticOperation.Summa(list1));
            Console.WriteLine(StatisticOperation.CountOfElements(list2));
            Console.WriteLine(StatisticOperation.DifferentBetwinMaxAndMin(list2));

            List.LinkedList<string> list3 = new List.LinkedList<string>();
            list3.Add("Пgивет");
            list3.Add("Хай");
            list3.Add("Hello");
            list3.Add("Пgив");
            Console.WriteLine(list3.ToString());
            
            Console.WriteLine(list3.SerchLenght());

            list3.RemoteLastElement();
            Console.WriteLine(list3.ToString());
        }
    }
}
