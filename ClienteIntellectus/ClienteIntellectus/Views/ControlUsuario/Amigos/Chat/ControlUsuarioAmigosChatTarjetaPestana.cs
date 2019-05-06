using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteIntellectus.Views.ControlUsuario.Amigos.Chat
{
    public partial class ControlUsuarioAmigosChatTarjetaPestana : UserControl
    {
        PerfilServicios.PerfilCompuesto PerfilCompuesto;
        public ControlUsuarioAmigosChatTarjetaPestana(PerfilServicios.PerfilCompuesto PerfilCompuesto)
        {
            InitializeComponent();
            this.PerfilCompuesto = PerfilCompuesto;
        }

        private void ControlUsuarioAmigosChatTarjetaPestana_Click(object sender, EventArgs e)
        {
            Control control = this.Parent;
            Console.WriteLine(control.Name);
            control = control.Parent;
            Console.WriteLine(control.Name);

            control = control.Parent;
            Console.WriteLine(control.Name);
            control = control.Parent;
            Console.WriteLine(control.Name);

            control = control.Parent;
            Console.WriteLine(control.Name);
        }
    }
}
