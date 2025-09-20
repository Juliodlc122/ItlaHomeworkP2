using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadEducativa.Models
{
    public class Estudiante : MiembroDeLaComunidad
    {
        public string Carrera { get; set; }
        public int Semestre { get; set; }
    }
}
