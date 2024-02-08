using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_05
{
    internal partial class Book : PrintedEdition, ICheckPopularity
    {
        internal string NameGanre { get; set; }
        public Author author;

        internal Book(string NamePublisher, int CountOfCopies, int PublisherYear, int Cost, string NameBook, string NameAuthor, string Gender, string NameGanre) 
            : base(NamePublisher, CountOfCopies, PublisherYear, Cost, NameBook, NameAuthor, Gender)
        {
            this.NameGanre = NameGanre;
        }

        internal Book(Author author, string NameGanre) : base(author.NamePublisher, author.CountOfCopies, author.PublisherYear, author.Cost, author.NameBook, author.NameAuthor, author.Gender)
        {
            this.NameGanre = NameGanre;
        }
    }
}
