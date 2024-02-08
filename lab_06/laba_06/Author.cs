using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_06
{
    internal class Author : Person
    {
        internal Author(string NamePublisher, int CountOfCopies, int PublisherYear, int Cost, string NameBook, string NameAuthor, string Gender)
           : base(NamePublisher, CountOfCopies, PublisherYear, Cost, NameBook, NameAuthor, Gender)
        {
            this.NameAuthor = NameAuthor;
        }
    }
}
