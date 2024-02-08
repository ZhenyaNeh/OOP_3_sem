using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Xml.Linq;

namespace laba_16
{
    class TravelAgent
    {
        private Dictionary<Client, List<Tours>> poolTourse;
        private List<Client> clients;
        private List<Tours> tours;

        public static int CountTurs = 0;

        public TravelAgent()
        {
            clients = new List<Client>();
            tours = new List<Tours>();
            poolTourse = new Dictionary<Client, List<Tours>>();
        }

        public void RegisterClient(string clientName)
        {
            clients.Add(new Client(clientName));
        }

        public string GetClientID(string name)
        {
            var client = clients.FirstOrDefault(t => t.ClientName == name);
            if (client != null)
            {
                return client.IdNumb;
            }
            return "no such client exists";
        }

        public void ViewClients()
        {
            foreach (var client in clients)
            {
                Console.WriteLine(client.ToString());
            }
        }

        public bool SignIn(string name, string id)
        {
            return clients.Any(u => u.ClientName == name && u.IdNumb == id);
        }

        public void ViewTours()
        {
            foreach (var tour in tours)
            {
                Console.WriteLine(tour.ToString());
            }
        }

        public void AddTour(string name, bool isHotDeal, double BasePrice)
        {
            CountTurs++;
            tours.Add(new Tours(name, isHotDeal, BasePrice, CountTurs));
        }

        public void RemoveTour(string name)
        {
            var tourToRemove = tours.FirstOrDefault(t => t.Name == name);
            if (tourToRemove != null)
            {
                tours.Remove(tourToRemove);
            }
        }

        public void ModifyTour(string name, bool newIsHotDeal, double newPrice)
        {
            var tourToModify = tours.FirstOrDefault(t => t.Name == name);
            if (tourToModify != null)
            {
                tourToModify.Price = newPrice;
                tourToModify.IsHotDeal = newIsHotDeal;
            }
        }

        public void ViewAllClients()
        {
            foreach (var clientInDic in poolTourse.Keys)
            {
                Console.WriteLine("=============================");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(clientInDic.ToString());
                Console.ResetColor();
                foreach (var toursClient in poolTourse[clientInDic])
                {
                    Console.WriteLine(toursClient.ToString());
                }
            }
        }

        public void SeveClient()
        {
            if (!poolTourse.ContainsKey(clients.First()))
            {
                List<Tours> list = new List<Tours>();
                list = tours.ToList();
                poolTourse.Add(clients.First(), list);

                clients.Clear();
                tours.Clear();
                CountTurs = 0;
            }
        }
    }
}
