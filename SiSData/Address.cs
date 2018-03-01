using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SiS
{
    public enum AddressTypes { Mailing, Home, Business }

    [Serializable]
    public class Address :ISerializable
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

        #region Serialiazable implementation
        // Implement this method to serialize data. The method is called 
        // on serialization.
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            // Use the AddValue method to specify serialized values.
            info.AddValue("Line1", Line1, typeof(String));
            info.AddValue("Line2", Line2, typeof(String));
            info.AddValue("City", City, typeof(String));
            info.AddValue("Province", Province, typeof(String));
            info.AddValue("Country", Country, typeof(String));
            info.AddValue("AddressType", AddressType, typeof(AddressTypes));
            info.AddValue("Person", Person, typeof(IPerson));
        }

        // The special constructor is used to deserialize values.
        public Address(SerializationInfo info, StreamingContext context)
        {
            Line1 = (String)info.GetValue("Line1", typeof(String));
            Line1 = (String)info.GetValue("Line2", typeof(String));
            Line1 = (String)info.GetValue("City", typeof(String));
            Line1 = (String)info.GetValue("Province", typeof(String));
            Line1 = (String)info.GetValue("Country", typeof(String));
            AddressType = (AddressTypes)info.GetValue("AddressType", typeof(AddressTypes));
            Person = (IPerson)info.GetValue("Person", typeof(IPerson));
        }
        
        #endregion


    }
}
