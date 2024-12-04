﻿using System;
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
    }
}