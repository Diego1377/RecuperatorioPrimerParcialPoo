using Ejercicio03.Entidades;

namespace Ejercicio03.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kilo kilo = new Kilo(2);
            Libras libra = new Libras(4);

            Console.WriteLine($"Kilos: {kilo.GetPeso}Kg");
            Console.WriteLine($"Libras: {libra.GetPeso}Lb");

            // Conversión explícita entre tipos
            Kilo kilosConverted = (Kilo)libra;
            Libras librasConverted = (Libras)kilo;

            Console.WriteLine(
                $"Libras convertido a Kilos: {kilosConverted.GetPeso}Kg");
            Console.WriteLine(
                $"Kilos convertido a Libras: {librasConverted.GetPeso}Lb");

            // Operaciones aritméticas
            Kilo sumaKilo = kilo + kilosConverted;
            Libras sumaLibras = libra + librasConverted;

            Console.WriteLine($"Suma de Kilos: {sumaKilo.GetPeso}Kg");
            Console.WriteLine($"Suma de Libras: {sumaLibras.GetPeso}Lb");

            // Comparaciones
            Console.WriteLine(
                kilo == kilosConverted
                ? "Los pesos en Kilos son iguales."
                : "Los pesos en Kilos no son iguales.");
            Console.WriteLine(
                libra == librasConverted
                ? "Los Pesos en Libras son iguales."
                : "Los Pesos en Libras no son iguales.");
        }
    }
}
