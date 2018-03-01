using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SiS
{
    [Serializable]
    public class CollegeProgram : ISerializable
    {
        public enum CollegeCredentials { Certificate, Diploma, Degree}
        public String Name { get; private set; }
        public CollegeCredentials Credential { get; private set; }
        public int Years { get; private set; }

        private List<Student> students { get; set; }
        private List<Course> courses { get; set; }

        public CollegeProgram(String name, CollegeCredentials credential, int years)
        {
            Name = name;
            Credential = credential;
            Years = years;
            students = new List<Student>();
            courses = new List<Course>();
        }
        public List<Student> GetStudents()
        {
            return students;
        }
        public List<Course> GetCourses()
        {
            return courses;
        }
        public void addCourse(Course c)
        {
            if(c!=null)
                courses.Add(c);
        }


        #region Serialiazable implementation
        // Implement this method to serialize data. The method is called 
        // on serialization.
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            // Use the AddValue method to specify serialized values.
            info.AddValue("Name", Name, typeof(String));
            info.AddValue("Credential", Credential, typeof(CollegeCredentials));
            info.AddValue("Years", Years, typeof(int));
            info.AddValue("students", students, typeof(List<Student>));
            info.AddValue("courses", courses, typeof(List<Course>));
        }

        // The special constructor is used to deserialize values.
        public CollegeProgram(SerializationInfo info, StreamingContext context)
        {
            Name = (String)info.GetValue("Name", typeof(String));
            Credential = (CollegeCredentials)info.GetValue("Credential", typeof(CollegeCredentials));
            courses = (List<Course>)info.GetValue("courses", typeof(List<Course>));
            Years = (int)info.GetValue("Years", typeof(int));
            students = (List<Student>)info.GetValue("students", typeof(List<Student>));
        }
        #endregion


    }
}
