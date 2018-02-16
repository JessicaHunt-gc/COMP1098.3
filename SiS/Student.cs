using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiS
{
    public class Student : IPerson
    {
        public String FirstName { get; protected set; }
        public String LastName { get; protected set; }
        public Identification ID { get; protected set; }
        public DateTime DateOfBirth { get; private set; }

        public List<CollegeProgram> Programs { get; private set; }
        public List<Address> Addresses { get; private set; }
        public Student(String FirstName, String LastName,
            DateTime dateOfBirth)
        {
            ID = new Identification(this);
            this.FirstName = FirstName;
            this.LastName = LastName;
            DateOfBirth = dateOfBirth;
        }
    }
}
