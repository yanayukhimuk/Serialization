using ProtoBuf;
using ProtoSerialization;
using System;

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

        using (var fileStream = File.Create(@"C:\Users\Yana_Yukhimuk\source\repos\SQL\Serialization\department.buf"))
        {
            Serializer.Serialize(fileStream, department);
        }

        using (var fileStream = File.OpenRead(@"C:\Users\Yana_Yukhimuk\source\repos\SQL\Serialization\department.buf"))
        {
            var myDepartment = Serializer.Deserialize<Department>(fileStream);
            Console.WriteLine(myDepartment.DepartmentName);
        }
    }
}