namespace Ejercicio04.Entidades
{
    public class NumeroDivDosTres
    {
        public int Valor { get; set; }
        public NumeroDivDosTres(int valor)
        {
            Valor = valor;
        }
        public bool EsValido()
        {
            int numero = Valor;
            return numero % 2 == 0 && numero % 3 == 0;
        }
        public override string ToString()
        {
            return $"{Valor}";
        }
        public static bool operator ==(NumeroDivDosTres n1, NumeroDivDosTres n2)
        {
            if (ReferenceEquals(n1, null) || ReferenceEquals(n2, null))
            {
                return ReferenceEquals(n1, n2);
            }
            return n1.Valor == n2.Valor;
        }
        public static bool operator !=(NumeroDivDosTres n1, NumeroDivDosTres n2)
        {
            return !(n1 == n2);
        }
        public override bool Equals(object? obj)
        {
            if (obj is null || !(obj is NumeroDivDosTres nd)) return false;
            return this == nd;
        }
        public override int GetHashCode()
        {
            return Valor.GetHashCode();
        }

    }
}
