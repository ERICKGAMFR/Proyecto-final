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
namespace Proyecto_final
{
    public partial class frmMienbros : Form
    {
        public frmMienbros()
        {
            InitializeComponent();
        }

        private void frmMienbros_Load(object sender, EventArgs e)
        {

            /*List<CLIENTE> ptcliente = new CN_CLIENTE().Listar();

            foreach (CLIENTE item in ptcliente)
            {
                dgvcliente.Rows.Add(new object[] { "", item.Cli_Id,item.Cli_Nombre, item.Cli_Edad, item.Cli_Telefono, item.Cli_Telefono_Emer,
                    item.Cli_Domicilio, item.Cli_Colonia,
                    item.oestatus.est_id,item.oestatus.Est_descricion,
                    item.Fecha_Creacion, item.Fecha_termina });
            }*/

            List<CLIENTE> listmiembre = new CN_CLIENTE().LDM();

            foreach(CLIENTE item in listmiembre)
            {
                dgvmiembro.Rows.Add(new object[] { "",item.oestatus.Est_descricion, item.Cli_Id, item.Cli_Nombre,item.Cli_Telefono,item.Cli_Telefono_Emer,item.Cli_Correo,
                    item.Cli_Domicilio,item.Cli_Colonia,item.Fecha_Creacion,item.Fecha_termina});
            }
        }

        private void ibtnsave_Click(object sender, EventArgs e)
        {

        }

        private void ibtneliminar_Click(object sender, EventArgs e)
        {

        }

        private void dgvusuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
