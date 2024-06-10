
using System.ComponentModel.DataAnnotations;

namespace EmployeesAPI.ViewDTO
{
    public class EmployeeDTO
    {
        [Required]
        public string FullName { get; set; }
        [Required]
        public DateTime Birth { get; set; }
    }
}
