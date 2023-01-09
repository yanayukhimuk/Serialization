using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoSerialization
{
    [ProtoContract]
    internal class Department
    {
        [ProtoMember(2)]
        public string DepartmentName { get; set; }
        [ProtoMember(3)]
        public List<Employee>? EmployeeList { get; set; }

        public Department() { }
        
        public Department(string depatmentName = "No name", List<Employee>? emplyeeList = null)
        {
            DepartmentName = depatmentName;
            EmployeeList = emplyeeList;
        }
    }
}
