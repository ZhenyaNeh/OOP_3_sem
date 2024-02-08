using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_04
{
    sealed class Magazine : PrintedEdition
    {
        string Topic { get; set; }
        internal Magazine(int NumberOfReaders, string NamePublisheer, string NamePerson, int CountOfCopies, string topic) 
            : base(NumberOfReaders, NamePublisheer, NamePerson, CountOfCopies)
        {
            Topic = topic;
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
                   $"Тема новости: {Topic} \n";
        }
    }
}
