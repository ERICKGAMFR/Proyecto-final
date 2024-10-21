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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            INICIO form = new INICIO(/*ousuario*/);
            /*List<USUARIO> TEST = new CN_USUARIO().Listar();

            USUARIO ousuario = new CN_USUARIO().Listar().Where(u => u.Documento == txtdocumento.Text
            && u.Clave == txtclave.Text).FirstOrDefault();

            if (ousuario != null)
            {

                INICIO form = new INICIO(ousuario);

                form.Show();
                this.Hide();

                form.FormClosing += frm_closing;
            }
            else
            {
                MessageBox.Show("NO SE ENCONTRO EL USUARIO", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }*/
            form.Show();
            this.Hide();

            form.FormClosing += frm_closing;
        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txtclave.Clear();
            txtnomusuario.Clear();
            /*forma en la que el video enseña a vaciar los campos:
            txtdocumento.Text = "";
            txtclave.Text = "";*/

            this.Show();

        }
    }


}
