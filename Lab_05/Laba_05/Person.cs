using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_05
{
    internal class Person : Publisher
    {
        internal string Gender { get; set; }

        internal Person (string NamePublisher, int CountOfCopies, int PublisherYear, int Cost, string NameBook, string NameAuthor, string Gender)
            : base(NamePublisher, CountOfCopies, PublisherYear, Cost, NameBook, NameAuthor, Gender)
        {
            this.Gender = Gender;
        }
    }
}
