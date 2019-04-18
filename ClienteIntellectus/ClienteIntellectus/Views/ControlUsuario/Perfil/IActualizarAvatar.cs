

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteIntellectus.Views.ControlUsuario.Perfil
{
    public interface IActualizarAvatar
    {
        Image Avatar { get; set; }
        
        void MostrarMensajeUsuarioError(String mensaje);
    }
}
