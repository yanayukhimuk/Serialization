using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace JSONSerialization
{
    [Serializable()]
    public class Department : ISerializable
    {
        public string? DepartmentName { get; set; }  
        public List<Employee>? EmployeeList { get; set; }

        public Department() { }
        public Department(string depatmentName = "No name", List<Employee>? emplyeeList = null)
        {
            DepartmentName = depatmentName;
            EmployeeList = emplyeeList;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Department", DepartmentName);
            info.AddValue("EmployeeList", EmployeeList);
        }

        public Department(SerializationInfo info, StreamingContext context)
        {
            DepartmentName = info.GetValue("Department", typeof(string)) as string;
            EmployeeList = info.GetValue("EmployeeList", typeof(string)) as List<Employee>;
        }
    }
}
