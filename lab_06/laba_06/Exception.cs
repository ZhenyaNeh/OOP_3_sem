using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_06
{
    internal class CountOfCopiesException : Exception
    {
        public int Value { get; set; }
        public CountOfCopiesException(string massage, int val) : base(massage) 
        {
            Value = val;
        }
    }

    internal class PublisherYearException : ArgumentOutOfRangeException
    {
        public int Value { get; set; }
        public PublisherYearException(string massage, int val) : base (massage)
        {
            Value = val;
        }
    }

    internal class CostException : Exception
    {
        public int Value { get; set; }
        public CostException(string massage, int val) : base(massage) 
        {
            Value= val;
        }
    }

    internal class StringException : Exception
    {
        public StringException(string massage) : base(massage)
        {
        }
    }

    internal class TestException : Exception
    {
        public TestException(string massage) : base(massage)
        {
        }
    }
}

