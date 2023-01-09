﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace JSONSerialization
{
    [Serializable()]
    public class Employee
    {
        public string EmployeeName { get; set; }
        public Employee() { }

        public Employee(string employeeName = "No name")
        {
            EmployeeName = employeeName;
        }
    }
}
