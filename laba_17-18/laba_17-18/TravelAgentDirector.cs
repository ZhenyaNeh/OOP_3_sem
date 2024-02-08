using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_17_18
{
    public class TravelAgentDirector
    {
        private readonly ITravelAgentBuilder _builder;

        public TravelAgentDirector(ITravelAgentBuilder builder)
        {
            _builder = builder;
        }

        public void Build()
        {
            _builder.BuildHeader();
            _builder.BuildClientInfo();
            _builder.BuildTourInfo();
            _builder.BuildFooter();
        }
    }
}
