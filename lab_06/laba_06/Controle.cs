using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_06
{
    internal class Controle : Library
    {
        int CountTextBook = 0;
        int CostBook = 0;

        public void CheckYear (List<PrintedEdition> library, int year)
        {
            Console.WriteLine($"Книги вышедшие не раньше {year} года: ");
            for (int i = 0; i < Library.CountLibrary; i++)
            {
                if (library[i].PublisherYear > year)
                {
                    Console.WriteLine($"{library[i].NameBook}");
                }
            }
        }
        public void Count(List<PrintedEdition> library)
        {
            for (int i = 0; i < Library.CountLibrary; i++)
            {
                if (library[i] is Textbook textbook)
                {
                    CountTextBook++;
                }
            }
            Console.WriteLine($"Количество учебников: {CountTextBook}");
        }

        public void Cost(List<PrintedEdition> library)
        {
            for (int i = 0; i < Library.CountLibrary; i++)
            {
                    CostBook += library[i].Cost;
            }
            Console.WriteLine($"Цена всех книг в билиотеке: {CostBook}");
            CostBook = 0;

            for (int i = 0; i < Library.CountLibrary; i++)
            {
                if (library[i] is Textbook textbook)
                {
                    CostBook += library[i].Cost;
                }
            }
            Console.WriteLine($"Цена учебников: {CostBook}");
        }

    }
}
