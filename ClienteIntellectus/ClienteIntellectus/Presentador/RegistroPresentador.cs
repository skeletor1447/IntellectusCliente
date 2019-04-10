using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteIntellectus.Presentador
{
    public class RegistroPresentador
    {
        Views.IRegistro iregistro;
        public RegistroPresentador(Views.IRegistro iregistro)
        {
            this.iregistro = iregistro;
        }

        public void RegistrarUsuario()
        {
            try
            {
                UsuarioServicios.UsuarioServicesClient usuarioServicesClient = new UsuarioServicios.UsuarioServicesClient();
                UsuarioServicios.InsertarRespuesta respuesta = usuarioServicesClient.Registrar(new UsuarioServicios.Usuario() { Correo = iregistro.Correo, ID = -1, Nick = iregistro.Nick, Password = iregistro.Password });

                if (!respuesta.Error)
                {
                    iregistro.MostrarMensajeUsuarioError("Usuario registrado correctamente");
                    (iregistro as Views.Registro).Hide();
                    (iregistro as Views.Registro).padre.Show();

                }
                else
                {
                    iregistro.MostrarMensajeUsuarioError(respuesta.Errores["Error"]);
                }
            }
            catch(Exception ex)
            {
                iregistro.MostrarMensajeUsuarioError(ex.Message);
            }
        }
        public bool ValidarRegistro()
        {
            bool valido = false;

            if (iregistro.ConfirmarPassword.Trim() != iregistro.Password.Trim())
            {
                iregistro.MostrarMensajeUsuarioError("Los password no coinciden.");
            }
            else if (String.IsNullOrEmpty(iregistro.Correo))
            {
                iregistro.MostrarMensajeUsuarioError("El campo Correo está vacío.");
            }
            else if (String.IsNullOrEmpty(iregistro.Nick))
            {
                iregistro.MostrarMensajeUsuarioError("El campo Nick está vacío.");
            }
            else if (String.IsNullOrEmpty(iregistro.Password))
            {
                iregistro.MostrarMensajeUsuarioError("El campo Password está vacío.");
            }
            else
                return true;
            return valido;
        }
    }
}
