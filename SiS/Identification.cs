using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiS
{
    public class Identification
    {
        private static int idKey = 1;
        public int ID { get; private set; }
        public IPerson Person { get; private set; }
        public Identification(IPerson person)
        {
            Person = person;
            ID = Identification.idKey++;
        }
    }
}
