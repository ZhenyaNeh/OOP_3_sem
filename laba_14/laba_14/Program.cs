using System.Diagnostics;

namespace laba_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetProc.ProcInfo();
            GetProc.DomainInfo();
            GetProc.AnotherTread();

            GetProc.WorkTread();
            GetProc.TimeWork();
        }
    }
}