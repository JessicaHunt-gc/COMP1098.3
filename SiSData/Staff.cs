using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
//https://github.com/justinhuntgc/COMP1098.3
namespace SiS
{
    [Serializable]
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
            Courses = new List<Course>();
            Addresses = new List<Address>();
            Manager?.addSubordinate(this);
        }


        #region Seriailizable implementation
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("FirstName", FirstName, typeof(string));
            info.AddValue("LastName", LastName, typeof(string));
            info.AddValue("ID", ID, typeof(Identification));
            info.AddValue("Position", Position, typeof(string));
            info.AddValue("Salary", Salary, typeof(decimal));
            info.AddValue("StartDate", StartDate, typeof(DateTime));
            info.AddValue("Addresses", Addresses, typeof(List<Address>));

            //save only enough info to find the following:
            info.AddValue("Manager", Manager, typeof(Staff));
            info.AddValue("Subordinates", Subordinates, typeof(List<Staff>));
        }

        // The special constructor is used to deserialize values.
        public Staff(SerializationInfo info, StreamingContext context)
        {
            FirstName = (string)info.GetValue("FirstName", typeof(string));
            LastName = (string)info.GetValue("LastName", typeof(string));
            ID = (Identification)info.GetValue("ID", typeof(Identification));
            Position = (string)info.GetValue("Position", typeof(string));
            Salary = (Decimal)info.GetValue("Salary", typeof(Decimal));
            StartDate = (DateTime)info.GetValue("StartDate", typeof(DateTime));            
            Addresses = (List<Address>)info.GetValue("Addresses", typeof(List<Address>));
            Manager = (Staff)info.GetValue("Manager", typeof(Staff));
            Subordinates = (List<Staff>)info.GetValue("Subordinates", typeof(List<Staff>));           
        }
        #endregion
    }
}
