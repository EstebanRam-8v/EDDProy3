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
    public partial class frmSecuencia : Form
    {
        public frmSecuencia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidad = int.Parse(txtCantidad.Text);
                var stopwatch = Stopwatch.StartNew();
                var fibonacciSecuencia = Secuencia.GenerarFibonacci(cantidad);
                stopwatch.Stop();
                txtSerie.Text = string.Join(", ", fibonacciSecuencia);
                LbTiempo4.Text = $"Tiempo: {stopwatch.Elapsed.TotalMilliseconds} ms";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private List<int> GenerarFibonacci(int cantidad)
        {
            List<int> secuencia = new List<int>();

            // Caso base: agregar los primeros dos números
            if (cantidad >= 1) secuencia.Add(0);
            if (cantidad >= 2) secuencia.Add(1);

            // Generar los siguientes números de la secuencia
            for (int i = 2; i < cantidad; i++)
            {
                int nuevoNumero = secuencia[i - 1] + secuencia[i - 2];
                secuencia.Add(nuevoNumero);
            }

            return secuencia;
        }
    }
    
}
