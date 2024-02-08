using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_08
{
    internal class Game
    {
        public delegate void MyGame(string message);
        public event MyGame Attack;
        public event MyGame Heal;

        public int Health { get; set; } = 100;

        public void DisplayMessage(string message) => Console.WriteLine(message);

        public Game()
        {
            Attack += DisplayMessage;
            Heal += DisplayMessage;
        }
        public Game(int health)
        {
            Health = health;
            Attack += DisplayMessage;
            Heal += DisplayMessage;
        }

        public void BustHeal(int heal)
        {
            Console.Clear();
            if (Health + heal >= 100)
            {
                Health = 100;
                Console.ForegroundColor = ConsoleColor.Green;
                Heal($"Пополнение здоровья на {heal}");
                Console.ResetColor();
                Informathion();
            }
            else
            {
                Health += heal;
                Console.ForegroundColor = ConsoleColor.Green;
                Heal($"Пополнение здоровья на {heal}");
                Console.ResetColor();
                Informathion();
            }
            Console.ReadKey();
            Console.Clear();
        }

        public void Damage(int damage)
        {
            Console.Clear();
            if (Health - damage <= 0)
            {
                Health = 0;
                Console.ForegroundColor = ConsoleColor.Red;
                Attack($"GAME_OVER!!!");
                Console.ResetColor();
                Informathion();
            }
            else
            {
                Health -= damage;
                Console.ForegroundColor = ConsoleColor.Red;
                Attack($"Здоровье уменьшилось на {damage}");
                Console.ResetColor();
                Informathion();
            }
            Console.ReadKey();
            Console.Clear();
        }

        public void Informathion()
        {
            if (Health >= 50)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Текущее здоровье - {Health} \n");
                Console.ResetColor();
            }
            else if (Health < 50 && Health >= 25)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Текущее здоровье - {Health} \n");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Текущее здоровье - {Health} \n");
                Console.ResetColor();
            }

        }

        public int WriteAndCheck(string str)
        {
            int num = 0;
            bool check = false;
            while (!check)
            {
                Console.WriteLine(str);
                string life = Console.ReadLine();
                check = Int32.TryParse(life, out num);
               /* if (check)
                    if (num > 2 || num < 1)
                    {
                        check = false;
                        Console.Clear();
                        Console.WriteLine($"Error!!! \n\"{life}\" is not a correct data \nTry again\n");
                        continue;
                    }*/
                if (!check)
                {
                    Console.Clear();
                    Console.WriteLine($"Error!!! \n\"{life}\" is not a number \nTry again\n");
                    continue;
                }
            }
            return num;
        }
    }
}
