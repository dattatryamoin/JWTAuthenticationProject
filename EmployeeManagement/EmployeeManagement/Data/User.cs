using System;
using System.Collections.Generic;

namespace EmployeeManagement.Data;

public partial class User
{
    public int UserId { get; set; }

    public string? Username { get; set; }

    public string? Email { get; set; }

    public string? PasswordHash { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public DateTime? RegistrationDate { get; set; }
}
