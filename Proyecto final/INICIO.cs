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
            Con_botonee.BackColor = Color.SlateGray;
            formulario.Show();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
        private void btnusuario_Click(object sender, EventArgs e)
        {
            Abrirformulariobtn(btnusuario, new frmUsuario());
        }
    }
}
