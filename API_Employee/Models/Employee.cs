using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Employee.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Address { get; set; }
        public decimal Salary { get; set; }
        public DateTime JoiningDate { get; set; }
    }
}
