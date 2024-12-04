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
    public partial class frmColas : Form
    {
        private Queue<string> miCola;

        public frmColas()
        {
            InitializeComponent();
            miCola = new Queue<string>();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string input = txtColas.Text;

            if (!string.IsNullOrWhiteSpace(input))
            {
                miCola.Enqueue(input);
                ActualizarContenido();
                txtColas.Clear();
                txtColas.Focus();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un valor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            if (miCola.Count > 0)
            {
                string eliminado = miCola.Dequeue();
                MessageBox.Show($"Elemento eliminado: {eliminado}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarContenido();
            }
            else
            {
                MessageBox.Show("La cola está vacía.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

            string input = txtColas.Text;

            if (miCola.Contains(input))
            {
                MessageBox.Show($"El elemento '{input}' se encuentra en la cola.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"El elemento '{input}' no se encuentra en la cola.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            miCola.Clear();
            ActualizarContenido();
            MessageBox.Show("La cola ha sido limpiada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ActualizarContenido()
        {
            LbContenido.Text = string.Join(", ", miCola);
        }
    }
}
