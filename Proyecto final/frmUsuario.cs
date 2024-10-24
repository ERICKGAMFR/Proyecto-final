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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iconButton5_Click(object sender, EventArgs e)
        {

        }
    }
}
