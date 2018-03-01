using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SiS
{
    [Serializable]
    public class Identification : ISerializable
    {
        public static int idKey = 1;
        public int ID { get; private set; }
        public IPerson Person { get; private set; }
        public Identification(IPerson person)
        {
            Person = person;
            ID = Identification.idKey++;
        }

        public Identification(int ID, IPerson Person)
        {
            this.ID = ID;
            this.Person = Person;
        }

        #region Serialiazable implementation
        // Implement this method to serialize data. The method is called 
        // on serialization.
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            // Use the AddValue method to specify serialized values.
            info.AddValue("ID", ID, typeof(int));
            info.AddValue("Person", Person, typeof(IPerson));
            

        }

        // The special constructor is used to deserialize values.
        public Identification(SerializationInfo info, StreamingContext context)
        {            
            ID = (int)info.GetValue("ID", typeof(int));
            Person = (IPerson)info.GetValue("Person", typeof(IPerson));
        }

        public void DeserializeIDKey(int key)
        {
            idKey = key;
        }
        #endregion

    }
}
