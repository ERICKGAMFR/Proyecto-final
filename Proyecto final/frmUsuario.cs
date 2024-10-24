using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final
{
    public partial class frmUsuario : Form
    {
        private static IconButton a = null;
        private static Form FormularioActivo = null;
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void Abrirformulariobtn(IconButton b, Form formulario)
        {
            if (a != null)
            {
                a.BackColor = Color.DarkGray;

            }
            //b.BackColor = Color.SlateGray;
            a = b;
            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            //formulario.BackColor = Color.SlateGray;

            conte_listau.Controls.Add(formulario);
            formulario.Show();
        }
    }
}
