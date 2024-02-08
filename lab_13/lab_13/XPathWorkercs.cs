using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace lab_13.Serialization_Librrary
{
    internal class XPathWorkercs
    {
        public static void WorkXpath(string path)
        {
            var pathToXml = path + "\\XML.xml";

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(pathToXml);
            XmlElement? xRoot = xDoc.DocumentElement;

            //1.
            XmlNodeList? nodes = xRoot?.SelectNodes("*");
            if (nodes is not null)
            {
                foreach (XmlNode node in nodes)
                    Console.WriteLine(node.OuterXml + "\n");
            }

            //2.
            XmlNodeList? costNodes = xRoot?.SelectNodes("//Book/Cost");
            if (costNodes is not null)
            {
                foreach (XmlNode node in costNodes)
                    Console.WriteLine(node.InnerText);
                Console.WriteLine();
            }
        }
    }
}
