using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Estructuras_No_Lineales;

namespace EDDemo
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pilasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPilas mPilas = new frmPilas();
            mPilas.MdiParent = this;
            mPilas.Show();
        }

        private void estructurasLinealesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void arbolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArboles mArboles = new frmArboles();
            mArboles.MdiParent = this;
            mArboles.Show();
        }

        private void colasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmColas mColas = new frmColas();
            mColas.MdiParent = this;
            mColas.Show();
        }

        private void listasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListas mListas = new frmListas();
            mListas.MdiParent = this;
            mListas.Show();
        }

        private void listasDoblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaDobles mListasDobles = new frmListaDobles();
            mListasDobles.MdiParent= this;
            mListasDobles.Show();

        }

        private void listasCircularesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaCircular mListaCircular = new frmListaCircular();
            mListaCircular.MdiParent = this;
            mListaCircular.Show();
        }

        private void listaCircularDobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaCircularDoble mListaCircularDoble = new frmListaCircularDoble();
            mListaCircularDoble.MdiParent = this;
            mListaCircularDoble.Show();
        }

        private void secuencialDeFibonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSecuencia mSecuencial=new frmSecuencia();
            mSecuencial.MdiParent = this;
            mSecuencial.Show();

        }

        private void busquedaBinariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBusqueda mBusqueda = new frmBusqueda();
            mBusqueda.MdiParent = this;
            mBusqueda.Show();
        }

        private void calculoDeExponenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalculo mCalculo = new frmCalculo();
            mCalculo.MdiParent = this;
            mCalculo.Show();
        }

        private void factorialDeUnNumeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFactorial mFactorial = new frmFactorial();
            mFactorial.MdiParent = this;
            mFactorial.Show();
        }

        private void sumasDeElementosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSuma mSuma = new frmSuma();
            mSuma.MdiParent = this;
            mSuma.Show();
        }

        private void torreHinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTorre mTorre = new frmTorre();
            mTorre.MdiParent = this;
            mTorre.Show();
        }

        private void shellsortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShellsort mShellsort = new frmShellsort();
            mShellsort.MdiParent = this;
            mShellsort.Show();
        }

        private void burbujaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBurbuja mBurbuja = new frmBurbuja();
            mBurbuja.MdiParent = this;
            mBurbuja.Show();
        }

        private void quicksortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuicksort mQuicksort = new frmQuicksort();
            mQuicksort.MdiParent = this;
            mQuicksort.Show();
        }

        private void radixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRadix mRadix = new frmRadix();
            mRadix.MdiParent = this;
            mRadix.Show();
        }

        private void búsquedaSecuencialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBusquedaSec mBusquedaSec = new frmBusquedaSec();
            mBusquedaSec.MdiParent = this;
            mBusquedaSec.Show();
        }

        private void búsquedaBinariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBusquedaBi mBusquedaBi = new frmBusquedaBi();
            mBusquedaBi.MdiParent = this;
            mBusquedaBi.Show();
        }
    }
}
