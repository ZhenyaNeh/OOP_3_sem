using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;

namespace laba_17_18
{
    public interface IObserver
    {
        void Update(ISubject subject);
    }
}
