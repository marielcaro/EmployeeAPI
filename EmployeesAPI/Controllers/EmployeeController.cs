using EmployeesAPI.Models;
using EmployeesAPI.Services;
using EmployeesAPI.ViewDTO;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet("search")]
        public async Task<ActionResult> SearchAsync(string? name)
        {
            var result = await _employeeService.SearchEmployeesAsync(name);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> AddAsync(EmployeeDTO employeeDto)
        {
            var result = await _employeeService.AddEmployeeAsync(employeeDto);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> RemoveAsync(int id)
        {
            var result = await _employeeService.RemoveEmployeeAsync(id);
            return Ok(result);
        }
    }
}
