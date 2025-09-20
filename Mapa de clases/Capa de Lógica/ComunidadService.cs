using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ComunidadEducativa.Models;
using System.Collections.Generic;

namespace ComunidadEducativa.Services
{
    public class ComunidadService
    {
        private List<MiembroDeLaComunidad> miembros = new List<MiembroDeLaComunidad>();

        public void AgregarMiembro(MiembroDeLaComunidad miembro)
        {
            miembros.Add(miembro);
        }

        public List<MiembroDeLaComunidad> ObtenerMiembros()
        {
            return miembros;
        }
    }
}
