using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_17_18
{
    public class TravelAgentBuilder : ITravelAgentBuilder
    {
        private TravelAgent _travelAgent;

        private readonly Client _client;
        private readonly IEnumerable<Tours> _tours;

        public TravelAgentBuilder(Client client, IEnumerable<Tours> tours)
        {
            _client = client;
            _tours = tours;
            _travelAgent = TravelAgent.GetInstance();
        }

        public void BuildHeader()
        {
            _travelAgent.Header =
                $"CLIENT ON DATA: {DateTime.Now}\n";

            _travelAgent.Header +=
                "-------------------------------------------------------------";
        }

        public void BuildClientInfo()
        {
            _travelAgent.ClientInfo =
               $"\nClient name: {_client.ClientName}\n" + 
               $"Client ID: {_client.IdNumb}\n\n";
        }

        public void BuildTourInfo()
        {
            _travelAgent.TourInfo =
                string.Join(Environment.NewLine,
                _tours.Select(el =>
                $"Name tour: {el.Name} \n" +
                $"Is hot tour: {el.IsHotDeal}\n" +
                $"Base price: {el.BasePrice}$\n"));
        }

        public void BuildFooter()
        {
            _travelAgent.Footer =   
                "-------------------------------------------------------------";

            _travelAgent.Footer +=
                $"\nTOTAL TOURS: {_tours.Count()}";
        }

        public TravelAgent GetTravelAgent()
        {
           TravelAgent travelAgent = _travelAgent;

            _travelAgent = TravelAgent.GetInstance();

            return travelAgent;
        }
    }
}
