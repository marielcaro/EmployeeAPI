using EmployeesAPI.Models;

namespace EmployeesAPI.Data
{
    public static class MockEmployee
    {
        public static List<Employee> Employees = new List<Employee>
        {
            new Employee { Id = 1, FullName = "Mariel Caro", Birth = new DateTime(1980, 1, 1) },
            new Employee { Id = 2, FullName = "Elizabeth Darcy", Birth = new DateTime(1990, 2, 2) },
            new Employee { Id = 3, FullName = "Alan Turing", Birth = new DateTime(1975, 3, 3) }
        };
    }
}
