using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo
{
    internal class BusquedaBi
    {
        /// <summary>
        /// Realiza la búsqueda binaria en un arreglo ordenado.
        /// </summary>
        /// <param name="array">Arreglo de enteros ordenado.</param>
        /// <param name="valor">Valor a buscar.</param>
        /// <returns>Verdadero si se encuentra el valor, falso de lo contrario.</returns>
        public bool BusquedaBinaria(int[] array, int valor)
        {
            int inicio = 0;
            int fin = array.Length - 1;

            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;

                if (array[medio] == valor)
                {
                    return true; // Encontrado
                }
                else if (array[medio] < valor)
                {
                    inicio = medio + 1;
                }
                else
                {
                    fin = medio - 1;
                }
            }

            return false; // No encontrado
        }

        /// <summary>
        /// Convierte una cadena de texto separada por comas en un arreglo de enteros ordenado.
        /// </summary>
        /// <param name="datos">Cadena de números separados por comas.</param>
        /// <returns>Arreglo de enteros ordenado.</returns>
        public int[] ConvertirYOrdenar(string datos)
        {
            return datos.Split(',')
                        .Select(int.Parse)
                        .OrderBy(x => x)
                        .ToArray();
        }

    }
}
