using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace lab_11
{
    internal static class Reflector
    {
        static string path;
        static bool createOrClear = false;

        static Reflector()
        {
            path = "..\\..\\..\\first.txt";
        }

        public static void GetName(Type type)
        {
            Console.WriteLine(type.Assembly);
            InFile(type.Assembly);
        }

        public static bool PublicCtor(Type type)
        {
            foreach (var ctor in type.GetConstructors())
            {
                if (ctor.IsPublic)
                {
                    InFile(true);
                    return true;
                }
            }
            InFile(false);
            return false;
        }

        public static IEnumerable<string> PublicMethods(Type type)
        {
            var list = new List<string>();
            foreach (var method in type.GetMethods(BindingFlags.Instance |
                                                  BindingFlags.Public    |
                                                  BindingFlags.Static))
            {
                list.Add($"{method.DeclaringType} {method.Name}");
                InFile($"{method.DeclaringType} {method.Name}");
            }
            return list;
        }

        public static IEnumerable<string> InfAboutFieldsAndProp(Type type)
        {
            var list = new List<string>();
            foreach (var filed in type.GetFields(BindingFlags.Instance |
                                                 BindingFlags.Static   |
                                                 BindingFlags.Public   |
                                                 BindingFlags.NonPublic))
            {
                list.Add(filed.Name);
                InFile($"{filed.Name}");
            }
            foreach (var prop in type.GetProperties(BindingFlags.Instance |
                                                    BindingFlags.Static   |
                                                    BindingFlags.Public   |
                                                    BindingFlags.NonPublic))
            {
                list.Add($"{prop.PropertyType.Name} {prop.Name}");
                InFile($"{prop.PropertyType.Name} {prop.Name}");
            }
            return list;
        }

        public static IEnumerable<string> AllInterfaces(Type type)
        {
            var list = new List<string>();
            foreach (var method in type.GetInterfaces())
            {
                list.Add(method.Name);
                InFile($"{method.Name}");
            }
            return list;
        }

        public static IEnumerable<string> MethodsOfClass(string name, string nameType)
        {
            var list = new List<string>();
            foreach (var method in Type.GetType(name, false, false).
                                        GetMethods(BindingFlags.Instance |
                                                   BindingFlags.Public   |
                                                   BindingFlags.NonPublic))
            {
                foreach (var parms in method.GetParameters())
                    if (parms.ParameterType.Name == nameType)
                    {
                        list.Add($"{method.Name}");
                        InFile($"{method.Name}");
                    }
            }
            return list;
        }

        static public void InvokeFile(string name, string method, object[] param)
        {
            Type? type = Type.GetType(name);
            object? instanc = Activator.CreateInstance(type);
            MethodInfo? metod = type.GetMethod(method);

            metod.Invoke(instanc, param);
        }

        static public object Generator(Type type)
        {
            Random rnd = new Random();
            int randomValueInt = rnd.Next(0, 100);
            string? randomValueStr = randomValueInt.ToString();

            if (type == typeof(int))
                return randomValueInt;
            if (type == typeof(string))
                return randomValueStr;

            return null;
        }

        public static T Create<T>()
        {
            Type type = typeof(T);
            var constructors = type.GetConstructors();

            if(constructors.Length == 0)
                throw new InvalidOperationException("Тип не имеет публичных конструкторов.");
            
            var constructor = constructors.First();
            var parameters = constructor.GetParameters();

            var args = new object[parameters.Length];

            for(int i = 0; i < parameters.Length; i++)
            {
                if (parameters[i].ParameterType == typeof(string))
                    args[i] = "defaulr string";
                if (parameters[i].ParameterType == typeof(int))
                    args[i] = 1111;
                if (parameters[i].ParameterType == typeof(bool))
                    args[i] = true;
            }

            T instance = (T)constructor.Invoke(args);
            return instance;
        }

        public static void WriteInormation(string info)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(info);
            Console.ResetColor();
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine($"{info}");
            }
        }

        public static void InFile<T>(T info)
        {
            if (!createOrClear)
            {
                createOrClear = true;
                using (StreamWriter sw = File.CreateText(path));
            }
            else
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine($"  {info}");
                }
            }
        }
    }
}
