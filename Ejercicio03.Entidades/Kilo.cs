namespace Ejercicio03.Entidades
{
    public class Kilo
    {
        private float peso;
        public float GetPeso => peso;
        public Kilo(float peso = 5)
        {
            this.peso = peso;
        }
        public static implicit operator float(Kilo kilo)
        {
            return kilo.peso;
        }
        public static bool operator ==(Kilo k1, Kilo k2)
        {
            return k1.peso==k2.peso;
        }
        public static bool operator !=(Kilo k1, Kilo k2)
        {
            return !(k1 == k2);
        }
        public static explicit operator Kilo(Libras libras)
        {
            return new Kilo(libras.GetPeso * 0.45359237f);
        }
        public static bool operator ==(Kilo k, Libras l)
        {
            return k == (Kilo)l;
        }
        public static bool operator !=(Kilo k, Libras l)
        {
            return !(k == (Kilo)l);
        }
        public static Kilo operator +(Kilo k1, Kilo k2)
        {
            return new Kilo(k1.peso + k2.peso);
        }
        public static Kilo operator +(Kilo k, Libras l)
        {
            return k + (Kilo)l;
        }

        public override bool Equals(object obj)
        {
            if (obj is null || !(obj is Kilo kilo)) return false;
            return this.Equals(kilo);

        }
        public override int GetHashCode()
        {
            return this.peso.GetHashCode();
        }
    }
}
