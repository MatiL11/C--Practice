using System;
using System.Collections;

class Program
{
    public class MiColeccion : IEnumerable
    {
        private string[] elementos;

        public MiColeccion(string[] items)
        {
            elementos = new string[items.Length];
            for (int i = 0; i < items.Length; i++)
            {
                elementos[i] = items[i];
            }
        }

        public IEnumerator GetEnumerator()
        {
            return new MiEnumerator(elementos);
        }

        private class MiEnumerator : IEnumerator
        {
            private string[] _elementos;
            private int _posicion = -1;

            public MiEnumerator(string[] items)
            {
                _elementos = items;
            }

            public bool MoveNext()
            {
                _posicion++;
                return (_posicion < _elementos.Length);
            }

            public void Reset()
            {
                _posicion = -1;
            }

            public object Current
            {
                get
                {
                    if (_posicion < 0 || _posicion >= _elementos.Length)
                    {
                        throw new InvalidOperationException();
                    }
                    return _elementos[_posicion];
                }
            }
        }
    }

    static void Main()
    {
        // Crear una colección de elementos
        string[] items = { "Elemento1", "Elemento2", "Elemento3", "Elemento4" };
        MiColeccion miColeccion = new MiColeccion(items);

        // Recorrer los elementos utilizando foreach
        Console.WriteLine("Elementos de la colección:");
        foreach (var item in miColeccion)
        {
            Console.WriteLine(item);
        }
    }
}