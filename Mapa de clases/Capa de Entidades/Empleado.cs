using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunidadEducativa.Models
{
    public class Empleado : MiembroDeLaComunidad
    {
        public string Puesto { get; set; }
        public double Salario { get; set; }
    }
}
