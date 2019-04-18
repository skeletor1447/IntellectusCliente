using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClienteIntellectus.Views
{
    public interface IPrincipal
    {
        Socket ClienteSocket { get; set; }
        PerfilServicios.PerfilCompuesto  Perfil { get; set; }
        long IdCliente { get; set; }
        void MostrarMensajeUsuarioError(String mensaje);
    }
}
