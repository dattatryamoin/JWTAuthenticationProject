using EmployeeManagement.Data;
using EmployeeManagement.Repository.Interfaces;

namespace EmployeeManagement.Repository
{
    public class UsersRepository : IUser
    {
        private readonly EmployeeDbContext _employeeDbContext;

        public UsersRepository(EmployeeDbContext employeeDbContext)
        {
            _employeeDbContext = employeeDbContext;
        }

        public User GetUser(string emailId, string password)
        {
            return _employeeDbContext.Users.Where(x => x.Email == emailId && x.PasswordHash == password).FirstOrDefault();
        }
    }
}
