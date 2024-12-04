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
    public partial class frmListaDobles : Form
    {

        private LinkedList<string> miListaDoblementeEnlazada;

        public frmListaDobles()
        {
            InitializeComponent();

            miListaDoblementeEnlazada = new LinkedList<string>();
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            miListaDoblementeEnlazada.Clear();
            txtMostrar.Text = "Lista generada y vacía.";
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            string input = txtLisDo.Text;
            if (!string.IsNullOrWhiteSpace(input))
            {
                miListaDoblementeEnlazada.AddLast(input);
                ActualizarContenido();
                txtLisDo.Clear();
                txtLisDo.Focus();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un valor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnVerlista_Click(object sender, EventArgs e)
        {
            ActualizarContenido();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string input = txtLisDo.Text;
            if (miListaDoblementeEnlazada.Contains(input))
            {
                MessageBox.Show($"El elemento '{input}' se encuentra en la lista.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"El elemento '{input}' no se encuentra en la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            string input = txtLisDo.Text;
            string nuevoValor = txtNuevoDa.Text;

            if (!string.IsNullOrWhiteSpace(input) && !string.IsNullOrWhiteSpace(nuevoValor))
            {
                var nodo = miListaDoblementeEnlazada.Find(input);
                if (nodo != null)
                {
                    nodo.Value = nuevoValor;
                    ActualizarContenido();
                    txtLisDo.Clear();
                    txtNuevoDa.Clear();
                }
                else
                {
                    MessageBox.Show("El elemento no se encuentra en la lista para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa valores para ambos campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnOrdenar_Click(object sender, EventArgs e)
        {
            var listaOrdenada = miListaDoblementeEnlazada.OrderBy(x => x).ToList();
            miListaDoblementeEnlazada = new LinkedList<string>(listaOrdenada);
            ActualizarContenido();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string input = txtLisDo.Text;
            if (!string.IsNullOrWhiteSpace(input))
            {
                if (miListaDoblementeEnlazada.Remove(input))
                {
                    MessageBox.Show($"El elemento '{input}' fue eliminado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarContenido();
                }
                else
                {
                    MessageBox.Show($"El elemento '{input}' no se encuentra en la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un valor para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ActualizarContenido()
        {
            txtMostrar.Text = string.Join(", ", miListaDoblementeEnlazada);
        }
    }
}
