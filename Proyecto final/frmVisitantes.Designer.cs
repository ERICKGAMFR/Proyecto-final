﻿
namespace Proyecto_final
{
    partial class frmregistar_Visitantes
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
            this.dgvusuario = new System.Windows.Forms.DataGridView();
            this.ibtnsave = new FontAwesome.Sharp.IconButton();
            this.ibtneliminar = new FontAwesome.Sharp.IconButton();
            this.ibtnexportarexcel = new FontAwesome.Sharp.IconButton();
            this.Id_Venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Visita_Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbtitulovisitantes = new System.Windows.Forms.Label();
            this.lbbuscar = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ibtnbusca = new FontAwesome.Sharp.IconButton();
            this.ibtnlimpiar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvusuario
            // 
            this.dgvusuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvusuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Venta,
            this.Nombre,
            this.Visita_Fecha});
            this.dgvusuario.Location = new System.Drawing.Point(163, 46);
            this.dgvusuario.Margin = new System.Windows.Forms.Padding(2);
            this.dgvusuario.Name = "dgvusuario";
            this.dgvusuario.RowHeadersWidth = 51;
            this.dgvusuario.Size = new System.Drawing.Size(618, 432);
            this.dgvusuario.TabIndex = 99;
            // 
            // ibtnsave
            // 
            this.ibtnsave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.ibtnsave.IconColor = System.Drawing.Color.ForestGreen;
            this.ibtnsave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnsave.Location = new System.Drawing.Point(37, 129);
            this.ibtnsave.Margin = new System.Windows.Forms.Padding(2);
            this.ibtnsave.Name = "ibtnsave";
            this.ibtnsave.Size = new System.Drawing.Size(64, 57);
            this.ibtnsave.TabIndex = 130;
            this.ibtnsave.Text = "Guardar";
            this.ibtnsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtnsave.UseVisualStyleBackColor = true;
            // 
            // ibtneliminar
            // 
            this.ibtneliminar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.ibtneliminar.IconColor = System.Drawing.Color.Red;
            this.ibtneliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtneliminar.Location = new System.Drawing.Point(37, 227);
            this.ibtneliminar.Margin = new System.Windows.Forms.Padding(2);
            this.ibtneliminar.Name = "ibtneliminar";
            this.ibtneliminar.Size = new System.Drawing.Size(64, 57);
            this.ibtneliminar.TabIndex = 131;
            this.ibtneliminar.Text = "Eliminar";
            this.ibtneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtneliminar.UseVisualStyleBackColor = true;
            // 
            // ibtnexportarexcel
            // 
            this.ibtnexportarexcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.ibtnexportarexcel.IconColor = System.Drawing.Color.Green;
            this.ibtnexportarexcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnexportarexcel.Location = new System.Drawing.Point(37, 318);
            this.ibtnexportarexcel.Margin = new System.Windows.Forms.Padding(2);
            this.ibtnexportarexcel.Name = "ibtnexportarexcel";
            this.ibtnexportarexcel.Size = new System.Drawing.Size(64, 68);
            this.ibtnexportarexcel.TabIndex = 132;
            this.ibtnexportarexcel.Text = "Exportar a excel";
            this.ibtnexportarexcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtnexportarexcel.UseVisualStyleBackColor = true;
            // 
            // Id_Venta
            // 
            this.Id_Venta.HeaderText = "Id Visitante";
            this.Id_Venta.MinimumWidth = 6;
            this.Id_Venta.Name = "Id_Venta";
            this.Id_Venta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Id_Venta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Id_Venta.Visible = false;
            this.Id_Venta.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Visita_Fecha
            // 
            this.Visita_Fecha.HeaderText = "Fecha de Visita";
            this.Visita_Fecha.Name = "Visita_Fecha";
            // 
            // lbtitulovisitantes
            // 
            this.lbtitulovisitantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitulovisitantes.Location = new System.Drawing.Point(159, -2);
            this.lbtitulovisitantes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbtitulovisitantes.Name = "lbtitulovisitantes";
            this.lbtitulovisitantes.Size = new System.Drawing.Size(622, 75);
            this.lbtitulovisitantes.TabIndex = 133;
            this.lbtitulovisitantes.Text = "LISTA DE VISITANTES:";
            // 
            // lbbuscar
            // 
            this.lbbuscar.AutoSize = true;
            this.lbbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbuscar.Location = new System.Drawing.Point(386, 13);
            this.lbbuscar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbbuscar.Name = "lbbuscar";
            this.lbbuscar.Size = new System.Drawing.Size(81, 17);
            this.lbbuscar.TabIndex = 134;
            this.lbbuscar.Text = "Buscar por:";
            this.lbbuscar.Click += new System.EventHandler(this.lbbuscar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(471, 13);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(95, 21);
            this.comboBox1.TabIndex = 135;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(570, 14);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 20);
            this.textBox1.TabIndex = 136;
            // 
            // ibtnbusca
            // 
            this.ibtnbusca.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.ibtnbusca.IconColor = System.Drawing.Color.Black;
            this.ibtnbusca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnbusca.IconSize = 30;
            this.ibtnbusca.Location = new System.Drawing.Point(709, 5);
            this.ibtnbusca.Margin = new System.Windows.Forms.Padding(2);
            this.ibtnbusca.Name = "ibtnbusca";
            this.ibtnbusca.Size = new System.Drawing.Size(30, 35);
            this.ibtnbusca.TabIndex = 137;
            this.ibtnbusca.UseVisualStyleBackColor = true;
            // 
            // ibtnlimpiar
            // 
            this.ibtnlimpiar.IconChar = FontAwesome.Sharp.IconChar.Brush;
            this.ibtnlimpiar.IconColor = System.Drawing.Color.Black;
            this.ibtnlimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnlimpiar.IconSize = 30;
            this.ibtnlimpiar.Location = new System.Drawing.Point(751, 7);
            this.ibtnlimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.ibtnlimpiar.Name = "ibtnlimpiar";
            this.ibtnlimpiar.Size = new System.Drawing.Size(30, 35);
            this.ibtnlimpiar.TabIndex = 138;
            this.ibtnlimpiar.UseVisualStyleBackColor = true;
            // 
            // frmregistar_Visitantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 489);
            this.Controls.Add(this.ibtnlimpiar);
            this.Controls.Add(this.ibtnbusca);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbbuscar);
            this.Controls.Add(this.ibtnexportarexcel);
            this.Controls.Add(this.ibtneliminar);
            this.Controls.Add(this.ibtnsave);
            this.Controls.Add(this.dgvusuario);
            this.Controls.Add(this.lbtitulovisitantes);
            this.Name = "frmregistar_Visitantes";
            this.Text = "frmregistar_Visitantes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvusuario;
        private FontAwesome.Sharp.IconButton ibtnsave;
        private FontAwesome.Sharp.IconButton ibtneliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Visita_Fecha;
        private FontAwesome.Sharp.IconButton ibtnexportarexcel;
        private System.Windows.Forms.Label lbtitulovisitantes;
        private System.Windows.Forms.Label lbbuscar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconButton ibtnbusca;
        private FontAwesome.Sharp.IconButton ibtnlimpiar;
    }
}