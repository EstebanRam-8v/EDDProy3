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
    public partial class frmSuma : Form
    {
        public frmSuma()
        {
            InitializeComponent();
        }

        private void BtnResultado1_Click(object sender, EventArgs e)
        {
            try
            {
                // Lee los valores de los TextBox
                int valor1 = int.Parse(txtSuma.Text);
                int valor2 = int.Parse(txtResultado1.Text);

                // Inicia el cronómetro
                var stopwatch = Stopwatch.StartNew();

                // Calcula la suma usando la clase Suma
                int resultado = Suma.CalcularSuma(valor1, valor2);

                // Detiene el cronómetro
                stopwatch.Stop();

                // Muestra el tiempo en el Label
                LbtiempoSuma.Text = $"Tiempo: {stopwatch.Elapsed.TotalMilliseconds} ms";

                // Muestra el resultado en una ventana emergente
                MessageBox.Show($"El resultado de la suma es: {resultado}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa números válidos en ambos campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static class Suma
        {
            public static int CalcularSuma(int valor1, int valor2)
            {
                return valor1 + valor2;
            }

        }
    }
}
