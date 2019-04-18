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

        
    }
}
