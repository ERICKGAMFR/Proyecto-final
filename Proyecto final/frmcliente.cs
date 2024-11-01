﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_final.Utilidades;
using CapaEntidades;
using CapaNegocios;

namespace Proyecto_final
{
    public partial class frmcliente : Form
    {
        private CN_CLIENTE objcn_cliente = new CN_CLIENTE();
        public frmcliente()
        {
            InitializeComponent();
        }

        private void lbNU_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmcliente_Load(object sender, EventArgs e)
        {
           /* cboestatus.Items.Add(new optioncombo() { Valor = 1, Texto = "MIEMBRO" });
            cboestatus.Items.Add(new optioncombo() { Valor = 0, Texto = "VISITANTE" });
            cboestatus.DisplayMember = "Texto";
            cboestatus.ValueMember = "Valor";
            cboestatus.SelectedIndex = 0;*/

            List<ESTATUS> listatecomesesta = new CN_ESTATUS().Listar();

            foreach (ESTATUS item in listatecomesesta)
            {
                cboestatus.Items.Add(new optioncombo() { Valor = item.est_id, Texto = item.Est_descricion });
            }
            cboestatus.DisplayMember = "Texto";
            cboestatus.ValueMember = "Valor";
            cboestatus.SelectedIndex = 2;

            foreach (DataGridViewColumn columna in dgvcliente.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnseleccionar")
                {
                    cbobusqueda.Items.Add(new optioncombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cbobusqueda.DisplayMember = "Texto";
            cbobusqueda.ValueMember = "Valor";
            cbobusqueda.SelectedIndex = 0;

            List<CLIENTE> ptcliente = new CN_CLIENTE().Listar();

            foreach(CLIENTE item in ptcliente)
            {
                dgvcliente.Rows.Add(new object[] { "", item.Cli_Id,item.Cli_Nombre, item.Cli_Edad, item.Cli_Telefono, item.Cli_Telefono_Emer,
                    item.Cli_Domicilio, item.Cli_Colonia,
                    item.oestatus.est_id,item.oestatus.Est_descricion,
                    item.Fecha_Creacion, item.Fecha_termina });
            }

            /*
             foreach (USUARIO item in listausuario)
            {
                dgvusuario.Rows.Add(new object[] { "",item.Id_Usuario,item.Nombre_Usuario,item.Telefono,item.Correo,item.Clave,
                item.oROl.Id_Rol,item.oROl.Descripcion,
                item.Estado == true ? 1 : 0,
                item.Estado == true ? "Activo" : "No Activo",
                });
            }
            cborol.DisplayMember = "Texto";
            cborol.ValueMember = "Valor";
            cborol.SelectedIndex = 0;
                */

        }
        private void CargarClientes()
        {
            dgvcliente.Rows.Clear(); // Limpia el DataGridView antes de recargar
            List<CLIENTE> ptcliente = new CN_CLIENTE().Listar();

            foreach (CLIENTE item in ptcliente)
            {
                int rowIndex = dgvcliente.Rows.Add();
                DataGridViewRow row = dgvcliente.Rows[rowIndex];

                row.Cells["NombreC"].Value = item.Cli_Nombre;
                row.Cells["Edad"].Value = item.Cli_Edad;
                row.Cells["Telefono"].Value = item.Cli_Telefono;
                row.Cells["Telefono_emer"].Value = item.Cli_Telefono_Emer;
                row.Cells["Correo"].Value = item.Cli_Correo;
                row.Cells["Domicilio"].Value = item.Cli_Domicilio;
                row.Cells["Ciudad"].Value = item.Cli_Colonia;
                row.Cells["Estatus"].Value = item.oestatus.Est_descricion;
                row.Cells["FechaCreacion"].Value = item.Fecha_Creacion;
                row.Cells["FechaTermina"].Value = item.Fecha_termina;
                /*
                row.Cells["EstId"].Value = item.oestatus.est_id;
                row.Cells["Id_Cliente"].Value = item.oestatus.Est_descricion;
                row.Cells["FechaCreacion"].Value = item.Fecha_Creacion;
                row.Cells["FechaTermina"].Value = item.Fecha_termina;
                */
            }

        }


        private void ibtnsave_Click(object sender, EventArgs e)
        {
            CLIENTE objcliente = new CLIENTE()
            {
                Cli_Nombre = txtNombreCliente.Text,
                Cli_Edad = Convert.ToInt32(txtEdad.Text),
                Cli_Telefono = txtTelefono.Text,
                Cli_Telefono_Emer = txtTelefonoEmergencia.Text,
                Cli_Correo = txtCorreo.Text,
                Cli_Domicilio = txtdomicilio.Text,
                Cli_Colonia = txtCiudad.Text,
                oestatus = new ESTATUS() {est_id = Convert.ToInt32(((optioncombo)cboestatus.SelectedItem).Valor)}
            };



            string nombre = txtNombreCliente.Text;
            int edad = Convert.ToInt32(txtEdad.Text);
            string telefono = txtTelefono.Text;
            string telefono911 = txtTelefonoEmergencia.Text;
            string correo = txtCorreo.Text;
            string domicilio = txtdomicilio.Text;
            string colonia = txtCiudad.Text;
            int estadoId = Convert.ToInt32(((optioncombo)cboestatus.SelectedItem).Valor);

            if (objcn_cliente.sihay(nombre))
            {

                try
                {
                  objcn_cliente.actualiza(nombre, edad, telefono, telefono911, correo, domicilio, colonia, estadoId);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el usuario: " + ex.Message);
                }
            }
            else
            {
                try
                {
                    objcn_cliente.ingresarcln(nombre, edad, telefono, telefono911, correo, domicilio, colonia, estadoId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar el usuario: " + ex.Message);
                }
            }

            CargarClientes();
            Limpiar();
        }

        private void dgvusuario_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void dgvusuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvcliente.Columns[e.ColumnIndex].Name == "dgvbtnseleciona" && e.RowIndex >= 0)
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {

                    txtNombreCliente.Text = dgvcliente.Rows[indice].Cells["NombreC"].Value.ToString();
                    txtEdad.Text = dgvcliente.Rows[indice].Cells["Edad"].Value.ToString();
                    txtTelefono.Text = dgvcliente.Rows[indice].Cells["Telefono"].Value.ToString();
                    txtTelefonoEmergencia.Text = dgvcliente.Rows[indice].Cells["Telefono_emer"].Value.ToString();
                    txtCorreo.Text = dgvcliente.Rows[indice].Cells["Correo"].Value.ToString();
                    txtdomicilio.Text = dgvcliente.Rows[indice].Cells["Domicilio" ].Value.ToString();
                    txtCiudad.Text = dgvcliente.Rows[indice].Cells["Ciudad"].Value.ToString();
                    foreach (optioncombo oc in cboestatus.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvcliente.Rows[indice].Cells["Id_Cliente"].Value))
                        {
                            cboestatus.SelectedItem = oc;
                            break;
                        }
                    }

                }
            }

        }
        private void Limpiar()
        {
            txtNombreCliente.Text = " ";
            txtEdad.Text = " ";
            txtTelefono.Text = " ";
            txtTelefonoEmergencia.Text = " ";
            txtCorreo.Text = "";
            txtdomicilio.Text = " ";
            txtCiudad.Text = "";
            cboestatus.SelectedIndex = 0;
        }

        private void ibtneliminar_Click(object sender, EventArgs e)
        {
            string Cli_Nombre = txtNombreCliente.Text;
            objcn_cliente.byebye(Cli_Nombre);
            CargarClientes();
            Limpiar();
        }
    }
}