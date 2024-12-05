using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo
{
    public partial class frmBusqueda : Form
    {
        public frmBusqueda()
        {
            InitializeComponent();
        }

        private void BtnBuscarBi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBinario.Text))
            {
                MessageBox.Show("El campo de datos no puede estar vacío.", "Error");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtBuscarBi.Text))
            {
                MessageBox.Show("Por favor, ingresa un número a buscar.", "Error");
                return;
            }

            int numeroBuscado;
            if (!int.TryParse(txtBuscarBi.Text, out numeroBuscado))
            {
                MessageBox.Show("Por favor, ingresa un número válido para buscar.", "Error");
                return;
            }

            try
            {
                // Crear una instancia de la clase BusquedaBi
                var busqueda = new BusquedaBi();

                // Convertir y ordenar los datos del TextBox
                int[] datos = busqueda.ConvertirYOrdenar(txtBinario.Text);

                // Iniciar el temporizador
                var reloj = System.Diagnostics.Stopwatch.StartNew();

                // Realizar la búsqueda binaria
                bool encontrado = busqueda.BusquedaBinaria(datos, numeroBuscado);

                // Detener el temporizador
                reloj.Stop();

                // Mostrar el tiempo de búsqueda
                LbTiempo.Text = $"Tiempo: {reloj.Elapsed.TotalMilliseconds:F3} ms";

                // Mostrar el resultado
                if (encontrado)
                {
                    MessageBox.Show($"El número {numeroBuscado} fue encontrado.", "Éxito");
                }
                else
                {
                    MessageBox.Show($"El número {numeroBuscado} no está en el array.", "Resultado");
                }
            }
            catch
            {
                MessageBox.Show("Asegúrate de que los datos estén correctamente formateados (ejemplo: 5,8,3,1).", "Error");
            }
        }


        private bool BusquedaBinaria(int[] array, int valor)
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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
