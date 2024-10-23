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
        private static IconButton a = null;
        private static Form FormularioActivo = null;
        public INICIO()
        {
            /*if (objUSUARIO == null) usuarioactual = new USUARIO() { NombreCompleto = "ADMIN PREDEFINIDO", id_usuario = 0};
            else usuarioactual = objUSUARIO;*/
            InitializeComponent();
        }

        private void INICIO_Load(object sender, EventArgs e)
        {

        }

        private void Abrirformulario (IconMenuItem menu, Form formulario)
        {
            
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.DarkGray;

            }
            menu.BackColor = Color.SlateGray;
            MenuActivo = menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();

            }
            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.SlateGray;

            Contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void Abrirformulariobtn(IconButton b, Form formulario)
        {
            if (a != null)
            {
                a.BackColor = Color.DarkGray;

            }
            b.BackColor = Color.SlateGray;
            a = b;
            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.SlateGray;

            Contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuusuarios_Click(object sender, EventArgs e)
        {
            Abrirformulario(menuusuarios, new frmUsuario());
        }

        private void submenuregitarventa_Click(object sender, EventArgs e)
        {
            Abrirformulario(menuventas, new frmVenta());
        }

        private void submenuverdetalleventa_Click(object sender, EventArgs e)
        {
            Abrirformulario(menuventas, new frmDetalleVenta());
        }

        private void menuvisitas_Click(object sender, EventArgs e)
        {
            Abrirformulario(menuvisitas, new  frmregistar_Visitantes());
        }

        private void menumiembros_Click(object sender, EventArgs e)
        {
            Abrirformulario(menumiembros, new frmMienbros());
        }

        private void submenucategoria_Click(object sender, EventArgs e)
        {
            Abrirformulario(menuinventario, new frmcategoria());
        }

        private void submenuproducto_Click(object sender, EventArgs e)
        {
            Abrirformulario(menuinventario, new frmProducto());
        }

        private void menureportes_Click(object sender, EventArgs e)
        {
            Abrirformulario(menureportes, new frmReportes());
        }

        private void btnusuario_Click(object sender, EventArgs e)
        {
            Abrirformulariobtn(btnusuario, new frmUsuario());
        }
    }
}
