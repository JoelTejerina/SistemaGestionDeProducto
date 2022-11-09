using System.Data;
using System.Data.OleDb;

namespace CapaAccesoDatos
{
    public class CD_LlenarCombos : clsConexion 
    {

        #region ATRIBUTOS
        private string tabla;
        private string campoid;
        private string campodescrip;
        private string condicion;
        #endregion

        #region PROPERTIES
        public string Tabla
        {
            set { tabla = value; }
        }
        public string CampoId
        {
            set { campoid = value; }
        }
        public string CampoDescrip
        {
            set { campodescrip = value; }
        }
        public string Condicion
        {
            set { condicion = value; }
        }
        #endregion


        public DataTable CargarCMB()
        {
            string sSql;
            if (condicion == "")
            {
                sSql = "SELECT " + campoid + ", " + campodescrip + " FROM " + tabla + " ORDER BY " + campodescrip;
            }
            else
            {
                sSql = "SELECT " + campoid + ", " + campodescrip + " FROM " + tabla + " Where  " + condicion + " ORDER BY " + campodescrip;
            }

            clsEjecutarComando Ejecutar = new clsEjecutarComando();
            return Ejecutar.Ejecutar(sSql);
        }
    }
}

