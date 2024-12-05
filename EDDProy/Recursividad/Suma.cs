using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo
{
    internal class Suma
    {
        public static int CalcularSuma(string numeros)
        {
            if (string.IsNullOrWhiteSpace(numeros))
            {
                throw new ArgumentException("La entrada no puede estar vacía.");
            }

            try
            {
                var listaNumeros = numeros.Split(',')
                                          .Select(x => int.Parse(x.Trim()))
                                          .ToList();

                return listaNumeros.Sum();
            }
            catch (FormatException)
            {
                throw new FormatException("La entrada contiene valores no válidos. Asegúrate de usar números separados por comas.");
            }
        }
    }
}
