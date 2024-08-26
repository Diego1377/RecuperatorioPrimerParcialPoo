using Ejercicio01.Entidades;
using RecuperatorioPrimerParcialPooTema1;

namespace Ejercicio01.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int radio = ConsoleExtensions.ReadInt("Ingrese el radio de la Esfera: ");

                Esfera esfera = new Esfera(radio);

                Console.WriteLine(esfera.GetInfo());

            }
            catch (ArgumentException exepcion)
            {
                Console.WriteLine($"Error:{exepcion.Message}");
            }
        }
    }
}
