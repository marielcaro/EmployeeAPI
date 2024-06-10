using AutoMapper;
using EmployeesAPI.Data;
using EmployeesAPI.Mapper;
using EmployeesAPI.Models;
using EmployeesAPI.Services;
using EmployeesAPI.ViewDTO;
using Moq;
using System.Linq;
using Xunit;

namespace EmployeesAPI.Tests
{
    public class EmployeeServiceTests
    {
        private readonly IEmployeeService _employeeService;
        private readonly IMapper _mapper;
        public EmployeeServiceTests()
        {
            var config = new MapperConfiguration(cfg => cfg.AddProfile<EmployeeProfile>());
            _mapper = config.CreateMapper();
            _employeeService = new EmployeeService(_mapper);
        }

        [Fact]
        public void SearchEmployees_ShouldReturnCorrectResults()
        {
            
            var result = _employeeService.SearchEmployeesAsync("Mariel");
            Assert.Single(result.Result);
            Assert.Equal("Mariel Caro", result.Result.First().FullName);
        }

        [Fact]
        public void AddEmployee_ShouldIncreaseCount()
        {
            var initialCount = MockEmployee.Employees.Count;
            _employeeService.AddEmployeeAsync(new EmployeeDTO { FullName = "New Employee", Birth = new DateTime(2000, 1, 1) });


            Assert.Equal(initialCount + 1, MockEmployee.Employees.Count);
        }
    }
}
