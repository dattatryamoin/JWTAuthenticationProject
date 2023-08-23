using EmployeeManagement.Data;

namespace EmployeeManagement.Repository.Interfaces
{
    public interface IUser
    {
        User GetUser(string emailId, string password);
    }
}
