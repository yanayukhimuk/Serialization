using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoSerialization
{
    [ProtoContract]
    internal class Employee
    {
        [ProtoMember(1)]
        public string EmployeeName { get; set; }
        public Employee() { }   

        public Employee(string employeeName = "No name")
        {
            EmployeeName = employeeName;
        }
    }
}
