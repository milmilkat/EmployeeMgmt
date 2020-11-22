using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMgmt.Models
{
    public class Employee
    {
        public int Id { get; set; } // This is the primary key
        public string Name { get; set; } // this is the name
        public string Address { get; set; } // this is the address
    }
}
