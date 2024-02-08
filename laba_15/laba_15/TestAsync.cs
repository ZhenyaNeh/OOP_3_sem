using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_15
{
    internal class TestAsync
    {
        public static async void TestAsyncMethods()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n--------Async--------");
            Console.ResetColor();

            await PrintAsync();   // вызов асинхронного метода
            Console.WriteLine("Некоторые действия в методе Main");

            void Print()
            {
                Thread.Sleep(3000);     // имитация продолжительной работы
                Console.WriteLine("Hello Sasha");
            }

            // определение асинхронного метода
            async Task PrintAsync()
            {
                Console.WriteLine("Начало метода PrintAsync"); // выполняется синхронно
                await Task.Run(() => Print());                // выполняется асинхронно
                Console.WriteLine("Конец метода PrintAsync");
            }
        }
    }
}
