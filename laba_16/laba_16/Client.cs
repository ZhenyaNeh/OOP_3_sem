using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_16
{
    class Client
    {
        public string ClientName { get; set; } = "";
        public string IdNumb { get; set; }
        public int CountTuors { get; set; } = 0;

        public Client(string clientName)
        {
            ClientName = clientName;
            IdNumb = GetIdNumb();
        }

        private string GetIdNumb()
        {
            Guid newGuid = Guid.NewGuid();
            string? code = Convert.ToString(newGuid);
            return code;
        }

        public override string ToString()
        {
            return $"Client Name: {ClientName} \n" +
                   $"Client ID: {IdNumb} \n";
        }
    }
}
