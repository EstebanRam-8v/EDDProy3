using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo
{
    internal class Radix
    {
        public class RadixSorter
        {
           
            public static void Sort(int[] arr)
            {
                if (arr == null || arr.Length == 0)
                    throw new ArgumentException("El arreglo no puede estar vacío.");

                // Encuentra el número máximo para saber cuántos dígitos tiene
                int max = arr.Max();

                // Realiza la clasificación por cada dígito, pasando de las unidades hacia arriba
                for (int exp = 1; max / exp > 0; exp *= 10)
                {
                    CountingSort(arr, exp);
                }
            }

            
            private static void CountingSort(int[] arr, int exp)
            {
                int n = arr.Length;
                int[] output = new int[n]; // Arreglo de salida
                int[] count = new int[10]; // Cuenta de los dígitos (base 10)

                // Cuenta las ocurrencias de cada dígito
                for (int i = 0; i < n; i++)
                {
                    int digit = (arr[i] / exp) % 10;
                    count[digit]++;
                }

                // Cambia count[i] para contener la posición real de este dígito en output[]
                for (int i = 1; i < 10; i++)
                {
                    count[i] += count[i - 1];
                }

                // Construye el arreglo de salida
                for (int i = n - 1; i >= 0; i--)
                {
                    int digit = (arr[i] / exp) % 10;
                    output[count[digit] - 1] = arr[i];
                    count[digit]--;
                }

                // Copia el arreglo de salida al arreglo original
                for (int i = 0; i < n; i++)
                {
                    arr[i] = output[i];
                }
            }

        }
    }
}