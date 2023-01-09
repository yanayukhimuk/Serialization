// See https://aka.ms/new-console-template for more information
using JSONSerialization;
using Newtonsoft.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        Employee Employee1 = new Employee("Sam Black");
        Employee Employee2 = new Employee("Tom Harrolds");
        Employee Employee3 = new Employee("John Weak");
        Employee Employee4 = new Employee("Sam White");

        List<Employee> EmployeeList = new List<Employee>();
        EmployeeList.Add(Employee1);
        EmployeeList.Add(Employee2);
        EmployeeList.Add(Employee3);
        EmployeeList.Add(Employee4);

        var department = new Department("MyDepartment", EmployeeList);
        JsonSerializer serializer= new JsonSerializer();

        using (TextWriter tw = new StreamWriter(@"C:\Users\Yana_Yukhimuk\source\repos\SQL\Serialization\department.json"))
        {
            serializer.Serialize(tw, department);
        }

        department = null;

        using (StreamReader reader = new StreamReader(@"C:\Users\Yana_Yukhimuk\source\repos\SQL\Serialization\department.json"))
        {
            string json = reader.ReadToEnd();
            object obj = JsonConvert.DeserializeObject<Department>(json);
            department = (Department)obj;
            reader.Close();
        }
    }
}