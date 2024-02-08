using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_10
{
    internal class Collectiom<T> : IList<T>, IEnumerable<T> where T : Book
    {
        IList<T> list = new List<T>();

        public T this[int index] { get => list[index]; set => list[index] = value; }

        public void Show(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{message}");
            Console.ForegroundColor = ConsoleColor.White;
            if (list == null)
            {
                Console.WriteLine("нет");
            }
            else
            {
                foreach (var element in list)
                {
                    Console.WriteLine(element);
                }
            }
        }

        public void AddManyElement(int countElement, T element)
        {
            for (int i = 1; i <= countElement; i++)
            {
                var buffer = new Book("", "", "", 2000, 100, 0);
                buffer.NameBook = element.NameBook + "_" + i;
                buffer.Publish = element.Publish + "_" + i;
                buffer.Autor = element.Autor + "_" + i;
                buffer.Year = element.Year + i;
                buffer.CountPages = element.CountPages + i * 100;
                buffer.Cost = element.Cost + i;
                list.Add(buffer as T);
            }
        }

        public void Print ()
        {
            Console.WriteLine($"\n======={list.GetType()}=======");
            foreach (var element in list)
            {
                Console.WriteLine(element.ToString());
            }
        }

        public int Count => list.Count;

        public bool IsReadOnly => list.IsReadOnly;

        public void Add(T item)
        {
            list.Add(item);
        }

        public void Clear()
        {
            list.Clear();
        }

        public bool Contains(T item)
        {
            return list.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            list.CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        public int IndexOf(T item)
        {
            return list.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            list.Insert(index, item);
        }

        public bool Remove(T item)
        {
            return list.Remove(item);
        }

        public void RemoveAt(int index)
        {
            list.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)list).GetEnumerator();
        }
    }
}
