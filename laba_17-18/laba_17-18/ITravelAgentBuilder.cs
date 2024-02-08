using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_17_18
{
    public interface ITravelAgentBuilder
    {
        void BuildHeader();
        void BuildClientInfo();
        void BuildTourInfo();
        void BuildFooter();

        TravelAgent GetTravelAgent();
    }
}
