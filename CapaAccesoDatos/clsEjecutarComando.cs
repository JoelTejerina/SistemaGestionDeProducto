using System.Data;
using System.Data.OleDb;

namespace CapaAccesoDatos
{
    class clsEjecutarComando : clsConexion
    {
        OleDbDataReader DR;
        private DataTable DT = new DataTable();

        public DataTable Ejecutar(string sSql)
        {   
            using (OleDbConnection CNN = GetConexion())
            {
                CNN.Open();
                using (OleDbCommand comando = new OleDbCommand(sSql, CNN))
                {
                    DR = comando.ExecuteReader();
                    DT.Load(DR);
                    return DT;
                }
            }
        }
        public void EjecucionDirecta(string sSql)
        {
            using (OleDbConnection CNN = GetConexion())
            {
                CNN.Open();
                using (OleDbCommand comando = new OleDbCommand(sSql, CNN))
                {
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
