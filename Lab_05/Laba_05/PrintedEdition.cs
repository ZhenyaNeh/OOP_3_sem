using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Laba_05
{
    internal abstract class PrintedEdition : Publisher
    { 
        internal PrintedEdition(string NamePublisher, int CountOfCopies, int PublisherYear,int Cost, string NameBook, string NameAuthor, string Gender)
            : base(NamePublisher, CountOfCopies, PublisherYear, Cost, NameBook, NameAuthor, Gender) 
        {
            this.CountOfCopies = CountOfCopies;
            this.PublisherYear = PublisherYear;
            this.Cost = Cost;
            this.NameBook = NameBook;
        }

        internal abstract bool CheckPopularity();

        public override string ToString()
        {
            return $"Название идателя: {NamePublisher} \n" +
                    $"Количество копий: {CountOfCopies} \n" +
                    $"Количество работников: {PublisherYear} \n" +
                    $"Имя автора: {NameAuthor} \n";
        }

        public override bool Equals(object obj)
        {
            PrintedEdition printedEdition = obj as PrintedEdition;
            if (null != printedEdition)
                return CountOfCopies == printedEdition.CountOfCopies;
            return false;
        }

        public override int GetHashCode() => PublisherYear.GetHashCode();
    }
}
