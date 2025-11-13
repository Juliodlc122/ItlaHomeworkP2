using AutoMapper;
using School.Application.Dtos.Department;
using School.Domain.Entities;

namespace School.Application.Mappings
{
   
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
           
            CreateMap<Department, DepartmentDto>();

            
            CreateMap<DepartmentCreateDto, Department>();

    
            CreateMap<DepartmentDto, Department>();
        }
    }
}