using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Laba_05
{
    internal abstract class Publisher
    {
        internal string NamePublisher { get; set; }
        internal int CountOfCopies { get; set; }
        internal int PublisherYear { get; set; }
        internal int Cost { get; set; } 
        internal string NameBook { get; set; }
        internal string NameAuthor { get; set; }

        internal Publisher(string NamePublisher, int CountOfCopies, int PublisherYear, int Cost, string NameBook,  string NameAuthor, string Gender) 
        {
            this.NamePublisher = NamePublisher;
            this.CountOfCopies = CountOfCopies;
            this.PublisherYear = PublisherYear;
            this.NameBook = NameBook;
            this.Cost = Cost;
            this.NameAuthor = NameAuthor;
        }

        public override string ToString()
        {
            return $"Название идателя: {NamePublisher} \n" +
                   $"Количество копий: {CountOfCopies} \n" +
                   $"Количество работников: {PublisherYear} \n" + 
                   $"Имя автора: {NameAuthor} \n" ;
        }
        public override bool Equals(object obj)
        {
            if (obj is Publisher publisher)
                return CountOfCopies == publisher.CountOfCopies;
            return false;
        }
        public override int GetHashCode() => PublisherYear.GetHashCode();
    }
}
