CREATE TABLE Employee (
    EmployeeID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Email VARCHAR(100),
    Department VARCHAR(50),
    Salary DECIMAL(10, 2),
    HireDate DATE
);


CREATE TABLE [User] (
    UserID INT PRIMARY KEY,
    Username NVARCHAR(50) UNIQUE,
    Email NVARCHAR(100) UNIQUE,
    PasswordHash NVARCHAR(128),
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    RegistrationDate DATETIME
);

INSERT INTO Employee (EmployeeID, FirstName, LastName, Email, Department, Salary, HireDate)
VALUES
    (1, 'John', 'Doe', 'john.doe@example.com', 'Sales', 50000.00, '2023-01-15'),
    (2, 'Jane', 'Smith', 'jane.smith@example.com', 'Marketing', 60000.00, '2022-09-10'),
    (3, 'Michael', 'Johnson', 'michael.johnson@example.com', 'IT', 75000.00, '2023-03-20');


INSERT INTO [User] (UserID, Username, Email, PasswordHash, FirstName, LastName, RegistrationDate)
VALUES
    (1, 'john_doe', 'john.doe@example.com', 'hashed_password_here', 'John', 'Doe', '2023-01-05 09:30:00'),
    (2, 'jane_smith', 'jane.smith@example.com', 'hashed_password_here', 'Jane', 'Smith', '2022-09-08 15:20:00'),
    (3, 'michael_johnson', 'michael.johnson@example.com', 'hashed_password_here', 'Michael', 'Johnson', '2023-03-18 11:45:00');
