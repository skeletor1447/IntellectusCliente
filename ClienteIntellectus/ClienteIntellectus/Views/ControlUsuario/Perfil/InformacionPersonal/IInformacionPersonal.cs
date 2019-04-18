using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteIntellectus.Views.ControlUsuario.Perfil.InformacionPersonal
{
    public interface IInformacionPersonal
    {
        String Correo { get; set; }
        String Nick { get; set; }
        String NombreReal { get; set; }
        String Descripcion { get; set; }
    }
}
