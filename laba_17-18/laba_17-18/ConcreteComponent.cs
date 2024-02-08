using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_17_18
{
    class ConcreteComponent : Component
    {
        public override string Operation()
        {
            return "Sunny ";
        }
    }
}
