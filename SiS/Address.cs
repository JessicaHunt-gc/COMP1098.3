using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiS
{
    public enum AddressTypes { Mailing, Home, Business }
    public class Address
    {
        public String Line1 { get; set; }
        public String Line2 { get; set; }
        public String City { get; set; }
        public String Province { get; set; }
        public String Country { get; set; }
        public AddressTypes AddressType { get; set; }
        public IPerson Person { get; private set; }

        public Address (String line1, String line2, String city, String province, String country, AddressTypes addressType,IPerson person)
        {
            Line1 = line1;
            Line2 = line2;
            City = city;
            Province = province;
            Country = country;
            AddressType = addressType;
            Person = person;
            
        }
    }
}
