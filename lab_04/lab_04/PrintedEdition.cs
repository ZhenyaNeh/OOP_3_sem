using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab_04
{
    abstract class PrintedEdition : Author
    {
        internal int CountOfCopies { get; set; }
        internal PrintedEdition(int NumberOfReaders, string NamePublisher, string NamePerson, int countOfCopies) : base(NumberOfReaders, NamePublisher, NamePerson)
        {
            CountOfCopies = countOfCopies;
        }

        internal abstract bool Popular();

        public override string ToString()
        {
            return $"Количество читателей: {NumberOfReaders} \n" +
                   $"Название идателя: {NamePublisher} \n" +
                   $"Имя автора: {NamePerson} \n" +
                   $"Количество проданных копий: {CountOfCopies} \n";
        } 

        public override bool Equals(object obj)
        {
            PrintedEdition printedEdition = obj as PrintedEdition;
            if (null != printedEdition)
                return CountOfCopies == printedEdition.CountOfCopies;
            return false;
        }

        public override int GetHashCode() => CountOfCopies.GetHashCode();
    }
}
