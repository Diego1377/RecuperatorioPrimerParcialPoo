
using Ejercicio02.Entidades;

namespace Ejercicio02.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Ingrese el CUIL/CUIT:");
            string cuilCuit = Console.ReadLine();

            Console.WriteLine("Ingrese el tipo (hombre, mujer, empresa):");
            string tipo = Console.ReadLine().ToLower();

            bool esValido = ValidadorCUILCUIT.Validar(cuilCuit, tipo);

            if (esValido)
            {
                Console.WriteLine("El CUIL/CUIT es válido.");
            }
            else
            {
                Console.WriteLine("El CUIL/CUIT es inválido.");
            }

        }
    }
}
