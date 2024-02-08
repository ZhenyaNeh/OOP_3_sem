using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_04
{
    sealed class Book : PrintedEdition, ICheckPopularity
    {
        string Genre { get; set; }
        internal Book(int NumberOfReaders, string NamePublisheer, string NamePerson, int CountOfCopies, string genre) 
            : base(NumberOfReaders, NamePublisheer, NamePerson, CountOfCopies)
        {
            Genre = genre;
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
                   $"Жанр: {Genre} \n";
        }

        bool ICheckPopularity.CheckPopularity() 
        {
            return NumberOfReaders > 3000;
        }
    }
}
