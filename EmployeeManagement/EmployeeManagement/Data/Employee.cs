﻿using System;
using System.Collections.Generic;

namespace EmployeeManagement.Data;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? Department { get; set; }

    public decimal? Salary { get; set; }

    public DateTime? HireDate { get; set; }
}
