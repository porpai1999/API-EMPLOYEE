using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Employee.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeContext _employeeContext;

        public EmployeeRepository(EmployeeContext employeeContext) => _employeeContext = employeeContext;

        public void Add(Employee employee) => _employeeContext.Add(employee);

        public void Delete(int id)
        {
            Employee employee = _employeeContext.Employees.Find(id);
            _employeeContext.Employees.Remove(employee);
        }

        public IEnumerable<Employee> GetAllEmpoyee() => _employeeContext.Employees.ToList();

        public Employee GetEmployee(int id) => _employeeContext.Employees.Find(id);

        public void Update(Employee employeeChanges) {
            var employee = _employeeContext.Employees.Find(employeeChanges.ID);
            if (employee != null) {
                employee.Name = employeeChanges.Name;
                employee.Designation = employeeChanges.Designation;
                employee.Address = employeeChanges.Address;
                employee.Salary = employeeChanges.Salary;
                employee.JoiningDate = employeeChanges.JoiningDate;
            }
        }

        public void Save() => _employeeContext.SaveChanges();
    }
}
