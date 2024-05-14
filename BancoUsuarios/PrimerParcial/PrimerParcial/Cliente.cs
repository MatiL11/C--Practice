using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial
{
    public abstract class Cliente
    {
        public string Nombre { get; }
        public string Apellido { get; }
        public DateTime FechaNacimiento { get; }

        protected Cliente(string nombre, string apellido, DateTime fechaNacimiento)
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
        }

        public virtual bool EsMayorDeEdad()
        {
            return (DateTime.Today - FechaNacimiento).TotalDays / 365 >= 18;
        }
    }
}
