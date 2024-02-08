using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace lab_04_v2
{
    internal abstract class Publisher
    {
        internal string NamePublisher { get; set; }
        internal int CountOfCopies { get; set; }
        internal int CountOfEmployees { get; set; }
        internal string NameAuthor { get; set; }

        internal Publisher(string NamePublisher, int CountOfCopies, int CountOfEmployees, string NameAuthor, string Gender) 
        {
            this.NamePublisher = NamePublisher;
            this.CountOfCopies = CountOfCopies;
            this.CountOfEmployees = CountOfEmployees;
            this.NameAuthor = NameAuthor;
        }

        public override string ToString()
        {
            return $"Название идателя: {NamePublisher} \n" +
                   $"Количество копий: {CountOfCopies} \n" +
                   $"Количество работников: {CountOfEmployees} \n" + 
                   $"Имя автора: {NameAuthor} \n" ;
        }
        public override bool Equals(object obj)
        {
            if (obj is Publisher publisher)
                return CountOfCopies == publisher.CountOfCopies;
            return false;
        }
        public override int GetHashCode() => CountOfEmployees.GetHashCode();
    }
}
