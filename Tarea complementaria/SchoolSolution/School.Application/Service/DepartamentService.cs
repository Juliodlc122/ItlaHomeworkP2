using AutoMapper;
using FluentValidation;
using School.Application.Contract;
using School.Application.Core;
using School.Application.Dtos.Department;
using School.Domain.Entities;
using School.Infrastructure.Interfaces;

namespace School.Application.Service
{
    
    public class DepartamentService : IDepartamentService
    {
        
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IMapper _mapper;
        private readonly IValidator<DepartmentCreateDto> _validator;

        public DepartamentService(IDepartmentRepository departmentRepository,
                                  IMapper mapper,
                                  IValidator<DepartmentCreateDto> validator)
        {
            _departmentRepository = departmentRepository;
            _mapper = mapper;
            _validator = validator;
        }

        public async Task<ServiceResult<IEnumerable<DepartmentDto>>> GetAll()
        {
            var result = new ServiceResult<IEnumerable<DepartmentDto>>();
            var departments = await _departmentRepository.GetAll();
            result.Data = _mapper.Map<IEnumerable<DepartmentDto>>(departments);
            return result;
        }

        public async Task<ServiceResult<DepartmentDto>> GetById(int id)
        {
            var result = new ServiceResult<DepartmentDto>();
            var department = await _departmentRepository.GetById(id);
            if (department == null)
            {
                result.Success = false;
                result.Message = $"No se encontró departamento con el Id {id}";
                return result;
            }
            result.Data = _mapper.Map<DepartmentDto>(department);
            return result;
        }

        public async Task<ServiceResult<DepartmentDto>> Add(DepartmentCreateDto createDto)
        {
            var result = new ServiceResult<DepartmentDto>();

         
            var validation = await _validator.ValidateAsync(createDto);
            if (!validation.IsValid)
            {
                result.Success = false;
                result.Message = validation.Errors.FirstOrDefault()?.ErrorMessage ?? "Error de validación";
                return result;
            }

            
            var department = _mapper.Map<Department>(createDto);
            department.StartDate = DateTime.UtcNow; // Asignar valores por defecto

           
            await _departmentRepository.Add(department);

            
            result.Data = _mapper.Map<DepartmentDto>(department);
            return result;
        }

        public async Task<ServiceResult<DepartmentDto>> Update(DepartmentDto model, int id)
        {
            var result = new ServiceResult<DepartmentDto>();
            if (id != model.Id)
            {
                result.Success = false;
                result.Message = "El Id del modelo no coincide con el Id de la URL.";
                return result;
            }

            var department = await _departmentRepository.GetById(id);
            if (department == null)
            {
                result.Success = false;
                result.Message = $"No se encontró departamento con el Id {id}";
                return result;
            }

            
            department.Name = model.Nombre;
            department.Budget = model.Presupuesto;

            await _departmentRepository.Update(department);
            result.Data = _mapper.Map<DepartmentDto>(department);
            return result;
        }

        public async Task<ServiceResult<bool>> Delete(int id)
        {
            var result = new ServiceResult<bool>();
            var department = await _departmentRepository.GetById(id);
            if (department == null)
            {
                result.Success = false;
                result.Message = $"No se encontró departamento con el Id {id}";
                return result;
            }

            await _departmentRepository.Delete(id);
            result.Data = true;
            return result;
        }
    }
}