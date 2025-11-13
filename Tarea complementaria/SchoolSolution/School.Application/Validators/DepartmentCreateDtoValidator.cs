using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using School.Application.Dtos.Department;

namespace School.Application.Validators
{
    public class DepartmentCreateDtoValidator : AbstractValidator<DepartmentCreateDto>
    {
        public DepartmentCreateDtoValidator()
        {
            
            RuleFor(d => d.Nombre)
                .NotEmpty().WithMessage("El nombre no puede estar vacío.")
                .NotNull().WithMessage("El nombre es requerido.")
                .MinimumLength(3).WithMessage("El nombre debe tener al menos 3 caracteres.");

            
            RuleFor(d => d.Presupuesto)
                .GreaterThan(0).WithMessage("El presupuesto debe ser mayor a cero.");
        }
    }
}