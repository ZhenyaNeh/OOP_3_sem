using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lab_03.List;

namespace lab_03
{
    public static class StatisticOperation
    {
        /*Создайте статический класс StatisticOperation, содержащий 3 метода для
        работы с вашим классом(по варианту п.1): сумма, разница между
        максимальным и минимальным, подсчет количества элементов.*/
        public static int Summa(List.LinkedList<int> list)
        {
            int result = 0;
            for (int i = 0; i < list.Count; i++)
            {
                result += list[i];
            }
            return result;

        }

        public static int DifferentBetwinMaxAndMin(List.LinkedList<int> list)
        {
            int maxNumber = -9999999;
            int minNumber = 9999999;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > maxNumber)
                    maxNumber = list[i];
            }

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < minNumber)
                    minNumber = list[i];
            }

            return (maxNumber - minNumber);
        }

        public static int CountOfElements(List.LinkedList<int> list)
        {
            return list.Count;
        }

        /*Методы расширения:
            1) Поиск самого длинного слова
            2) Удаление последнего элемента из списка*/

        public static string SerchLenght(this List.LinkedList<string> list)
        {
            int check = 0;
            string result = null;
            for (int i = 0; i < list.Count; i++)
            {
                if (check < list[i].Length)
                {
                    check = list[i].Length;
                    result = list[i];
                }
            }
            return result;
        }

        public static void RemoteLastElement(this List.LinkedList<string> list)
        {
            int countElements = list.Count;
            list.RemoveByIndex(countElements - 1);
        }
    }
}
