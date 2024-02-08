using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*a.	Определите переменные всех возможных примитивных типов С# 
             * и проинициализируйте их.   Осуществите ввод и вывод их значений
             * используя консоль. */

            Console.WriteLine("ПЕРВОЕ ЗАДАНИЕ\n");

            bool variant_1 = false;
            byte variant_2 = 255;
            sbyte variant_3 = 127;
            short variant_4 = 32767;
            ushort variant_5 = 65535;
            int variant_6 = 2147483647;
            uint variant_7 = 4294967295;
            long variant_8 = 9223372036854775807;
            ulong variant_9 = 18446744073709551615;
            float variant_10 = 5.6F;
            double variant_11 = 56.4455;
            char variant_12 = 'h';
            string variant_13 = "string";

            Console.WriteLine("Вывод значений: \n");
            Console.WriteLine($"bool - {variant_1}");
            Console.WriteLine($"byte - {variant_2}");
            Console.WriteLine($"sbyte - {variant_3}");
            Console.WriteLine($"short - {variant_4}");
            Console.WriteLine($"ushort- {variant_5}");
            Console.WriteLine($"int - {variant_6}");
            Console.WriteLine($"uint - {variant_7}");
            Console.WriteLine($"long - {variant_8}");
            Console.WriteLine($"ulong - {variant_9}");
            Console.WriteLine($"float - {variant_10}");
            Console.WriteLine($"double - {variant_11}");
            Console.WriteLine($"char - {variant_12}");
            Console.WriteLine($"string - {variant_13}");

            ////////////////////////////////////////////////////////
            Console.WriteLine("\n\nWrite a value : \n");
            Console.WriteLine("bool - ");
            variant_1 = bool.Parse(Console.ReadLine());
            Console.WriteLine("\nbyte - ");
            variant_2 = byte.Parse(Console.ReadLine());
            Console.WriteLine("\nsbyte - ");
            variant_3 = sbyte.Parse(Console.ReadLine());
            Console.WriteLine("\nshort - ");
            variant_4 = short.Parse(Console.ReadLine());
            Console.WriteLine("\nushort - ");
            variant_5 = ushort.Parse(Console.ReadLine());
            Console.WriteLine("\nint - ");
            variant_6 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nuint - ");
            variant_7 = uint.Parse(Console.ReadLine());
            Console.WriteLine("\nlong - ");
            variant_8 = long.Parse(Console.ReadLine());
            Console.WriteLine("\nulong - ");
            variant_9 = ulong.Parse(Console.ReadLine());
            Console.WriteLine("\nfloat - ");
            variant_10 = float.Parse(Console.ReadLine());
            Console.WriteLine("\ndouble - ");
            variant_11 = double.Parse(Console.ReadLine());
            Console.WriteLine("\nchar - ");
            variant_12 = char.Parse(Console.ReadLine());
            Console.WriteLine("\nstring - ");
            variant_13 = Console.ReadLine();



            Console.WriteLine("\n\nЯВНЫЕ_И_НЕЯВНЫЕ_ПРЕОБРАЗОВАНИЯ\n\n");
            Console.WriteLine("Неявные:\n");

            byte byte_Value = 100;

            short int16_Value = byte_Value;
            ushort uint16_Value = byte_Value;
            int int32_Value = byte_Value;
            uint uint32_Value = byte_Value;
            long int64_Value = byte_Value;

            Console.WriteLine("Byte   = " + byte_Value + "\n");
            Console.WriteLine("Short  = " + int16_Value + "\n");
            Console.WriteLine("UShort = " + uint16_Value + "\n");
            Console.WriteLine("Int    = " + int32_Value + "\n");
            Console.WriteLine("UInt   = " + uint32_Value + "\n");
            Console.WriteLine("Long   = " + int64_Value + "\n");

            Console.WriteLine("\nЯвные:\n");
            short value_1 = 1245;

            int value_2 = (int)value_1;
            byte value_3 = (byte)value_2;
            char value_4 = (char)value_3;
            double value_5 = (double)value_4;
            float value_6 = (float)value_5;

            Console.WriteLine("short  = " + value_1 + "\n");
            Console.WriteLine("int    = " + value_2 + "\n");
            Console.WriteLine("byte   = " + value_3 + "\n");
            Console.WriteLine("char   = " + value_4 + "\n");
            Console.WriteLine("double = " + value_5 + "\n");
            Console.WriteLine("float  = " + value_6 + "\n");


            //Класс Convert 
            Console.WriteLine("Класс Convert: ");
            int var_1111 = 1111;
            double var_2111 = Convert.ToDouble(var_1111);
            Console.WriteLine($"int     - {var_1111}\n");
            Console.WriteLine($"double  - {var_2111}\n");


            //c. Выполните упаковку и распаковку значимых типов
            //d. Продемонстрируйте работу с неявно типизированной переменной.
            int var_2222 = 2222;
            object var_3333 = var_2222;
            var var_4444 = (int)var_3333;
            Console.WriteLine($"Hello,  {var_4444}");


            //e. Продемонстрируйте пример работы с Nullable переменной
            int? var_x = null;
            int? var_y = 1;
            Console.WriteLine(var_x ?? var_y);

            /*f. Определите переменную типа var и присвойте ей любое значение.
            * Затем следующей инструкцией присвойте ей значение другого типа. Объясните причину ошибки
           */

            /*var var_vvv = 4;
            float var_float = 3.5f;
            var_vvv = var_float;*/

        }
    }
}
