using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiS
{
    public class Staff : IPerson
    {
        public String FirstName { get; protected set; }
        public String LastName { get; protected set; }
        public String Position { get; private set; }
        public Decimal Salary { get; private set; }
        public DateTime StartDate { get; private set; }

        public Staff Manager { get; private set; }
        public List<Staff> Subordinates { get; private set; }

        public void addSubordinate (Staff subordinate)
        {
            if (Subordinates != null &&
                subordinate != null)
                Subordinates.Add(subordinate);
        }

        public Staff(String firstName,String lastName,
            String position, Decimal salary,
            DateTime startDate, Staff manager)
        {
            LastName = lastName;
            FirstName = firstName;
            Subordinates = new List<Staff>();
            Position = position;
            Salary = salary;
            Manager = manager;
            Manager?.addSubordinate(this);
        }
    }
}
