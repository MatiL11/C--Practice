using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SociosClubes
{
    public class Club
    {
        public string Nombre { get; set; }
        public List<Miembros> Socios { get; } = new List<Miembros>(); // Inicializar la lista 

        public Club(string nombre)
        {
            Nombre = nombre;
        }
        public void AgregarSocio(int id, int edad, int tipoSocio)
        {
            if (tipoSocio != 0 && (tipoSocio == 1 || tipoSocio == 2))
            {
                if (edad >= 0 && edad <= 100)
                {
                    Socios.Add(new Miembros(id, edad, tipoSocio));
                    MessageBox.Show("Socio agregado correctamente.");
                }
                else
                {
                    if (edad < 0)
                    {
                        MessageBox.Show("La edad no puede ser menor a 0.");
                    }
                    else if (edad > 100)
                    {
                        MessageBox.Show("La edad no puede ser mayor a 100.");
                    }
                }
            }
            else
            {
                // Manejar tipo de socio inválido
            }
        }

        //funcion para obtener la cantidad de socios temporales y permanentes
        //public (int, int) ObtenerCantidadSocios()
        //{
        //    int cantidadTemporales = 0, cantidadPermanentes = 0;
        //    foreach (Miembros socio in Socios)
        //    {
        //        if (socio.TipoSocio == 1)
        //        {
        //            cantidadTemporales++;
        //        }
        //        else if (socio.TipoSocio == 2)
        //        {
        //            cantidadPermanentes++;
        //        }
        //    }
        //    return (cantidadTemporales, cantidadPermanentes);
        //}
    }
}
