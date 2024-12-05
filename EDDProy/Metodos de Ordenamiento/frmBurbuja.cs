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
    public partial class frmBurbuja : Form
    {
        public frmBurbuja()
        {
            InitializeComponent();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer números desde el TextBox, separados por comas
                string input = txtNumeros.Text;
                if (string.IsNullOrWhiteSpace(input))
                {
                    MessageBox.Show("Por favor, ingrese números separados por comas.");
                    return;
                }

                // Convertir los números ingresados a una lista de enteros
                List<int> numeros = input.Split(',')
                                         .Select(n => int.Parse(n.Trim()))
                                         .ToList();

                // Ordenar los números usando el método Burbuja
                Burbuja(numeros);

                // Mostrar el resultado en el Label
                lblResultado.Text = "Resultado: " + string.Join(", ", numeros);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Método de ordenación Burbuja
        private void Burbuja(List<int> lista)
        {
            int n = lista.Count;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (lista[j] > lista[j + 1])
                    {
                        // Intercambiar los elementos
                        int temp = lista[j];
                        lista[j] = lista[j + 1];
                        lista[j + 1] = temp;
                    }
                }
            }
        }
    }
}