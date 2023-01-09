using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MyCustomSerializer
{
    [Serializable()]
    public class Person : ISerializable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Person() { }

        public Person(int id, string name, string surname)
        {
            Id = id;
            Name = name;
            Surname = surname;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Id", Id);
            info.AddValue("Name", Name);
            info.AddValue("Surname", Surname);
        }

        public Person(SerializationInfo info, StreamingContext context)
        {
            Id = info.GetInt32("Id");
            Name = info.GetString("Name");
            Surname = info.GetString("Surname");
        }
    }
}
