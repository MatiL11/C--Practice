using System;

class Program
{

    public class Persona : IComparable<Persona>
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public int CompareTo(Persona otra)
        {
            if (otra == null) return 1;

            return this.Edad.CompareTo(otra.Edad);
        }

        public override string ToString()
        {
            return $"{Nombre}, {Edad} años";
        }
    }

    static void Main()
    {
        Persona[] personas = new Persona[]
        {
            new Persona("Ana", 25),
            new Persona("Juan", 30),
            new Persona("Lucía", 22),
            new Persona("Carlos", 28)
        };

        // array antes de ordenar
        Console.WriteLine("Antes de ordenar:");
        foreach (var persona in personas)
        {
            Console.WriteLine(persona);
        }

        // Ordenar el array
        Array.Sort(personas);

        // array después de ordenar
        Console.WriteLine("\nDespués de ordenar:");
        foreach (var persona in personas)
        {
            Console.WriteLine(persona);
        }
    }
}