using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogicaNegocio;
using CapaLogicaNegocio.Administrador;
using CapaComun;

namespace CapaVistaUsuario.Administrador
{
    public partial class frmGerencia : Form
    {
        CN_Gerencia Gerencia = new CN_Gerencia();

        public frmGerencia()
        {
            InitializeComponent();
        }

        private void frmGerencia_Load(object sender, EventArgs e)
        {
            dgvGerencia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGerencia.ReadOnly = true;
            dgvGerencia.MultiSelect = false;
            dgvGerencia.AllowUserToAddRows = false;

            MostrarPersonas();
            dgvGerencia.Select();
            CV_Utiles.BloquearControles(this);
            CV_Botonera.btnFormularios(this, btnCancelar);
        }

        private void dgvGerencia_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGerencia.SelectedRows.Count > 0)
            {
                grpGerencia.Text = "Identificacion Gerencia Nº " + dgvGerencia.Rows[dgvGerencia.SelectedRows[0].Index].Cells["IdGerencia"].Value.ToString();
                txtGerencia.Text = dgvGerencia.Rows[dgvGerencia.SelectedRows[0].Index].Cells["Gerencia"].Value.ToString();
            }
        }

        #region BOTONES

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                PasarDatos(false);

                Gerencia.InsertarGerencia();
                MostrarPersonas();

                CV_Botonera.btnFormularios(this, btnGuardaCambios);
                CV_Utiles.BloquearControles(this);
                dgvGerencia.Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardaron los datos por: \n" + ex);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CV_Utiles.DesbloquearControles(this);
            CV_Utiles.LimpiarControles(this);
            CV_Botonera.btnFormularios(this, btnAgregar);
            txtGerencia.Select();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CV_Botonera.btnFormularios(this, btnCancelar);
            CV_Utiles.BloquearControles(this);
            CV_Utiles.LimpiarControles(this);
            dgvGerencia.Select();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            CV_Botonera.btnFormularios(this, btnModificar);
            CV_Utiles.DesbloquearControles(this);
            txtGerencia.Select();
        }

        private void btnGuardaCambios_Click(object sender, EventArgs e)
        {
            try
            {
                PasarDatos(true);

                Gerencia.ModificarGerencia();

                MostrarPersonas();
                CV_Botonera.btnFormularios(this, btnGuardaCambios);
                CV_Utiles.BloquearControles(this);
                dgvGerencia.Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardaron los datos por: \n" + ex);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("esta seguro de ELIMINAR defilitivamente a la persona?",
                                                        "ELIMINAR PERSONA",
                                                        MessageBoxButtons.OKCancel,
                                                        MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
            {
                Gerencia.IdGenencia = Convert.ToInt32(dgvGerencia.Rows[dgvGerencia.SelectedRows[0].Index].Cells["IdGerencia"].Value.ToString());
                Gerencia.EliminarGerencia();
                MostrarPersonas();
                dgvGerencia.Select();
            }
        }

        #endregion

        #region METODOS

        private void MostrarPersonas()
        {
            CN_Personas Pers = new CN_Personas();
            dgvGerencia.DataSource = Pers.MostrarPersona();
        }


        private void PasarDatos(bool origen)
        {
            if (origen == true)
            {
                Gerencia.IdGenencia = Convert.ToInt32(dgvGerencia.Rows[dgvGerencia.SelectedRows[0].Index].Cells["IdGerencia"].Value.ToString());
            }
            else
            {
                Gerencia.IdGenencia = 0;
            }
            Gerencia.Nombre = txtGerencia.Text;
        }
        #endregion

        private void dgvGerencia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGerencia.SelectedRows.Count > 0)
            {
                grpGerencia.Text = "Identificacion Gerencia Nº " + dgvGerencia.Rows[dgvGerencia.SelectedRows[0].Index].Cells["IdGerencia"].Value.ToString();
                txtGerencia.Text = dgvGerencia.Rows[dgvGerencia.SelectedRows[0].Index].Cells["Gerencia"].Value.ToString();
            }
        }
    }
}
