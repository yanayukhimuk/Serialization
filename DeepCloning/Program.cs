using DeepCloning;

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

Department clonedDepartment = (Department) department.Clone();

department = null;

Employee Employee5 = new Employee("Sam B");
Employee Employee6 = new Employee("Tom H");

List<Employee> EmployeeList2 = new List<Employee>();
EmployeeList2.Add(Employee5);
EmployeeList2.Add(Employee6);

clonedDepartment.EmployeeList= EmployeeList2;


Console.WriteLine(clonedDepartment.EmployeeList.Count);