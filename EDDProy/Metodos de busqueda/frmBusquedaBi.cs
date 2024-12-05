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
    public partial class frmBusquedaBi : Form
    {
        public frmBusquedaBi()
        {
            InitializeComponent();
        }

        private void btnBuscar4_Click(object sender, EventArgs e)
        {
            // Leer los números ingresados en txtNumeros4
            string numerosTexto = txtNumero4.Text;

            // Validar si se ingresaron números
            if (string.IsNullOrWhiteSpace(numerosTexto))
            {
                LbResultado4.Text = "Por favor, ingresa una lista de números separados por comas.";
                return;
            }

            // Dividir los números ingresados por comas
            string[] numerosArray = numerosTexto.Split(',');

            // Convertir los números a un array de enteros
            int[] numeros;
            try
            {
                numeros = numerosArray.Select(int.Parse).ToArray();
            }
            catch
            {
                LbResultado4.Text = "Error: Asegúrate de que todos los valores sean números enteros válidos.";
                return;
            }

            // Ordenar el array para aplicar búsqueda binaria
            Array.Sort(numeros);

            // Leer el número a buscar desde txtBuscar4
            if (!int.TryParse(txtBuscar4.Text, out int numeroBuscar))
            {
                LbResultado4.Text = "Por favor, ingresa un número válido para buscar.";
                return;
            }

            // Realizar la búsqueda binaria
            int resultado = BusquedaBinaria(numeros, numeroBuscar);

            // Mostrar el resultado
            if (resultado >= 0)
            {
                LbResultado4.Text = $"Número encontrado en la posición: {resultado}";
            }
            else
            {
                LbResultado4.Text = "Número no encontrado.";
            }
        }

        // Método de Búsqueda Binaria
        private int BusquedaBinaria(int[] array, int valor)
        {
            int inicio = 0;
            int fin = array.Length - 1;

            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;

                if (array[medio] == valor)
                {
                    return medio; // Retorna la posición si encuentra el número
                }
                else if (array[medio] < valor)
                {
                    inicio = medio + 1; // Ajustar el rango al lado derecho
                }
                else
                {
                    fin = medio - 1; // Ajustar el rango al lado izquierdo
                }
            }

            return -1; // Retorna -1 si no se encuentra el número
        }
    }
}
