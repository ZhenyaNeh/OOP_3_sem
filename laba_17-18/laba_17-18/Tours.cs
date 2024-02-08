using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace laba_17_18
{
    public class Tours
    {
        public string Name { get; set; }
        public bool IsHotDeal { get; set; }
        public int BasePrice { get; set; }

        public IdInfo IdInfo;

        public Tours ShallowCopy()
        {
            return (Tours)this.MemberwiseClone();
        }

        public Tours DeepCopy()
        {
            Tours clone = (Tours)this.MemberwiseClone();
            clone.IdInfo = new IdInfo(IdInfo.IdNumber);
            clone.Name = String.Copy(Name);
            return clone;
        }

        public void TourCode(Component component)
        {
            Console.WriteLine("RESULT: " + component.Operation());
        }
    }

    public class IdInfo
    {
        public int IdNumber;

        public IdInfo(int idNumber)
        {
            this.IdNumber = idNumber;
        }
    }
}
