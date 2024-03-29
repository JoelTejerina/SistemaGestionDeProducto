﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaComun;
using CapaVistaUsuario.Administrador;


namespace CapaVistaUsuario
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblSesion.Text = "Sesion de: " + UserCache.Apellido + " " + UserCache.Nombres; 
        }

        private void cambioDePasswordToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Loguin.frmCambioPassword fAux = new Loguin.frmCambioPassword();
            fAux.MdiParent = this;
            fAux.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Esta seguro de CERRAR el sistema?",
                                "FINALIZAR SISTEMA",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Asterisk,
                                MessageBoxDefaultButton.Button2);

            if (resultado == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void gestiónDePersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonas fAux = new frmPersonas();
            fAux.MdiParent = this;
            fAux.Show();
        }

        private void gestionDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProducto fAux = new frmProducto();
            fAux.MdiParent = this;
            fAux.Show();
        }

        private void gestionDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProveedor fAux = new frmProveedor();
            fAux.MdiParent = this;
            fAux.Show();
        }
    }
}