using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace laba_16
{
    class Tours
    {
        public string Name { get; set; }
        public bool IsHotDeal { get; set; }
        public double BasePrice { get; set; }
        public double CountTuors { get; set; }

        public double price;
        public double Price
        {
            get => price;
            set
            {
                if (CountTuors <= 1)
                {
                    double discount = 0.25;
                    price = BasePrice - (BasePrice * discount);
                }
                if (CountTuors > 1 && !IsHotDeal)
                {
                    double discount = CountTuors / 100 + 0.05;
                    price = BasePrice - (BasePrice * discount);
                }
                if (CountTuors > 1 && IsHotDeal)
                {
                    double discount = CountTuors / 100 + 0.05 + 0.25;
                    price = BasePrice - (BasePrice * discount);
                }
            }
        }

        public Tours(string name, bool isHotDeal, double basePrice, int count)
        {

            Name = name;
            IsHotDeal = isHotDeal;
            BasePrice = basePrice;
            CountTuors = count;
            Price = basePrice;
        }

        public override string ToString()
        {
            return $"Name Tours: {Name} \n" +
                   $"Is Hot Tour: {IsHotDeal} \n" +
                   $"Base Price: {BasePrice}$ \n" +
                   $"Price including discount: {price}$ \n";
        }
    }
}
