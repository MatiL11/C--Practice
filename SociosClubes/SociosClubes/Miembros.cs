using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SociosClubes
{
    public class Miembros
    {
        public int Id { get; set; }
        public int Edad { get; set; }
        public int TipoSocio { get; set; } // 1 para temporal, 2 para permanente

        public Miembros(int id, int edad, int tipoSocio)
        {
            Id = id;
            Edad = edad;
            TipoSocio = tipoSocio;
        }
    }
}
