using EmployeeManagement.Data;
using EmployeeManagement.Repository.Interfaces;

namespace EmployeeManagement.Repository
{
    public class EmployeeRepository : IEmployee
    {
        private readonly EmployeeDbContext _employeeDbContext;

        public EmployeeRepository(EmployeeDbContext employeeDbContext)
        {
            _employeeDbContext = employeeDbContext;
        }

        public IEnumerable<Employee> GetAll()
        {
            return _employeeDbContext.Employees.ToList();
        }
    }
}
