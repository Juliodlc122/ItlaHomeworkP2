using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Application.Dtos.Department
{
    public class DepartmentCreateDto
    {
        public string? Nombre { get; set; }
        public decimal Presupuesto { get; set; }
    }
}