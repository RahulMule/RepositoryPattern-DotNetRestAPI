using RepositoryPattern.Models;

namespace RepositoryPattern.Repositories
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employees> GetEmployees();
        Employees GetEmployee(int id);
        void DeleteEmployee(int id);
        void AddEmployee(Employees employee);
        void UpdateEmployee(Employees employee);
    }
}
