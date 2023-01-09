using MyCustomSerializer;
using System.Runtime.Serialization.Formatters.Binary;

Person person1 = new Person(1, "Jane", "Black");

FileStream fileStream = new FileStream(@"C:\Users\Yana_Yukhimuk\source\repos\SQL\Serialization\person.dat", FileMode.Create);

BinaryFormatter formatter = new BinaryFormatter();
#pragma warning disable SYSLIB0011 // Type or member is obsolete
formatter.Serialize(fileStream, person1);
fileStream.Close();

FileStream fileStream2 = new FileStream(@"C:\Users\Yana_Yukhimuk\source\repos\SQL\Serialization\person.dat", FileMode.Open);

BinaryFormatter formatter2 = new BinaryFormatter();
Person deserializedPerson = (Person)formatter.Deserialize(fileStream2);

Console.WriteLine("The deserialized object:");
Console.WriteLine(String.Format("Id: {0}", deserializedPerson.Id.ToString()));
Console.WriteLine(String.Format("Name: {0}", deserializedPerson.Name));
Console.WriteLine(String.Format("Surname: {0}", deserializedPerson.Surname));

Console.Read();
#pragma warning restore SYSLIB0011 // Type or member is obsolete