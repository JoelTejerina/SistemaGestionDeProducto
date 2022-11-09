using System;
using System.Collections.Generic;
using System.Data;
using CapaAccesoDatos;
using CapaAccesoDatos.Administrador;

namespace CapaLogicaNegocio.Administrador
{
    public class CN_Producto
    {
        private CD_Producto producto = new CD_Producto();

        #region ATRIBUTOS
        private int idproducto;
        private string nombre;
        private string descripcion;
        private string stock;
        private string precio;
        private string idproveedor;
        private string cantidad;

        #endregion

        #region PROPERTIES

        public int Idproducto
        {
            get => idproducto;
            set { idproducto = value; }
        }

        public string Nombre
        {
            get => nombre;
            set { nombre = value; }
        }

        public string Descripcion
        {
            get => descripcion;
            set { descripcion = value; }
        }

        public string Stock
        {
            get => stock;
            set { stock = value; }
        }

        public string Precio
        {
            get => precio;
            set { precio = value; }
        }

        public string Idproveedor
        {
            get => idproveedor;
            set { idproveedor = value; }
        }

        public string Cantidad
        {
            get => cantidad;
            set { cantidad = value; }
        }

        #endregion

        #region METODOS

        public DataTable MostrarProducto()
        {
            DataTable tabla = new DataTable();
            tabla = producto.Mostrar();
            return tabla;
        }

        public void InsertarProducto()
        {
            PasarDatos();
            producto.InsertarProducto();
        }

        public void ModificarProducto()
        {
            PasarDatos();
            producto.ModificarProducto();
        }

        public void EliminarProducto()
        {
            producto.Idproducto = idproducto;
            producto.EliminarProducto();
        }

        private void PasarDatos()
        {

            producto.Idproducto = idproducto;
            producto.Nombre = this.nombre;
            producto.Descripcion = this.descripcion;
            if (this.precio == "")
            {
                producto.Precio = 0;
            }
            else
            {
                producto.Precio = Convert.ToDouble(this.precio);
            }
            if (this.cantidad != null)
            {
                producto.Cantidad = Convert.ToInt32(cantidad);
            }
            producto.Stock = this.Stock;
            producto.Idproveedor = Convert.ToInt32(this.Idproveedor);
        }
        #endregion
    }
}