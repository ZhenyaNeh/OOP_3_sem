using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace laba_15
{
    class MatrixMultiply
    {
        public static void Multiply()
        {
            int[,] matrix1 = new int[1000, 1000];
            int[,] matrix2 = new int[1000, 1000];
            int[,] result = new int[1000, 1000];

            Random random = new Random();
            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < 1000; j++)
                {
                    matrix1[i, j] = random.Next(10);
                    matrix2[i, j] = random.Next(10);
                }
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------Matrix_Mulyiply--------");
            Console.ResetColor();

            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch1.Start();

            Task taskOne = new Task(() =>
            {
                for (int i = 0; i < 1000; i++)
                {
                    for (int j = 0; j < 1000; j++)
                    {
                        for (int k = 0; k < 1000; k++)
                        {
                            result[i, j] += matrix1[i, k] * matrix2[k, j];
                        }
                    }
                }
            });

            taskOne.Start();
            Console.WriteLine("Идентификатор текущей задачи: {0}", taskOne.Id);
            Console.WriteLine("Статус задачи: {0}", taskOne.Status);
            Console.WriteLine();
            taskOne.Wait();
            stopwatch1.Stop();
            Console.WriteLine("Идентификатор текущей задачи: {0}", taskOne.Id);
            Console.WriteLine("Статус задачи: {0}", taskOne.Status);
            Console.WriteLine("Задача завершена: {0}", taskOne.IsCompleted);
            Console.WriteLine("Прошло времени: {0} мс", stopwatch1.ElapsedMilliseconds);

            TimeSpan ts1 = stopwatch1.Elapsed;
            string elapsedTime1 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts1.Hours, ts1.Minutes, ts1.Seconds,
                ts1.Milliseconds / 10);
            Console.WriteLine("RunTime: " + elapsedTime1);

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n--------Matrix_Mulyiply_With_Interruption--------");
            Console.ResetColor();

            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Start();
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;
            Task taskTwo = new Task(() =>
            {
                for (int i = 0; i < 1000; i++)
                {
                    for (int j = 0; j < 1000; j++)
                    {
                        for (int k = 0; k < 1000; k++)
                        {
                            if (token.IsCancellationRequested)
                            {
                                Console.WriteLine("Операция прервана");
                                return;
                            }

                            result[i, j] += matrix1[i, k] * matrix2[k, j];
                        }
                    }
                }
            }, token);

            try
            {
                taskTwo.Start();

                Console.WriteLine("Идентификатор текущей задачи: {0}", taskOne.Id);
                Console.WriteLine("Статус задачи: {0}", taskOne.Status);
                Console.WriteLine();
                Thread.Sleep(3000);
                cancellationTokenSource.Cancel();

                taskOne.Wait();
            }
            catch (AggregateException ae)
            {
                foreach (Exception e in ae.InnerExceptions)
                {
                    if (e is TaskCanceledException)
                        Console.WriteLine("Операция прервана");
                    else
                        Console.WriteLine(e.Message);
                }
            }
            finally
            {
                cancellationTokenSource.Dispose();
                stopwatch2.Stop();
            }

            Console.WriteLine("Идентификатор текущей задачи: {0}", taskOne.Id);
            Console.WriteLine("Статус задачи: {0}", taskOne.Status);
            Console.WriteLine("Задача завершена: {0}", taskOne.IsCompleted);
            Console.WriteLine("Прошло времени: {0} мс", stopwatch2.ElapsedMilliseconds);

            TimeSpan ts2 = stopwatch2.Elapsed;
            string elapsedTime2 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts2.Hours, ts2.Minutes, ts2.Seconds,
                ts2.Milliseconds / 10);
            Console.WriteLine("RunTime: " + elapsedTime2);

        }
    }
}
