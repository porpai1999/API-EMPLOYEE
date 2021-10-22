using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Employee.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int ID);
        IEnumerable<Employee> GetAllEmpoyee();
        void Add(Employee employee);
        void Update(Employee employeeChanges);
        void Delete(int ID);
        void Save();
    }
}
