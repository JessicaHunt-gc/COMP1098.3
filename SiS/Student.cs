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
        public DateTime DateOfBirth { get; private set; }

        
        public Student(String FirstName, String LastName,
            DateTime dateOfBirth)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            DateOfBirth = dateOfBirth;
        }
    }
}
