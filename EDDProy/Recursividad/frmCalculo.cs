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
    public partial class frmCalculo : Form
    {
        public frmCalculo()
        {
            InitializeComponent();
        }

        // Botón para insertar la base
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Valida que sea un número
                double baseNumber = double.Parse(txtInsertarExpo.Text);
                MessageBox.Show($"Base '{baseNumber}' insertada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa un número válido en el campo 'Base'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón para insertar el exponente
        private void BtnExpo_Click(object sender, EventArgs e)
        {
            try
            {
                // Valida que sea un número
                int exponent = int.Parse(txtExpo.Text);
                MessageBox.Show($"Exponente '{exponent}' insertado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa un número válido en el campo 'Exponente'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón para calcular el resultado y medir el tiempo
        private void BtnResul_Click(object sender, EventArgs e)
        {
            try
            {
                // Toma los valores de los TextBox
                double baseNumber = double.Parse(txtInsertarExpo.Text);
                int exponent = int.Parse(txtExpo.Text);

                // Inicializa el cronómetro
                Stopwatch stopwatch = Stopwatch.StartNew();

                // Calcula el resultado
                double result = Math.Pow(baseNumber, exponent);

                // Detiene el cronómetro
                stopwatch.Stop();

                // Muestra el resultado en el TextBox de resultado
                txtResul.Text = result.ToString();

                // Muestra el tiempo en el Label
                LbTiempo2.Text = $"Tiempo: {stopwatch.Elapsed.TotalMilliseconds} ms";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, asegúrate de que los campos 'Base' y 'Exponente' contengan números válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
