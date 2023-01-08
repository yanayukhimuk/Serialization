// See https://aka.ms/new-console-template for more information

using System.Xml.Serialization;
using XMLSerialization;

Employee Employee1 = new Employee("Sam Black");
Employee Employee2 = new Employee("Tom Harrolds");
Employee Employee3 = new Employee("John Weak");
Employee Employee4 = new Employee("Sam White");

List<Employee> EmployeeList = new List<Employee>();
EmployeeList.Add(Employee1);
EmployeeList.Add(Employee2);
EmployeeList.Add(Employee3);
EmployeeList.Add(Employee4);

Department? department = new Department("MyDepartment", EmployeeList);

XmlSerializer serializer = new XmlSerializer(typeof(Department));

using (TextWriter tw = new StreamWriter(@"C:\Users\Yana_Yukhimuk\source\repos\SQL\Serialization\department.xml"))
{
    serializer.Serialize(tw, department);
}

department = null;

XmlSerializer deserializer = new XmlSerializer(typeof(Department));
TextReader reader = new StreamReader(@"C:\Users\Yana_Yukhimuk\source\repos\SQL\Serialization\department.xml");

object obj = deserializer.Deserialize(reader);
department = (Department)obj;
reader.Close();