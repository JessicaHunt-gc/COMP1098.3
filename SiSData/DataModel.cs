using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SiS
{
    //This is a helper class to make serializing our whole data set simple.
    [Serializable]
    public class DataModel : ISerializable
    {
        public List<IPerson> People;
        public List<CollegeProgram> Programs;
        public List<Course> Courses;
        
        public DataModel ()
        {
            People = new List<IPerson>();
            Programs = new List<CollegeProgram>();
            Courses = new List<Course>();
        }

        #region Serialiazable implementation
        // Implement this method to serialize data. The method is called 
        // on serialization.
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            // Use the AddValue method to specify serialized values.
            info.AddValue("People", People, typeof(List<IPerson>));
            info.AddValue("Programs", Programs, typeof(List<CollegeProgram>));
            info.AddValue("Courses", Courses, typeof(List<Course>));
            info.AddValue("IdKey", Identification.idKey, typeof(int));
        }

        // The special constructor is used to deserialize values.
        public DataModel(SerializationInfo info, StreamingContext context)
        {
            People = (List<IPerson>)info.GetValue("People", typeof(List<IPerson>));
            Programs = (List<CollegeProgram>)info.GetValue("Programs", typeof(List<CollegeProgram>));
            Courses = (List<Course>)info.GetValue("Courses", typeof(List<Course>));
            Identification.idKey = (int)info.GetValue("IdKey", typeof(int));
        }
        #endregion

        public static byte[] serialize<T>(T objectToWrite)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, objectToWrite);
                byte[] r = stream.ToArray();
                return r;
            }
        }

        public static T Deserialize<T>(byte[] obj)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                stream.Write(obj, 0, obj.Length);
                stream.Seek(0, SeekOrigin.Begin);
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                return (T)binaryFormatter.Deserialize(stream);
            }
        }
    }
}
