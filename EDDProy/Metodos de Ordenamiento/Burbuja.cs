using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo
{
    internal class Burbuja
    {
        // Método genérico para ordenar una lista usando el método Burbuja
        public static void Ordenar<T>(List<T> lista) where T : IComparable<T>
        {
            int n = lista.Count;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    // Comparar elementos adyacentes
                    if (lista[j].CompareTo(lista[j + 1]) > 0)
                    {
                        // Intercambiar si el actual es mayor que el siguiente
                        T temp = lista[j];
                        lista[j] = lista[j + 1];
                        lista[j + 1] = temp;
                    }
                }
            }
        }
    }
}
