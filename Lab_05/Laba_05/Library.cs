using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_05
{
    internal class Library : LibraryAbstract
    {
        internal override void AddElement(PrintedEdition element)
        {
            library.Add(element);
            CountLibrary++;
    }

        internal override void RemoveElement (PrintedEdition element)
        {
            library.Remove(element);
            CountLibrary++;
        }

        internal override void PrintElements()
        {
            foreach (var element in library) 
            { 
                Console.WriteLine(element.ToString());
            }
        }

         
    }
}
