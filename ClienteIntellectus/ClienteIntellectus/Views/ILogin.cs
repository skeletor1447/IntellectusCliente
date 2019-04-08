using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClienteIntellectus.Views
{
    public interface ILogin
    {
        String Correo { get; set; }
        String Password { get; set; }
        long ID { get; set; }
        Socket ClienteSocket { get; set; }

        void MostrarMensajeUsuarioError(String mensaje);
    }
}
