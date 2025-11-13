using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.Application.Core;

namespace School.Application.Core
{
    
    public interface IBaseService<TDto, TCreateDto>
        where TDto : class
        where TCreateDto : class
    {
        Task<ServiceResult<IEnumerable<TDto>>> GetAll();
        Task<ServiceResult<TDto>> GetById(int id);
        Task<ServiceResult<TDto>> Add(TCreateDto model);
        Task<ServiceResult<TDto>> Update(TDto model, int id);
        Task<ServiceResult<bool>> Delete(int id);
    }
}