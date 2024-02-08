using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_05
{
    internal abstract class LibraryAbstract 
    {
        public List<PrintedEdition> library = new List<PrintedEdition>();

        List<PrintedEdition> lib
        {
            get { return library; }
            set { library = value; }
        }
        public static int CountLibrary = 0;
        internal abstract void AddElement(PrintedEdition element);
        internal abstract void RemoveElement(PrintedEdition element);
        internal abstract void PrintElements();

    }
}
