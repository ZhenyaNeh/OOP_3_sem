using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab_04
{
    internal abstract class Person
    {
        public int NumberOfReaders { get; set; }

        public Person(int NumberOfReaders)
        { 
            this.NumberOfReaders = NumberOfReaders;
        }

        public override string ToString()
        {
            return $" Количество читателей: {NumberOfReaders} ";
        }
        public override bool Equals(object obj)
        {
            if (obj is Person person )
                return NumberOfReaders == person.NumberOfReaders;
            return false;
        }
        public override int GetHashCode() => NumberOfReaders.GetHashCode();

    }
}
