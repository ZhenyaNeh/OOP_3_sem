using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_08
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int life;
            var game = new Game(100);
            while (game.Health != 0)
            {
                life = game.WriteAndCheck("1 - Полученный урон \n2 - Полученное здоровье \n");
                Console.Clear();
                switch (life)
                {
                    case 1:
                        life = game.WriteAndCheck("Введите количество полученного урона");
                        game.Damage(life);
                        break;
                    case 2:
                        life = game.WriteAndCheck("Введите количество полученного здоровья"); ;
                        game.BustHeal(life);
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            }

            var classString = new ClassString("Привет, как дела");

            Action actionStr = classString.ShowStr;
            Predicate<string> predicateStr = (string a) => a.Length > 20;

            Func<string, string> funcStr = classString.AddSymbol;
            funcStr += classString.DeletePunctuation;
            funcStr += classString.ToUpperStr;
            funcStr += classString.ToLowerStr;
            funcStr += classString.LengthStr;
            funcStr += classString.DeleteSpace;
            funcStr += classString.LengthStr;

            actionStr();
            funcStr(classString.SomethingString);
            Console.WriteLine($"Строка больше 20?: {predicateStr(classString.SomethingString)}");
        }
    }
}
