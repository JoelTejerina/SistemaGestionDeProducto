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
    public class CD_Gerencia
    {
        OleDbDataReader DR;
        DataTable DT = new DataTable();
        OleDbCommand comando = new OleDbCommand();

        #region ATRIBUTOS
        private int idgerencia;
        private string nombre;
        #endregion

        #region PROPERTIES

        public int IdGenencia
        {
            get => idgerencia; //Expresion Lambda (Se suprime el Return y las llaves)
            set { idgerencia = value; }
        }

        public string Nombre
        {
            get => nombre;
            set { nombre = value; }
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

        public void InsertarGerencia()
        {
            string sSql = "INSERT INTO Gerencia " +
               "(Gerencia) " +
                "values" +
                " ('" + nombre + ")";
            clsEjecutarComando Ejecutar = new clsEjecutarComando();
            Ejecutar.Ejecutar(sSql);
        }

        public void ModificarGerencia()
        {
            string sSql = "UPDATE Gerencia set " +
                "Nombre='" + nombre + "'" +
                " WHERE idGerencia =" + idgerencia;
            clsEjecutarComando Ejecutar = new clsEjecutarComando();
            Ejecutar.Ejecutar(sSql);
        }

        public void EliminarGerencia()
        {
            string sSql = "DELETE FROM Gerencia WHERE idGerencia =" + idgerencia;
            clsEjecutarComando Ejecutar = new clsEjecutarComando();
            Ejecutar.Ejecutar(sSql);
        }

        #endregion
    }
}
