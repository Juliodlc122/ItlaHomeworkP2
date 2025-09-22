using Mapa_De_Clases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapa_De_Clases.Models
{
    public class ExAlumno : MiembroDeLaComunidad
    {
        public string Carrera { get; set; }
        public DateTime FechaEgreso { get; set; }

        public ExAlumno() { }

        public ExAlumno(int id, string nombre, string carrera, DateTime fechaEgreso)
        {
            Id = id;
            Nombre = nombre;
            Carrera = carrera;
            FechaEgreso = fechaEgreso;
        }
    }
}
