using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogicaNegocio.Administrador;
using CapaLogicaNegocio;

namespace CapaVistaUsuario.Administrador
{
    public partial class frmProveedor : Form
    {
        CN_Proveedor prove = new CN_Proveedor();

        public frmProveedor()
        {
            InitializeComponent();
        }

        private void frmProveedor_Load(object sender, EventArgs e)
        {
            //Acomodo el dataGridView a mi necesidad
            dgvProveedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //Selecciona toda la fila
            dgvProveedor.ReadOnly = true; //hace que la grilla no se pueda editar
            dgvProveedor.MultiSelect = false; //desactiva la seleccion multiple
            dgvProveedor.AllowUserToAddRows = false; //desactiva  la ultima fila 

            CN_LlenarCombos llenarCMB = new CN_LlenarCombos(cmbLocalidad, "Localidades", "idLocalidad", "Localidades");
            MostrarProveedor();
            dgvProveedor.Select();
            CV_Utiles.BloquearControles(this);
            CV_Botonera.btnFormularios(this, btnCancelar);
        }

        private void dgvProveedor_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProveedor.SelectedRows.Count > 0)
            {
                grpProveedor.Text = "Identificacion Proveedor Nº " + dgvProveedor.Rows[dgvProveedor.SelectedRows[0].Index].Cells["idProveedor"].Value.ToString();
                txtNombre.Text = dgvProveedor.Rows[dgvProveedor.SelectedRows[0].Index].Cells["Nombre"].Value.ToString();
                txtDireccion.Text = dgvProveedor.Rows[dgvProveedor.SelectedRows[0].Index].Cells["Direccion"].Value.ToString();
                cmbLocalidad.Text = dgvProveedor.Rows[dgvProveedor.SelectedRows[0].Index].Cells["idLocalidad"].Value.ToString();
                txtTelefono.Text = dgvProveedor.Rows[dgvProveedor.SelectedRows[0].Index].Cells["Telefono"].Value.ToString();
                txtCuit.Text = dgvProveedor.Rows[dgvProveedor.SelectedRows[0].Index].Cells["Cuit"].Value.ToString();
            }
        }

        #region BOTONES

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                PasarDatos(false);

                prove.InsertarProveedor();
                MostrarProveedor();

                CV_Botonera.btnFormularios(this, btnGuardaCambios);
                CV_Utiles.BloquearControles(this);
                dgvProveedor.Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardaron los datos por: \n" + ex);
            }

            //errorProvider1.Dispose();
            //errorProvider2.Dispose();
        }

        private void btnGuardaCambios_Click(object sender, EventArgs e)
        {
            try
            {
                PasarDatos(true);

                prove.ModificarProveedor();

                MostrarProveedor();
                CV_Botonera.btnFormularios(this, btnGuardaCambios);
                CV_Utiles.BloquearControles(this);
                dgvProveedor.Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardaron los datos por: \n" + ex);
            }
            //errorProvider1.Dispose();
            //errorProvider2.Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CV_Utiles.DesbloquearControles(this);
            CV_Utiles.LimpiarControles(this);
            CV_Botonera.btnFormularios(this, btnAgregar);
            txtNombre.Select();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CV_Botonera.btnFormularios(this, btnCancelar);
            CV_Utiles.BloquearControles(this);
            CV_Utiles.LimpiarControles(this);
            dgvProveedor.Select();
            //errorProvider1.Dispose();
            //errorProvider2.Dispose();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            CV_Botonera.btnFormularios(this, btnModificar);
            CV_Utiles.DesbloquearControles(this);
            txtNombre.Select();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("esta seguro de ELIMINAR defilitivamente el proveedor?",
                                                        "ELIMINAR PRODUCTO",
                                                        MessageBoxButtons.OKCancel,
                                                        MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
            {
                prove.IdProveedor = Convert.ToInt32(dgvProveedor.Rows[dgvProveedor.SelectedRows[0].Index].Cells["idProveedor"].Value.ToString());
                prove.EliminarProveedor();
                MostrarProveedor();
                dgvProveedor.Select();
            }
        }

        #endregion

        #region METODOS

        private void MostrarProveedor()
        {
            CN_Proveedor proveedor = new CN_Proveedor();
            dgvProveedor.DataSource = proveedor.MostrarProveedor();
        }

        private void PasarDatos(bool origen)
        {
            if (origen == true)
            {
                prove.IdProveedor = Convert.ToInt32(dgvProveedor.Rows[dgvProveedor.SelectedRows[0].Index].Cells["idProveedor"].Value.ToString());
            }
            else
            {
                prove.IdProveedor = 0;
            }
            prove.Nombre = txtNombre.Text;
            prove.Direccion = txtDireccion.Text;

            if (cmbLocalidad.SelectedItem == null)
            {
                prove.Idlocalidad = "0";
            }
            else
            {
                prove.Idlocalidad = cmbLocalidad.SelectedValue.ToString();
            }

            prove.Telefono = txtTelefono.Text;
            prove.Cuit = txtCuit.Text;
        }

        #endregion

        private void dgvProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProveedor.SelectedRows.Count > 0)
            {
                grpProveedor.Text = "Identificacion Proveedor Nº " + dgvProveedor.Rows[dgvProveedor.SelectedRows[0].Index].Cells["idProveedor"].Value.ToString();
                txtNombre.Text = dgvProveedor.Rows[dgvProveedor.SelectedRows[0].Index].Cells["Nombre"].Value.ToString();
                txtDireccion.Text = dgvProveedor.Rows[dgvProveedor.SelectedRows[0].Index].Cells["Direccion"].Value.ToString();
                cmbLocalidad.Text = dgvProveedor.Rows[dgvProveedor.SelectedRows[0].Index].Cells["idLocalidad"].Value.ToString();
                txtTelefono.Text = dgvProveedor.Rows[dgvProveedor.SelectedRows[0].Index].Cells["Telefono"].Value.ToString();
                txtCuit.Text = dgvProveedor.Rows[dgvProveedor.SelectedRows[0].Index].Cells["Cuit"].Value.ToString();
            }
        }
    }
}
