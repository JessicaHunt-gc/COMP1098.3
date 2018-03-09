using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FileIO_L5
{
    public class Book:ISerializable
    {
        public String Name;

        [JsonIgnore]
        public String Author;

        public Book() { }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", Name, typeof(String));
            info.AddValue("Author", Author, typeof(String));
        }

        public Book(SerializationInfo info, StreamingContext context)
        {
            Name = (String)info.GetValue("Name", typeof(String));
            Author = (String)info.GetValue("Author", typeof(String));
        }
    }
}
