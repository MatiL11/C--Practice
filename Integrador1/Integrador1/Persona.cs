using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador1
{
    public class Persona
    {
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        private List<Auto> autos;

        public Persona(string dni, string nombre, string apellido)
        {
            DNI = dni;
            Nombre = nombre;
            Apellido = apellido;
            autos = new List<Auto>();
        }

        public List<Auto> Lista_de_autos()
        {
            return autos;
        }

        public int Cantidad_de_Autos()
        {
            return autos.Count;
        }

        public void AgregarAuto(Auto auto)
        {
            if (auto != null)
            {
                autos.Add(auto);
                auto.AsignarPropietario(this);
            }
        }

        public void EliminarAuto(Auto auto)
        {
            if (auto != null && autos.Contains(auto))
            {
                autos.Remove(auto);
                auto.RemoverPropietario();
            }
        }

        ~Persona()
        {
            Console.WriteLine($"Persona con DNI {DNI} ha sido liberada.");
        }
    }
}
