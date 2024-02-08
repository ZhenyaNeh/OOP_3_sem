using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_09
{
    internal class Computer
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }

        public Computer(string name, string type, int price)
        {
            Name = name;
            Type = type;
            Price = price;
        }

        public override string ToString()
        {
            return $"Название: {Name} \n" +
                   $"Тип: {Type} \n" +
                   $"Цена: {Price}$ \n" ;
        }
    }
}
