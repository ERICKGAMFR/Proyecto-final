
namespace Proyecto_final
{
    partial class frmVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvventa = new System.Windows.Forms.DataGridView();
            this.dgvbtnseleciona = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id_Venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cli_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cli_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_Creacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ibtnsave = new FontAwesome.Sharp.IconButton();
            this.ibtneliminar = new FontAwesome.Sharp.IconButton();
            this.ibtnexportarexcel = new FontAwesome.Sharp.IconButton();
            this.lbtituloventa = new System.Windows.Forms.Label();
            this.lbbuscar = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ibtnbusca = new FontAwesome.Sharp.IconButton();
            this.ibtnlimpiar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvventa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvventa
            // 
            this.dgvventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvventa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvbtnseleciona,
            this.Id_Venta,
            this.Cli_ID,
            this.Cli_Nombre,
            this.Monto_pago,
            this.Monto_Total,
            this.fecha_Creacion});
            this.dgvventa.Location = new System.Drawing.Point(217, 57);
            this.dgvventa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvventa.Name = "dgvventa";
            this.dgvventa.RowHeadersWidth = 51;
            this.dgvventa.Size = new System.Drawing.Size(824, 532);
            this.dgvventa.TabIndex = 98;
            // 
            // dgvbtnseleciona
            // 
            this.dgvbtnseleciona.HeaderText = "";
            this.dgvbtnseleciona.MinimumWidth = 6;
            this.dgvbtnseleciona.Name = "dgvbtnseleciona";
            this.dgvbtnseleciona.Width = 30;
            // 
            // Id_Venta
            // 
            this.Id_Venta.HeaderText = "Folio";
            this.Id_Venta.MinimumWidth = 6;
            this.Id_Venta.Name = "Id_Venta";
            this.Id_Venta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Id_Venta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Id_Venta.Width = 125;
            // 
            // Cli_ID
            // 
            this.Cli_ID.HeaderText = "ID cliente";
            this.Cli_ID.MinimumWidth = 6;
            this.Cli_ID.Name = "Cli_ID";
            this.Cli_ID.Visible = false;
            this.Cli_ID.Width = 125;
            // 
            // Cli_Nombre
            // 
            this.Cli_Nombre.HeaderText = "Nombre Cliente ";
            this.Cli_Nombre.MinimumWidth = 6;
            this.Cli_Nombre.Name = "Cli_Nombre";
            this.Cli_Nombre.Width = 150;
            // 
            // Monto_pago
            // 
            this.Monto_pago.HeaderText = "Monto de Pago";
            this.Monto_pago.MinimumWidth = 6;
            this.Monto_pago.Name = "Monto_pago";
            this.Monto_pago.Width = 140;
            // 
            // Monto_Total
            // 
            this.Monto_Total.HeaderText = "Monto Total";
            this.Monto_Total.MinimumWidth = 6;
            this.Monto_Total.Name = "Monto_Total";
            this.Monto_Total.Width = 125;
            // 
            // fecha_Creacion
            // 
            this.fecha_Creacion.HeaderText = "FECHA DE VENTA";
            this.fecha_Creacion.MinimumWidth = 6;
            this.fecha_Creacion.Name = "fecha_Creacion";
            this.fecha_Creacion.Width = 200;
            // 
            // ibtnsave
            // 
            this.ibtnsave.FlatAppearance.BorderSize = 0;
            this.ibtnsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(204)))));
            this.ibtnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnsave.ForeColor = System.Drawing.Color.White;
            this.ibtnsave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.ibtnsave.IconColor = System.Drawing.Color.White;
            this.ibtnsave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnsave.Location = new System.Drawing.Point(29, 117);
            this.ibtnsave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ibtnsave.Name = "ibtnsave";
            this.ibtnsave.Size = new System.Drawing.Size(85, 80);
            this.ibtnsave.TabIndex = 129;
            this.ibtnsave.Text = "Guardar";
            this.ibtnsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtnsave.UseVisualStyleBackColor = true;
            // 
            // ibtneliminar
            // 
            this.ibtneliminar.FlatAppearance.BorderSize = 0;
            this.ibtneliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(204)))));
            this.ibtneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtneliminar.ForeColor = System.Drawing.Color.White;
            this.ibtneliminar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.ibtneliminar.IconColor = System.Drawing.Color.White;
            this.ibtneliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtneliminar.Location = new System.Drawing.Point(29, 219);
            this.ibtneliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ibtneliminar.Name = "ibtneliminar";
            this.ibtneliminar.Size = new System.Drawing.Size(85, 80);
            this.ibtneliminar.TabIndex = 130;
            this.ibtneliminar.Text = "Eliminar";
            this.ibtneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtneliminar.UseVisualStyleBackColor = true;
            // 
            // ibtnexportarexcel
            // 
            this.ibtnexportarexcel.FlatAppearance.BorderSize = 0;
            this.ibtnexportarexcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(204)))));
            this.ibtnexportarexcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnexportarexcel.ForeColor = System.Drawing.Color.White;
            this.ibtnexportarexcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.ibtnexportarexcel.IconColor = System.Drawing.Color.White;
            this.ibtnexportarexcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnexportarexcel.Location = new System.Drawing.Point(29, 327);
            this.ibtnexportarexcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ibtnexportarexcel.Name = "ibtnexportarexcel";
            this.ibtnexportarexcel.Size = new System.Drawing.Size(85, 103);
            this.ibtnexportarexcel.TabIndex = 131;
            this.ibtnexportarexcel.Text = "Exportar a excel";
            this.ibtnexportarexcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtnexportarexcel.UseVisualStyleBackColor = true;
            this.ibtnexportarexcel.Click += new System.EventHandler(this.ibtnexportarexcel_Click);
            // 
            // lbtituloventa
            // 
            this.lbtituloventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtituloventa.ForeColor = System.Drawing.Color.White;
            this.lbtituloventa.Location = new System.Drawing.Point(212, 4);
            this.lbtituloventa.Name = "lbtituloventa";
            this.lbtituloventa.Size = new System.Drawing.Size(829, 92);
            this.lbtituloventa.TabIndex = 132;
            this.lbtituloventa.Text = "LISTA DE VENTAS:";
            // 
            // lbbuscar
            // 
            this.lbbuscar.AutoSize = true;
            this.lbbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbuscar.ForeColor = System.Drawing.Color.White;
            this.lbbuscar.Location = new System.Drawing.Point(468, 15);
            this.lbbuscar.Name = "lbbuscar";
            this.lbbuscar.Size = new System.Drawing.Size(97, 20);
            this.lbbuscar.TabIndex = 133;
            this.lbbuscar.Text = "Buscar por:";
            this.lbbuscar.Click += new System.EventHandler(this.lbbuscar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(581, 14);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(125, 24);
            this.comboBox1.TabIndex = 134;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(727, 15);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 22);
            this.textBox1.TabIndex = 135;
            // 
            // ibtnbusca
            // 
            this.ibtnbusca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(79)))), ((int)(((byte)(203)))));
            this.ibtnbusca.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.ibtnbusca.IconColor = System.Drawing.Color.Black;
            this.ibtnbusca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnbusca.IconSize = 30;
            this.ibtnbusca.Location = new System.Drawing.Point(933, 5);
            this.ibtnbusca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ibtnbusca.Name = "ibtnbusca";
            this.ibtnbusca.Size = new System.Drawing.Size(40, 43);
            this.ibtnbusca.TabIndex = 136;
            this.ibtnbusca.UseVisualStyleBackColor = true;
            // 
            // ibtnlimpiar
            // 
            this.ibtnlimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(79)))), ((int)(((byte)(203)))));
            this.ibtnlimpiar.IconChar = FontAwesome.Sharp.IconChar.Brush;
            this.ibtnlimpiar.IconColor = System.Drawing.Color.Black;
            this.ibtnlimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnlimpiar.IconSize = 30;
            this.ibtnlimpiar.Location = new System.Drawing.Point(1001, 4);
            this.ibtnlimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ibtnlimpiar.Name = "ibtnlimpiar";
            this.ibtnlimpiar.Size = new System.Drawing.Size(40, 43);
            this.ibtnlimpiar.TabIndex = 137;
            this.ibtnlimpiar.UseVisualStyleBackColor = true;
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(1056, 602);
            this.Controls.Add(this.ibtnlimpiar);
            this.Controls.Add(this.ibtnbusca);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbbuscar);
            this.Controls.Add(this.ibtnexportarexcel);
            this.Controls.Add(this.ibtneliminar);
            this.Controls.Add(this.ibtnsave);
            this.Controls.Add(this.dgvventa);
            this.Controls.Add(this.lbtituloventa);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmVenta";
            this.Text = "frmVenta";
            this.Load += new System.EventHandler(this.frmVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvventa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvventa;
        private FontAwesome.Sharp.IconButton ibtnsave;
        private FontAwesome.Sharp.IconButton ibtneliminar;
        private FontAwesome.Sharp.IconButton ibtnexportarexcel;
        private System.Windows.Forms.Label lbtituloventa;
        private System.Windows.Forms.Label lbbuscar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconButton ibtnbusca;
        private FontAwesome.Sharp.IconButton ibtnlimpiar;
        private System.Windows.Forms.DataGridViewButtonColumn dgvbtnseleciona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cli_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cli_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_Creacion;
    }
}