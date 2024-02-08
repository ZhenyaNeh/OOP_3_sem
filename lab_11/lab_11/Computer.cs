using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_11
{
    internal class Computer : IComputer
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }

        public Computer(string name , string type, int price)
        {
            Name = name;
            Type = type;
            Price = price;
        }

        public Computer()
        {
            Name = "name";
            Type = "type";
            Price = 100;
        }

        public void SomeOperation(string a)
        {
            Console.WriteLine($"просто вывод: {a}");
            Reflector.InFile($"просто вывод: {a}");
        }

        public void Show()
        {
            Console.WriteLine($"Название: {Name} \n" +
                              $"Тип: {Type} \n" +
                              $"Цена: {Price}$ \n");

            Reflector.InFile($"Название: {Name} \n" +
                              $"  Тип: {Type} \n" +
                              $"  Цена: {Price}$ \n");
        }

        public override string ToString()
        {
            return $"Название: {Name} \n" +
                   $"Тип: {Type} \n" +
                   $"Цена: {Price}$ \n";
        }
    }
}
