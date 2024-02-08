using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab_13.Serialization_Librrary
{
    internal class LinqToXml
    {
        public static void WorkLinqXml(string path)
        {
            var newPathXml = path + "\\NewXml.xml";
            if (!File.Exists(newPathXml))
                File.Create(newPathXml);

            XDocument xdoc2 = new XDocument();
            XElement xmlBook1 = new XElement("book");

            XAttribute attributeBook1 = new XAttribute("name", "книга_1");
            XElement elementBook1 = new XElement("cost", 24);
            XElement elementBook2 = new XElement("page", 400);

            xmlBook1.Add(attributeBook1);
            xmlBook1.Add(elementBook1);
            xmlBook1.Add(elementBook2);

            XElement xmlBook2 = new XElement("book");

            XAttribute attributeBook2 = new XAttribute("name", "книга_2");
            XElement elementBook3 = new XElement("cost", 24);
            XElement elementBook4 = new XElement("page", 500);

            xmlBook2.Add(attributeBook2);
            xmlBook2.Add(elementBook3);
            xmlBook2.Add(elementBook4);

            XElement library = new XElement("library");

            library.Add(xmlBook1);
            library.Add(xmlBook2);

            xdoc2.Add(library);
            xdoc2.Save(newPathXml);

            var sortedName = xdoc2.Element("library")?
                                  .Elements("book")
                                  .Where(x => x.Attribute("name")?.Value == "книга_1")
                                  .Select(x => new
                                  {
                                      name = x.Attribute("name")?.Value,
                                      cost = x.Element("cost")?.Value,
                                      page = x.Element("page")?.Value
                                  });

            Console.WriteLine("Linq to Xml:");
            if (sortedName is not null)
                foreach (var element in sortedName)
                    Console.WriteLine($"Name: {element.name} \n" +
                                      $"Cost: {element.cost} \n" +
                                      $"Page: {element.page} \n"
                                      );
        }
    }
}
