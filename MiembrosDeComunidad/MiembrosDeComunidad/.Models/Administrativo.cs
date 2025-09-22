using Mapa_De_Clases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapa_De_Clases.Models
{
    public class Administrativo : Empleado
    {
        public string Puesto { get; set; }
        public string Departamento { get; set; }

        public Administrativo() { }

        public Administrativo(int id, string nombre, string apellido, DateTime fechaIngreso, decimal salario, string puesto, string departamento)
            : base(id, nombre, apellido, fechaIngreso, salario)
        {
            Puesto = puesto;
            Departamento = departamento;
        }
    }
}
