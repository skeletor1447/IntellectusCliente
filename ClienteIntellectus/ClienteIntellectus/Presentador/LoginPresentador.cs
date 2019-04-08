using Newtonsoft.Json;
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

                IntellectusMensajes.LoginPeticion loginPeticion = new IntellectusMensajes.LoginPeticion();

                loginPeticion.VERSION = 1;
                loginPeticion.ID = (int)ilogin.ID;

                String mensaje = JsonConvert.SerializeObject(loginPeticion);

                IntellectusSocketIO.SocketIO.WriteInt(ilogin.ClienteSocket, (int)IntellectusMensajes.Paquete.LOGIN);
                byte[] buffer = Encoding.UTF8.GetBytes(mensaje);
                IntellectusSocketIO.SocketIO.WriteInt(ilogin.ClienteSocket, buffer.Length);
                IntellectusSocketIO.SocketIO.Write(ilogin.ClienteSocket,buffer.Length, buffer);


                int paquete = IntellectusSocketIO.SocketIO.ReadInt(ilogin.ClienteSocket);
                int longitud = IntellectusSocketIO.SocketIO.ReadInt(ilogin.ClienteSocket);
                String mensajeRespuesta = IntellectusSocketIO.SocketIO.ReadString(ilogin.ClienteSocket, longitud);

                IntellectusMensajes.LoginRespuesta loginRespuesta = JsonConvert.DeserializeObject<IntellectusMensajes.LoginRespuesta>(mensajeRespuesta);

                if(loginRespuesta != null)
                {
                    if(loginRespuesta.ESTADO == IntellectusMensajes.EstadoLogin.LOGUEADO)
                    {
                        return true;
                    }
                    else
                    {
                        ilogin.MostrarMensajeUsuarioError(loginRespuesta.Mensaje);
                        return false;
                    }
                }
                else
                {
                    return false;
                }
                
            }
            catch(Exception ex)
            {
                ilogin.MostrarMensajeUsuarioError(ex.Message);
            }
            return false;
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
