using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapa_De_Clases.Models
{
    public class Estudiante : MiembroDeLaComunidad
    {
        public string Carrera { get; set; }
        public int AñoIngreso { get; set; }

        public Estudiante() { }

        public Estudiante(int id, string nombre, string carrera, int añoIngreso)
        {
            Id = id;
            Nombre = nombre;
            Carrera = carrera;
            AñoIngreso = añoIngreso;
        }
    }
}
