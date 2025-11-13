using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.Application.Core;
using School.Application.Dtos.Department;

namespace School.Application.Contract
{
   
    public interface IDepartamentService : IBaseService<DepartmentDto, DepartmentCreateDto>
    {
        
    }
}