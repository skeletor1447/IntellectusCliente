using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteIntellectus.Presentador.ControlUsuario.Perfil
{
    public class PerfilPrincipalPresentador
    {
        Views.ControlUsuario.Perfil.IPerfilPrincipal iPerfilPrincipal;

        public PerfilPrincipalPresentador(Views.ControlUsuario.Perfil.IPerfilPrincipal iPerfilPrincipal)
        {
            this.iPerfilPrincipal = iPerfilPrincipal;
        }
    }
}
