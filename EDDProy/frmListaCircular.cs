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
    public partial class frmListaCircular : Form
    {

        private EDDemo.ListaCircular listaCircular; 
        public frmListaCircular()
        {
            InitializeComponent();
            listaCircular = new EDDemo.ListaCircular();

        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            string dato = txtDaCircular.Text;
            if (!string.IsNullOrWhiteSpace(dato))
            {
                listaCircular.Insertar(dato);
                MessageBox.Show("Elemento insertado correctamente.");
            }
            else
            {
                MessageBox.Show("Ingrese un dato válido.");
            }
        }

        private void BtnInser_Click(object sender, EventArgs e)
        {
            string lista = listaCircular.MostrarLista();
            txtModi.Text = lista;
        }

        private void BtnVer_Click(object sender, EventArgs e)
        {
            string lista = listaCircular.MostrarLista();
            txtModi.Text = lista;
        }

        private void BtnBus_Click(object sender, EventArgs e)
        {
            string dato = txtDaCircular.Text;
            bool encontrado = listaCircular.Buscar(dato);
            MessageBox.Show(encontrado ? "Elemento encontrado." : "Elemento no encontrado.");

        }

        private void BtnModi_Click(object sender, EventArgs e)
        {
            string datoAntiguo = txtDaCircular.Text;
            string nuevoDato = txtModi.Text; // Asumiendo que txtModi es el textbox para el nuevo dato.
            bool modificado = listaCircular.Modificar(datoAntiguo, nuevoDato);
            MessageBox.Show(modificado ? "Elemento modificado correctamente." : "Elemento no encontrado para modificar.");
        }

        private void BtnElim_Click(object sender, EventArgs e)
        {
            string dato = txtDaCircular.Text;
            bool eliminado = listaCircular.Eliminar(dato);
            MessageBox.Show(eliminado ? "Elemento eliminado correctamente." : "Elemento no encontrado para eliminar.");
        }
    }
}
