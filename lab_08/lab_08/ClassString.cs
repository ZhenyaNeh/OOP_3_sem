using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_08
{
    public class ClassString
    {
        delegate void WriteStr(string massage);
        event WriteStr EventWrite;

        public string SomethingString { get; set; }

        public ClassString(string somethingString)
        {
            SomethingString = somethingString;
            EventWrite += DisplayMessage;
        }

        public void DisplayMessage(string message) => Console.WriteLine(message);

        public string AddSymbol(string str)
        {
            Console.WriteLine("Введите что-нибудь");
            string newSymbol = Console.ReadLine();
            SomethingString += newSymbol;
            EventWrite.Invoke($"\n_AddSymbol_ \nНовая строка: '{SomethingString}' \n");
            return SomethingString;
        }

        public string DeletePunctuation (string str)
        {
            SomethingString = SomethingString.Replace(",", "");
            EventWrite.Invoke($"_DeletePunctuation_ \nНовая строка: '{SomethingString}' \n");
            return SomethingString;
        }

        public string ToUpperStr(string str)
        {
            SomethingString = SomethingString.ToUpper();
            EventWrite.Invoke($"_ToUpperStr_ \nНовая строка: '{SomethingString}' \n");
            return SomethingString;
        }

        public string ToLowerStr(string str)
        {
            SomethingString = SomethingString.ToLower();
            EventWrite.Invoke($"_ToLowerStr_ \nНовая строка: '{SomethingString}' \n");
            return SomethingString;
        }
     
        public string DeleteSpace(string str)
        {
            SomethingString = SomethingString.Replace(" ", "");
            EventWrite.Invoke($"_DeleteSpace_ \nНовая строка: '{SomethingString}' \n");
            return SomethingString;
        }

        public string LengthStr(string str)
        {
            EventWrite.Invoke($"_LengthStr_ \nСтрока: '{SomethingString}' имеет длмнну: {SomethingString.Length} \n");
            return SomethingString;
        }

        public void ShowStr() => EventWrite.Invoke($"\"_ShowStr_ \nНачальная строка: '{SomethingString}' \n");
        
    }
}
