using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_05
{
    internal class Printer
    {
        internal void IAmPrinting(PrintedEdition check)
        {
            if (check is Book book)
            {
                Console.WriteLine(book.ToString());
            }
            if (check is Magazine magazine)
            {
                Console.WriteLine(magazine.ToString());
            }
            if (check is Textbook textbook)
            {
                Console.WriteLine(textbook.ToString());
            }
        }
    }
}
