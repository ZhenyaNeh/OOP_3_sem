using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace laba_06
{
    internal abstract class PrintedEdition : Publisher
    { 
        internal PrintedEdition(string NamePublisher, int CountOfCopies, int PublisherYear,int Cost, string NameBook, string NameAuthor, string Gender)
            : base(NamePublisher, CountOfCopies, PublisherYear, Cost, NameBook, NameAuthor, Gender) 
        {
        }

        internal abstract bool CheckPopularity();

        public override string ToString()
        {
            return $"Название идателя: {_NamePublisher} \n" +
                   $"Количество копий: {_CountOfCopies} \n" +
                   $"Год издания: {_PublisherYear} \n" +
                   $"Цена: {_Cost} \n" +
                   $"Название книги: {_NameBook} \n" +
                   $"Имя автора: {_NameAuthor} \n";
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
