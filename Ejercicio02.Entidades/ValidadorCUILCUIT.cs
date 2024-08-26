using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio02.Entidades
{
    public static class ValidadorCUILCUIT
    {
        public static bool Validar(string cuilCuit, string tipo)
        {
            if (!EsFormatoValido(cuilCuit))
            {
                return false;
            }

            if (!EsTipoValido(cuilCuit, tipo))
            {
                return false;
            }

            return VerificarDigito(cuilCuit);
        }

        public static bool VerificarDigito(string cuilCuit)
        {
            if (cuilCuit.Length != 11)
            {
                return false;
            }
            int[] multiplicadores = { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };
            string numeros = cuilCuit.Replace("-", "").Substring(0, 10);
            int digitoVerificador = int.Parse(cuilCuit.Substring(12, 1));
            int suma = 0;

            for (int i = 0; i < 10; i++)
            {
                suma += int.Parse(numeros[i].ToString()) * multiplicadores[i];
            }

            int resto = suma % 11;
            int digitoCalculado = resto == 0 ? 0 : (resto == 1 ? 9 : 11 - resto);

            return digitoVerificador == digitoCalculado;
        }

        private static bool EsTipoValido(string cuilCuit, string tipo)
        {
            string prefijo = cuilCuit.Substring(0, 2);
            return (tipo == "hombre" && prefijo == "20") ||
                   (tipo == "mujer" && prefijo == "27") ||
                   (tipo == "empresa" && prefijo == "30");
        }

        private static bool EsFormatoValido(string cuilCuit)
        {
            string patron = @"^\d{2}-\d{8}-\d{1}$";
            return Regex.IsMatch(cuilCuit, patron);
        }
    }
}
