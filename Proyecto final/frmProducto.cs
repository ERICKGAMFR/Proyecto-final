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
using ClosedXML.Excel;

namespace Proyecto_final
{
    public partial class frmProducto : Form
    {
        private CN_PRUDUCTOS objcn_produc = new CN_PRUDUCTOS();

        private bool a;
        public frmProducto()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvprod_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void frmProducto_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvprod.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnseleccionar")
                {
                    cbobusqueda.Items.Add(new optioncombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cbobusqueda.DisplayMember = "Texto";
            cbobusqueda.ValueMember = "Valor";
            cbobusqueda.SelectedIndex = 0;


            List<PRODUCTO> listainv = new CN_PRUDUCTOS().Listar();

            foreach (PRODUCTO item in listainv)
            {
                dgvprod.Rows.Add(new object[] { "", item.Prod_Id, item.Prod_Nombre, item.Prod_Cantidad, item.Prod_Precio, item.Prod_FechaCad, item.Fecha_Creacion});
            }

        }

        private void ibtnsave_Click(object sender, EventArgs e)
        {
            int prodId;
            if (!int.TryParse(txtCodigoBarras.Text, out prodId))
            {
                // MessageBox.Show("El código de barras debe ser un número válido.");
                return; // Salir del método si hay un error
            }

            string prodNombre = txtNombre.Text;

            int prodCantidad;
            if (!int.TryParse(txtCantidad.Text, out prodCantidad))
            {
                //MessageBox.Show("La cantidad debe ser un número válido.");
                return;
            }

            decimal prodPrecio;
            if (!decimal.TryParse(txtPrecio.Text, out prodPrecio))
            {
                //MessageBox.Show("El precio debe ser un número válido.");
                return;
            }

            PRODUCTO objproducto = new PRODUCTO()
            {
                Prod_Id = prodId,
                Prod_Nombre = prodNombre,
                Prod_Cantidad = prodCantidad,
                Prod_Precio = prodPrecio,
                Prod_FechaCad = txtCaducidad.Text // Asegúrate de que sea un formato de fecha válido
            };

            int id = Convert.ToInt32(txtCodigoBarras.Text);
            string nombre = txtNombre.Text;
            int cant = Convert.ToInt32(txtCantidad.Text);
            decimal precio = Convert.ToDecimal(txtPrecio.Text);
            string fechacad = txtCaducidad.Text;

            if(objcn_produc.Existe(id))
            {
                try
                {
                    objcn_produc.EFEHOV(id, nombre, cant, precio, fechacad);

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
                    objcn_produc.MPBA(id, nombre, cant, precio, fechacad); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar el producto: " + ex.Message);
                }
            }


            //objcn_produc.MPBA(id, nombre, cant, precio, fechacad);

            cargarprod();
        }



        private void cargarprod()
        {
            dgvprod.Rows.Clear();
            List<PRODUCTO> ptprod = new CN_PRUDUCTOS().Listar();

            foreach (PRODUCTO item in ptprod)
            {
                int rowIndex = dgvprod.Rows.Add();
                DataGridViewRow row = dgvprod.Rows[rowIndex];

                row.Cells["CodigoB"].Value = item.Prod_Id;
                row.Cells["Nombre"].Value = item.Prod_Nombre;
                row.Cells["Cantidad"].Value = item.Prod_Cantidad;
                row.Cells["Precio"].Value = item.Prod_Precio;
                row.Cells["FechaC"].Value = item.Prod_FechaCad;
                row.Cells["Fecharegistro"].Value = item.Fecha_Creacion;
            }
        }

        public void Noemi()
            {
            txtCodigoBarras.Text = " ";
            txtNombre.Text = " ";
            txtCantidad.Text = " ";
            txtPrecio.Text = " ";
            txtCaducidad.Text = "  ";
            }
        private void ibtneliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtCodigoBarras.Text);
            objcn_produc.SALV(id);
            cargarprod();
            Noemi();
        }

        private void dgvprod_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dgvprod.Columns[e.ColumnIndex].Name == "btnselecionar" && e.RowIndex >= 0)
            {
                a = true;
                txtCaducidad.ForeColor = Color.Black;
                int indice = e.RowIndex;
                if (indice >= 0)
                {

                    txtCodigoBarras.Text = dgvprod.Rows[indice].Cells["CodigoB"].Value.ToString();
                    txtNombre.Text = dgvprod.Rows[indice].Cells["Nombre"].Value.ToString();
                    txtCantidad.Text = dgvprod.Rows[indice].Cells["Cantidad"].Value.ToString();
                    txtPrecio.Text = dgvprod.Rows[indice].Cells["Precio"].Value.ToString();
                    txtCaducidad.Text = dgvprod.Rows[indice].Cells["FechaC"].Value.ToString();


                }
            }

        }

       public void ASUPUTAMADRE()
        {
            if(a == true)
                {
                 txtCaducidad.ForeColor = Color.Black;
                }
   
        }

        private void ibtnexportarexcel_Click(object sender, EventArgs e)
        {
            if (dgvprod.Rows.Count < 1)
            {
                MessageBox.Show("No hay datos para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DataTable dt = new DataTable();

                foreach (DataGridViewColumn colum in dgvprod.Columns)
                {
                    if (colum.HeaderText != "" && colum.Visible)
                    {
                        dt.Columns.Add(colum.HeaderText, typeof(string));
                    }
                }

                foreach (DataGridViewRow row in dgvprod.Rows)
                {
                    if (row.Visible)
                    {
                        dt.Rows.Add(new object[]{
                            //10 este numero puede cambiar depende de las columnas que se vaya a pasara la excel
                            row.Cells[1].Value.ToString(),
                            row.Cells[2].Value.ToString(),
                            row.Cells[3].Value.ToString(),
                            row.Cells[4].Value.ToString(),
                            row.Cells[5].Value.ToString(),


                        });
                    }
                }
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("REPORTE DE PRODUCTOS_{0}.xlsx ", DateTime.Now.ToString("ddMMyyyyHHmmss"));
                savefile.Filter = "Excel file | *.xlsx";

                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XLWorkbook wb = new XLWorkbook();

                        var hoja = wb.Worksheets.Add(dt, "informe");
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(savefile.FileName);
                        MessageBox.Show("Reporte Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Error al generar reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

            }

        }


    }
}

