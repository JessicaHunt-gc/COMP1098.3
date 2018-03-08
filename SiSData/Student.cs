using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SiS
{
    [Serializable]
    public class Student : IPerson
    {
        public String FirstName { get; protected set; }
        public String LastName { get; protected set; }
        public Identification ID { get; protected set; }
        public DateTime DateOfBirth { get; private set; }

        public List<CollegeProgram> Programs { get; private set; }
        public List<Address> Addresses { get; private set; }

        public List<Course> Courses { get; private set; }

        public void addCourse(Course c)
        {            
            Courses.Add(c);                        
        }
        //public XElement createXMLTree()
        //{

        //}
        public Student(String FirstName, String LastName,
            DateTime dateOfBirth, bool generateID = true)
        {
            if(generateID)
                ID = new Identification(this);
            this.FirstName = FirstName;
            this.LastName = LastName;
            DateOfBirth = dateOfBirth;
            Courses = new List<Course>();
            Addresses = new List<Address>();
        }

        public Student(String FirstName, String LastName,
            DateTime dateOfBirth,int ID) : this(FirstName,LastName,dateOfBirth,false)
        {
            this.ID = new Identification(ID, this);
        }

        #region Seriailizable implementation
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {           
            info.AddValue("FirstName", FirstName, typeof(string));
            info.AddValue("LastName", LastName, typeof(string));
            info.AddValue("ID", ID, typeof(Identification));
            info.AddValue("DateOfBirth", DateOfBirth, typeof(DateTime));
            info.AddValue("Addresses", Addresses, typeof(List<Address>));

            //save only enough info to find the following:
            //info.AddValue("Programs", Programs, typeof(List<Program>));            
            //info.AddValue("Courses", FirstName, typeof(List<Course>));
        }

        // The special constructor is used to deserialize values.
        public Student(SerializationInfo info, StreamingContext context)
        {            
            FirstName = (string)info.GetValue("FirstName", typeof(string));
            LastName = (string)info.GetValue("LastName", typeof(string));
            ID = (Identification)info.GetValue("ID", typeof(Identification));            
            DateOfBirth = (DateTime)info.GetValue("DateOfBirth", typeof(DateTime));
            Addresses = (List<Address>)info.GetValue("Addresses", typeof(List<Address>));
        }
        #endregion
    }
}
