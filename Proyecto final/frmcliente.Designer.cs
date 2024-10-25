namespace Proyecto_final
{
    partial class frmcliente
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
            this.lbNC = new System.Windows.Forms.Label();
            this.lbedad = new System.Windows.Forms.Label();
            this.lbtelefono = new System.Windows.Forms.Label();
            this.lbciudad = new System.Windows.Forms.Label();
            this.lbdomicilio = new System.Windows.Forms.Label();
            this.lbcorreo = new System.Windows.Forms.Label();
            this.lbtelefono_emergencia = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtTelefonoEmergencia = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.textCiudad = new System.Windows.Forms.TextBox();
            this.textDomicilio = new System.Windows.Forms.TextBox();
            this.ibtnlimpiar = new FontAwesome.Sharp.IconButton();
            this.ibtnbusca = new FontAwesome.Sharp.IconButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbbuscar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbtitulolistaclientes = new System.Windows.Forms.Label();
            this.Id_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono_de_emergencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checvisitante = new System.Windows.Forms.CheckBox();
            this.checkMiembro = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvusuario
            // 
            this.dgvusuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvusuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Cliente,
            this.NombreC,
            this.Edad,
            this.Telefono,
            this.Telefono_de_emergencia,
            this.Correo,
            this.Domicilio,
            this.Ciudad,
            this.Calle});
            this.dgvusuario.Location = new System.Drawing.Point(188, 78);
            this.dgvusuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvusuario.Name = "dgvusuario";
            this.dgvusuario.RowHeadersWidth = 51;
            this.dgvusuario.Size = new System.Drawing.Size(603, 432);
            this.dgvusuario.TabIndex = 1;
            // 
            // ibtnsave
            // 
            this.ibtnsave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.ibtnsave.IconColor = System.Drawing.Color.ForestGreen;
            this.ibtnsave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnsave.Location = new System.Drawing.Point(6, 363);
            this.ibtnsave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ibtnsave.Name = "ibtnsave";
            this.ibtnsave.Size = new System.Drawing.Size(64, 57);
            this.ibtnsave.TabIndex = 49;
            this.ibtnsave.Text = "Guardar";
            this.ibtnsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtnsave.UseVisualStyleBackColor = true;
            // 
            // ibtneliminar
            // 
            this.ibtneliminar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.ibtneliminar.IconColor = System.Drawing.Color.Red;
            this.ibtneliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtneliminar.Location = new System.Drawing.Point(111, 363);
            this.ibtneliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ibtneliminar.Name = "ibtneliminar";
            this.ibtneliminar.Size = new System.Drawing.Size(64, 57);
            this.ibtneliminar.TabIndex = 50;
            this.ibtneliminar.Text = "Eliminar";
            this.ibtneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtneliminar.UseVisualStyleBackColor = true;
            // 
            // ibtnexportarexcel
            // 
            this.ibtnexportarexcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.ibtnexportarexcel.IconColor = System.Drawing.Color.Green;
            this.ibtnexportarexcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnexportarexcel.Location = new System.Drawing.Point(57, 424);
            this.ibtnexportarexcel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ibtnexportarexcel.Name = "ibtnexportarexcel";
            this.ibtnexportarexcel.Size = new System.Drawing.Size(66, 71);
            this.ibtnexportarexcel.TabIndex = 51;
            this.ibtnexportarexcel.Text = "Exportar a excel";
            this.ibtnexportarexcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtnexportarexcel.UseVisualStyleBackColor = true;
            // 
            // lbNC
            // 
            this.lbNC.AutoSize = true;
            this.lbNC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNC.Location = new System.Drawing.Point(8, 40);
            this.lbNC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNC.Name = "lbNC";
            this.lbNC.Size = new System.Drawing.Size(124, 17);
            this.lbNC.TabIndex = 52;
            this.lbNC.Text = "Nombre Cliente:";
            this.lbNC.Click += new System.EventHandler(this.lbNU_Click);
            // 
            // lbedad
            // 
            this.lbedad.AutoSize = true;
            this.lbedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbedad.Location = new System.Drawing.Point(8, 81);
            this.lbedad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbedad.Name = "lbedad";
            this.lbedad.Size = new System.Drawing.Size(50, 17);
            this.lbedad.TabIndex = 53;
            this.lbedad.Text = "Edad:";
            // 
            // lbtelefono
            // 
            this.lbtelefono.AutoSize = true;
            this.lbtelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtelefono.Location = new System.Drawing.Point(3, 122);
            this.lbtelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbtelefono.Name = "lbtelefono";
            this.lbtelefono.Size = new System.Drawing.Size(77, 17);
            this.lbtelefono.TabIndex = 54;
            this.lbtelefono.Text = "Telefono:";
            // 
            // lbciudad
            // 
            this.lbciudad.AutoSize = true;
            this.lbciudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbciudad.Location = new System.Drawing.Point(8, 286);
            this.lbciudad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbciudad.Name = "lbciudad";
            this.lbciudad.Size = new System.Drawing.Size(63, 17);
            this.lbciudad.TabIndex = 55;
            this.lbciudad.Text = "Ciudad:";
            // 
            // lbdomicilio
            // 
            this.lbdomicilio.AutoSize = true;
            this.lbdomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdomicilio.Location = new System.Drawing.Point(3, 245);
            this.lbdomicilio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbdomicilio.Name = "lbdomicilio";
            this.lbdomicilio.Size = new System.Drawing.Size(78, 17);
            this.lbdomicilio.TabIndex = 56;
            this.lbdomicilio.Text = "Domicilio:";
            this.lbdomicilio.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbcorreo
            // 
            this.lbcorreo.AutoSize = true;
            this.lbcorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcorreo.Location = new System.Drawing.Point(3, 204);
            this.lbcorreo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbcorreo.Name = "lbcorreo";
            this.lbcorreo.Size = new System.Drawing.Size(62, 17);
            this.lbcorreo.TabIndex = 57;
            this.lbcorreo.Text = "Correo:";
            // 
            // lbtelefono_emergencia
            // 
            this.lbtelefono_emergencia.AutoSize = true;
            this.lbtelefono_emergencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtelefono_emergencia.Location = new System.Drawing.Point(-6, 163);
            this.lbtelefono_emergencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbtelefono_emergencia.Name = "lbtelefono_emergencia";
            this.lbtelefono_emergencia.Size = new System.Drawing.Size(190, 17);
            this.lbtelefono_emergencia.TabIndex = 58;
            this.lbtelefono_emergencia.Text = "Telefono de Emergencia:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(1, 59);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(155, 20);
            this.txtNombreCliente.TabIndex = 60;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(1, 100);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(2);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(155, 20);
            this.txtEdad.TabIndex = 61;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(1, 141);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(155, 20);
            this.txtTelefono.TabIndex = 62;
            // 
            // txtTelefonoEmergencia
            // 
            this.txtTelefonoEmergencia.Location = new System.Drawing.Point(-3, 182);
            this.txtTelefonoEmergencia.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefonoEmergencia.Name = "txtTelefonoEmergencia";
            this.txtTelefonoEmergencia.Size = new System.Drawing.Size(155, 20);
            this.txtTelefonoEmergencia.TabIndex = 63;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(-3, 223);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(155, 20);
            this.txtCorreo.TabIndex = 64;
            // 
            // textCiudad
            // 
            this.textCiudad.Location = new System.Drawing.Point(-3, 305);
            this.textCiudad.Margin = new System.Windows.Forms.Padding(2);
            this.textCiudad.Name = "textCiudad";
            this.textCiudad.Size = new System.Drawing.Size(155, 20);
            this.textCiudad.TabIndex = 66;
            // 
            // textDomicilio
            // 
            this.textDomicilio.Location = new System.Drawing.Point(1, 264);
            this.textDomicilio.Margin = new System.Windows.Forms.Padding(2);
            this.textDomicilio.Name = "textDomicilio";
            this.textDomicilio.Size = new System.Drawing.Size(155, 20);
            this.textDomicilio.TabIndex = 67;
            // 
            // ibtnlimpiar
            // 
            this.ibtnlimpiar.IconChar = FontAwesome.Sharp.IconChar.Brush;
            this.ibtnlimpiar.IconColor = System.Drawing.Color.Black;
            this.ibtnlimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnlimpiar.IconSize = 30;
            this.ibtnlimpiar.Location = new System.Drawing.Point(751, 32);
            this.ibtnlimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.ibtnlimpiar.Name = "ibtnlimpiar";
            this.ibtnlimpiar.Size = new System.Drawing.Size(30, 35);
            this.ibtnlimpiar.TabIndex = 68;
            this.ibtnlimpiar.UseVisualStyleBackColor = true;
            // 
            // ibtnbusca
            // 
            this.ibtnbusca.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.ibtnbusca.IconColor = System.Drawing.Color.Black;
            this.ibtnbusca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnbusca.IconSize = 30;
            this.ibtnbusca.Location = new System.Drawing.Point(702, 32);
            this.ibtnbusca.Margin = new System.Windows.Forms.Padding(2);
            this.ibtnbusca.Name = "ibtnbusca";
            this.ibtnbusca.Size = new System.Drawing.Size(30, 35);
            this.ibtnbusca.TabIndex = 69;
            this.ibtnbusca.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(572, 44);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 20);
            this.textBox1.TabIndex = 70;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(473, 44);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(95, 21);
            this.comboBox1.TabIndex = 71;
            // 
            // lbbuscar
            // 
            this.lbbuscar.AutoSize = true;
            this.lbbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbuscar.Location = new System.Drawing.Point(388, 44);
            this.lbbuscar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbbuscar.Name = "lbbuscar";
            this.lbbuscar.Size = new System.Drawing.Size(81, 17);
            this.lbbuscar.TabIndex = 72;
            this.lbbuscar.Text = "Buscar por:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 512);
            this.label1.TabIndex = 73;
            this.label1.Text = "Datos de registro";
            // 
            // lbtitulolistaclientes
            // 
            this.lbtitulolistaclientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitulolistaclientes.Location = new System.Drawing.Point(196, 4);
            this.lbtitulolistaclientes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbtitulolistaclientes.Name = "lbtitulolistaclientes";
            this.lbtitulolistaclientes.Size = new System.Drawing.Size(595, 75);
            this.lbtitulolistaclientes.TabIndex = 74;
            this.lbtitulolistaclientes.Text = "LISTA DE CLIENTES:";
            // 
            // Id_Cliente
            // 
            this.Id_Cliente.HeaderText = "Id Cliente";
            this.Id_Cliente.MinimumWidth = 6;
            this.Id_Cliente.Name = "Id_Cliente";
            this.Id_Cliente.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Id_Cliente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Id_Cliente.Visible = false;
            this.Id_Cliente.Width = 125;
            // 
            // NombreC
            // 
            this.NombreC.HeaderText = "Nombre Cliente";
            this.NombreC.MinimumWidth = 6;
            this.NombreC.Name = "NombreC";
            this.NombreC.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NombreC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NombreC.Width = 125;
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.MinimumWidth = 6;
            this.Edad.Name = "Edad";
            this.Edad.Width = 125;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Telefono.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Telefono.Width = 125;
            // 
            // Telefono_de_emergencia
            // 
            this.Telefono_de_emergencia.HeaderText = "Telefono de Emergencia";
            this.Telefono_de_emergencia.MinimumWidth = 6;
            this.Telefono_de_emergencia.Name = "Telefono_de_emergencia";
            this.Telefono_de_emergencia.Width = 125;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 6;
            this.Correo.Name = "Correo";
            this.Correo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Correo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Correo.Width = 125;
            // 
            // Domicilio
            // 
            this.Domicilio.HeaderText = "Domicilio";
            this.Domicilio.MinimumWidth = 6;
            this.Domicilio.Name = "Domicilio";
            this.Domicilio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Domicilio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Domicilio.Width = 125;
            // 
            // Ciudad
            // 
            this.Ciudad.HeaderText = "Ciudad";
            this.Ciudad.MinimumWidth = 6;
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.Width = 125;
            // 
            // Calle
            // 
            this.Calle.HeaderText = "Calle";
            this.Calle.MinimumWidth = 6;
            this.Calle.Name = "Calle";
            this.Calle.Width = 125;
            // 
            // checvisitante
            // 
            this.checvisitante.AutoSize = true;
            this.checvisitante.Location = new System.Drawing.Point(6, 341);
            this.checvisitante.Name = "checvisitante";
            this.checvisitante.Size = new System.Drawing.Size(66, 17);
            this.checvisitante.TabIndex = 75;
            this.checvisitante.Text = "Visitante";
            this.checvisitante.UseVisualStyleBackColor = true;
            // 
            // checkMiembro
            // 
            this.checkMiembro.AutoSize = true;
            this.checkMiembro.Location = new System.Drawing.Point(90, 341);
            this.checkMiembro.Name = "checkMiembro";
            this.checkMiembro.Size = new System.Drawing.Size(66, 17);
            this.checkMiembro.TabIndex = 76;
            this.checkMiembro.Text = "Miembro";
            this.checkMiembro.UseVisualStyleBackColor = true;
            // 
            // frmcliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 570);
            this.Controls.Add(this.checkMiembro);
            this.Controls.Add(this.checvisitante);
            this.Controls.Add(this.lbbuscar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ibtnbusca);
            this.Controls.Add(this.ibtnlimpiar);
            this.Controls.Add(this.textDomicilio);
            this.Controls.Add(this.textCiudad);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtTelefonoEmergencia);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.lbtelefono_emergencia);
            this.Controls.Add(this.lbcorreo);
            this.Controls.Add(this.lbdomicilio);
            this.Controls.Add(this.lbciudad);
            this.Controls.Add(this.lbtelefono);
            this.Controls.Add(this.lbedad);
            this.Controls.Add(this.lbNC);
            this.Controls.Add(this.ibtnexportarexcel);
            this.Controls.Add(this.ibtneliminar);
            this.Controls.Add(this.ibtnsave);
            this.Controls.Add(this.dgvusuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbtitulolistaclientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmcliente";
            this.Text = "frmcliente";
            this.Load += new System.EventHandler(this.frmcliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvusuario;
        private FontAwesome.Sharp.IconButton ibtnsave;
        private FontAwesome.Sharp.IconButton ibtneliminar;
        private FontAwesome.Sharp.IconButton ibtnexportarexcel;
        private System.Windows.Forms.Label lbNC;
        private System.Windows.Forms.Label lbedad;
        private System.Windows.Forms.Label lbtelefono;
        private System.Windows.Forms.Label lbciudad;
        private System.Windows.Forms.Label lbdomicilio;
        private System.Windows.Forms.Label lbcorreo;
        private System.Windows.Forms.Label lbtelefono_emergencia;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtTelefonoEmergencia;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox textCiudad;
        private System.Windows.Forms.TextBox textDomicilio;
        private FontAwesome.Sharp.IconButton ibtnlimpiar;
        private FontAwesome.Sharp.IconButton ibtnbusca;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbbuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbtitulolistaclientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono_de_emergencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calle;
        private System.Windows.Forms.CheckBox checvisitante;
        private System.Windows.Forms.CheckBox checkMiembro;
    }
}