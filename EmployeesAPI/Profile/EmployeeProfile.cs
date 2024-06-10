using AutoMapper;
using EmployeesAPI.Models;
using EmployeesAPI.ViewDTO;

namespace EmployeesAPI.Mapper
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<EmployeeDTO, Employee>();
        }
    }
}
