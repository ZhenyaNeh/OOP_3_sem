using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace laba_06
{
    sealed internal class Textbook : PrintedEdition, ICheckPopularity
    {
        internal string NameTextBook { get; set; }
        public Author author;

        internal Textbook(string NamePublisher, int CountOfCopies, int PublisherYear, int Cost, string NameBook, string NameAuthor, string Gender, string NameTextBook)
            : base(NamePublisher, CountOfCopies, PublisherYear, Cost, NameBook, NameAuthor, Gender)
        {
            this .NameTextBook = NameTextBook;
        }

        internal Textbook(Author author, string NameTextBook) : base(author.NamePublisher, author.CountOfCopies, author.PublisherYear, author.Cost, author.NameBook, author.NameAuthor, author.Gender)
        {
            this.NameTextBook = NameTextBook;
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
            Console.WriteLine("".PadLeft(15, '_') + "textbook" + "".PadLeft(15, '_'));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(
                $"Название идателя: {_NamePublisher} \n" +
                $"Количество копий: {_CountOfCopies} \n" +
                $"Год издания: {_PublisherYear} \n" +
                $"Цена: {_Cost} \n" +
                $"Имя автора: {_NameAuthor} \n" +
                $"Жанр: {NameTextBook} \n");
            Console.ForegroundColor = ConsoleColor.White;

            return $"Название идателя: {_NamePublisher} \n" +
                   $"Количество копий: {_CountOfCopies} \n" +
                   $"Год издания: {_PublisherYear} \n" +
                   $"Цена: {_Cost} \n" +
                   $"Имя автора: {_NameAuthor} \n" +
                   $"Жанр: {NameTextBook} \n";
        }
    
    }
}
