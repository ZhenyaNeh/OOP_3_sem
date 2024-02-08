using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_04
{
    internal class Publisher : Person
    {
        internal string NamePublisher { get; set; }
        internal Publisher(int NumberOfReaders, string namePublisher) : base(NumberOfReaders)
        {
            NamePublisher = namePublisher;
        }

        public override string ToString()
        {
            return $"Количество читателей: {NumberOfReaders} \n" +
                   $"Название идателя: {NamePublisher} \n" ;
        }
    }
}
