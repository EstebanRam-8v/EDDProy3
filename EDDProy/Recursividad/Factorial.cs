using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo
{
    internal class Factorial
    {
        public static long Calcular(int n)
        {
            // Validación: El factorial no está definido para números negativos.
            if (n < 0)
            {
                throw new ArgumentException("El factorial no está definido para números negativos.");
            }

            // Factorial de 0 o 1 es 1
            if (n == 0 || n == 1)
            {
                return 1;
            }

            // Cálculo del factorial usando un bucle
            long resultado = 1;
            for (int i = 2; i <= n; i++)
            {
                resultado *= i;

                // Validación: Asegurarse de que no ocurra un desbordamiento
                if (resultado < 0)
                {
                    throw new OverflowException("El resultado del factorial es demasiado grande para ser representado como un valor long.");
                }
            }

            return resultado;
        }

    }
}
