using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_13
{
    [Serializable]
    public class PrintedEdition
    {
        public string? PublishType { get; set; }
        public int Cost { get; set; }
        public int CountPages { get; set; }

        public PrintedEdition(string? publishType, int cost, int countPages)
        {
            PublishType = publishType;
            Cost = cost;
            CountPages = countPages;
        }

        public PrintedEdition() {}

        public override string ToString()
        {
            return $"Publish Type: {PublishType} \n" +
                   $"Cost: {Cost}$" +
                   $"Count Pages: {CountPages}";
        }
    }
}
