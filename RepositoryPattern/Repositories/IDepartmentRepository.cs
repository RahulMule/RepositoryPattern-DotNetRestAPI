using RepositoryPattern.Models;

namespace RepositoryPattern.Repositories
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAllDepartment();
        Department GetDepartmentById(int id);

        void DeleteDepartment(Department department);
        void UpdateDepartment(Department department);

        void AddDepartment(Department department);  
    }
}
