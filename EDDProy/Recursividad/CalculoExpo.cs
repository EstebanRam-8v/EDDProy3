using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo
{
    internal class CalculoExpo
    {
        /// <summary>
        /// Calcula la potencia de un número base elevado a un exponente.
        /// </summary>
        /// <param name="baseNumero">El número base.</param>
        /// <param name="exponente">El exponente al que se eleva el número base.</param>
        /// <returns>El resultado del cálculo base^exponente.</returns>
        public static double Calcular(double baseNumero, double exponente)
        {
            return Math.Pow(baseNumero, exponente);
        }

        /// <summary>
        /// Valida que el texto ingresado sea un número válido.
        /// </summary>
        /// <param name="texto">El texto a validar.</param>
        /// <returns>El número convertido.</returns>
        /// <exception cref="FormatException">Se lanza si el texto no es un número válido.</exception>
        public static double ValidarNumero(string texto)
        {
            if (double.TryParse(texto, out double numero))
            {
                return numero;
            }
            else
            {
                throw new FormatException("El texto ingresado no es un número válido.");
            }
        }

    }
}
