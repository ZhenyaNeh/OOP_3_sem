using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Text.Json;
using System.Xml;
using System.Xml.Linq;
using lab_13.Serialization_Librrary;

namespace lab_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var print1 = new PrintedEdition("книга", 12, 100);
            var print2 = new PrintedEdition("журнал", 12, 100);
            var book1 = new Book(print1, "фанатастика");
            var book2 = new Book(print2, "новости");

            Book[] books = { book1, book2 };
            /*foreach (var el in books)
            {
                Console.WriteLine(el.ToString());
            }*/

            string path = "..\\..\\..\\Serialization_Librrary";
            DirectoryAndFileWorker.CreateDirectory(path);
            DirectoryAndFileWorker.SerializedBinary(book1, path);
            DirectoryAndFileWorker.SerializedSoap(book1, path);
            DirectoryAndFileWorker.SerializedXml(book1, path);
            DirectoryAndFileWorker.SerializedJson(book1, path);

            DirectoryAndFileWorker.SerializedBinary(books, path);
            DirectoryAndFileWorker.SerializedSoap(books, path);
            DirectoryAndFileWorker.SerializedXml(books, path);
            DirectoryAndFileWorker.SerializedJson(books, path);

            XPathWorkercs.WorkXpath(path);
            LinqToXml.WorkLinqXml(path);
        }
    }
}