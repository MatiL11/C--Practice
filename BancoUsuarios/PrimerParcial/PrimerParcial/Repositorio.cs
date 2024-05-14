using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial
{
    public class ClienteRepositorio
    {
        private List<Cliente> clientes = new List<Cliente>();

        // agrega un cliente al repositorio
        public void AgregarCliente(Cliente cliente)
        {
            if (!clientes.Contains(cliente))
            {
                if (cliente.EsMayorDeEdad())
                {
                    clientes.Add(cliente);
                }
                else
                {
                    Console.WriteLine("El cliente debe ser mayor de 18 años para ser registrado.");
                }
            }
            else
            {
                Console.WriteLine("El cliente ya está registrado.");
            }
        }

        // obtiene todos los clientes de un tipo específico
        public List<Cliente> ObtenerClientesPorTipo<T>() where T : Cliente
        {
            var clientesPorTipo = new List<Cliente>();
            foreach (var cliente in clientes)
            {
                if (cliente.GetType() == typeof(T))
                {
                    clientesPorTipo.Add(cliente);
                }
            }
            return clientesPorTipo;
        }
    }
}
