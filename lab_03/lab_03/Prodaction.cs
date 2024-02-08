using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_03
{
    public class Production
    {
        private readonly int OrganizationID;
        public string OrganizationName { get; set; }

        public Production()
        {
            OrganizationID = GetHashCode();
        }
        public Production(string name)
        {
            OrganizationID = GetHashCode();
            this.OrganizationName = name;
        }
    }
}
