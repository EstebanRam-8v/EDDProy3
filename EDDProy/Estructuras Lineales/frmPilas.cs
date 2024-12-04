using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using EDDemo.Clases;

namespace EDDemo
{
    public partial class frmPilas : Form
    {
        private Pilas miPila;
        public frmPilas()
        {
            InitializeComponent();
            miPila = new Pilas();

        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            String input = txtpila.Text;

            if (!string.IsNullOrWhiteSpace(input))
            {
                miPila.Push(input);
                LbPila.Text = string.Join(", ", miPila.Count()); // Mostrar contenido
                txtpila.Clear(); // Limpiar el TextBox
                txtpila.Focus(); // Regresar el enfoque al TextBox
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un valor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string removedItem = miPila.Pop();

            if (removedItem != null)
            {
                LbPila.Text = string.Join(", ", miPila.GetAllItems()); // Mostrar contenido actualizado
            }
            else
            {
                MessageBox.Show("La pila está vacía.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LbPila_Click(object sender, EventArgs e)
        {

        }
    }
}
