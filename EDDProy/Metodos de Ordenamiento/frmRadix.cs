using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo
{
    public partial class frmRadix : Form
    {
        public frmRadix()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer los números ingresados
                string input = txtDatos3.Text;
                int[] numeros = input.Split(',').Select(int.Parse).ToArray();

                // Aplicar Radix Sort
                RadixSort(numeros);

                // Mostrar resultado
                txtRe.Text = "Ordenado: " + string.Join(", ", numeros);
            }
            catch (Exception)
            {
                // Mostrar mensaje de error en el mismo label del resultado
                txtRe.Text = "Error: Entrada no válida. Ingresa números separados por comas.";
            }
        }

        private void RadixSort(int[] arr)
        {
            // Encuentra el número máximo para saber cuántos dígitos tiene
            int max = arr.Max();

            // Realiza la clasificación por cada dígito, pasando de las unidades hacia arriba
            for (int exp = 1; max / exp > 0; exp *= 10)
            {
                CountingSort(arr, exp);
            }
        }

        private void CountingSort(int[] arr, int exp)
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

