using Mapa_De_Clases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapa_De_Clases.Models
{
    public class Administrador : Docente
    {
        public string AreaResponsabilidad { get; set; }
        public string Cargo { get; set; }

        public Administrador() { }

        public Administrador(int id, string nombre, string apellido, DateTime fechaIngreso, decimal salario, string departamento, DateTime fechaNombramiento, string areaResponsabilidad, string cargo)
            : base(id, nombre, apellido, fechaIngreso, salario, departamento, fechaNombramiento)
        {
            AreaResponsabilidad = areaResponsabilidad;
            Cargo = cargo;
        }
    }
}
