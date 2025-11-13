using AutoMapper;
using School.Application.Dtos.Department;
using School.Domain.Entities;

namespace School.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Department, DepartmentDto>()
                .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Presupuesto, opt => opt.MapFrom(src => src.Budget));

            CreateMap<DepartmentCreateDto, Department>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Nombre))
                .ForMember(dest => dest.Budget, opt => opt.MapFrom(src => src.Presupuesto));

            CreateMap<DepartmentDto, Department>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Nombre))
                .ForMember(dest => dest.Budget, opt => opt.MapFrom(src => src.Presupuesto));
        }
    }
}