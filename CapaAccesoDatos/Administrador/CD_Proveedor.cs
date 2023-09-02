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
    public class CD_Proveedor
    {
        OleDbDataReader DR;
        DataTable DT = new DataTable();
        OleDbCommand comando = new OleDbCommand();

        #region ATRIBUTOS
        private int idproveedor;
        private string nombre;
        private string direccion;
        private int idlocalidad;
        private int telefono;
        private string cuit;
        private string prueba;
        private string pruebatomas;

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

        public int Idlocalidad
        {
            get => idlocalidad;
            set { idlocalidad = value; }
        }

        public int Telefono
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

        public DataTable Mostrar()
        {
            string sSql;
            sSql = "Select * from Proveedor";
            clsEjecutarComando Ejecutar = new clsEjecutarComando();
            return Ejecutar.Ejecutar(sSql);
        }

        public void InsertarProveedor()
        {
            string sSql = "INSERT INTO Proveedor " +
               "(Nombre, Direccion, idLocalidad, Telefono, CUIT) " +
                "values" +
                " ('" + nombre + "','" + direccion + "'," + idlocalidad + "," + telefono +
                ",'" + cuit + "')";
            clsEjecutarComando Ejecutar = new clsEjecutarComando();
            Ejecutar.Ejecutar(sSql);
        }

        public void ModificarProveedor()
        {
            string sSql = "UPDATE Proveedor set " +
                "Nombre='" + nombre + "', Direccion='" + direccion + "', idLocalidad =" + idlocalidad +
                ", Telefono = " + telefono + ", Cuit = '" + cuit +
                "' WHERE idProveedor =" + idproveedor;
            clsEjecutarComando Ejecutar = new clsEjecutarComando();
            Ejecutar.Ejecutar(sSql);
        }

        public void EliminarProveedor()
        {
            string sSql = "DELETE FROM Proveedor WHERE idProveedor =" + idproveedor;
            clsEjecutarComando Ejecutar = new clsEjecutarComando();
            Ejecutar.Ejecutar(sSql);
        }

        #endregion
    }
}
