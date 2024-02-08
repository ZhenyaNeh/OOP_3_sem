using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace lab_13
{
    public class DirectoryAndFileWorker
    {
        public static void SerializedBinary<T>(T obj, string path)
        {
            path += "\\BINARY.dat";
#pragma warning disable SYSLIB0011
            Console.WriteLine("\n------------BinarySerializetion------------");
            var formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                formatter.Serialize(fs, obj);
                Console.WriteLine("Объект сериализован...");
            }

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                var deserialization = (T)formatter.Deserialize(fs);
                Console.WriteLine("Объект десериализован: \n");

                var books = deserialization as Book[];
                if (books == null)
                    Console.WriteLine(deserialization.ToString());
                else
                    foreach (var el in books)
                        Console.WriteLine(el.ToString());
            }

            Console.WriteLine("------------------------------------");
#pragma warning restore SYSLIB0011
        }

        public static void SerializedSoap<T>(T obj, string path)
        {
            path += "\\SOAP.soap";
            Console.WriteLine("\n------------SoapSerializetion------------");
            var formatter = new SoapFormatter();
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                formatter.Serialize(fs, obj);
                Console.WriteLine("Объект сериализован...");
            }

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                var deserialization = (T)formatter.Deserialize(fs);
                Console.WriteLine("Объект десериализован: \n");

                var books = deserialization as Book[];
                if (books == null)
                    Console.WriteLine(deserialization.ToString());
                else
                    foreach (var el in books)
                        Console.WriteLine(el.ToString());
            }

            Console.WriteLine("------------------------------------");
        }

        public static void SerializedXml<T>(T obj, string path)
        {
            path += "\\XML.xml";
            Console.WriteLine("\n------------XmlSerializetion------------");
            var formatter = new XmlSerializer(typeof(T));

            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                formatter.Serialize(fs, obj);
                Console.WriteLine("Объект сериализован...");
            }

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                var deserialization = formatter.Deserialize(fs);
                Console.WriteLine("Объект десериализован: \n");

                var books = deserialization as Book[];
                if (books == null)
                    Console.WriteLine(deserialization.ToString());
                else
                    foreach (var el in books)
                        Console.WriteLine(el.ToString());
            }
            Console.WriteLine("------------------------------------");
        }

        public static void SerializedJson<T>(T obj, string path)
        {
            path += "\\JSON.json";
            Console.WriteLine("\n------------JsonSerializetion------------");
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                JsonSerializer.Serialize<T>(fs, obj);
                Console.WriteLine("Объект сериализован...");
            }

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                T? deserialization = JsonSerializer.Deserialize<T>(fs);
                Console.WriteLine("Объект десериализован: \n");

                var books = deserialization as Book[];
                if (books == null)
                    Console.WriteLine(deserialization.ToString());
                else
                    foreach (var el in books)
                        Console.WriteLine(el.ToString());
            }
            Console.WriteLine("------------------------------------");
        }

        public static void CreateDirectory(string path)
        {
            var directory = new DirectoryInfo(path);
            if (!directory.Exists)
            {
                directory.Create();
            }
        }
    }
}
