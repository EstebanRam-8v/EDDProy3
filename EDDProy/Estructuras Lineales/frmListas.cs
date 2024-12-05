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
    public partial class frmListas : Form
    {

        private List<string> miLista;
        public frmListas()
        {
            InitializeComponent();
            miLista = new List<string>();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string input = txtLista.Text;

            if (miLista.Contains(input))
            {
                MessageBox.Show($"El elemento '{input}' se encuentra en la lista.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"El elemento '{input}' no se encuentra en la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = txtLista.Text;

            if (!string.IsNullOrWhiteSpace(input))
            {
                miLista.Add(input);
                ActualizarContenido();
                txtLista.Clear();
                txtLista.Focus();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un valor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string input = txtLista.Text;

            if (miLista.Remove(input))
            {
                MessageBox.Show($"El elemento '{input}' fue eliminado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarContenido();
            }
            else
            {
                MessageBox.Show($"El elemento '{input}' no se encuentra en la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            miLista.Clear();
            ActualizarContenido();
            MessageBox.Show("La lista ha sido limpiada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ActualizarContenido()
        {
            LbMostrar.Text = string.Join(", ", miLista);
        }
    }
    
}
