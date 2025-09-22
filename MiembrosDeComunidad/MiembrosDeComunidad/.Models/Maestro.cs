using Mapa_De_Clases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapa_De_Clases.Models
{
    public class Maestro : Docente
    {
        public string Especialidad { get; set; }
        public string Curso { get; set; }

        public Maestro() { }

        public Maestro(int id, string nombre, string apellido, DateTime fechaIngreso, decimal salario, string departamento, DateTime fechaNombramiento, string especialidad, string curso)
            : base(id, nombre, apellido, fechaIngreso, salario, departamento, fechaNombramiento)
        {
            Especialidad = especialidad;
            Curso = curso;
        }
    }
}
