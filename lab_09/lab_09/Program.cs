using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var spec1 = new Computer("Asus", "Gaming laptop", 4000);
            var spec2 = new Computer("Aser", "Laptop", 2000);
            var spec3 = new Computer("Lenovo", "Ultrabook", 3000);
            var spec4 = new Computer("HP", "Gaming laptop", 3500);
            var spec5 = new Computer("Honor", "Ultrabook", 2500);

            var coll = new CollectionSet<Computer>();
            coll.Add(spec1);
            coll.Add(spec2);
            coll.Add(spec3);
            coll.Add(spec4);
            coll.Add(spec5);

            coll.Print();
            coll.Remove(spec2);
            coll.Print();

            var secondTask = new HashSet<int>();
            secondTask.Add(1);
            secondTask.Add(2);
            secondTask.Add(3);
            secondTask.Add(4);
            secondTask.Add(5);

            secondTask.Print();
            secondTask = secondTask.RemoveRange(2,4);
            secondTask.Print();

            secondTask.Add(2);
            secondTask.Add(3);
            secondTask.Add(4);
            secondTask.Add(5);

            var list = secondTask.ToList();
            list.Print();

            list.ContColl(9);

            ObservableCollection<Computer> C = new ObservableCollection<Computer>();

            C.CollectionChanged += C_CollectionChanged;

            C.Add(spec1);
            C.Add(spec2);
            C.RemoveAt(1);
            C[0] = spec3;

            Console.WriteLine("\nСписок пользователей:");
            foreach (var item in C)
            {
                Console.WriteLine(item.ToString());
            }

            void C_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
            {
                switch (e.Action)
                {
                    case NotifyCollectionChangedAction.Add: // если добавление
                        if (e.NewItems?[0] is Computer newComputer)
                            Console.WriteLine($"Добавлен новый объект: {newComputer.Name}");
                        break;
                    case NotifyCollectionChangedAction.Remove: // если удаление
                        if (e.OldItems?[0] is Computer oldComputer)
                            Console.WriteLine($"Удален объект: {oldComputer.Name}");
                        break;
                    case NotifyCollectionChangedAction.Replace: // если замена
                        if ((e.NewItems?[0] is Computer replacingComputer) &&
                            (e.OldItems?[0] is Computer replacedComputer))
                            Console.WriteLine($"Объект {replacedComputer.Name} заменен объектом {replacingComputer.Name}");
                        break;
                }
            }
        }
    }
}
