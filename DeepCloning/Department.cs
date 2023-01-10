using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DeepCloning
{
    [Serializable]
    public class Department : ICloneable
    {
        public string? DepartmentName { get; set; }
        public List<Employee>? EmployeeList { get; set; }

        public Department() { }
        public Department(string depatmentName = "No name", List<Employee>? emplyeeList = null)
        {
            DepartmentName = depatmentName;
            EmployeeList = emplyeeList;
        }

        public object Clone()
        {
            Department clonedDepartment = (Department)this.MemberwiseClone();
            clonedDepartment.DepartmentName = DepartmentName;
            clonedDepartment.EmployeeList = EmployeeList;
            return clonedDepartment;
        }
    }
}
