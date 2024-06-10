using EmployeesAPI.Models;
using EmployeesAPI.ViewDTO;

namespace EmployeesAPI.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> SearchEmployeesAsync(string name);
        Task<bool> AddEmployeeAsync(EmployeeDTO employeeDto);
        Task<bool> RemoveEmployeeAsync(int id);
    }
}
