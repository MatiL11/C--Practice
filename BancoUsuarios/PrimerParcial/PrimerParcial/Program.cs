using PrimerParcial;


class Program
{
    static void Main(string[] args)
    {
        var repositorio = new ClienteRepositorio();


        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Ingresando cliente {i + 1}");
            Console.Write("Tipo de cliente (Personal/Empresa): ");
            string tipoCliente = Console.ReadLine();

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Apellido: ");
            string apellido = Console.ReadLine();

            DateTime fechaNacimiento = DateTime.MinValue;
            bool fechaValida = false;
            while (!fechaValida)
            {
                Console.Write("Fecha de nacimiento (yyyy-MM-dd): ");
                string fechaNacimientoStr = Console.ReadLine();
                fechaValida = DateTime.TryParseExact(fechaNacimientoStr, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out fechaNacimiento);
                if (!fechaValida)
                {
                    Console.WriteLine("Fecha de nacimiento inválida. Intente de nuevo.");
                }
            }

            if (tipoCliente.ToLower() == "personal")
            {
                Console.Write("DNI: ");
                string dni = Console.ReadLine();

                Console.Write("CUIL: ");
                string cuil = Console.ReadLine();

                var clientePersonal = new ClientePersonal(nombre, apellido, fechaNacimiento, dni, cuil);
                repositorio.AgregarCliente(clientePersonal);
            }
            else if (tipoCliente.ToLower() == "empresa")
            {
                Console.Write("CUIT: ");
                string cuit = Console.ReadLine();

                Console.Write("Nombre de la empresa: ");
                string nombreEmpresa = Console.ReadLine();

                Console.Write("Dirección: ");
                string direccion = Console.ReadLine();

                Console.Write("Situación fiscal (Monotributo/ResponsableInscripto): ");
                SituacionFiscal situacionFiscal;
                Enum.TryParse(Console.ReadLine(), true, out situacionFiscal);

                var clienteEmpresa = new ClienteEmpresa(nombre, apellido, fechaNacimiento, cuit, nombreEmpresa, direccion, situacionFiscal);
                repositorio.AgregarCliente(clienteEmpresa);
            }
            else
            {
                Console.WriteLine("Tipo de cliente inválido. Inténtelo de nuevo.");
                i--;
            }
        }

        // Ver todos los clientes
        Console.WriteLine("\nClientes de Banca Personal:");
        var clientesPersonal = repositorio.ObtenerClientesPorTipo<ClientePersonal>();
        foreach (var cliente in clientesPersonal)
        {
            Console.WriteLine($"{cliente.Nombre} {cliente.Apellido} - DNI: {((ClientePersonal)cliente).DNI}");
        }

        Console.WriteLine("\nClientes de Banca Empresa:");
        var clientesEmpresa = repositorio.ObtenerClientesPorTipo<ClienteEmpresa>();
        foreach (var cliente in clientesEmpresa)
        {
            Console.WriteLine($"{cliente.Nombre} {cliente.Apellido} - CUIT: {((ClienteEmpresa)cliente).CUIT}");
        }
    }
}
