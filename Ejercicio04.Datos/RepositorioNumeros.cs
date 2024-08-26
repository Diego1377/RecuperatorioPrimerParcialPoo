using Ejercicio04.Entidades;

namespace Ejercicio04.Datos
{
    public class RepositorioNumeros
    {
        private NumeroDivDosTres[]? numeros;
        private int cantidad;
        public int GetCantidad() => cantidad;
        public RepositorioNumeros(int Cantidad)
        {        
            cantidad = Cantidad;
            numeros = new NumeroDivDosTres[cantidad];          
        }
        public RepositorioNumeros() : this(5) { }
        private bool EstaCompleto() => numeros!.All(n => !(n is null));
        private bool EstaVacio() => numeros!.All(n => n is null);
        private bool ExisteNumero(NumeroDivDosTres nBuscado) => numeros!.Any(n => n == nBuscado);

        public (bool, string) Agregar(NumeroDivDosTres nAgregar)
        {
            if (EstaCompleto())
            {
                return (false, "El repositorio está completo.");
            }
            if (!nAgregar.EsValido())
            {
                return (false, "Numero Divisible por 2 y 3 no valido");
            }
            if (ExisteNumero(nAgregar))
            {
                return (false, "El número ya existe en el repositorio.");
            }
            for (int i = 0; i <= numeros!.Length; i++)
            {
                if (numeros[i] is null)
                {
                    numeros[i] = nAgregar;
                    return (true, $"Número agregado en la posicion {i}.");
                }
            }
            return (false, "No se puede agregar");
        }
        public (bool, string) QuitarNumero(NumeroDivDosTres nQuitar)
        {
            if (EstaVacio())
            {
                return (false, "Repo sin elementos");
            }
            if (!ExisteNumero(nQuitar))
            {
                return (false, "numero inexistente");
            }
            for (int i = 0; i < numeros!.Length; i++)
            {
                if (numeros[i].Equals(nQuitar))
                {
                    numeros[i] = null;
                    return (true, "Número eliminado correctamente.");
                }
            }
            return (false, "El número no se encontró en el repositorio.");
        }
        public NumeroDivDosTres ObtenerElemento(int index)
        {
            if (index < 0 || index > cantidad - 1)
            {
                throw new IndexOutOfRangeException("Indice fuera del rango permitido");
            }
            return numeros![index];

        }
        public string ObtenerTodosLosNumeros()
        {
            string resultado = string.Empty;
            if (EstaVacio())
            {
                return "No hay elementos almacenados todavía.";
            }
            else
            {
                for (int i = 0; 1 <= numeros!.Length; i++)
                {
                    resultado += numeros[1] is null ? "Elemento Nulo" : numeros[i].ToString();
                    resultado += "\n";
                }
            }
            return resultado;

        }
        public (bool, int) BuscarNumero(NumeroDivDosTres n)
        {
            if (EstaVacio())
            {
                return (false, -1);
            }
            if (!ExisteNumero(n))
            {
                return (false, -1);
            }
            for (int i = 0; i <= numeros!.Length; i++)
            {
                if (n.Equals(numeros[i]))
                {
                    return (true, i);
                }
            }
            return (false, -1);
        }
        public static implicit operator int(RepositorioNumeros repo)
        {
            if (repo.EstaVacio()) return 0;
            return repo.numeros!.Sum(x => x.Valor);
        }
    }
}
