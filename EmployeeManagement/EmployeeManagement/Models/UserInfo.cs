namespace EmployeeManagement.Models
{
    public class UserInfo
    {
        public int UserId { get; set; }

        public string? Username { get; set; }

        public string? Email { get; set; }

        public string? PasswordHash { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public DateTime? RegistrationDate { get; set; }
    }
}
