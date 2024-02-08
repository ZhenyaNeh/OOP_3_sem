using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_06
{
    internal class Printer
    {
        internal void IAmPrinting(PrintedEdition check)
        {
            if (check is Book book)
            {
                book.ToString();
            }
            if (check is Magazine magazine)
            {
                magazine.ToString();
            }
            if (check is Textbook textbook)
            {
                textbook.ToString();
            }
        }
    }
}
