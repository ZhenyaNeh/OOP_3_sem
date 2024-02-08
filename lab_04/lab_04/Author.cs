using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_04
{
    internal class Author : Publisher
    {
        internal string NamePerson { get; set; }
        internal Author(int NumberOfReaders, string NamePublisher, string namePerson) : base(NumberOfReaders, NamePublisher)
        {
            NamePerson = namePerson;
        }

        public override string ToString()
        {
            return $"Количество читателей: {NumberOfReaders} \n" +
                   $"Название идателя: {NamePublisher} \n" +
                   $"Имя автора: {NamePerson} \n";
        }
    }
}
