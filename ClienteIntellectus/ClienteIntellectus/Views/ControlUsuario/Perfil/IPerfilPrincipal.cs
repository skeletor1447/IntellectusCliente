using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteIntellectus.Views.ControlUsuario.Perfil
{
    public interface IPerfilPrincipal
    {
        Image Avatar { get; set; } 
        Image ImagenInstitucion { get; set; }
        String Nick { get; set; }
        String Institucion { get; set; }
        String Descripcion { get; set; }
        PerfilServicios.PerfilCompuesto Perfil { get; set; }
    }
}
