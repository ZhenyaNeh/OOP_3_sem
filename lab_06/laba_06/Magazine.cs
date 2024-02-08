using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_06
{
    sealed internal class Magazine : PrintedEdition, ICheckPopularity
    {
        internal string NameMagazine { get; set; }
        public Author author;
        internal Magazine (string NamePublisher, int CountOfCopies, int PublisherYear, int Cost, string NameBook, string NameAuthor, string Gender, string NameMagazine)
            : base(NamePublisher, CountOfCopies, PublisherYear, Cost,NameBook, NameAuthor, Gender)
        {
            this.NameMagazine = NameMagazine;
        }

        internal Magazine(Author author, string NameMagazine) : base(author.NamePublisher, author.CountOfCopies, author.PublisherYear, author.Cost, author.NameBook, author.NameAuthor, author.Gender)
        {
            this.NameMagazine = NameMagazine;
        }

        bool ICheckPopularity.CheckPopularity()
        {
            return CountOfCopies >= 3000;
        }

        internal override bool CheckPopularity()
        {
            if (CountOfCopies >= 3000 && PublisherYear >= 20)
                return true;

            return false;
        }

        public override string ToString()
        {
            Console.WriteLine("".PadLeft(15, '_') + "magazine" + "".PadLeft(15, '_'));
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(
                $"Название идателя: {_NamePublisher} \n" +
                $"Количество копий: {_CountOfCopies} \n" +
                $"Год издания: {_PublisherYear} \n" +
                $"Цена: {_Cost} \n" +
                $"Имя автора: {_NameAuthor} \n" +
                $"Жанр: {NameMagazine} \n");
            Console.ForegroundColor = ConsoleColor.White;

            return $"Название идателя: {_NamePublisher} \n" +
                   $"Количество копий: {_CountOfCopies} \n" +
                   $"Год издания: {_PublisherYear} \n" +
                   $"Цена: {_Cost} \n" +
                   $"Имя автора: {_NameAuthor} \n" +
                   $"Жанр: {NameMagazine} \n";
        }
    }
}
