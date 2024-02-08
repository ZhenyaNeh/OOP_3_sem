using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace laba_16
{
    internal static class StaticClass
    {
        private static void Loading()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"You write UNCORRECT number! \nTry again");
                for (int j = 0; j < 4; j++)
                {
                    Thread.Sleep(200);
                    Console.Write(". ");
                }
                Console.ResetColor();
                Console.Clear();
            }
        }

        public static int CheckInt(this ref int checkNum, string message)
        {
            bool check = true;
            while (check)
            {
                Console.Write(message);
                if (Int32.TryParse(Console.ReadLine(), out checkNum))
                {
                    return checkNum;
                }
                Console.Clear();
                Loading();
            }
            return checkNum;
        }

        public static bool CheckBool(this ref bool checkNum, string message)
        {
            bool check = true;
            while (check)
            {
                Console.Write(message);
                if (Boolean.TryParse(Console.ReadLine(), out checkNum))
                {
                    return checkNum;
                }
                Console.Clear();
                Loading();
            }
            return checkNum;
        }

        public static double CheckDouble(this ref double checkNum, string message)
        {
            bool check = true;
            while (check)
            {
                Console.Write(message);
                if (Double.TryParse(Console.ReadLine(), out checkNum))
                {
                    return checkNum;
                }
                Console.Clear();
                Loading();
            }
            return checkNum;
        }
    }
}
