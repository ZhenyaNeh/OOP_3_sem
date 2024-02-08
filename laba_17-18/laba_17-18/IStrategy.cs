using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_17_18
{
    public interface IStrategy
    {
        object DoAlgorithm(object data);
    }
}
