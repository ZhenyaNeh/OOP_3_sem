using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_05
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
            return $"Название идателя: {NamePublisher} \n" +
                   $"Количество копий: {CountOfCopies} \n" +
                   $"Год издания: {PublisherYear} \n" +
                   $"Цена: {Cost} \n" +
                   $"Имя автора: {NameAuthor} \n" +
                   $"Тема дня: {NameMagazine} \n";
        }
    }
}
