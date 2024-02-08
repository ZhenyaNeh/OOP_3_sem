using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lab_12
{
    static class NEVLog
    {
        static bool checkForCreate = true;
        public static void WriteInFile(string str)
        {
            if (checkForCreate)
            {
                checkForCreate = false;
                using (StreamWriter sw = File.CreateText("..\\..\\..\\nevlogfile.txt"))
                {
                    sw.Write(str);
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter("..\\..\\..\\nevlogfile.txt", true))
                {
                    sw.WriteLine(str);
                }
            }
        }

        public static void ReadFile()
        {
            using (StreamReader sr = new StreamReader("..\\..\\..\\nevlogfile.txt", true))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
        }

        public static void CheckCount()
        {
            int count = 0;
            using (StreamReader sr = new StreamReader("..\\..\\..\\nevlogfile.txt", true))
            {
                string? line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains("------"))
                        count++;
                }
            }

            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Write($"Количество записей равно: {count}");
            Console.ResetColor();
            Console.WriteLine("\n");
        }

        public static void CheckTime(string time)
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Write($"Записи за дату {time}:");
            Console.ResetColor();
            Console.WriteLine();

            using (StreamReader sr = new StreamReader("..\\..\\..\\nevlogfile.txt", true))
            {
                string? line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains("Дата:"))
                    {
                        if (line.Contains(time))
                        {
                            Console.WriteLine($"{line}");
                            while (!(line = sr.ReadLine()).Contains("------"))
                            {
                                Console.WriteLine(line);
                            }
                        }
                    }
                }
            }
        }

        static List<int> CheckSec(this string str)
        {
            int sec = 0, min = 0, hour = 0;

            if (str.Contains("Дата: "))
                str = str.Replace("Дата: ", "");

            var colTime = str.Split(":");

            hour = Int32.Parse(string.Join("", colTime[0].SkipWhile(x => x != ' ')));
            min = Int32.Parse(colTime[1]);
            sec = Int32.Parse(colTime[2].Replace("AM", "").Replace("PM", ""));

            var list = new List<int>();
            list.Add(sec);
            list.Add(min);
            list.Add(hour);

            return list;
        }

        public static void CheckLastTenSec()
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Write($"Записи за последние 10 секунд:");
            Console.ResetColor();
            Console.WriteLine();

            string timeNow = DateTime.Now.ToString();
            var time = new List<int>();
            int secCrit = 0, minCrit = 0, hourCrit = 0;

            time = timeNow.CheckSec();
            secCrit = time.First();
            time.RemoveAt(0);
            minCrit = time.First();
            time.RemoveAt(0);
            hourCrit = time.First();

            secCrit += 10;
            if (secCrit > 60)
            {
                minCrit++;
                secCrit = secCrit - 60;
            }

            using (StreamReader sr = new StreamReader("..\\..\\..\\nevlogfile.txt", true))
            {
                string? line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains("Дата:"))
                    {
                        int secCheck = default;
                        time = line.CheckSec();
                        secCheck = time.First();
                        time.RemoveAt(0);
                        int minCheck = time.First();

                        if (secCrit > secCheck || minCrit > minCheck)
                        {
                            using (StreamWriter sw = new StreamWriter("..\\..\\..\\nevlogfile_DelCPy.txt", true))
                            {
                                sw.WriteLine(line);
                                while (!(line = sr.ReadLine()).Contains("------"))
                                {
                                    sw.WriteLine(line);
                                }
                            }
                        }
                    }
                }
            }

            var file = new FileInfo("..\\..\\..\\nevlogfile.txt");
            if (file.Exists)
            {
                file.Delete();
                Console.WriteLine($"Файл \'{file.Name}\' был удален!");
            }
        }

        public static void TimeRange(int before, int after)
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Write($"Записи межеду {before} и {after} часами:");
            Console.ResetColor();
            Console.WriteLine();

            var time = new List<int>();
            int chekHour = 0;
            using (StreamReader sr = new StreamReader("..\\..\\..\\nevlogfile.txt", true))
            {
                string? line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains("Дата:"))
                    {
                        time = line.CheckSec();
                        time.RemoveAt(0);
                        time.RemoveAt(0);
                        chekHour = time.First();
                        if (before < chekHour && chekHour < after)
                        {
                            Console.WriteLine(line);
                            while (!(line = sr.ReadLine()).Contains("------"))
                                Console.WriteLine(line);
                        }
                    }
                }
            }
        }

        public static void Search(string str)
        {
            using (StreamReader sr = new StreamReader("..\\..\\..\\nevlogfile.txt", true))
            {
                string text = sr.ReadToEnd();
                if (text.Contains(str))
                    Console.WriteLine($"Стррока \'{text}\' содержится в файле");
            }
        }

    }
}
