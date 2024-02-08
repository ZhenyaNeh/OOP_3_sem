using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_07
{
    internal interface ICollection<T>
    {
        void AddList(T item);
        void ShowList();
        void RemoveListElement(T item);
    }
}
