using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteIntellectus.Views
{
    public interface IRegistro
    {
        String Correo { get; set; }
        String Nick { get; set; }
        String Password { get; set; }
        String ConfirmarPassword { get; set; }

        void MostrarMensajeUsuarioError(String mensaje);
    }
}
