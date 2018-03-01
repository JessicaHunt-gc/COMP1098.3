using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SiS
{
    
    public interface IPerson : ISerializable
    {
        Identification ID { get; }
        String FirstName { get; }
        String LastName { get; }
        List<Address> Addresses { get; }

    }
}
