using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace laba_14
{
    public class GetProc
    {
        static string path = "..\\..\\..\\info.txt";
        static int countOfRecords = 0;

        public static void ProcInfo()
        {
            Process[] processes = Process.GetProcessesByName("chrome");
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                Console.WriteLine("-----GetProcesses-----");
                sw.WriteLine("-----GetProcesses-----");

                foreach (Process process in processes)
                {
                    Console.WriteLine("Id: {0}", process.Id);
                    Console.WriteLine("Имя: {0}", process.ProcessName);
                    Console.WriteLine("Приоритет: {0}", process.BasePriority);
                    //Console.WriteLine("Время запуска: {0}", process.StartTime);
                    Console.WriteLine("Текущее состояние: {0}", process.Responding ? "Отвечает" : "Не отвечает");
                    //Console.WriteLine("Сколько всего времени использовал процессор: {0}", process.TotalProcessorTime);
                    Console.WriteLine();

                    sw.WriteLine("Id: {0}", process.Id);
                    sw.WriteLine("Имя: {0}", process.ProcessName);
                    sw.WriteLine("Приоритет: {0}", process.BasePriority);
                    //sw.WriteLine("Время запуска: {0}", process.StartTime);
                    sw.WriteLine("Текущее состояние: {0}", process.Responding ? "Отвечает" : "Не отвечает");
                   // sw.WriteLine("Сколько всего времени использовал процессор: {0}", process.TotalProcessorTime);
                    sw.WriteLine();

                    countOfRecords++;
                }
            }
        }

        public static void DomainInfo()
        {
            AppDomain domain = AppDomain.CurrentDomain;
            Console.WriteLine("Имя домена: {0}", domain.FriendlyName);
            Console.WriteLine("Детали конфигурации: {0}", domain.SetupInformation);
            Console.WriteLine("Сборки, загруженные в домен:");
            foreach (var assembly in domain.GetAssemblies())
            {
                Console.WriteLine(assembly.GetName().Name);
            }
            Console.WriteLine();

            try
            {
                AppDomain newDomain = AppDomain.CreateDomain("NewDomain");
                newDomain.Load("MyAssembly");
                AppDomain.Unload(newDomain);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"START_MESSAGE:");
                Console.WriteLine($"   {ex}");
                Console.WriteLine($"END_MESSAGE:");
                Console.WriteLine();
            }
        }

        public static void DoSomthing()
        {
            for (int i = 2; i <= 20; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                    Console.WriteLine(i);
            }
        }

        public static void AnotherTread()
        {
            Thread thread = new Thread(DoSomthing);

            Console.WriteLine("Статус потока: {0}", thread.ThreadState);
            Console.WriteLine("Имя потока: {0}", thread.Name);
            Console.WriteLine("Приоритет потока: {0}", thread.Priority);
            Console.WriteLine("Числовой идентификатор потока: {0}", thread.ManagedThreadId);

            thread.Start();
            Console.WriteLine("Статус потока после запуска: {0}", thread.ThreadState);

            /*Thread.Sleep(1000);
            thread.Suspend();
            Console.WriteLine("Статус потока после приостановки: {0}", thread.ThreadState);

            Thread.Sleep(1000);
            thread.Resume();
            Console.WriteLine("Статус потока после возобновления: {0}", thread.ThreadState);*/

            thread.Join();
            Console.WriteLine("Статус потока после завершения: {0}", thread.ThreadState);
            Console.WriteLine();
        }

        static object locker = new();
        private static void Odd()
        {
            //using (StreamWriter sw1 = new StreamWriter(path, true))
            //{
            for (int i = 1; i <= 10; i += 2)
            {
                lock (locker)
                {
                    Console.WriteLine(i);
                    //sw1.WriteLine(i);
                    Thread.Sleep(500);
                }
            }
            //}
        }

        private static void Even()
        {
            //using (StreamWriter sw2 = new StreamWriter(path, true))
            //{
            for (int i = 2; i <= 10; i += 2)
            {
                lock (locker)
                {
                    Console.WriteLine(i);
                    //sw1.WriteLine(i);
                    Thread.Sleep(250);
                }
            }
            //}
        }

        public static void WorkTread()
        {
            Thread treadOdd = new Thread(Odd);
            Thread treadEven = new Thread(Even);

            treadOdd.Name = "Odd";
            treadEven.Name = "Even";

            //treadOdd.Priority = ThreadPriority.Highest;
            Console.WriteLine("------Start_Proces------");
            treadOdd.Start();
            treadEven.Start();

            treadOdd.Join();
            treadEven.Join();
            Console.WriteLine();
        }

        public static void TimeWork()
        {
            System.Timers.Timer timer = new System.Timers.Timer(1000);
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;

            //Console.WriteLine("Нажмите любую клавишу для выхода.");
            Console.Write("Нажмите любую клавишу для выхода.");
            Console.ReadKey();
        }
        
        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            //Console.WriteLine("Текущее время: {0}", DateTime.Now);
            Console.Write('.');
        }

    }
}
