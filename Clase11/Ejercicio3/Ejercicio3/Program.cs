using System;

class Program
{
    public class Persona : ICloneable
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public object Clone()
        {
            // MemberwiseClone para realizar una copia superficial
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"{Nombre}, {Edad} años";
        }
    }

    static void Main()
    {
        // Crear un objeto Persona
        Persona personaOriginal = new Persona("Ana", 25);

        // Clonar el objeto Persona
        Persona personaClonada = (Persona)personaOriginal.Clone();

        Console.WriteLine("Persona Original: " + personaOriginal);
        Console.WriteLine("Persona Clonada: " + personaClonada);

        // Verificar si el objeto clonado es del mismo tipo utilizando el operador is
        if (personaClonada is Persona)
        {
            Console.WriteLine("El objeto clonado es del tipo Persona.");
        }
        else
        {
            Console.WriteLine("El objeto clonado NO es del tipo Persona.");
        }
    }
}