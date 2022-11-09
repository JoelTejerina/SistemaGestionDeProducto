using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaComun;
using System.Data.OleDb;
using CapaAccesoDatos;

namespace CapaAccesoDatos.Administrador
{
    public class CD_Producto
    {
        OleDbDataReader DR;
        DataTable DT = new DataTable();
        OleDbCommand comando = new OleDbCommand();

        #region ATRIBUTOS
        private int idproducto;
        private string nombre;
        private string descripcion;
        private string stock;
        private double precio;
        private int idproveedor;
        private int cantidad;
        private DateTimeOffset fecha;
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

        public double Precio
        {
            get => precio;
            set { precio = value; }
        }

        public int Idproveedor
        {
            get => idproveedor;
            set { idproveedor = value; }
        }

        public int Cantidad
        {
            get => cantidad;
            set { cantidad = value; }
        }

        public DateTimeOffset Fecha
        {
            get => fecha;
            set { fecha = value; }
        }
        #endregion

        #region METODOS

        public DataTable Mostrar()
        {
            string sSql;
            sSql = "Select * from Stock";
            clsEjecutarComando Ejecutar = new clsEjecutarComando();
            return Ejecutar.Ejecutar(sSql);
        }

        public void InsertarProducto()
        {
            string sSql = "INSERT INTO Stock " +
               "(Nombre, Descripcion, Stock, Precio, idProveedor, Cantidad, Fecha) " +
                "values" +
                " ('" + nombre + "','" + descripcion + "'," + stock + "," + precio +
                "," + idproveedor + "," + cantidad + "," + Fecha + ")";
            clsEjecutarComando Ejecutar = new clsEjecutarComando();
            Ejecutar.Ejecutar(sSql);
        }

        public void ModificarProducto()
        {
            string sSql = "UPDATE Stock set " +
                "Nombre='" + nombre + "', Descripcion='" + descripcion + "', Stock =" + stock +
                ", Precio = " + precio + ", Idproveedor = '" + idproveedor + "', Cantidad = " + cantidad + 
                " WHERE idProducto =" + idproducto;
            clsEjecutarComando Ejecutar = new clsEjecutarComando();
            Ejecutar.Ejecutar(sSql);
        }

        public void EliminarProducto()
        {
            string sSql = "DELETE FROM Stock WHERE idProducto =" + Idproducto;
            clsEjecutarComando Ejecutar = new clsEjecutarComando();
            Ejecutar.Ejecutar(sSql);
        }

        #endregion
    }
}