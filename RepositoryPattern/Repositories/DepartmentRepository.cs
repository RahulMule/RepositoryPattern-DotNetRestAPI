using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Data;
using RepositoryPattern.Models;

namespace RepositoryPattern.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {

        private EmployeeDbContext _dbcontext;

        public DepartmentRepository(EmployeeDbContext dbContext)
        {
            _dbcontext = dbContext;
        }
        public void AddDepartment(Department department)
        {
            _dbcontext.department.Add(department);
            _dbcontext.SaveChanges();
        }

        public void DeleteDepartment(Department department)
        {
            
               _dbcontext.department.Remove(department);
               _dbcontext.SaveChanges(true);
           
        }

        public IEnumerable<Department> GetAllDepartment()
        {
            return _dbcontext.department.ToList();

        }

        public Department GetDepartmentById(int id)
        {
            var department = _dbcontext.department.Find(id);
            if (department == null)
            {
                return null;
            }
            return department;
        }

        public void UpdateDepartment(Department department)
        {
            _dbcontext.Entry(department).State = EntityState.Modified;
            _dbcontext.SaveChanges();
        }
    }
}
