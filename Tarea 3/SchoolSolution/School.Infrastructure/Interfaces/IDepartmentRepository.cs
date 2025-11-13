using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.Domain.Entities;

namespace School.Infrastructure.Interfaces
{
    public interface IDepartmentRepository : IRepository<Department>
    {
    }
}