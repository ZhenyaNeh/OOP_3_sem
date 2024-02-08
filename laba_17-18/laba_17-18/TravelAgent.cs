using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Xml.Linq;

namespace laba_17_18
{
    public class TravelAgent
    {
        public string Header {  get; set; }
        public string ClientInfo { get; set; }
        public string TourInfo { get; set; }
        public string Footer { get; set; }

        private TravelAgent() { }

        private static TravelAgent _instance;

        public static TravelAgent GetInstance()
        {
            if (_instance == null)
            {
                _instance = new TravelAgent();
            }
            return _instance;
        }

        public override string ToString() =>
            new StringBuilder()
            .Append(Header)
            .Append(ClientInfo)
            .Append(TourInfo)
            .Append(Footer)
            .ToString();

        public void Main()
        {
            Console.WriteLine("Client: Testing client code with the first factory type...");
            ClientMethod(new ConcreteFactory1());
            Console.WriteLine();

            Console.WriteLine("Client: Testing the same client code with the second factory type...");
            ClientMethod(new ConcreteFactory2());
        }

        public void ClientMethod(IAbstractFactory factory)
        {
            var productA = factory.CreateProductA();
            var productB = factory.CreateProductB();

            Console.WriteLine(productB.UsefulFunctionB());
            Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
        }
    }
}
