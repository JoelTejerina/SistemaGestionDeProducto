using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using CapaComun;
using CapaDatos;

namespace CapaLogicaNegocio
{
    public class clsLogicaLoguin
    {
        private bool existe;
 
        clsConectarUsuario userLoguin = new clsConectarUsuario();
        clsPermisos Permisos = new clsPermisos();
        public bool LoginUser(string user, string pass)
        {
            if (pass != null)
            {   // si password carga como null, busca coincidancia de usuario y contraseña
                existe = userLoguin.Login(user, clsSeguridad.SHA256(pass));
                //existe = userLoguin.Login(user, pass);
                if (existe)
                {
                    Permisos.Permisos(UserCache.IdUsuario);
                }
            }
            else
            {   // si password == null
                existe = userLoguin.UserVerific(user);
                if (existe)
                {// si es true
                    Permisos.Permisos(UserCache.IdUsuario);
                }
                else
                {// si es false
                    // Codigo
                }
            }
           
            
            return existe;
        }
    }
}
