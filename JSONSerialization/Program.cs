// See https://aka.ms/new-console-template for more information
using JSONSerialization;
using Newtonsoft.Json;

Employee Employee1= new Employee("Sam Black");
Employee Employee2 = new Employee("Tom Harrolds");
Employee Employee3 = new Employee("John Weak");
Employee Employee4 = new Employee("Sam White");

List<Employee> EmployeeList = new List<Employee>();
EmployeeList.Add(Employee1);
EmployeeList.Add(Employee2);
EmployeeList.Add(Employee3);
EmployeeList.Add(Employee4);

Department department = new Department("MyDepartment", EmployeeList);

object departmentJSON = JsonConvert.SerializeObject(department);