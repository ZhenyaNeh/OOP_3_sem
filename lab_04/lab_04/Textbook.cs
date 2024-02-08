using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_04
{
    sealed class Textbook : PrintedEdition
    {
        string Area { get; set; }
        internal Textbook(int NumberOfReaders, string NamePublisheer, string NamePerson, int CountOfCopies, string area) 
            : base(NumberOfReaders, NamePublisheer, NamePerson, CountOfCopies)
        {
            Area = area;
        }

        internal override bool Popular()
        {
            if (NumberOfReaders >= 3000)
                return true;

            return false;  
        }

        public override string ToString()
        {
            return $"Количество читателей: {NumberOfReaders} \n" +
                   $"Название идателя: {NamePublisher} \n" +
                   $"Имя автора: {NamePerson} \n" +
                   $"Количество проданных копий: {CountOfCopies} \n" +
                   $"Область исследования: {Area} \n";
        }
    }
}
