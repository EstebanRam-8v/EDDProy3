using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EDDemo
{
    public partial class frmShellsort : Form
    {
        private List<int> numeros = new List<int>();

        public frmShellsort()
        {
            InitializeComponent();
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            // Validar si el valor en el TextBox es un número
            if (int.TryParse(txtShell.Text, out int numero))
            {
                numeros.Add(numero); // Agregar número a la lista
                txtShell.Clear();    // Limpiar el TextBox
                txtShell.Focus();    // Enfocar el TextBox
                MessageBox.Show("Número agregado correctamente.");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
        }

        // Evento para ordenar la lista y mostrar el resultado
        private void BtnOrdenar_Click(object sender, EventArgs e)
        {
            if (numeros.Count > 0)
            {
                ShellSort(numeros); // Ordenar la lista con Shell Sort
                LbResultado.Text = "Resultado: " + string.Join(", ", numeros); // Mostrar el resultado
            }
            else
            {
                MessageBox.Show("No hay números para ordenar.");
            }
        }

        // Método de ordenación Shell Sort
        private void ShellSort(List<int> lista)
        {
            int n = lista.Count;
            int intervalo = n / 2;

            while (intervalo > 0)
            {
                for (int i = intervalo; i < n; i++)
                {
                    int temp = lista[i];
                    int j = i;

                    // Ordenar los subgrupos por el intervalo
                    while (j >= intervalo && lista[j - intervalo] > temp)
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
