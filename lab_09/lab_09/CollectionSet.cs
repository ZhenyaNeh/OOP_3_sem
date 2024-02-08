using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_09
{
    internal class CollectionSet<T> : ISet<T> where T : Computer
    {
        ISet<T> specifications = new HashSet<T>();

        public int Count => specifications.Count;

        public bool IsReadOnly => specifications.IsReadOnly;

        public void Print()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"_____Collection_____");
            Console.ResetColor();
            foreach (var el in specifications)
                Console.WriteLine(el.ToString());
        }

        public bool Add(T item)
        {
            return specifications.Add(item);
        }

        public void Clear()
        {
            specifications.Clear();
        }

        public bool Contains(T item)
        {
            return specifications.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            specifications.CopyTo(array, arrayIndex);
        }

        public void ExceptWith(IEnumerable<T> other)
        {
            specifications.ExceptWith(other);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return specifications.GetEnumerator();
        }

        public void IntersectWith(IEnumerable<T> other)
        {
            specifications.IntersectWith(other);
        }

        public bool IsProperSubsetOf(IEnumerable<T> other)
        {
            return specifications.IsProperSubsetOf(other);
        }

        public bool IsProperSupersetOf(IEnumerable<T> other)
        {
            return specifications.IsProperSupersetOf(other);
        }

        public bool IsSubsetOf(IEnumerable<T> other)
        {
            return specifications.IsSubsetOf(other);
        }

        public bool IsSupersetOf(IEnumerable<T> other)
        {
            return specifications.IsSupersetOf(other);
        }

        public bool Overlaps(IEnumerable<T> other)
        {
            return specifications.Overlaps(other);
        }

        public bool Remove(T item)
        {
            return specifications.Remove(item);
        }

        public bool SetEquals(IEnumerable<T> other)
        {
            return specifications.SetEquals(other);
        }

        public void SymmetricExceptWith(IEnumerable<T> other)
        {
            specifications.SymmetricExceptWith(other);
        }

        public void UnionWith(IEnumerable<T> other)
        {
            specifications.UnionWith(other);
        }

        void ICollection<T>.Add(T item)
        {
            ((ICollection<T>)specifications).Add(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)specifications).GetEnumerator();
        }
    }
}
