using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial
{
    public class ClientePersonal : Cliente
    {
        public string DNI { get; }
        public string CUIL { get; }

        public ClientePersonal(string nombre, string apellido, DateTime fechaNacimiento, string dni, string cuil)
            : base(nombre, apellido, fechaNacimiento)
        {
            DNI = dni;
            CUIL = cuil;
        }

        public override bool EsMayorDeEdad()
        {
            return base.EsMayorDeEdad();
        }
    }
}
