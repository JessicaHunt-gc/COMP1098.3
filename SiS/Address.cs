using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiS
{
    public enum AddressTypes { Mailing, Home, }
    public class Address
    {
        public String Line1 { get; set; }
        public String Line2 { get; set; }
        public String City { get; set; }
        public String Province { get; set; }
        public String Country { get; set; }
        //public String Line1 { get; set; }

    }
}
