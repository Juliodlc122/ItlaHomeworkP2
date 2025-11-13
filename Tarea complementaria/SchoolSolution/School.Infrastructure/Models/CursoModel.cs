using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Infrastructure.Models
{
    public class CursoModel
    {
        public int Id { get; set; }
        public string? NombreCurso { get; set; }
        public int Creditos { get; set; }
        public int DepartamentoId { get; set; }
    }
}