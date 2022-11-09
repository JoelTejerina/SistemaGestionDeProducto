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
            {
                existe = userLoguin.Login(user, clsSeguridad.SHA256(pass));
                if (existe)
                {
                    Permisos.Permisos(UserCache.IdUsuario);
                }
            }
            else
            { 
                existe = userLoguin.UserVerific(user);
                if (existe)
                {
                    Permisos.Permisos(UserCache.IdUsuario);
                }
            }
           
            
            return existe;
        }
    }
}
