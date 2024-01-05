using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.Models;
using RepositoryPattern.Repositories;

namespace RepositoryPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeRepository _employeeRepository;
        private IDepartmentRepository _DepartmentRepository;

        public EmployeeController(IEmployeeRepository employeeRepository, IDepartmentRepository departmentrepository)
        {
            _employeeRepository = employeeRepository;
            _DepartmentRepository = departmentrepository;
        }

        [HttpGet]
        public IActionResult GetAllEmployee()
        {
            try
            {
                var employees = _employeeRepository.GetEmployees();
                return Ok(employees);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]

        public IActionResult AddEmployee(Employees employee)
        {
            try
            {
                var department = _DepartmentRepository.GetDepartmentById(employee.DepartmentId);
                if (department == null)
                {
                    return BadRequest("Invalid DepartmentId");
                }

                employee.Department = department;
                _employeeRepository.AddEmployee(employee);
                return Ok();
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    
    
    }
}
