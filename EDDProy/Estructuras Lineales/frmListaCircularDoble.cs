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
    public partial class frmListaCircularDoble : Form
    {
        private ListaCircularDoble lista; // Instancia de la lista circular doblemente enlazada

        public frmListaCircularDoble()
        {
            InitializeComponent();
            lista = new ListaCircularDoble(); // Inicializamos la lista
        }

        private void BtnCrearDo_Click(object sender, EventArgs e)
        {
            lista = new ListaCircularDoble(); // Reiniciamos la lista
            txtListaMos.Clear(); // Limpiamos el campo de visualización
            MessageBox.Show("Lista circular doblemente enlazada creada.", "Éxito");
        }

        private void BtnInsertarDo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtIngresar.Text))
            {
                int numero;
                if (int.TryParse(txtIngresar.Text, out numero))
                {
                    lista.Insertar(numero);
                    txtIngresar.Clear();
                    MessageBox.Show("Número insertado correctamente.", "Éxito");
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un número válido.", "Error");
                }
            }
            else
            {
                MessageBox.Show("El campo no puede estar vacío.", "Error");
            }
        }

        private void BtnVerlist_Click(object sender, EventArgs e)
        {
            txtListaMos.Text = lista.Mostrar(); // Mostrar la lista en el TextBox
        }

        private void BtnBuscarDo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtIngresar.Text))
            {
                int numero;
                if (int.TryParse(txtIngresar.Text, out numero))
                {
                    bool encontrado = lista.Buscar(numero);
                    if (encontrado)
                    {
                        MessageBox.Show($"El número {numero} fue encontrado en la lista.", "Éxito");
                    }
                    else
                    {
                        MessageBox.Show($"El número {numero} no está en la lista.", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un número válido.", "Error");
                }
            }
            else
            {
                MessageBox.Show("El campo no puede estar vacío.", "Error");
            }
        }

        private void BtnEliminarDo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtIngresar.Text))
            {
                int numero;
                if (int.TryParse(txtIngresar.Text, out numero))
                {
                    bool eliminado = lista.Eliminar(numero);
                    if (eliminado)
                    {
                        MessageBox.Show($"El número {numero} fue eliminado de la lista.", "Éxito");
                    }
                    else
                    {
                        MessageBox.Show($"El número {numero} no está en la lista.", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un número válido.", "Error");
                }
            }
            else
            {
                MessageBox.Show("El campo no puede estar vacío.", "Error");
            }
        }
    }
}