using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo
{
    internal class Shellsort
    {
        // Método genérico para ordenar una lista usando Shell Sort
        public static void Ordenar<T>(List<T> lista) where T : IComparable<T>
        {
            int n = lista.Count;
            int intervalo = n / 2;

            while (intervalo > 0)
            {
                for (int i = intervalo; i < n; i++)
                {
                    T temp = lista[i];
                    int j = i;

                    // Ordenar los subgrupos por el intervalo
                    while (j >= intervalo && lista[j - intervalo].CompareTo(temp) > 0)
                    {
                        lista[j] = lista[j - intervalo];
                        j -= intervalo;
                    }

                    lista[j] = temp;
                }

                intervalo /= 2; // Reducir el intervalo
            }
        }
    }
}
