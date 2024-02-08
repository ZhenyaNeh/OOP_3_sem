using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_03
{
    public class List
    {
        /*Добавьте в свой класс вложенный объект Production, который содержит 
       Id, название организации.*/
        Production production = new Production();

        //) Добавьте в свой класс вложенный класс Developer (разработчик – фио, id, отдел).
        public class Developer
        {
            private readonly int DeveloperID;
            public string Name { get; set; }
            public string Department { get; set; }

            public Developer()
            {
                DeveloperID = GetHashCode();
            }
            public Developer(string name, string department)
            {
                DeveloperID = GetHashCode();
                this.Name = name;
                this.Department = department;
            }
        }

        // класс узла списка
        public class ListNode<T>
        {
            public T Data { get; set; }
            public ListNode<T> Next { get; set; }

            public ListNode(T data)
            {
                Data = data;
                Next = null;
            }
        }

        public class LinkedList<T>
        {
            private ListNode<T> head;
            public int Count { get; private set; }

            public LinkedList()
            {
                head = null;
                Count = 0;
            }

            public void Add(T data)
            {
                ListNode<T> newNode = new ListNode<T>(data);

                if (head == null)
                {
                    head = newNode;
                }
                else
                {
                    ListNode<T> current = head;
                    while (current.Next != null)
                    {
                        current = current.Next;
                    }
                    current.Next = newNode;
                }

                Count++;
            }

            public void Inrest(T data, int index)
            {
                if (index < 0 || index >= Count)
                    throw new IndexOutOfRangeException();

                ListNode<T> newNode = new ListNode<T>(data);
                if (index == 0)
                {
                    newNode.Next = head;
                    head = newNode;
                }
                else
                {
                    ListNode<T> previous = null;
                    ListNode<T> current = head;
                    for (int i = 0; i < index; i++)
                    {
                        previous = current;
                        current = current.Next;
                    }
                    newNode.Next = current;
                    previous.Next = newNode;
                }
                Count++;
            }

            public void Print()
            {
                ListNode<T> currrent = head;
                while (currrent != null)
                {
                    Console.WriteLine(currrent.Data);
                    currrent = currrent.Next;
                }
            }

            public override string ToString()
            {
                string result = string.Empty;
                ListNode<T> current = head;
                while (current != null)
                {
                    result += current.Data.ToString() + " -> ";
                    current = current.Next;
                }
                result += "null";
                return result;
            }

           public T this[int index]
            {
                get
                {
                    if (index < 0 || index >= Count)
                        throw new IndexOutOfRangeException();
                    ListNode<T> current = head;
                    for (int i = 0; i < index; i++)
                    {
                        current = current.Next;
                    }
                    return current.Data;
                }
                set
                {
                    if (index < 0 || index >= Count)
                        throw new IndexOutOfRangeException();
                    ListNode<T> current = head;
                    for (int i = 0; i < index; i++)
                    {
                        current = current.Next;
                    }
                    current.Data = value;
                }
            }

            public void RemoveByIndex(int index)
            {
                if (index < 0 || index >= Count)
                    throw new IndexOutOfRangeException();
                if (index == 0)
                {
                    head = head.Next;
                }
                else
                {
                    ListNode<T> previous = null;
                    ListNode<T> current = head;
                    for (int i = 0; i < index; i++)
                    {
                        previous = current;
                        current = current.Next;
                    }
                    previous.Next = current.Next;
                }
                Count--;
            }

            public ListNode<T> Find(T value)
            {
                ListNode<T> current = head;
                while (current != null)
                {
                    if (current.Data.Equals(value))
                    {
                        return current;
                    }
                    current = current.Next;
                }
                return null;
            }

            public void Clear()
            {
                head = null;
                Count = 0;
            }

           /* Дополнительно
            перегрузить следующие операции:
            >>  удалить элемент в заданной позиции
            +  добавить элемент в заданную позицию,например,
            !=  проверка на неравенство множеств*/

            public static LinkedList<T> operator >>(LinkedList<T> list, int index)
            {
                if (index < 0 || index >= list.Count)
                    throw new IndexOutOfRangeException();

                list.RemoveByIndex(index);
                return list;
            }

            public static LinkedList<T> operator +(LinkedList<T> list, (T data, int index) item)
            {
                if (item.index < 0 || item.index >= list.Count)
                    throw new IndexOutOfRangeException();

                list.Inrest(item.data, item.index);
                return list;
            }

            public static bool operator !=(LinkedList<T> list1, LinkedList<T> list2)
            {
                if (list1.Count != list2.Count)
                {
                    return true;
                }

                if (!list1.Equals(list2))
                {
                    return true;
                }

                return false;
            }

            public static bool operator ==(LinkedList<T> list1, LinkedList<T> list2)
            {
                if (list1.Count == list2.Count)
                {
                    return true;
                }

                if (list1.Equals(list2))
                {
                    return true;
                }

                return false;
            }

        }
    }
}
