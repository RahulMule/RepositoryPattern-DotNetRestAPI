using RepositoryPattern.Data;
using RepositoryPattern.Models;
using Microsoft.EntityFrameworkCore;

namespace RepositoryPattern.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDbContext _dbContext;

        public EmployeeRepository(EmployeeDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddEmployee(Employees employee)
        {
            Console.WriteLine(employee);
            _dbContext.employees.Add(employee);
            _dbContext.SaveChanges();
        }

        public void DeleteEmployee(int id)
        {
            var employee = _dbContext.employees.Find(id);
            if(employee != null)
            {
                _dbContext.employees.Remove(employee);
                _dbContext.SaveChanges();
            }
        }

        public Employees GetEmployee(int id)
        {
            return _dbContext.employees.Find(id);
        }

        public IEnumerable<Employees> GetEmployees()
        {
            return _dbContext.employees.ToList();
        }

        public void UpdateEmployee(Employees employee)
        {
            _dbContext.Entry(employee).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
    }
}
