using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FileIO_L5
{
    public class Movie :ISerializable
    {
        public String Name;
        public int lengthSec;
        public Movie() { }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", Name, typeof(String));
            info.AddValue("lengthSec", lengthSec, typeof(int));
        }

        public Movie(SerializationInfo info, StreamingContext context)
        {
            Name = (String)info.GetValue("Name", typeof(String));
            lengthSec = (int)info.GetValue("lengthSec", typeof(int));
        }
    }
}
