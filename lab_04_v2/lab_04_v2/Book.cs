using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_04_v2
{
    sealed internal class Book : PrintedEdition, ICheckPopularity
    {
        internal string Genre { get; set; }
        public Author author;

        internal Book(string NamePublisher, int CountOfCopies, int CountOfEmployees, string NameAuthor, string Gender, string Genre)
            : base(NamePublisher, CountOfCopies, CountOfEmployees, NameAuthor, Gender)
        {
            this.Genre = Genre;
        }

        internal Book(Author author, string AreaOfResearch) : base(author.NamePublisher, author.CountOfCopies, author.CountOfEmployees, author.NameAuthor, author.Gender)
        {
            this.author = author;
            this.Genre= AreaOfResearch;
        }

        bool ICheckPopularity.CheckPopularity()
        {
            return CountOfCopies >= 3000;
        }

        internal override bool CheckPopularity()
        {
            if (CountOfCopies >= 3000 && CountOfEmployees >= 20)
                return true;

            return false;
        }

        public override string ToString()
        {
            return $"Название идателя: {NamePublisher} \n" +
                   $"Количество копий: {CountOfCopies} \n" +
                   $"Количество работников: {CountOfEmployees} \n" +
                   $"Имя автора: {NameAuthor} \n" +
                   $"Жанр: {Genre} \n";
        }
    }
}
