using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_04_v2
{
    internal class Person : Publisher
    {
        internal string Gender { get; set; }

        internal Person (string NamePublisher, int CountOfCopies, int CountOfEmployees, string NameAuthor, string Gender)
            : base(NamePublisher, CountOfCopies, CountOfEmployees, NameAuthor, Gender)
        {
            this.Gender = Gender;
        }
    }
}
