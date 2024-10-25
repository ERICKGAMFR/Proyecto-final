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
using Proyecto_final.Utilidades;

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

       

        private void dgvusuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvusuario.Columns[e.ColumnIndex].Name == "dgvbtnseleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    //txtindice.Text = indice.ToString();
                    //txtid.Text = dgvusuario.Rows[indice].Cells["Id"].Value.ToString();
                    txtNombre.Text = dgvusuario.Rows[indice].Cells["NombreU"].Value.ToString();
                    txtphone.Text = dgvusuario.Rows[indice].Cells["NombreCompleto"].Value.ToString();
                    txtcorreo.Text = dgvusuario.Rows[indice].Cells["Correo"].Value.ToString();
                    txtclave.Text = dgvusuario.Rows[indice].Cells["Clave"].Value.ToString();


                    foreach (optioncombo oc in cborol.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvusuario.Rows[indice].Cells["id_rol"].Value.ToString()))
                        {
                            int indice_combo = cborol.Items.IndexOf(oc);
                            cborol.SelectedIndex = indice_combo;
                            break;
                        }
                    }

                    foreach (optioncombo oc in cboestado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvusuario.Rows[indice].Cells["EstadoValor"].Value.ToString()))
                        {
                            int indice_combo = cboestado.Items.IndexOf(oc);
                            cboestado.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                }
            }
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            cboestado.Items.Add(new optioncombo() { Valor = 1, Texto = "Activo" });
            cboestado.Items.Add(new optioncombo() { Valor = 0, Texto = "No Activo" });
            cboestado.DisplayMember = "Texto";
            cboestado.ValueMember = "Valor";
            cboestado.SelectedIndex = 0;
        }

        private void lbNU_Click(object sender, EventArgs e)
        {

        }

        private void lbtitulolistausuario_Click(object sender, EventArgs e)
        {

        }
    }
}


    

