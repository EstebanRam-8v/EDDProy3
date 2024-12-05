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
    public partial class frmBusquedaSec : Form
    {
        public frmBusquedaSec()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string numerosTexto = txtNumeros3.Text;

            // Verificar si hay datos ingresados
            if (string.IsNullOrWhiteSpace(numerosTexto))
            {
                LbResultado3.Text = "Por favor, ingresa una lista de números.";
                return;
            }

            // Dividir la lista de números (asume que están separados por comas)
            string[] numerosArray = numerosTexto.Split(',');

            // Intentar convertir cada valor a entero
            int[] numeros;
            try
            {
                numeros = numerosArray.Select(int.Parse).ToArray();
            }
            catch
            {
                LbResultado3.Text = "Por favor, asegúrate de que todos los números estén correctamente formateados.";
                return;
            }

            // Leer el número a buscar desde txtBuscar3
            if (!int.TryParse(txtBuscar3.Text, out int numeroBuscar))
            {
                LbResultado3.Text = "Por favor, ingresa un número válido para buscar.";
                return;
            }

            // Realizar la búsqueda secuencial
            int indice = -1;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == numeroBuscar)
                {
                    indice = i;
                    break;
                }
            }

            // Mostrar el resultado
            if (indice >= 0)
            {
                LbResultado3.Text = $"Número encontrado en la posición: {indice}";
            }
            else
            {
                LbResultado3.Text = "Número no encontrado.";
            }
        }
    }
    
}
