using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaComun;
using CapaAccesoDatos;
using CapaAccesoDatos.Loguin;

namespace CapaLogicaNegocio.Loguin
{
    public class CL_clsLogicaBloqueoUser
    {
        CD_BloqueoUser bloqueo = new CD_BloqueoUser();

        public void BlokUser(int IdUser)
        {
            bloqueo.BloquearUser(IdUser);
        }

    }
}
        
        