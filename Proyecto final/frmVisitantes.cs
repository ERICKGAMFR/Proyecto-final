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
    public partial class frmregistar_Visitantes : Form
    {
        public frmregistar_Visitantes()
        {
            InitializeComponent();
        }

        private void lbbuscar_Click(object sender, EventArgs e)
        {

        }

        private void frmregistar_Visitantes_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvvisita.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnseleccionar")
                {
                    cbobusqueda.Items.Add(new optioncombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cbobusqueda.DisplayMember = "Texto";
            cbobusqueda.ValueMember = "Valor";
            cbobusqueda.SelectedIndex = 0;

            List<CLIENTE> listvisita = new CN_CLIENTE().LDV();

            foreach (CLIENTE item in listvisita)
            {
                dgvvisita.Rows.Add(new object[] { "",item.oestatus.Est_descricion, item.Cli_Id, item.Cli_Nombre,item.Cli_Telefono,item.Cli_Telefono_Emer,item.Cli_Correo,
                    item.Cli_Domicilio,item.Cli_Colonia,item.Fecha_Creacion,item.Fecha_termina});
            }
        }
    }
}
