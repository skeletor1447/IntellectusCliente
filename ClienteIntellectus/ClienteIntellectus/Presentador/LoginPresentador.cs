using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClienteIntellectus.Presentador
{
    public class LoginPresentador
    {
        Views.ILogin ilogin;

        public LoginPresentador(Views.ILogin ilogin)
        {
            this.ilogin = ilogin;
        }

        public bool ConectarseAlServidor()
        {
            try
            {
                ilogin.ClienteSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse("192.168.1.71"), 8001);

                ilogin.ClienteSocket.Connect(iPEndPoint);
            }
            catch
            {

            }

        }

        public bool ValidarUsuario()
        {
            try
            {
                UsuarioServicios.UsuarioServicesClient usuarioServicesClient = new UsuarioServicios.UsuarioServicesClient();

                UsuarioServicios.UnicaRespuestaOfUsuarioqYdlCAL1 respuesta = usuarioServicesClient.ConsultarPorCorreoYPassword(ilogin.Correo, ilogin.Password);

                if(!respuesta.Error)
                {
                    ilogin.ID = respuesta.Entidad.ID;

                    return true;
                }
                else
                {
                    foreach(var error in respuesta.Errores)
                    {
                        ilogin.MostrarMensajeUsuarioError(error.Value);
                        break;
                    }
                }
            }
            catch(Exception ex)
            {
                ilogin.MostrarMensajeUsuarioError(ex.Message);
            }

            return false;
        }
    }
}
