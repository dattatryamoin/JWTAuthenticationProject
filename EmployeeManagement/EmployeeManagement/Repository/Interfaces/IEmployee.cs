using EmployeeManagement.Data;

namespace EmployeeManagement.Repository.Interfaces
{
    public interface IEmployee
    {
        IEnumerable<Employee> GetAll();
    }
}
