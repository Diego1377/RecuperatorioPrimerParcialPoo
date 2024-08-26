namespace Ejercicio03.Entidades
{
    public class Libras
    {
        private float peso;
        public float GetPeso => peso;
        public Libras(float peso = 5f)
        {
            this.peso = peso;
        }
        public static implicit operator float(Libras libras)
        {
            return libras.peso;
        }
        public static bool operator ==(Libras l1, Libras l2)
        {
            return l1.peso == l2.peso;
        }
        public static bool operator !=(Libras l1, Libras l2)
        {
            return !(l1 == l2);
        }
        public static explicit operator Libras(Kilo kilo)
        {
            return new Libras(kilo.GetPeso* 2.20462262f) ;
        }
        public static bool operator ==(Libras l, Kilo k)
        {
            return l == (Libras)k;
        }
        public static bool operator !=(Libras l, Kilo k)
        {
            return !(l == (Libras)k);
        }
        public static Libras operator +(Libras l1, Libras l2)
        {
            return new Libras(l1.peso + l2.peso);
        }
        public static Libras operator +(Libras l, Kilo k)
        {
            return l + (Libras)k;
        }

        public override bool Equals(object obj)
        {
            if (obj is null || !(obj is Libras libras)) return false;
            return this.Equals(libras);

        }
        public override int GetHashCode()
        {
            return this.peso.GetHashCode();
        }
    }
}
