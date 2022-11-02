using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos.Loguin
{
    public class CD_BloqueoUser
    {

        clsEjecutarComando Ejecutar = new clsEjecutarComando();
        public void BloquearUser(int IdUser)
        {
            string SSql = "UPDATE Usuarios SET Usuarios.UsuarioDesactivado ='true' WHERE Usuarios.IdUsuario =" + IdUser;
            Ejecutar.EjecucionDirecta(SSql);
        }
    }
}
