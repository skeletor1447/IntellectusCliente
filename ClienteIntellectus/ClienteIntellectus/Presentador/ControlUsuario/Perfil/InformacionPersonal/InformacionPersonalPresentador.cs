using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteIntellectus.Presentador.ControlUsuario.Perfil.InformacionPersonal
{
    public class InformacionPersonalPresentador
    {
        Views.ControlUsuario.Perfil.InformacionPersonal.IInformacionPersonal InformacionPersonal;

        public InformacionPersonalPresentador(Views.ControlUsuario.Perfil.InformacionPersonal.IInformacionPersonal informacionPersonal)
        {
            this.InformacionPersonal = informacionPersonal;
        }

        public void GuardarCambios()
        {
            try
            {
                PerfilServicios.PerfilServicesClient perfilServicesClient = new PerfilServicios.PerfilServicesClient();

                ClienteIntellectus.Views.Principal.Perfil.Perfil.NombreReal = InformacionPersonal.NombreReal;
                ClienteIntellectus.Views.Principal.Perfil.Perfil.Descripcion = InformacionPersonal.Descripcion;

                PerfilServicios.ActualizarRespuestaOfPerfilCompuestoqYdlCAL1 respuesta = perfilServicesClient.ActualizarPerfilCompuesto(ClienteIntellectus.Views.Principal.Perfil);

                if(!respuesta.Error)
                {
                    ClienteIntellectus.Views.Principal.Perfil = respuesta.Entidad;
                }
                else
                {
                    InformacionPersonal.MostrarMensajeUsuarioError(respuesta.Errores["Error"]);
                }


            }
            catch (Exception es)
            {
                InformacionPersonal.MostrarMensajeUsuarioError(es.Message);
            }
        }
    }
}
