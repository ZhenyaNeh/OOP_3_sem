using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_07
{
    internal class CollectionTypeForBook<T> : ICollection<T> where T : Book
    {
        public static T jh;
        T g = default(T);
        public List<T> list = new List<T>();
        public void AddList(T item)
        {
            list.Add(item);
        }

        public void ShowList()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n----------{list.GetType()}----------");
            Console.ResetColor();
            foreach (T item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void RemoveListElement(T item)
        {
            if (list.Remove(item))
            {
                Console.WriteLine($"Элемент '{item}' удален.");
                return;
            }
            throw new Exception($"Элемент '{item}' не найден");
        }

        public static CollectionTypeForBook<T> operator +(CollectionTypeForBook<T> lis, T value)
        {
            lis.list.Add(value);
            return lis;
        }

        public static CollectionTypeForBook<T> operator -(CollectionTypeForBook<T> lis, T value)
        {
            if (lis.list.Remove(value))
            {
                Console.WriteLine($"Элемент '{value}' удален.");
                return lis;
            }
            throw new Exception($"Элемент '{value}' не найден");
        }

        public void SaveAndRead()
        {
            using (StreamWriter file = File.CreateText("..\\..\\examlple.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, list);
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Данные сохранены <{list.GetType()}>\n");
            Console.ResetColor ();

            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("Читка из файла");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\n");

            string json = File.ReadAllText("..\\..\\examlple.json");
            List<T> deserialazed = JsonConvert.DeserializeObject<List<T>>(json);

            foreach (T element in deserialazed)
                Console.WriteLine($"{element}");
        }
    }
}
