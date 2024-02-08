using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_04_v2
{
    internal abstract class PrintedEdition : Publisher
    {
        internal PrintedEdition(string NamePublisher, int CountOfCopies, int CountOfEmployees, string NameAuthor, string Gender)
            : base(NamePublisher, CountOfCopies, CountOfEmployees, NameAuthor, Gender) 
        {
            this.CountOfCopies = CountOfCopies;
        }

        internal abstract bool CheckPopularity();

        public override string ToString()
        {
            return $"Название идателя: {NamePublisher} \n" +
                    $"Количество копий: {CountOfCopies} \n" +
                    $"Количество работников: {CountOfEmployees} \n" +
                    $"Имя автора: {NameAuthor} \n";
        }

        public override bool Equals(object obj)
        {
            PrintedEdition printedEdition = obj as PrintedEdition;
            if (null != printedEdition)
                return CountOfCopies == printedEdition.CountOfCopies;
            return false;
        }

        public override int GetHashCode() => CountOfEmployees.GetHashCode();
    }
}
