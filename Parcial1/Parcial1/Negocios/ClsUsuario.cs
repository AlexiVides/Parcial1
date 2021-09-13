using Parcial1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1.Negocios
{
    class ClsUsuario
    {
        public string acceso(Usuario usuario )
        {
            if(usuario.Nombre == "Alexi" && usuario.Contraseña == 123)
            {
                return "Inicio de sesión correcto, puede continuar con el proceso de compra";
            }
            else
            {
                return "Error debes ingresa el nombre y la contraseña correta";
            }
        }
    }
}
