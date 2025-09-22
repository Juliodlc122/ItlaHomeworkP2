using Mapa_De_Clases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapa_De_Clases.Models
{
    public class Docente : Empleado
    {
        public string Departamento { get; set; }
        public DateTime FechaNombramiento { get; set; }

        public Docente() { }

        public Docente(int id, string nombre, string apellido, DateTime fechaIngreso, decimal salario, string departamento, DateTime fechaNombramiento)
            : base(id, nombre, apellido, fechaIngreso, salario)
        {
            Departamento = departamento;
            FechaNombramiento = fechaNombramiento;
        }
    }
}
