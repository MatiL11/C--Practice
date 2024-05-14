using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial
{

    public enum SituacionFiscal
    {
        Monotributo,
        ResponsableInscripto
    }

    public class ClienteEmpresa : Cliente
    {
        public string CUIT { get; }
        public string NombreEmpresa { get; }
        public string Direccion { get; }
        public SituacionFiscal SituacionFiscal { get; }

        public ClienteEmpresa(string nombre, string apellido, DateTime fechaNacimiento, string cuit, string nombreEmpresa, string direccion, SituacionFiscal situacionFiscal)
            : base(nombre, apellido, fechaNacimiento)
        {
            CUIT = cuit;
            NombreEmpresa = nombreEmpresa;
            Direccion = direccion;
            SituacionFiscal = situacionFiscal;
        }

        public override bool EsMayorDeEdad()
        {
            return base.EsMayorDeEdad();
        }
    }
}
