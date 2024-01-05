# Repository Pattern In Dot Net Web API using Entity framework core.

This repository contains a .NET Web API project showcasing implementation of Repository Design Pattern. Tech stack includes .Net 6, Entity Framework core as the Object-Relational Mapping (ORM) tool
for interacting with a SQL Server database.

## Project Structure

The project structure follows a typical ASP.NET Web API pattern, utilizing Entity Framework Core for database interaction.

### DepartmentController

- **Description:** Manages CRUD operations for departments.
- **Methods:**
  - `GetDepartmentById(int id)`: Retrieve a department by ID.
  - `AddDepartment(Department department)`: Add a new department.

### EmployeeController

- **Description:** Manages CRUD operations for employees, including a dependency on the `DepartmentController` for validating department IDs.
- **Methods:**
  - `GetAllEmployee()`: Retrieve all employees.
  - `AddEmployee(Employees employee)`: Add a new employee, including validation of the associated department.

## How to Run

1. Clone this repository.
2. Set up a SQL Server or another compatible database and update the connection string in `appsettings.json`.
3. Run the application using Visual Studio or `dotnet run`.
4. Test the API using a tool like [Postman](https://www.postman.com/) or [Swagger](https://swagger.io/).

## Dependencies

- ASP.NET Core
- Microsoft.Extensions.DependencyInjection
- Entity Framework Core (assuming it's used in the repositories)
- Microsoft.AspNetCore.Http
- Microsoft.AspNetCore.Mvc

## Repository Pattern

The project uses the Repository Pattern to separate data access logic from the controllers, promoting better code organization and maintainability.

### `IDepartmentRepository`

- **Description:** Interface for department data access.
- **Methods:**
  - `GetDepartmentById(int id)`: Retrieve a department by ID.
  - `AddDepartment(Department department)`: Add a new department.

### `IEmployeeRepository`

- **Description:** Interface for employee data access, including a dependency on `IDepartmentRepository` for validating department IDs.
- **Methods:**
  - `GetEmployees()`: Retrieve all employees.
  - `AddEmployee(Employees employee)`: Add a new employee, including validation of the associated department.

Feel free to customize and extend this project based on your specific requirements. For any issues or improvements, please create an issue or submit a pull request.

Happy coding!
