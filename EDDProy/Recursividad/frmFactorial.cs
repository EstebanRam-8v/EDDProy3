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
    public partial class frmFactorial : Form
    {
        public frmFactorial()
        {
            InitializeComponent();
        }

        private void BtnCalcu_Click(object sender, EventArgs e)
        {
            try
            {
                // Toma el valor del TextBox de entrada
                int number = int.Parse(txtIngresarFac.Text);

                if (number < 0)
                {
                    MessageBox.Show("El factorial no está definido para números negativos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Inicializa el cronómetro
                Stopwatch stopwatch = Stopwatch.StartNew();

                // Calcula el factorial
                long factorial = CalcularFactorial(number);

                // Detiene el cronómetro
                stopwatch.Stop();

                // Muestra el resultado en el TextBox de resultado
                txtResultado.Text = factorial.ToString();

                // Muestra el tiempo en el Label
                LbTiempo3.Text = $"Tiempo: {stopwatch.Elapsed.TotalMilliseconds} ms";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa un número válido en el campo 'Número'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private long CalcularFactorial(int n)
        {
            long resultado = 1;

            for (int i = 1; i <= n; i++)
            {
                resultado *= i;
            }

            return resultado;
        }
    }
    
}
