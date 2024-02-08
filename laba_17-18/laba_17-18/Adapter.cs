using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_17_18
{
    class Adapter : ITarget
    {
        private readonly TravelAgent _agent;

        public Adapter(TravelAgent agent)
        {
            this._agent = agent;
        }

        public void Main()
        {
            this._agent.Main();
        }
    }
}
