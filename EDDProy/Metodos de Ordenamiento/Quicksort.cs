using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo
{
    internal class Quicksort
    {
        private void QuickSort(List<int> lista, int inicio, int fin)
        {
            if (inicio < fin)
            {
                int indicePivote = Particionar(lista, inicio, fin);

                // Ordenar la sublista izquierda
                QuickSort(lista, inicio, indicePivote - 1);

                // Ordenar la sublista derecha
                QuickSort(lista, indicePivote + 1, fin);
            }
        }

        // Método para dividir la lista y encontrar la posición del pivote
        private int Particionar(List<int> lista, int inicio, int fin)
        {
            int pivote = lista[fin]; // Seleccionar el último elemento como pivote
            int i = inicio - 1;

            for (int j = inicio; j < fin; j++)
            {
                if (lista[j] <= pivote)
                {
                    i++;
                    // Intercambiar lista[i] con lista[j]
                    int temp = lista[i];
                    lista[i] = lista[j];
                    lista[j] = temp;
                }
            }

            // Intercambiar el pivote con el elemento en la posición i+1
            int tempFinal = lista[i + 1];
            lista[i + 1] = lista[fin];
            lista[fin] = tempFinal;

            return i + 1;
        }
    }
}

