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
    public partial class frmTorre : Form
    {
        public frmTorre()
        {
            InitializeComponent();
        }

        private void BtnTorre_Click(object sender, EventArgs e)
        {
            try
            {
                int discos = int.Parse(txtDiscos.Text);

                if (discos <= 0)
                {
                    MessageBox.Show("Por favor, ingresa un número de discos mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                txtTorre.Clear();

                var stopwatch = Stopwatch.StartNew();

                // Llamada al método Resolver de la clase Torre
                string pasos = Torre.Resolver(discos, "A", "C", "B");

                stopwatch.Stop();

                txtTorre.Text = pasos;
                txtTiempoTorre.Text = $"Tiempo: {stopwatch.Elapsed.TotalMilliseconds} ms";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa un número válido en el campo 'Discos'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public static class Torre
        {
            public static string Resolver(int n, string origen, string destino, string auxiliar)
            {
                if (n <= 0)
                {
                    throw new ArgumentException("El número de discos debe ser mayor a 0.");
                }

                var pasos = new StringBuilder();
                ResolverHanoi(n, origen, destino, auxiliar, pasos);
                return pasos.ToString();
            }

            private static void ResolverHanoi(int n, string origen, string destino, string auxiliar, StringBuilder pasos)
            {
                if (n == 1)
                {
                    pasos.AppendLine($"Mover disco 1 de {origen} a {destino}");
                    return;
                }

                ResolverHanoi(n - 1, origen, auxiliar, destino, pasos);
                pasos.AppendLine($"Mover disco {n} de {origen} a {destino}");
                ResolverHanoi(n - 1, auxiliar, destino, origen, pasos);
            }
        }
    }
}



