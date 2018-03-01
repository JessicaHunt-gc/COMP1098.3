using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SiS
{
    [Serializable]
    public class Course :ISerializable
    {
        public String Name { get; private set; }
        public String Subject { get; private set; }
        public String Number { get; private set; }
        public int Capacity { get; private set; }

        public List<CollegeProgram> Programs { get; private set; }
        public List<Student> students { get; private set; }
        public List<Staff> instructors { get; private set; }

        public Course(String name,String subject,String number,int capacity,CollegeProgram primaryProgram)
        {
            Name = name;
            Subject = subject;
            Number = number;
            Capacity = capacity;
            Programs = new List<CollegeProgram>();
            Programs.Add(primaryProgram);
            primaryProgram.addCourse(this);

            students = new List<Student>();
            instructors = new List<Staff>();
        }

        public bool registerStudent(Student s)
        {
            if (students.Count >= Capacity)
                return false;
            students.Add(s);
            return true;
        }

        public bool registerInstructor(Staff i)
        {
            instructors.Add(i);
            i.addCourse(this);
            return true;
        }
        #region Serialiazable implementation
        // Implement this method to serialize data. The method is called 
        // on serialization.
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            // Use the AddValue method to specify serialized values.
            info.AddValue("Name", Name, typeof(String));
            info.AddValue("Subject", Subject, typeof(String));
            info.AddValue("Number", Number, typeof(String));
            info.AddValue("Capacity", Capacity, typeof(int));
            info.AddValue("Programs", Programs, typeof(List<CollegeProgram>));
            info.AddValue("students", students, typeof(List<Student>));
            info.AddValue("instructors", instructors, typeof(List<Staff>));
        }

        // The special constructor is used to deserialize values.
        public Course(SerializationInfo info, StreamingContext context)
        {
            Name = (String)info.GetValue("Name", typeof(String));
            Subject = (String)info.GetValue("Subject", typeof(String));
            Number = (String)info.GetValue("Number", typeof(String));
            instructors = (List<Staff>)info.GetValue("instructors", typeof(List<Staff>));
            Capacity = (int)info.GetValue("Capacity", typeof(int));
            students = (List<Student>)info.GetValue("students", typeof(List<Student>));
            Programs = (List<CollegeProgram>)info.GetValue("Programs", typeof(List<CollegeProgram>));
        }
        #endregion
    }
}
