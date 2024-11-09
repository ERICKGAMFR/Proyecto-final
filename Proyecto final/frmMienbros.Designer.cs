
namespace Proyecto_final
{
    partial class frmMienbros
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
            this.lbtitulolistamiembros = new System.Windows.Forms.Label();
            this.ibtnsave = new FontAwesome.Sharp.IconButton();
            this.ibtnexportarexcel = new FontAwesome.Sharp.IconButton();
            this.dgvmiembro = new System.Windows.Forms.DataGridView();
            this.dgvbtnsleciona = new System.Windows.Forms.DataGridViewButtonColumn();
            this.estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono_emer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaTermina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbbuscar = new System.Windows.Forms.Label();
            this.cbobusqueda = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ibtnbusca = new FontAwesome.Sharp.IconButton();
            this.ibtnlimpiar = new FontAwesome.Sharp.IconButton();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.icbgenerarqr = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmiembro)).BeginInit();
            this.SuspendLayout();
            // 
            // lbtitulolistamiembros
            // 
            this.lbtitulolistamiembros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitulolistamiembros.ForeColor = System.Drawing.Color.White;
            this.lbtitulolistamiembros.Location = new System.Drawing.Point(198, 9);
            this.lbtitulolistamiembros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbtitulolistamiembros.Name = "lbtitulolistamiembros";
            this.lbtitulolistamiembros.Size = new System.Drawing.Size(595, 75);
            this.lbtitulolistamiembros.TabIndex = 75;
            this.lbtitulolistamiembros.Text = "LISTA DE MIEMBROS:";
            // 
            // ibtnsave
            // 
            this.ibtnsave.FlatAppearance.BorderSize = 0;
            this.ibtnsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(79)))), ((int)(((byte)(203)))));
            this.ibtnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnsave.ForeColor = System.Drawing.Color.White;
            this.ibtnsave.IconChar = FontAwesome.Sharp.IconChar.History;
            this.ibtnsave.IconColor = System.Drawing.Color.White;
            this.ibtnsave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnsave.Location = new System.Drawing.Point(9, 123);
            this.ibtnsave.Margin = new System.Windows.Forms.Padding(2);
            this.ibtnsave.Name = "ibtnsave";
            this.ibtnsave.Size = new System.Drawing.Size(64, 64);
            this.ibtnsave.TabIndex = 92;
            this.ibtnsave.Text = "Renovar";
            this.ibtnsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtnsave.UseVisualStyleBackColor = true;
            this.ibtnsave.Click += new System.EventHandler(this.ibtnsave_Click);
            // 
            // ibtnexportarexcel
            // 
            this.ibtnexportarexcel.FlatAppearance.BorderSize = 0;
            this.ibtnexportarexcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(79)))), ((int)(((byte)(203)))));
            this.ibtnexportarexcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnexportarexcel.ForeColor = System.Drawing.Color.White;
            this.ibtnexportarexcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.ibtnexportarexcel.IconColor = System.Drawing.Color.White;
            this.ibtnexportarexcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnexportarexcel.Location = new System.Drawing.Point(11, 219);
            this.ibtnexportarexcel.Margin = new System.Windows.Forms.Padding(2);
            this.ibtnexportarexcel.Name = "ibtnexportarexcel";
            this.ibtnexportarexcel.Size = new System.Drawing.Size(64, 88);
            this.ibtnexportarexcel.TabIndex = 94;
            this.ibtnexportarexcel.Text = "Exportar a excel";
            this.ibtnexportarexcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtnexportarexcel.UseVisualStyleBackColor = true;
            // 
            // dgvmiembro
            // 
            this.dgvmiembro.AllowUserToAddRows = false;
            this.dgvmiembro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmiembro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvbtnsleciona,
            this.estatus,
            this.Id_Cliente,
            this.NombreM,
            this.Telefono,
            this.Telefono_emer,
            this.Correo,
            this.Domicilio,
            this.Ciudad,
            this.FechaCreacion,
            this.FechaTermina});
            this.dgvmiembro.Location = new System.Drawing.Point(84, 86);
            this.dgvmiembro.Margin = new System.Windows.Forms.Padding(2);
            this.dgvmiembro.MultiSelect = false;
            this.dgvmiembro.Name = "dgvmiembro";
            this.dgvmiembro.ReadOnly = true;
            this.dgvmiembro.RowHeadersVisible = false;
            this.dgvmiembro.RowHeadersWidth = 51;
            this.dgvmiembro.Size = new System.Drawing.Size(722, 394);
            this.dgvmiembro.TabIndex = 95;
            this.dgvmiembro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvusuario_CellContentClick);
            this.dgvmiembro.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvmiembro_CellPainting);
            // 
            // dgvbtnsleciona
            // 
            this.dgvbtnsleciona.HeaderText = "";
            this.dgvbtnsleciona.MinimumWidth = 6;
            this.dgvbtnsleciona.Name = "dgvbtnsleciona";
            this.dgvbtnsleciona.ReadOnly = true;
            this.dgvbtnsleciona.Width = 30;
            // 
            // estatus
            // 
            this.estatus.HeaderText = "Estatus";
            this.estatus.MinimumWidth = 6;
            this.estatus.Name = "estatus";
            this.estatus.ReadOnly = true;
            this.estatus.Visible = false;
            this.estatus.Width = 125;
            // 
            // Id_Cliente
            // 
            this.Id_Cliente.HeaderText = "Identificador de Cliente";
            this.Id_Cliente.MinimumWidth = 6;
            this.Id_Cliente.Name = "Id_Cliente";
            this.Id_Cliente.ReadOnly = true;
            this.Id_Cliente.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Id_Cliente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Id_Cliente.Width = 125;
            // 
            // NombreM
            // 
            this.NombreM.HeaderText = "Nombre Miembro";
            this.NombreM.MinimumWidth = 6;
            this.NombreM.Name = "NombreM";
            this.NombreM.ReadOnly = true;
            this.NombreM.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NombreM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NombreM.Width = 125;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Telefono.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Telefono.Width = 125;
            // 
            // Telefono_emer
            // 
            this.Telefono_emer.HeaderText = "Telefono de Emergencia";
            this.Telefono_emer.MinimumWidth = 6;
            this.Telefono_emer.Name = "Telefono_emer";
            this.Telefono_emer.ReadOnly = true;
            this.Telefono_emer.Width = 125;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 6;
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 125;
            // 
            // Domicilio
            // 
            this.Domicilio.HeaderText = "Domicilio";
            this.Domicilio.MinimumWidth = 6;
            this.Domicilio.Name = "Domicilio";
            this.Domicilio.ReadOnly = true;
            this.Domicilio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Domicilio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Domicilio.Width = 125;
            // 
            // Ciudad
            // 
            this.Ciudad.HeaderText = "Ciudad";
            this.Ciudad.MinimumWidth = 6;
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.ReadOnly = true;
            this.Ciudad.Width = 125;
            // 
            // FechaCreacion
            // 
            this.FechaCreacion.HeaderText = "Fecha Inicio";
            this.FechaCreacion.MinimumWidth = 6;
            this.FechaCreacion.Name = "FechaCreacion";
            this.FechaCreacion.ReadOnly = true;
            this.FechaCreacion.Width = 125;
            // 
            // FechaTermina
            // 
            this.FechaTermina.HeaderText = "Fecha Termina ";
            this.FechaTermina.MinimumWidth = 6;
            this.FechaTermina.Name = "FechaTermina";
            this.FechaTermina.ReadOnly = true;
            this.FechaTermina.Width = 125;
            // 
            // lbbuscar
            // 
            this.lbbuscar.AutoSize = true;
            this.lbbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbuscar.ForeColor = System.Drawing.Color.White;
            this.lbbuscar.Location = new System.Drawing.Point(357, 61);
            this.lbbuscar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbbuscar.Name = "lbbuscar";
            this.lbbuscar.Size = new System.Drawing.Size(81, 17);
            this.lbbuscar.TabIndex = 96;
            this.lbbuscar.Text = "Buscar por:";
            // 
            // cbobusqueda
            // 
            this.cbobusqueda.FormattingEnabled = true;
            this.cbobusqueda.Location = new System.Drawing.Point(442, 57);
            this.cbobusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.cbobusqueda.Name = "cbobusqueda";
            this.cbobusqueda.Size = new System.Drawing.Size(95, 21);
            this.cbobusqueda.TabIndex = 97;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(541, 57);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 20);
            this.textBox1.TabIndex = 98;
            // 
            // ibtnbusca
            // 
            this.ibtnbusca.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.ibtnbusca.IconColor = System.Drawing.Color.Black;
            this.ibtnbusca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnbusca.IconSize = 30;
            this.ibtnbusca.Location = new System.Drawing.Point(687, 47);
            this.ibtnbusca.Margin = new System.Windows.Forms.Padding(2);
            this.ibtnbusca.Name = "ibtnbusca";
            this.ibtnbusca.Size = new System.Drawing.Size(30, 35);
            this.ibtnbusca.TabIndex = 99;
            this.ibtnbusca.UseVisualStyleBackColor = true;
            // 
            // ibtnlimpiar
            // 
            this.ibtnlimpiar.IconChar = FontAwesome.Sharp.IconChar.Brush;
            this.ibtnlimpiar.IconColor = System.Drawing.Color.Black;
            this.ibtnlimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnlimpiar.IconSize = 30;
            this.ibtnlimpiar.Location = new System.Drawing.Point(748, 47);
            this.ibtnlimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.ibtnlimpiar.Name = "ibtnlimpiar";
            this.ibtnlimpiar.Size = new System.Drawing.Size(30, 35);
            this.ibtnlimpiar.TabIndex = 100;
            this.ibtnlimpiar.UseVisualStyleBackColor = true;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(184, 494);
            this.txtid.Margin = new System.Windows.Forms.Padding(2);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(44, 20);
            this.txtid.TabIndex = 101;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(348, 494);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(263, 20);
            this.txtnombre.TabIndex = 102;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(104, 497);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 103;
            this.label1.Text = "ID de Miembro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(242, 497);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 104;
            this.label2.Text = "Nombre de Miembro";
            // 
            // icbgenerarqr
            // 
            this.icbgenerarqr.FlatAppearance.BorderSize = 0;
            this.icbgenerarqr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(79)))), ((int)(((byte)(203)))));
            this.icbgenerarqr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbgenerarqr.ForeColor = System.Drawing.Color.White;
            this.icbgenerarqr.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.icbgenerarqr.IconColor = System.Drawing.Color.White;
            this.icbgenerarqr.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbgenerarqr.Location = new System.Drawing.Point(9, 322);
            this.icbgenerarqr.Margin = new System.Windows.Forms.Padding(2);
            this.icbgenerarqr.Name = "icbgenerarqr";
            this.icbgenerarqr.Size = new System.Drawing.Size(71, 100);
            this.icbgenerarqr.TabIndex = 105;
            this.icbgenerarqr.Text = "Generar Codigo QR";
            this.icbgenerarqr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.icbgenerarqr.UseVisualStyleBackColor = true;
            // 
            // frmMienbros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(806, 525);
            this.Controls.Add(this.icbgenerarqr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.ibtnlimpiar);
            this.Controls.Add(this.ibtnbusca);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbobusqueda);
            this.Controls.Add(this.lbbuscar);
            this.Controls.Add(this.dgvmiembro);
            this.Controls.Add(this.ibtnexportarexcel);
            this.Controls.Add(this.ibtnsave);
            this.Controls.Add(this.lbtitulolistamiembros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMienbros";
            this.Text = "frmMienbros";
            this.Load += new System.EventHandler(this.frmMienbros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmiembro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbtitulolistamiembros;
        private FontAwesome.Sharp.IconButton ibtnsave;
        private FontAwesome.Sharp.IconButton ibtnexportarexcel;
        private System.Windows.Forms.DataGridView dgvmiembro;
        private System.Windows.Forms.Label lbbuscar;
        private System.Windows.Forms.ComboBox cbobusqueda;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconButton ibtnbusca;
        private FontAwesome.Sharp.IconButton ibtnlimpiar;
        private System.Windows.Forms.DataGridViewButtonColumn dgvbtnsleciona;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono_emer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaTermina;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton icbgenerarqr;
    }
}