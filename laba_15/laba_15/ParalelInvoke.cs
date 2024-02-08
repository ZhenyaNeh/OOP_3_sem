using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_15
{
    internal class ParalelInvoke
    {
        public static void ParlInvoke()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n--------Parallel_Invoke--------");
            Console.ResetColor();

            Parallel.Invoke(Print, () => Square(5), () =>
            {
                Console.WriteLine($"Выполняется задача {Task.CurrentId}");
                Thread.Sleep(3000);
            });

            void Print()
            {
                Console.WriteLine($"Выполняется задача {Task.CurrentId}");
                Thread.Sleep(3000);
            }
            
            void Square(int n)
            {
                Console.WriteLine($"Выполняется задача {Task.CurrentId}");
                Thread.Sleep(3000);
                Console.WriteLine($"Результат {n * n}");
            }
        }
    }
}
