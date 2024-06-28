using System;

class Program
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public override string ToString()
        {
            return $"{Nombre}, {Edad} años";
        }
    }

    public class PersonaComparer : IComparer<Persona>
    {
        public enum Criterio
        {
            Nombre,
            Edad,
            LongitudNombre,
            PrimeraLetraNombre,
            UltimaLetraNombre
        }

        private Criterio criterio;

        public PersonaComparer(Criterio criterio)
        {
            this.criterio = criterio;
        }

        public int Compare(Persona x, Persona y)
        {
            switch (criterio)
            {
                case Criterio.Nombre:
                    return string.Compare(x.Nombre, y.Nombre);
                case Criterio.Edad:
                    return x.Edad.CompareTo(y.Edad);
                case Criterio.LongitudNombre:
                    return x.Nombre.Length.CompareTo(y.Nombre.Length);
                case Criterio.PrimeraLetraNombre:
                    return x.Nombre[0].CompareTo(y.Nombre[0]);
                case Criterio.UltimaLetraNombre:
                    return x.Nombre[x.Nombre.Length - 1].CompareTo(y.Nombre[y.Nombre.Length - 1]);
                default:
                    throw new ArgumentException("Criterio de comparación no soportado.");
            }
        }
    }

    static void Main()
    {
        Persona[] personas = new Persona[]
        {
            new Persona("Ana", 25),
            new Persona("Juan", 30),
            new Persona("Lucía", 22),
            new Persona("Carlos", 28),
            new Persona("Beatriz", 26)
        };

        MostrarOrdenados(personas, PersonaComparer.Criterio.Nombre, "Nombre");
        MostrarOrdenados(personas, PersonaComparer.Criterio.Edad, "Edad");
        MostrarOrdenados(personas, PersonaComparer.Criterio.LongitudNombre, "Longitud del Nombre");
        MostrarOrdenados(personas, PersonaComparer.Criterio.PrimeraLetraNombre, "Primera Letra del Nombre");
        MostrarOrdenados(personas, PersonaComparer.Criterio.UltimaLetraNombre, "Última Letra del Nombre");
    }

    static void MostrarOrdenados(Persona[] personas, PersonaComparer.Criterio criterio, string nombreCriterio)
    {
        Array.Sort(personas, new PersonaComparer(criterio));
        Console.WriteLine($"\nOrdenados por {nombreCriterio}:");
        foreach (var persona in personas)
        {
            Console.WriteLine(persona);
        }
    }
}