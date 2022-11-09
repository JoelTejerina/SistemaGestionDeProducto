using System;
using System.Collections.Generic;
using System.Data;
using CapaAccesoDatos;
using CapaAccesoDatos.Administrador;

namespace CapaLogicaNegocio.Administrador
{
    public class CN_Gerencia
    {
        private CD_Gerencia gerencia = new CD_Gerencia();

        #region ATRIBUTOS
        private int idgerencia;
        private string nombre;
        #endregion

        #region PROPERTIES

        public int IdGenencia
        {
            get => idgerencia;
            set { idgerencia = value; }
        }

        public string Nombre
        {
            get => nombre;
            set { nombre = value; }
        }
        #endregion

        #region METODOS

        public DataTable MostrarPersona()
        {
            DataTable tabla = new DataTable();
            tabla = gerencia.Mostrar();
            return tabla;
        }

        public void InsertarGerencia()
        {
            PasarDatos();
            gerencia.InsertarGerencia();
        }

        public void ModificarGerencia()
        {
            PasarDatos();
            gerencia.ModificarGerencia();
        }

        public void EliminarGerencia()
        {
            gerencia.IdGenencia = idgerencia;
            gerencia.EliminarGerencia();
        }

        private void PasarDatos()
        {
            gerencia.IdGenencia = idgerencia;
            gerencia.Nombre = this.nombre;
        }

        #endregion
    }
}
