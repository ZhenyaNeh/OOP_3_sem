using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_15
{
    internal class ParFor
    {
        public static void ParallelForForeach()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n--------Parallel_For--------");
            Console.ResetColor();

            const int arraySize = 1000000;
            const int numberOfArrays = 5;

            // Обычный цикл
            Stopwatch stopwatch = Stopwatch.StartNew();
            for (int i = 0; i < numberOfArrays; i++)
            {
                GenerateArray(arraySize);
            }
            stopwatch.Stop();
            Console.WriteLine($"Обычный цикл:");

            TimeSpan ts1 = stopwatch.Elapsed;
            string elapsedTime1 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts1.Hours, ts1.Minutes, ts1.Seconds,
                ts1.Milliseconds / 10);
            Console.WriteLine("RunTimeParallel " + elapsedTime1);

            // Параллельный цикл
            stopwatch.Restart();
            Parallel.For(0, numberOfArrays, i =>
            {
                GenerateArray(arraySize);
            });
            stopwatch.Stop();
            Console.WriteLine($"Параллельный цикл:");

            TimeSpan ts2 = stopwatch.Elapsed;
            string elapsedTime2 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts2.Hours, ts2.Minutes, ts2.Seconds,
                ts2.Milliseconds / 10);
            Console.WriteLine("RunTimeParallel " + elapsedTime2);
        }
        
        private static void GenerateArray(int size)
        {
            int[] array = new int[size];
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next();
            }
        }

    }
}
