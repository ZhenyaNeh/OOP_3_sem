using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_04_v2
{
    internal class Author : Person
    {
        internal Author(string NamePublisher, int CountOfCopies, int CountOfEmployees, string NameAuthor, string Gender)
           : base(NamePublisher, CountOfCopies, CountOfEmployees, NameAuthor, Gender)
        {
            this.NameAuthor = NameAuthor;
        }
    }
}
