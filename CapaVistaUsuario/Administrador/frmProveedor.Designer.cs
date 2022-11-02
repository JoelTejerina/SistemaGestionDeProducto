
namespace CapaVistaUsuario.Administrador
{
    partial class frmProveedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardaCambios = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grpProveedor = new System.Windows.Forms.GroupBox();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.Telefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbLocalidad = new System.Windows.Forms.ComboBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.dgvProveedor = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.grpProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.btnGuardaCambios);
            this.panel1.Location = new System.Drawing.Point(13, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 692);
            this.panel1.TabIndex = 10;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(15, 132);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(159, 35);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(15, 645);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(159, 35);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardaCambios
            // 
            this.btnGuardaCambios.Location = new System.Drawing.Point(15, 83);
            this.btnGuardaCambios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardaCambios.Name = "btnGuardaCambios";
            this.btnGuardaCambios.Size = new System.Drawing.Size(159, 35);
            this.btnGuardaCambios.TabIndex = 4;
            this.btnGuardaCambios.Text = "Guardar Cambios";
            this.btnGuardaCambios.UseVisualStyleBackColor = true;
            this.btnGuardaCambios.Click += new System.EventHandler(this.btnGuardaCambios_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(15, 131);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(159, 35);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(15, 38);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(159, 35);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(15, 83);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(159, 35);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(15, 38);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(159, 35);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // grpProveedor
            // 
            this.grpProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(1)))), ((int)(((byte)(41)))));
            this.grpProveedor.Controls.Add(this.txtDireccion);
            this.grpProveedor.Controls.Add(this.txtCuit);
            this.grpProveedor.Controls.Add(this.label1);
            this.grpProveedor.Controls.Add(this.label7);
            this.grpProveedor.Controls.Add(this.txtNombre);
            this.grpProveedor.Controls.Add(this.Telefono);
            this.grpProveedor.Controls.Add(this.txtTelefono);
            this.grpProveedor.Controls.Add(this.label5);
            this.grpProveedor.Controls.Add(this.label3);
            this.grpProveedor.Controls.Add(this.cmbLocalidad);
            this.grpProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpProveedor.ForeColor = System.Drawing.Color.White;
            this.grpProveedor.Location = new System.Drawing.Point(213, 24);
            this.grpProveedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpProveedor.Name = "grpProveedor";
            this.grpProveedor.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpProveedor.Size = new System.Drawing.Size(915, 288);
            this.grpProveedor.TabIndex = 8;
            this.grpProveedor.TabStop = false;
            this.grpProveedor.Text = "groupBox1";
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(493, 182);
            this.txtCuit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(277, 26);
            this.txtCuit.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(448, 182);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cuit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(448, 68);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Localidad";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(141, 65);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(277, 26);
            this.txtNombre.TabIndex = 6;
            // 
            // Telefono
            // 
            this.Telefono.AutoSize = true;
            this.Telefono.Location = new System.Drawing.Point(39, 185);
            this.Telefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(71, 20);
            this.Telefono.TabIndex = 11;
            this.Telefono.Text = "Telefono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(141, 182);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(277, 26);
            this.txtTelefono.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Direccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre";
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(568, 69);
            this.cmbLocalidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(277, 28);
            this.cmbLocalidad.TabIndex = 2;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(141, 124);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(277, 26);
            this.txtDireccion.TabIndex = 16;
            // 
            // dgvProveedor
            // 
            this.dgvProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedor.Location = new System.Drawing.Point(213, 320);
            this.dgvProveedor.Name = "dgvProveedor";
            this.dgvProveedor.RowHeadersWidth = 62;
            this.dgvProveedor.RowTemplate.Height = 28;
            this.dgvProveedor.Size = new System.Drawing.Size(915, 365);
            this.dgvProveedor.TabIndex = 11;
            this.dgvProveedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedor_CellContentClick);
            this.dgvProveedor.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedor_RowEnter);
            // 
            // frmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 701);
            this.Controls.Add(this.dgvProveedor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpProveedor);
            this.Name = "frmProveedor";
            this.Text = "frmProveedor";
            this.Load += new System.EventHandler(this.frmProveedor_Load);
            this.panel1.ResumeLayout(false);
            this.grpProveedor.ResumeLayout(false);
            this.grpProveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardaCambios;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox grpProveedor;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label Telefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbLocalidad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.DataGridView dgvProveedor;
    }
}