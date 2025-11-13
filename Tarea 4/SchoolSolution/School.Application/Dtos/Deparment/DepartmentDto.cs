using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.Application.Dtos;

namespace School.Application.Dtos.Department
{
    public class DepartmentDto : DtoBase
    {
        public string? Nombre { get; set; }
        public decimal Presupuesto { get; set; }
    }
}