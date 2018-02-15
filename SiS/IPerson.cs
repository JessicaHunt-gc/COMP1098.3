using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiS
{
    public interface IPerson
    {
        Identification ID { get; }
        String FirstName { get; }
        String LastName { get; }
    }
}
