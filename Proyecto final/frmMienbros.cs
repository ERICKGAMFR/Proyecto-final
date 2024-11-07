using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocios;
using Proyecto_final.Utilidades;

namespace Proyecto_final
{
    public partial class frmMienbros : Form
    {
        private CN_CLIENTE objcn_cliente = new CN_CLIENTE();
        int id;
        public frmMienbros()
        {
            InitializeComponent();
        }

        private void frmMienbros_Load(object sender, EventArgs e)
        {

            foreach (DataGridViewColumn columna in dgvmiembro.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnseleccionar")
                {
                    cbobusqueda.Items.Add(new optioncombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cbobusqueda.DisplayMember = "Texto";
            cbobusqueda.ValueMember = "Valor";
            cbobusqueda.SelectedIndex = 0;

            List<CLIENTE> listmiembre = new CN_CLIENTE().LDM();

            foreach (CLIENTE item in listmiembre)
            {
                dgvmiembro.Rows.Add(new object[] { "",item.oestatus.Est_descricion, item.Cli_Id, item.Cli_Nombre,item.Cli_Telefono,item.Cli_Telefono_Emer,item.Cli_Correo,
                    item.Cli_Domicilio,item.Cli_Colonia,item.Fecha_Creacion,item.Fecha_termina});
            }
        }

        private void ibtnsave_Click(object sender, EventArgs e)
        {

            objcn_cliente.soyyootravez(id);
            CargarClientes();
        }

        private void ibtneliminar_Click(object sender, EventArgs e)
        {

        }

        private void dgvusuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvmiembro.Columns[e.ColumnIndex].Name == "dgvbtnseleciona" && e.RowIndex >= 0)
            {
                MessageBox.Show("1", "Título del mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    MessageBox.Show("2", "Título del mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtid.Text = dgvmiembro.Rows[indice].Cells["Id_Cliente"].Value.ToString();
                    txtnombre.Text = dgvmiembro.Rows[indice].Cells["NombreM"].Value.ToString();
                }
            }
        }




        private void CargarClientes()
        {


            dgvmiembro.Rows.Clear(); // Limpia el DataGridView antes de recargar
            List<CLIENTE> listmiembre = new CN_CLIENTE().LDM();

            foreach (CLIENTE item in listmiembre)
            {
                int rowIndex = dgvmiembro.Rows.Add();
                DataGridViewRow row = dgvmiembro.Rows[rowIndex];
                row.Cells["estatus"].Value = item.oestatus.Est_descricion;
                row.Cells["Id_Cliente"].Value = item.Cli_Id;
                row.Cells["NombreM"].Value = item.Cli_Nombre;
                row.Cells["Telefono"].Value = item.Cli_Telefono;
                row.Cells["Telefono_emer"].Value = item.Cli_Telefono_Emer;
                row.Cells["Correo"].Value = item.Cli_Correo;
                row.Cells["Domicilio"].Value = item.Cli_Domicilio;
                row.Cells["Ciudad"].Value = item.Cli_Colonia;
                row.Cells["FechaCreacion"].Value = item.Fecha_Creacion;
                row.Cells["FechaTermina"].Value = item.Fecha_termina;
            }

        }

        private void dgvmiembro_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var W = Properties.Resources.check.Width;
                var h = Properties.Resources.check.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - W) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check, new Rectangle(x, y, W, h));
                e.Handled = true;

            }

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
