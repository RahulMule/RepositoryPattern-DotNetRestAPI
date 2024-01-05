using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.Models;
using RepositoryPattern.Repositories;

namespace RepositoryPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private IDepartmentRepository _departmentRepository;

        public DepartmentController(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        [HttpGet]
        public Department GetDepartmentbyID(int id)
        {
            var Department = _departmentRepository.GetDepartmentById(id);
            if (Department == null)
            {
                return null;
            }
            return Department;
        }

        [HttpPost]

        public Department AddDepartment(Department department)
        {
            _departmentRepository.AddDepartment(department);
            return department;
        }

    }
}
