using AutoMapper;
using EmployeesAPI.Data;
using EmployeesAPI.Models;
using EmployeesAPI.ViewDTO;

namespace EmployeesAPI.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IMapper _mapper;

        public EmployeeService(IMapper mapper)
        {
            _mapper = mapper;
        }
        public async Task<IEnumerable<Employee>> SearchEmployeesAsync(string? name)
        {
            if(string.IsNullOrEmpty(name))
            {
                return await Task.FromResult(MockEmployee.Employees).ConfigureAwait(false);
            }
            return await Task.FromResult( MockEmployee.Employees
                .Where(e => e.FullName.Contains(name, StringComparison.OrdinalIgnoreCase))).ConfigureAwait(false);
        }

        public async Task<bool> AddEmployeeAsync(EmployeeDTO employeeDto)
        {
            var employee = _mapper.Map<Employee>(employeeDto);
            employee.Id = MockEmployee.Employees.Max(e => e.Id) + 1;
            MockEmployee.Employees.Add(employee);

            return await Task.FromResult(true).ConfigureAwait(false);
        }

        public async Task<bool> RemoveEmployeeAsync(int id)
        {
            var employee = MockEmployee.Employees.FirstOrDefault(e => e.Id == id);
            if (employee != null)
            {
                MockEmployee.Employees.Remove(employee);
                return await Task.FromResult(true).ConfigureAwait(false);
            }
            else
            {
                return await Task.FromResult(false).ConfigureAwait(false);
            }
        }
    }
}
