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
    public partial class frmQuicksort : Form
    {
        public frmQuicksort()
        {
            InitializeComponent();
        }

        private void BtnOrdenar2_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer los números ingresados en el TextBox
                string input = txtDatos.Text;

                if (string.IsNullOrWhiteSpace(input))
                {
                    MessageBox.Show("Por favor, ingrese números separados por comas.");
                    return;
                }

                // Convertir los números a una lista de enteros
                List<int> numeros = input.Split(',')
                                         .Select(n => int.Parse(n.Trim()))
                                         .ToList();

                // Ordenar la lista usando el método QuickSort
                QuickSort(numeros, 0, numeros.Count - 1);

                // Mostrar el resultado en el Label
                LbResultado1.Text = "Resultado: " + string.Join(", ", numeros);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Método QuickSort
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

