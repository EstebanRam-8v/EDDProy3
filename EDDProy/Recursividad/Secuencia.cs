using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo
{
    internal class Secuencia
    {
        public static List<int> GenerarFibonacci(int cantidad)
        {
            if (cantidad <= 0)
            {
                throw new ArgumentException("La cantidad debe ser mayor a 0.");
            }

            List<int> secuencia = new List<int>();

            if (cantidad >= 1) secuencia.Add(0);
            if (cantidad >= 2) secuencia.Add(1);

            for (int i = 2; i < cantidad; i++)
            {
                int nuevoNumero = secuencia[i - 1] + secuencia[i - 2];
                secuencia.Add(nuevoNumero);
            }

            return secuencia;
        }
    }

}
