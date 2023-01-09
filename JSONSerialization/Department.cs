using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace JSONSerialization
{
    [Serializable()]
    public class Department
    {
        public string? DepartmentName { get; set; }  
        public List<Employee>? EmployeeList { get; set; }

        public Department() { }
        public Department(string depatmentName = "No name", List<Employee>? emplyeeList = null)
        {
            DepartmentName = depatmentName;
            EmployeeList = emplyeeList;
        }
    }
}
