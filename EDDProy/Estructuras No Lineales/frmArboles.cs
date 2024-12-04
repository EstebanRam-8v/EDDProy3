using EDDemo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;


//using GraphVizWrapper;
//using GraphVizWrapper.Queries;
//using GraphVizWrapper.Commands;

//using csdot;
//using csdot.Attributes.DataTypes;

namespace EDDemo.Estructuras_No_Lineales
{
    public partial class frmArboles : Form
    {
        ArbolBusqueda miArbol;
        NodoBinario miRaiz;

        public frmArboles()
        {
            InitializeComponent();
            miArbol = new ArbolBusqueda();
            miRaiz = null;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();

            //Limpiamos la cadena donde se concatenan los nodos del arbol 
            miArbol.strArbol = "";

            //Se inserta el nodo con el dato capturado
            miArbol.InsertaNodo(int.Parse(txtDato.Text),
                                ref miRaiz);

            //Leer arbol completo y mostrarlo en caja de texto
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;
            
            txtDato.Text = "";

 
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            miArbol = null;
            miRaiz = null;
            miArbol = new ArbolBusqueda();
            txtArbol.Text  = "";
            txtDato.Text = "";
            lblRecorridoPreOrden.Text = "";
            lblRecorridoInOrden.Text = "";
            lblRecorridoPostOrden.Text = "";
        }

        private void btnGrafica_Click(object sender, EventArgs e)
        {
            String graphVizString;
            String strOrientacion = "";

            miRaiz = miArbol.RegresaRaiz();
            if (miRaiz == null)
            {
                MessageBox.Show("El arbol esta vacio");
                return;
            }

            if (rbOrientacion2.Checked)
            {
                strOrientacion = "rankdir=\"LR\";";
            }
            StringBuilder b = new StringBuilder();
            //rankdir="LR";
            b.Append("digraph G { " + strOrientacion + " node [shape=\"circle\"]; " + Environment.NewLine);
            b.Append(miArbol.ToDot(miRaiz));
            b.Append("}");
            graphVizString =  b.ToString();

            //graphVizString = @" digraph g{ label=""Graph""; labelloc=top;labeljust=left;}";
            //graphVizString = @"digraph Arbol{Raiz->60; 60->40. 60->90; 40->34; 40->50;}";
            Bitmap bm = FileDotEngine.Run(graphVizString);

            
            frmGrafica graf = new frmGrafica();
            graf.ActualizaGrafica(bm);
            graf.MdiParent = this.MdiParent;
            graf.Show();
        }


        private void btnRecorrer_Click(object sender, EventArgs e)
        {

            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPreOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoPreOrden.Text = "";
            miArbol.PreOrden(miRaiz);

            lblRecorridoPreOrden.Text = miArbol.strRecorrido;

            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPostOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoInOrden.Text = "";
            miArbol.InOrden(miRaiz);
            lblRecorridoInOrden.Text = miArbol.strRecorrido;

            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null) {
                lblRecorridoPostOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoPostOrden.Text = ""; 
            miArbol.PostOrden(miRaiz);
            lblRecorridoPostOrden.Text = miArbol.strRecorrido;
        }

        private void btnCrearArbol_Click(object sender, EventArgs e)
        {
            miArbol = null;
            miRaiz = null;
            miArbol = new ArbolBusqueda();
            txtArbol.Text = "";
            txtDato.Text = "";
             
            miArbol.strArbol = "";

            Random rnd = new Random();

            for (int nNodos =1; nNodos <= txtNodos.Value; nNodos++)
            {
                int Dato = rnd.Next(1, 100);
                miRaiz = miArbol.RegresaRaiz();

                miArbol.InsertaNodo(Dato, ref miRaiz);
            }

            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;

            txtDato.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();

            if (miRaiz == null)
            {
                MessageBox.Show("El árbol está vacío.");
                return;
            }

            int valor = int.Parse(txtBuscar.Text);

            bool encontrado = miArbol.BuscarNodo(valor, miRaiz);

            if (encontrado)
            {
                MessageBox.Show($"El nodo con valor {valor} fue encontrado.");
            }
            else
            {
                MessageBox.Show($"El nodo con valor {valor} no existe en el árbol.");
            }

            txtBuscar.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();

            if (miRaiz == null)
            {
                MessageBox.Show("El árbol está vacío.");
                return;
            }

            int valor = int.Parse(txtDatos.Text);

            miArbol.EliminarNodoPredecesor(valor, ref miRaiz);

            miArbol.strArbol = "";
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbolpo.Text = miArbol.strArbol;

            txtDato.Text = "";
            MessageBox.Show($"El nodo con valor {valor} ha sido eliminado usando predecesor.");
        }

        private void BtnPodar_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();
            if (miRaiz != null)
            {
                miArbol.Podar(miRaiz);  

                miArbol.MuestraArbolAcostado(1, miRaiz);
                txtArbolpo.Text = miArbol.strArbol;
                lblRecorridoPreOrden.Text = "";
                lblRecorridoInOrden.Text = "";
                lblRecorridoPostOrden.Text = "";

                MessageBox.Show("El árbol ha sido podado, solo la raíz permanece.");
            }
            else
            {
                MessageBox.Show("El árbol ya está vacío.");
            }
        }

        private void txtNodos_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAltitud_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();

            if (miRaiz == null)
            {
                MessageBox.Show("El árbol está vacío.");
                return;
            }

            string recorridoNiveles = miArbol.RecorrerPorNiveles(miRaiz);

            lblAmplitud.Text = recorridoNiveles;
        }

        private void btnAltura_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();

            if (miRaiz == null)
            {
                MessageBox.Show("El árbol está vacío.");
                return;
            }

            int altura = miArbol.ObtenerAltura(miRaiz);

            lblAltura.Text = "Altura del árbol: " + altura.ToString();
        }

        private void btnHojas_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();

            if (miRaiz == null)
            {
                MessageBox.Show("El árbol está vacío.");
                return;
            }

            int cantidadHojas = miArbol.ContarHojas(miRaiz);

            lblCant.Text = "Cantidad de hojas: " + cantidadHojas.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();

            if (miRaiz == null)
            {
                MessageBox.Show("El árbol está vacío.");
                return;
            }

            int cantidadNodos = miArbol.ContarNodos(miRaiz);

            lblnodos.Text = "Cantidad de nodos: " + cantidadNodos.ToString();
        }

        private void btnBinario_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();

            if (miRaiz == null)
            {
                MessageBox.Show("El árbol está vacío.");
                return;
            }

            bool esCompleto = miArbol.EsArbolBinarioCompleto(miRaiz);

            if (esCompleto)
            {
                lblBinario1.Text = "El árbol es binario completo.";
            }
            else
            {
                lblBinario1.Text = "El árbol no es binario completo.";
            }
        }

        private void btnLleno_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();

            if (miRaiz == null)
            {
                MessageBox.Show("El árbol está vacío.");
                return;
            }

            bool esLleno = miArbol.EsArbolBinarioLleno(miRaiz);

            if (esLleno)
            {
                lblLleno.Text = "El árbol es binario lleno.";
            }
            else
            {
                lblLleno.Text = "El árbol no es binario lleno.";
            }
        }

        private void btnSucesor_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();

            if (miRaiz == null)
            {
                MessageBox.Show("El árbol está vacío.");
                return;
            }

            int valor;
            if (int.TryParse(txtSucesor.Text, out valor))
            {
                // Llama a EliminarNodoSucesor para eliminar el nodo con el valor especificado
                miRaiz = miArbol.EliminarNodoSucesor(miRaiz, valor);

                // Muestra el árbol actualizado en el TextBox
                miArbol.strArbol = "";
                miArbol.MuestraArbolAcostado(1, miRaiz);
                txtArbolpo.Text = miArbol.strArbol;

                txtSucesor.Text = "";

                MessageBox.Show($"El nodo con valor {valor} ha sido eliminado usando el sucesor.", "Nodo Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ingrese un valor válido.");
            }
        }
    }
}

