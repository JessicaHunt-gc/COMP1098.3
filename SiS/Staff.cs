using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://github.com/justinhuntgc/COMP1098.3
namespace SiS
{
    public class Staff : IPerson
    {
        public String FirstName { get; protected set; }
        public String LastName { get; protected set; }
        public Identification ID { get; protected set; }

        public String Position { get; private set; }
        public Decimal Salary { get; private set; }
        public DateTime StartDate { get; private set; }

        public Staff Manager { get; private set; }
        public List<Staff> Subordinates { get; private set; }
        public List<Address> Addresses { get; private set; }

        public List<Course> Courses { get; private set; }

        public void addSubordinate (Staff subordinate)
        {
            if (Subordinates != null &&
                subordinate != null)
                Subordinates.Add(subordinate);
        }
        
        public void addCourse(Course c)
        {
            Courses.Add(c);
        }

        public Staff(String firstName,String lastName,
            String position, Decimal salary,
            DateTime startDate, Staff manager)
        {
            ID = new Identification(this);
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
