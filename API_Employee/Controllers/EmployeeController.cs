using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Employee.Models;

namespace API_Employee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeController(IEmployeeRepository employeeRepository) => _employeeRepository = employeeRepository;

        [HttpGet]
        public IEnumerable<Employee> Get() => _employeeRepository.GetAllEmpoyee();

        [HttpGet("{id}")]
        public ActionResult<Employee> Get(int id) => _employeeRepository.GetEmployee(id);

        [HttpPost]
        public ActionResult Add(Employee data) {
            try
            {
                _employeeRepository.Add(data);
                _employeeRepository.Save();
                return StatusCode(200);
            }
            catch
            {
                return NoContent();
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                _employeeRepository.Delete(id);
                _employeeRepository.Save();
                return StatusCode(200);
            }
            catch
            {
                return NoContent();
            }
        }

        [HttpPut]
        public ActionResult Update(Employee data) {
            try
            {
                _employeeRepository.Update(data);
                _employeeRepository.Save();
                return StatusCode(200);
            }
            catch
            {
                return NoContent();
            }
        }


    }
}

/* [HttpGet]
public ActionResult<IEnumerable<string>> Get()
{
    return new string[] { "x", "x"};
}*/
