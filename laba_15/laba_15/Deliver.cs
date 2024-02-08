using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace laba_15
{
    class Deliver
    {
        static BlockingCollection<string> warehorse = new BlockingCollection<string>();

        public static void deliverProduct()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n--------Deliver_Product--------");
            Console.ResetColor();

            for (int i = 1; i <= 5; i++)
            {
                int supplierNumber = i;
                Task.Factory.StartNew(() => Supplier(supplierNumber));
            }

            // Запуск потоков для покупателей
            for (int i = 1; i <= 10; i++)
            {
                int customerNumber = i;
                Task.Factory.StartNew(() => Customer(customerNumber));
            }

            // Console.ReadLine();
        }

        private static void Supplier(int supplierNumber)
        {
            Random rand = new Random();

            while (true)
            {
                string product = $"Товар от поставщика {supplierNumber}";

                warehorse.Add(product);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"Поставщик {supplierNumber} доставил {product}");
                Console.ResetColor();

                //Thread.Sleep(rand.Next(1000, 3000));
            }
        }

        private static void Customer(int customerNumber)
        {
            Random rand = new Random();

            while (true)
            {
                try
                {
                    string product = warehorse.Take();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Покупатель {customerNumber} купил {product}");
                    Console.ResetColor();
                }
                catch (InvalidOperationException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Покупатель {customerNumber} ушел, так как товара нет на складе");
                    Console.ResetColor();
                }

                //Thread.Sleep(rand.Next(500, 2000));
            }
        }
    }
}
