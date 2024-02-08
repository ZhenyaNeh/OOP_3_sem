using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //МАССИВЫ
            //a. Создайте целый двумерный массив и выведите его на консоль в отформатированном виде (матрица). 
            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };

            Console.WriteLine("\n\nМатрица:");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }

            /*b. Создайте одномерный массив строк. Выведите на консоль его содержимое, длину массива. Поменяйте произвольный элемент
            (пользователь определяет позицию и значение).*/

            Console.WriteLine();

            string[] stringArray = { "First", "Second", "Third", "Fourth" };
            foreach (string str in stringArray)
                Console.Write($"{str}\t");
            Console.WriteLine($"\nДлина массива: {stringArray.Length}");

            Console.WriteLine($"Введите позицию замены (от 0 до {stringArray.Length - 1}):");
            int position = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите новую строку:");
            string newString = Console.ReadLine();

            stringArray[position] = newString;

            Console.WriteLine("Новый массив: ");
            foreach (string str in stringArray)
                Console.Write($"{str}\t");

            /*c. Создайте ступечатый (не выровненный) массив вещественных чисел с 3-мя строками, 
             * в каждой из которых 2, 3 и 4 столбцов соответственно. Значения массива введите с консоли.*/

            float[][] array1 = new float[3][];
            array1[0] = new float[2];
            array1[1] = new float[3];
            array1[2] = new float[4];

            Console.WriteLine("\nВведите элементы массива: ");
            for (var i = 0; i < array1.Length; i++)
            {
                for (var j = 0; j < array1[i].Length; j++)
                    array1[i][j] = float.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            Console.WriteLine("Массив: ");
            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array1[i].Length; j++)
                {
                    Console.Write($"{array1[i][j]} \t");
                }
                Console.WriteLine();
            }

            //d. Создайте неявно типизированные переменные для хранения массива и строки.
            var array2 = new[] { 1.5, 2.87, 3.23, 4.1 };
            var string1 = "abcdefgh";

            //КОРТЕЖИ
            //a.Задайте кортеж из 5 элементов с типами int, string, char, string, ulong.

            (int, string, char, string, ulong) myTuple = (-4, "Hello", 'a', "World", 199388384848);

            //b. Выведите кортеж на консоль целиком и выборочно ( например 1, 3, 4 элементы)
            Console.WriteLine("Кортеж: ");
            Console.WriteLine(myTuple);
            Console.WriteLine("Элементы кортежа (1, 3, 4): ");
            Console.WriteLine(myTuple.Item1);
            Console.WriteLine(myTuple.Item3);
            Console.WriteLine(myTuple.Item4);

            /*c. Выполните распаковку кортежа в переменные. Продемонстрируйте различные способы распаковки кортежа.
            Продемонстрируйте использование переменной(_).*/
            var firstItem = myTuple.Item1;
            var secondItem = myTuple.Item2;
            var thirdItem = myTuple.Item3;
            var fourthItem = myTuple.Item4;
            var fifthItem = myTuple.Item5;

            var (item1, item2, tem3, item4, item5) = myTuple;

            var (_, string11, _, string12, _) = (-4, "Hello", 'a', "World", 199388384848);

            //d. Сравните два кортежа.
            if (myTuple == myTuple)
                Console.WriteLine("Кортежи равны");
            else
                Console.WriteLine("Кортежи не равны");


            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //ЛОКАЛЬНАЯ ФУНКЦИЯ



            int[] arr = { 1, 2, 3, 4, 5, 6 };
            string str_For_Typle = "hello";

            var typle = Get_Information(arr, str_For_Typle);
            Console.WriteLine(typle);

            (int maxV, int minV, int sum, char letter) Get_Information(int[] _arr, string _str_For_Typle)
            {
                return (_arr.Max(), _arr.Min(), _arr.Sum(), _str_For_Typle[0]);
            }

            first();
            second();

            void first()
            {
                uint a = uint.MaxValue;
                unchecked
                {
                    Console.WriteLine(a + 3);  // вернет : 2
                }
            }

            void second()
            {
                uint a = uint.MaxValue;
                try
                {
                    checked
                    {
                        Console.WriteLine(a + 3);
                    }
                }
                catch (OverflowException e)
                {
                    Console.WriteLine(e.Message);  // вернет что произошло переполнение
                }
            }
        }
    }
}
