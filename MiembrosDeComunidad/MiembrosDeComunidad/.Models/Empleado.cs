using Mapa_De_Clases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapa_De_Clases.Models
{
    public class Empleado : MiembroDeLaComunidad
    {
        public string Apellido { get; set; }
        public DateTime FechaIngreso { get; set; }
        public decimal Salario { get; set; }

        public Empleado() { }

        public Empleado(int id, string nombre, string apellido, DateTime fechaIngreso, decimal salario)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            FechaIngreso = fechaIngreso;
            Salario = salario;
        }
    }
}
