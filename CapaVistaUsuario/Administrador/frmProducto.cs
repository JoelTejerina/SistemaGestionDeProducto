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
    public partial class frmProducto : Form
    {
        CN_Producto prod = new CN_Producto();

        public frmProducto()
        {
            InitializeComponent();
        }

        private void frmProducto_Load_1(object sender, EventArgs e)
        {
            //Acomodo el dataGridView a mi necesidad
            dgvProducto.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //Selecciona toda la fila
            dgvProducto.ReadOnly = true; //hace que la grilla no se pueda editar
            dgvProducto.MultiSelect = false; //desactiva la seleccion multiple
            dgvProducto.AllowUserToAddRows = false; //desactiva  la ultima fila 

            CN_LlenarCombos llenarCMB = new CN_LlenarCombos(cmbProveedor, "Proveedor", "idProveedor", "Direccion");
            MostrarProducto();
            dgvProducto.Select();
            CV_Utiles.BloquearControles(this);
            CV_Botonera.btnFormularios(this, btnCancelar);
        }

        private void dgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProducto.SelectedRows.Count > 0)
            {
                grpProvincia.Text = "Identificacion Stock Nº " + dgvProducto.Rows[dgvProducto.SelectedRows[0].Index].Cells["idProducto"].Value.ToString();
                txtNombre.Text = dgvProducto.Rows[dgvProducto.SelectedRows[0].Index].Cells["nombre"].Value.ToString();
                txtDescripcion.Text = dgvProducto.Rows[dgvProducto.SelectedRows[0].Index].Cells["descripcion"].Value.ToString();
                ckbStock.Checked = dgvProducto.Rows[dgvProducto.SelectedRows[0].Index].Cells["Stock"].Selected;
                cmbProveedor.Text = dgvProducto.Rows[dgvProducto.SelectedRows[0].Index].Cells["idProveedor"].Value.ToString();
                txtPrecio.Text = dgvProducto.Rows[dgvProducto.SelectedRows[0].Index].Cells["precio"].Value.ToString();
                txtCantidad.Text = dgvProducto.Rows[dgvProducto.SelectedRows[0].Index].Cells["Cantidad"].Value.ToString();
            }
        }

        #region BOTONES

        private void btnGuardaCambios_Click(object sender, EventArgs e)
        {
            try
            {
                PasarDatos(false);

                prod.InsertarProducto();
                MostrarProducto();

                CV_Botonera.btnFormularios(this, btnGuardaCambios);
                CV_Utiles.BloquearControles(this);
                dgvProducto.Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardaron los datos por: \n" + ex);
            }

            errorProvider1.Dispose();
            errorProvider2.Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CV_Utiles.DesbloquearControles(this);
            CV_Utiles.LimpiarControles(this);
            CV_Botonera.btnFormularios(this, btnAgregar);
            txtNombre.Select();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CV_Botonera.btnFormularios(this, btnCancelar);
            CV_Utiles.BloquearControles(this);
            CV_Utiles.LimpiarControles(this);
            dgvProducto.Select();
            errorProvider1.Dispose();
            errorProvider2.Dispose();
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            CV_Botonera.btnFormularios(this, btnModificar);
            CV_Utiles.DesbloquearControles(this);
            txtNombre.Select();
        }


        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("esta seguro de ELIMINAR defilitivamente el producto?",
                                                        "ELIMINAR PRODUCTO",
                                                        MessageBoxButtons.OKCancel,
                                                        MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
            {
                prod.Idproducto = Convert.ToInt32(dgvProducto.Rows[dgvProducto.SelectedRows[0].Index].Cells["idProducto"].Value.ToString());
                prod.EliminarProducto();
                MostrarProducto();
                dgvProducto.Select();
            }

        }

        #endregion


        #region Validaciones_Nivel_Formulario

        private void txtNombre_Validated(object sender, EventArgs e)
        {
            if (this.txtNombre.Text.Length == 0)
            {
                errorProvider2.Dispose();
                errorProvider1.SetError(this.txtNombre, "El campo Nombre no puede tener un valor vacio");
            }
            else
            {
                errorProvider1.Dispose();
                errorProvider1.SetError(this.txtNombre, "");
                errorProvider2.SetError(this.txtNombre, "CORRECTO");
            }
        }

        #endregion

        #region METODOS

        private void MostrarProducto()
        {
            CN_Producto Pers = new CN_Producto();
            dgvProducto.DataSource = Pers.MostrarProducto();
        }

        private void LlenarCombo(ComboBox CMB, string NombreTabla, string CampoID, string CampoDescrip, string Condicion = "")
        {
            /*  CN_LlenarCombos LC = new CN_LlenarCombos();

              LC.NomTabla = NombreTabla;
              LC.CampoId = CampoID;
              LC.CampoDescrip = CampoDescrip;
              LC.Condicion = Condicion;

              CMB.DataSource = LC.Cargar();
              CMB.DisplayMember = CampoDescrip;
              CMB.ValueMember = CampoID;*/
        }

        private void PasarDatos(bool origen)
        {
            if (origen == true)
            {
                prod.Idproducto = Convert.ToInt32(dgvProducto.Rows[dgvProducto.SelectedRows[0].Index].Cells["Id"].Value.ToString());
            }
            else
            {
                prod.Idproducto = 0;
            }
            prod.Nombre = txtNombre.Text;
            prod.Descripcion = txtDescripcion.Text;
            prod.Precio = txtPrecio.Text;
            prod.Cantidad = txtCantidad.Text;
            prod.Idproveedor = cmbProveedor.SelectedValue.ToString();
            //prod.Fecha = DateTime.Now.Date.ToString();
        }
    }
        #endregion
}