using System.Text;

namespace Ejercicio01.Entidades
{
    public class Esfera
    {
        public int Radio { get; }
        private double diametro;

        public Esfera(int radio)
        {
            if (radio <= 0)
            {
                throw new ArgumentException("El Radio debe ser mayor que cero.");
            }

            Radio = radio;
            diametro = CalcularDiametro();
        }

        private double CalcularDiametro()
        {
            return Radio * 2;
        }
        public double CalcularArea()
        {
            return 4*Math.PI * Math.Pow(Radio, 2);
        }
        public double CalcularVolumen()
        {
            return (4.0/3.0) * Math.PI * Math.Pow(Radio, 3);
        }
        public string GetInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Esfera");
            sb.AppendLine($"\tRadio: {Radio}");
            sb.AppendLine($"\tDiametro: {CalcularDiametro()}");
            sb.AppendLine($"\tÁrea:{CalcularArea()}");
            sb.AppendLine($"\tVolumen: {CalcularVolumen()}");
            return sb.ToString();
        }
    }
}
