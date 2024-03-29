﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ClienteIntellectus.Presentador
{
    public class PrincipalPresentador
    {
        Views.IPrincipal iprincipal;
        Views.Principal principal;

        PerfilServicios.PerfilServicesClient PerfilServicesClient;

        public PrincipalPresentador(Views.IPrincipal iprincipal, Views.Principal principal)
        {
            this.iprincipal = iprincipal;
            this.principal = principal;
        }

        public void Inicializar(ClienteIntellectus.Views.ControlUsuario.Principal.ControlUsuarioPrincipalPrincipal controlPrincipal)
        {
            try
            {
                PerfilServicesClient = new PerfilServicios.PerfilServicesClient();
            }
            catch (Exception ex)
            {
                iprincipal.MostrarMensajeUsuarioError(ex.Message);
            }

            try
            {
                PerfilServicios.UnicaRespuestaOfPerfilCompuestoqYdlCAL1 resultado = PerfilServicesClient.ConsultarPerfilCompuesto(iprincipal.IdCliente);

                if (!resultado.Error)
                {
                    ClienteIntellectus.Views.Principal.Perfil = resultado.Entidad;

                    using (var ms = new MemoryStream(ClienteIntellectus.Views.Principal.Perfil.Perfil.Avatar))
                    {
                        principal.pictureAvatar.Image = Image.FromStream(ms);
                        
                    }
                   
                   
                }
                else
                {
                    iprincipal.MostrarMensajeUsuarioError(resultado.Errores["Error"]);
                }
            }
            catch(Exception es)
            {
                iprincipal.MostrarMensajeUsuarioError(es.Message);
            }

            controlPrincipal.BringToFront();
        }
        
        public String GetNick()
        {
            return ClienteIntellectus.Views.Principal.Perfil.Usuario.Nick;
        }

        public void AjustarLabelAlTexto(System.Windows.Forms.Label label,String texto)
        {
            label.Text = texto;

            using (Graphics g = principal.CreateGraphics())
            {
                SizeF size = g.MeasureString(label.Text, label.Font, int.MaxValue);
                label.Width = (int)Math.Ceiling(size.Width+5);
                label.Text = label.Text;
            }
        }
    }
}
