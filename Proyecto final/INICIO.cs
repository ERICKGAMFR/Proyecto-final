using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using CapaEntidades;
//using CapaNegocios;
using FontAwesome.Sharp;

namespace Proyecto_final
{
    public partial class INICIO : Form
    {
       // private static USUARIO usuarioactual;
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;
        public INICIO()
        {
            InitializeComponent();
        }

        private void INICIO_Load(object sender, EventArgs e)
        {

        }

        private void Abrirformulario(IconMenuItem menu, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;

            }
            menu.BackColor = Color.Silver;
            MenuActivo = menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();

            }
            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.SteelBlue;

            Contenedor.Controls.Add(formulario);
            formulario.Show();
        }
    }
}
