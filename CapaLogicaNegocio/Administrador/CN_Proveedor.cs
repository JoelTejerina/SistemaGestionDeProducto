using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using CapaAccesoDatos.Administrador;

namespace CapaLogicaNegocio.Administrador
{
    public class CN_Proveedor
    {
        private CD_Proveedor proveedor = new CD_Proveedor();

        #region ATRIBUTOS
        private int idproveedor;
        private string nombre;
        private string direccion;
        private string idlocalidad;
        private string telefono;
        private string cuit;

        #endregion

        #region PROPERTIES

        public int IdProveedor
        {
            get => idproveedor;
            set { idproveedor = value; }
        }

        public string Nombre
        {
            get => nombre;
            set { nombre = value; }
        }

        public string Direccion
        {
            get => direccion;
            set { direccion = value; }
        }

        public string Idlocalidad
        {
            get => idlocalidad;
            set { idlocalidad = value; }
        }

        public string Telefono
        {
            get => telefono;
            set { telefono = value; }
        }

        public string Cuit
        {
            get => cuit;
            set { cuit = value; }
        }
        #endregion

        #region METODOS

        public DataTable MostrarProveedor()
        {
            DataTable tabla = new DataTable();
            tabla = proveedor.Mostrar();
            return tabla;
        }

        public void InsertarProveedor()
        {
            PasarDatos();
            proveedor.InsertarProveedor();
        }

        public void ModificarProveedor()
        {
            PasarDatos();
            proveedor.ModificarProveedor();
        }

        public void EliminarProveedor()
        {
            proveedor.IdProveedor = idproveedor;
            proveedor.EliminarProveedor();
        }

        private void PasarDatos()
        {

            proveedor.IdProveedor = idproveedor;
            proveedor.Nombre = this.nombre;
            proveedor.Direccion = this.direccion;
            proveedor.Idlocalidad = Convert.ToInt32(this.Idlocalidad);
            proveedor.Telefono = Convert.ToInt32(this.telefono);
            proveedor.Cuit = this.cuit;
            //producto.Fecha = DateTime.Now.Date;
        }
        #endregion
    }
}
