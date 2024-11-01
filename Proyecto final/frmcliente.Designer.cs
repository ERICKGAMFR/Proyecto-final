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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvcliente = new System.Windows.Forms.DataGridView();
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
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtdomicilio = new System.Windows.Forms.TextBox();
            this.ibtnlimpiar = new FontAwesome.Sharp.IconButton();
            this.ibtnbusca = new FontAwesome.Sharp.IconButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbobusqueda = new System.Windows.Forms.ComboBox();
            this.lbbuscar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbtitulolistaclientes = new System.Windows.Forms.Label();
            this.cboestatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvbtnseleciona = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono_emer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaTermina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvcliente
            // 
            this.dgvcliente.AllowUserToAddRows = false;
            this.dgvcliente.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvcliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvbtnseleciona,
            this.Id_Cliente,
            this.NombreC,
            this.Edad,
            this.Telefono,
            this.Telefono_emer,
            this.Correo,
            this.Domicilio,
            this.Ciudad,
            this.Estatus,
            this.FechaCreacion,
            this.FechaTermina});
            this.dgvcliente.EnableHeadersVisualStyles = false;
            this.dgvcliente.Location = new System.Drawing.Point(216, 96);
            this.dgvcliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvcliente.MultiSelect = false;
            this.dgvcliente.Name = "dgvcliente";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvcliente.RowHeadersVisible = false;
            this.dgvcliente.RowHeadersWidth = 51;
            this.dgvcliente.Size = new System.Drawing.Size(873, 534);
            this.dgvcliente.TabIndex = 1;
            this.dgvcliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvusuario_CellContentClick);
            this.dgvcliente.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvusuario_CellPainting);
            // 
            // ibtnsave
            // 
            this.ibtnsave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.ibtnsave.IconColor = System.Drawing.Color.ForestGreen;
            this.ibtnsave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnsave.IconSize = 34;
            this.ibtnsave.Location = new System.Drawing.Point(8, 461);
            this.ibtnsave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ibtnsave.Name = "ibtnsave";
            this.ibtnsave.Size = new System.Drawing.Size(85, 70);
            this.ibtnsave.TabIndex = 49;
            this.ibtnsave.Text = "Guardar";
            this.ibtnsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtnsave.UseVisualStyleBackColor = true;
            this.ibtnsave.Click += new System.EventHandler(this.ibtnsave_Click);
            // 
            // ibtneliminar
            // 
            this.ibtneliminar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.ibtneliminar.IconColor = System.Drawing.Color.Red;
            this.ibtneliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtneliminar.IconSize = 34;
            this.ibtneliminar.Location = new System.Drawing.Point(99, 461);
            this.ibtneliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ibtneliminar.Name = "ibtneliminar";
            this.ibtneliminar.Size = new System.Drawing.Size(84, 70);
            this.ibtneliminar.TabIndex = 50;
            this.ibtneliminar.Text = "Eliminar";
            this.ibtneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtneliminar.UseVisualStyleBackColor = true;
            this.ibtneliminar.Click += new System.EventHandler(this.ibtneliminar_Click);
            // 
            // ibtnexportarexcel
            // 
            this.ibtnexportarexcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.ibtnexportarexcel.IconColor = System.Drawing.Color.Green;
            this.ibtnexportarexcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnexportarexcel.IconSize = 34;
            this.ibtnexportarexcel.Location = new System.Drawing.Point(15, 535);
            this.ibtnexportarexcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ibtnexportarexcel.Name = "ibtnexportarexcel";
            this.ibtnexportarexcel.Size = new System.Drawing.Size(143, 70);
            this.ibtnexportarexcel.TabIndex = 51;
            this.ibtnexportarexcel.Text = "Exportar a excel";
            this.ibtnexportarexcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtnexportarexcel.UseVisualStyleBackColor = true;
            // 
            // lbNC
            // 
            this.lbNC.AutoSize = true;
            this.lbNC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNC.Location = new System.Drawing.Point(11, 49);
            this.lbNC.Name = "lbNC";
            this.lbNC.Size = new System.Drawing.Size(145, 20);
            this.lbNC.TabIndex = 52;
            this.lbNC.Text = "Nombre Cliente:";
            this.lbNC.Click += new System.EventHandler(this.lbNU_Click);
            // 
            // lbedad
            // 
            this.lbedad.AutoSize = true;
            this.lbedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbedad.Location = new System.Drawing.Point(11, 100);
            this.lbedad.Name = "lbedad";
            this.lbedad.Size = new System.Drawing.Size(57, 20);
            this.lbedad.TabIndex = 53;
            this.lbedad.Text = "Edad:";
            // 
            // lbtelefono
            // 
            this.lbtelefono.AutoSize = true;
            this.lbtelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtelefono.Location = new System.Drawing.Point(4, 150);
            this.lbtelefono.Name = "lbtelefono";
            this.lbtelefono.Size = new System.Drawing.Size(87, 20);
            this.lbtelefono.TabIndex = 54;
            this.lbtelefono.Text = "Telefono:";
            // 
            // lbciudad
            // 
            this.lbciudad.AutoSize = true;
            this.lbciudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbciudad.Location = new System.Drawing.Point(11, 352);
            this.lbciudad.Name = "lbciudad";
            this.lbciudad.Size = new System.Drawing.Size(78, 20);
            this.lbciudad.TabIndex = 55;
            this.lbciudad.Text = "Colonia:";
            // 
            // lbdomicilio
            // 
            this.lbdomicilio.AutoSize = true;
            this.lbdomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdomicilio.Location = new System.Drawing.Point(4, 302);
            this.lbdomicilio.Name = "lbdomicilio";
            this.lbdomicilio.Size = new System.Drawing.Size(94, 20);
            this.lbdomicilio.TabIndex = 56;
            this.lbdomicilio.Text = "Domicilio:";
            this.lbdomicilio.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbcorreo
            // 
            this.lbcorreo.AutoSize = true;
            this.lbcorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcorreo.Location = new System.Drawing.Point(4, 251);
            this.lbcorreo.Name = "lbcorreo";
            this.lbcorreo.Size = new System.Drawing.Size(72, 20);
            this.lbcorreo.TabIndex = 57;
            this.lbcorreo.Text = "Correo:";
            // 
            // lbtelefono_emergencia
            // 
            this.lbtelefono_emergencia.AutoSize = true;
            this.lbtelefono_emergencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtelefono_emergencia.Location = new System.Drawing.Point(-8, 201);
            this.lbtelefono_emergencia.Name = "lbtelefono_emergencia";
            this.lbtelefono_emergencia.Size = new System.Drawing.Size(218, 20);
            this.lbtelefono_emergencia.TabIndex = 58;
            this.lbtelefono_emergencia.Text = "Telefono de Emergencia:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(1, 73);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(205, 22);
            this.txtNombreCliente.TabIndex = 60;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(1, 123);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(205, 22);
            this.txtEdad.TabIndex = 61;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(1, 174);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(205, 22);
            this.txtTelefono.TabIndex = 62;
            // 
            // txtTelefonoEmergencia
            // 
            this.txtTelefonoEmergencia.Location = new System.Drawing.Point(-4, 224);
            this.txtTelefonoEmergencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefonoEmergencia.Name = "txtTelefonoEmergencia";
            this.txtTelefonoEmergencia.Size = new System.Drawing.Size(205, 22);
            this.txtTelefonoEmergencia.TabIndex = 63;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(-4, 274);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(205, 22);
            this.txtCorreo.TabIndex = 64;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(-4, 375);
            this.txtCiudad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(205, 22);
            this.txtCiudad.TabIndex = 66;
            // 
            // txtdomicilio
            // 
            this.txtdomicilio.Location = new System.Drawing.Point(1, 325);
            this.txtdomicilio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdomicilio.Name = "txtdomicilio";
            this.txtdomicilio.Size = new System.Drawing.Size(205, 22);
            this.txtdomicilio.TabIndex = 67;
            // 
            // ibtnlimpiar
            // 
            this.ibtnlimpiar.IconChar = FontAwesome.Sharp.IconChar.Brush;
            this.ibtnlimpiar.IconColor = System.Drawing.Color.Black;
            this.ibtnlimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnlimpiar.IconSize = 30;
            this.ibtnlimpiar.Location = new System.Drawing.Point(1001, 39);
            this.ibtnlimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ibtnlimpiar.Name = "ibtnlimpiar";
            this.ibtnlimpiar.Size = new System.Drawing.Size(40, 43);
            this.ibtnlimpiar.TabIndex = 68;
            this.ibtnlimpiar.UseVisualStyleBackColor = true;
            // 
            // ibtnbusca
            // 
            this.ibtnbusca.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.ibtnbusca.IconColor = System.Drawing.Color.Black;
            this.ibtnbusca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnbusca.IconSize = 30;
            this.ibtnbusca.Location = new System.Drawing.Point(936, 39);
            this.ibtnbusca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ibtnbusca.Name = "ibtnbusca";
            this.ibtnbusca.Size = new System.Drawing.Size(40, 43);
            this.ibtnbusca.TabIndex = 69;
            this.ibtnbusca.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(763, 54);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 22);
            this.textBox1.TabIndex = 70;
            // 
            // cbobusqueda
            // 
            this.cbobusqueda.FormattingEnabled = true;
            this.cbobusqueda.Location = new System.Drawing.Point(631, 54);
            this.cbobusqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbobusqueda.Name = "cbobusqueda";
            this.cbobusqueda.Size = new System.Drawing.Size(125, 24);
            this.cbobusqueda.TabIndex = 71;
            // 
            // lbbuscar
            // 
            this.lbbuscar.AutoSize = true;
            this.lbbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbuscar.Location = new System.Drawing.Point(517, 54);
            this.lbbuscar.Name = "lbbuscar";
            this.lbbuscar.Size = new System.Drawing.Size(97, 20);
            this.lbbuscar.TabIndex = 72;
            this.lbbuscar.Text = "Buscar por:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 607);
            this.label1.TabIndex = 73;
            this.label1.Text = "Datos de registro";
            // 
            // lbtitulolistaclientes
            // 
            this.lbtitulolistaclientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitulolistaclientes.Location = new System.Drawing.Point(216, 5);
            this.lbtitulolistaclientes.Name = "lbtitulolistaclientes";
            this.lbtitulolistaclientes.Size = new System.Drawing.Size(838, 92);
            this.lbtitulolistaclientes.TabIndex = 74;
            this.lbtitulolistaclientes.Text = "LISTA DE CLIENTES:";
            // 
            // cboestatus
            // 
            this.cboestatus.FormattingEnabled = true;
            this.cboestatus.Location = new System.Drawing.Point(0, 422);
            this.cboestatus.Name = "cboestatus";
            this.cboestatus.Size = new System.Drawing.Size(201, 24);
            this.cboestatus.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 76;
            this.label2.Text = "Estatus:";
            // 
            // dgvbtnseleciona
            // 
            this.dgvbtnseleciona.HeaderText = "";
            this.dgvbtnseleciona.MinimumWidth = 6;
            this.dgvbtnseleciona.Name = "dgvbtnseleciona";
            this.dgvbtnseleciona.Width = 20;
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
            // Telefono_emer
            // 
            this.Telefono_emer.HeaderText = "Telefono de Emergencia";
            this.Telefono_emer.MinimumWidth = 6;
            this.Telefono_emer.Name = "Telefono_emer";
            this.Telefono_emer.Width = 125;
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
            // Estatus
            // 
            this.Estatus.HeaderText = "Estatus";
            this.Estatus.MinimumWidth = 6;
            this.Estatus.Name = "Estatus";
            this.Estatus.Width = 125;
            // 
            // FechaCreacion
            // 
            this.FechaCreacion.HeaderText = "Fecha De Registro";
            this.FechaCreacion.MinimumWidth = 6;
            this.FechaCreacion.Name = "FechaCreacion";
            this.FechaCreacion.Width = 125;
            // 
            // FechaTermina
            // 
            this.FechaTermina.HeaderText = "Fecha Termina";
            this.FechaTermina.MinimumWidth = 6;
            this.FechaTermina.Name = "FechaTermina";
            this.FechaTermina.Visible = false;
            this.FechaTermina.Width = 125;
            // 
            // frmcliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 599);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboestatus);
            this.Controls.Add(this.lbbuscar);
            this.Controls.Add(this.cbobusqueda);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ibtnbusca);
            this.Controls.Add(this.ibtnlimpiar);
            this.Controls.Add(this.txtdomicilio);
            this.Controls.Add(this.txtCiudad);
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
            this.Controls.Add(this.dgvcliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbtitulolistaclientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmcliente";
            this.Text = "frmcliente";
            this.Load += new System.EventHandler(this.frmcliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvcliente;
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
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.TextBox txtdomicilio;
        private FontAwesome.Sharp.IconButton ibtnlimpiar;
        private FontAwesome.Sharp.IconButton ibtnbusca;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbobusqueda;
        private System.Windows.Forms.Label lbbuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbtitulolistaclientes;
        private System.Windows.Forms.ComboBox cboestatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewButtonColumn dgvbtnseleciona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono_emer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaTermina;
    }
}