
namespace Proyecto_final
{
    partial class frmUsuario
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
            this.conte_listau = new System.Windows.Forms.Panel();
            this.ibtneliminar = new FontAwesome.Sharp.IconButton();
            this.ibtnsave = new FontAwesome.Sharp.IconButton();
            this.cboestado = new System.Windows.Forms.ComboBox();
            this.lbestado = new System.Windows.Forms.Label();
            this.cborol = new System.Windows.Forms.ComboBox();
            this.lbrol = new System.Windows.Forms.Label();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.lbcorreo = new System.Windows.Forms.Label();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.lbclave = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.lbphone = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbNU = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ibtnlimpiar = new FontAwesome.Sharp.IconButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbbuscar = new System.Windows.Forms.Label();
            this.ibtnbusca = new FontAwesome.Sharp.IconButton();
            this.lbtitulolistausuario = new System.Windows.Forms.Label();
            this.dgvusuario = new System.Windows.Forms.DataGridView();
            this.dgvbtnselecionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado_Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conte_listau.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuario)).BeginInit();
            this.SuspendLayout();
            // 
            // conte_listau
            // 
            this.conte_listau.Controls.Add(this.ibtneliminar);
            this.conte_listau.Controls.Add(this.ibtnsave);
            this.conte_listau.Controls.Add(this.cboestado);
            this.conte_listau.Controls.Add(this.lbestado);
            this.conte_listau.Controls.Add(this.cborol);
            this.conte_listau.Controls.Add(this.lbrol);
            this.conte_listau.Controls.Add(this.txtcorreo);
            this.conte_listau.Controls.Add(this.lbcorreo);
            this.conte_listau.Controls.Add(this.txtclave);
            this.conte_listau.Controls.Add(this.lbclave);
            this.conte_listau.Controls.Add(this.txtphone);
            this.conte_listau.Controls.Add(this.lbphone);
            this.conte_listau.Controls.Add(this.txtNombre);
            this.conte_listau.Controls.Add(this.lbNU);
            this.conte_listau.Controls.Add(this.label1);
            this.conte_listau.Controls.Add(this.ibtnlimpiar);
            this.conte_listau.Controls.Add(this.comboBox1);
            this.conte_listau.Controls.Add(this.textBox1);
            this.conte_listau.Controls.Add(this.lbbuscar);
            this.conte_listau.Controls.Add(this.ibtnbusca);
            this.conte_listau.Controls.Add(this.lbtitulolistausuario);
            this.conte_listau.Controls.Add(this.dgvusuario);
            this.conte_listau.Location = new System.Drawing.Point(1, 1);
            this.conte_listau.Name = "conte_listau";
            this.conte_listau.Size = new System.Drawing.Size(1074, 630);
            this.conte_listau.TabIndex = 36;
            // 
            // ibtneliminar
            // 
            this.ibtneliminar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.ibtneliminar.IconColor = System.Drawing.Color.Red;
            this.ibtneliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtneliminar.Location = new System.Drawing.Point(130, 485);
            this.ibtneliminar.Name = "ibtneliminar";
            this.ibtneliminar.Size = new System.Drawing.Size(86, 70);
            this.ibtneliminar.TabIndex = 49;
            this.ibtneliminar.Text = "Eliminar";
            this.ibtneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtneliminar.UseVisualStyleBackColor = true;
            // 
            // ibtnsave
            // 
            this.ibtnsave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.ibtnsave.IconColor = System.Drawing.Color.ForestGreen;
            this.ibtnsave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnsave.Location = new System.Drawing.Point(13, 485);
            this.ibtnsave.Name = "ibtnsave";
            this.ibtnsave.Size = new System.Drawing.Size(86, 70);
            this.ibtnsave.TabIndex = 48;
            this.ibtnsave.Text = "Guardar";
            this.ibtnsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtnsave.UseVisualStyleBackColor = true;
            // 
            // cboestado
            // 
            this.cboestado.FormattingEnabled = true;
            this.cboestado.Location = new System.Drawing.Point(11, 396);
            this.cboestado.Name = "cboestado";
            this.cboestado.Size = new System.Drawing.Size(205, 24);
            this.cboestado.TabIndex = 47;
            // 
            // lbestado
            // 
            this.lbestado.AutoSize = true;
            this.lbestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbestado.Location = new System.Drawing.Point(7, 373);
            this.lbestado.Name = "lbestado";
            this.lbestado.Size = new System.Drawing.Size(73, 20);
            this.lbestado.TabIndex = 46;
            this.lbestado.Text = "Estado:";
            // 
            // cborol
            // 
            this.cborol.FormattingEnabled = true;
            this.cborol.Location = new System.Drawing.Point(11, 332);
            this.cborol.Name = "cborol";
            this.cborol.Size = new System.Drawing.Size(205, 24);
            this.cborol.TabIndex = 45;
            // 
            // lbrol
            // 
            this.lbrol.AutoSize = true;
            this.lbrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrol.Location = new System.Drawing.Point(7, 309);
            this.lbrol.Name = "lbrol";
            this.lbrol.Size = new System.Drawing.Size(49, 20);
            this.lbrol.TabIndex = 44;
            this.lbrol.Text = "Rol :";
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(11, 269);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(205, 22);
            this.txtcorreo.TabIndex = 43;
            // 
            // lbcorreo
            // 
            this.lbcorreo.AutoSize = true;
            this.lbcorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcorreo.Location = new System.Drawing.Point(7, 246);
            this.lbcorreo.Name = "lbcorreo";
            this.lbcorreo.Size = new System.Drawing.Size(72, 20);
            this.lbcorreo.TabIndex = 42;
            this.lbcorreo.Text = "Correo:";
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(11, 206);
            this.txtclave.Name = "txtclave";
            this.txtclave.PasswordChar = '*';
            this.txtclave.Size = new System.Drawing.Size(205, 22);
            this.txtclave.TabIndex = 41;
            // 
            // lbclave
            // 
            this.lbclave.AutoSize = true;
            this.lbclave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbclave.Location = new System.Drawing.Point(7, 183);
            this.lbclave.Name = "lbclave";
            this.lbclave.Size = new System.Drawing.Size(111, 20);
            this.lbclave.TabIndex = 40;
            this.lbclave.Text = "Contraseña:";
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(7, 143);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(205, 22);
            this.txtphone.TabIndex = 39;
            // 
            // lbphone
            // 
            this.lbphone.AutoSize = true;
            this.lbphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbphone.Location = new System.Drawing.Point(3, 120);
            this.lbphone.Name = "lbphone";
            this.lbphone.Size = new System.Drawing.Size(87, 20);
            this.lbphone.TabIndex = 38;
            this.lbphone.Text = "Telefono:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(7, 84);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(205, 22);
            this.txtNombre.TabIndex = 37;
            // 
            // lbNU
            // 
            this.lbNU.AutoSize = true;
            this.lbNU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNU.Location = new System.Drawing.Point(3, 61);
            this.lbNU.Name = "lbNU";
            this.lbNU.Size = new System.Drawing.Size(151, 20);
            this.lbNU.TabIndex = 8;
            this.lbNU.Text = "Nombre Usuario:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 630);
            this.label1.TabIndex = 7;
            this.label1.Text = "Datos de registro";
            // 
            // ibtnlimpiar
            // 
            this.ibtnlimpiar.IconChar = FontAwesome.Sharp.IconChar.Brush;
            this.ibtnlimpiar.IconColor = System.Drawing.Color.Black;
            this.ibtnlimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnlimpiar.IconSize = 30;
            this.ibtnlimpiar.Location = new System.Drawing.Point(978, 40);
            this.ibtnlimpiar.Name = "ibtnlimpiar";
            this.ibtnlimpiar.Size = new System.Drawing.Size(40, 43);
            this.ibtnlimpiar.TabIndex = 6;
            this.ibtnlimpiar.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(609, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(125, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(740, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 22);
            this.textBox1.TabIndex = 4;
            // 
            // lbbuscar
            // 
            this.lbbuscar.AutoSize = true;
            this.lbbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbuscar.Location = new System.Drawing.Point(513, 50);
            this.lbbuscar.Name = "lbbuscar";
            this.lbbuscar.Size = new System.Drawing.Size(97, 20);
            this.lbbuscar.TabIndex = 3;
            this.lbbuscar.Text = "Buscar por:";
            // 
            // ibtnbusca
            // 
            this.ibtnbusca.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.ibtnbusca.IconColor = System.Drawing.Color.Black;
            this.ibtnbusca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnbusca.IconSize = 30;
            this.ibtnbusca.Location = new System.Drawing.Point(932, 40);
            this.ibtnbusca.Name = "ibtnbusca";
            this.ibtnbusca.Size = new System.Drawing.Size(40, 43);
            this.ibtnbusca.TabIndex = 2;
            this.ibtnbusca.UseVisualStyleBackColor = true;
            // 
            // lbtitulolistausuario
            // 
            this.lbtitulolistausuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitulolistausuario.Location = new System.Drawing.Point(250, 8);
            this.lbtitulolistausuario.Name = "lbtitulolistausuario";
            this.lbtitulolistausuario.Size = new System.Drawing.Size(824, 92);
            this.lbtitulolistausuario.TabIndex = 1;
            this.lbtitulolistausuario.Text = "LISTA DE USUARIOS:";
            // 
            // dgvusuario
            // 
            this.dgvusuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvusuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvbtnselecionar,
            this.Id_Usuario,
            this.NombreU,
            this.Telefono,
            this.Correo,
            this.Clave,
            this.id_rol,
            this.descripcion,
            this.Estado_Valor,
            this.estado});
            this.dgvusuario.Location = new System.Drawing.Point(250, 103);
            this.dgvusuario.Name = "dgvusuario";
            this.dgvusuario.RowHeadersWidth = 51;
            this.dgvusuario.Size = new System.Drawing.Size(819, 532);
            this.dgvusuario.TabIndex = 0;
            this.dgvusuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvusuario_CellContentClick);
            // 
            // dgvbtnselecionar
            // 
            this.dgvbtnselecionar.HeaderText = "";
            this.dgvbtnselecionar.MinimumWidth = 6;
            this.dgvbtnselecionar.Name = "dgvbtnselecionar";
            this.dgvbtnselecionar.Width = 30;
            // 
            // Id_Usuario
            // 
            this.Id_Usuario.HeaderText = "Id Usuario";
            this.Id_Usuario.MinimumWidth = 6;
            this.Id_Usuario.Name = "Id_Usuario";
            this.Id_Usuario.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Id_Usuario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Id_Usuario.Visible = false;
            this.Id_Usuario.Width = 125;
            // 
            // NombreU
            // 
            this.NombreU.HeaderText = "Nombre Usuario";
            this.NombreU.MinimumWidth = 6;
            this.NombreU.Name = "NombreU";
            this.NombreU.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NombreU.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NombreU.Width = 125;
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
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 6;
            this.Correo.Name = "Correo";
            this.Correo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Correo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Correo.Width = 125;
            // 
            // Clave
            // 
            this.Clave.HeaderText = "Clave";
            this.Clave.MinimumWidth = 6;
            this.Clave.Name = "Clave";
            this.Clave.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Clave.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Clave.Width = 125;
            // 
            // id_rol
            // 
            this.id_rol.HeaderText = "ID ROL";
            this.id_rol.MinimumWidth = 6;
            this.id_rol.Name = "id_rol";
            this.id_rol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id_rol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id_rol.Visible = false;
            this.id_rol.Width = 125;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Rol";
            this.descripcion.MinimumWidth = 6;
            this.descripcion.Name = "descripcion";
            this.descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.descripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.descripcion.Width = 125;
            // 
            // Estado_Valor
            // 
            this.Estado_Valor.HeaderText = "Estado Valor";
            this.Estado_Valor.MinimumWidth = 6;
            this.Estado_Valor.Name = "Estado_Valor";
            this.Estado_Valor.Visible = false;
            this.Estado_Valor.Width = 125;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.MinimumWidth = 6;
            this.estado.Name = "estado";
            this.estado.Width = 125;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 630);
            this.Controls.Add(this.conte_listau);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmUsuario";
            this.Text = "frmUsuario";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            this.conte_listau.ResumeLayout(false);
            this.conte_listau.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel conte_listau;
        private System.Windows.Forms.Label lbtitulolistausuario;
        private System.Windows.Forms.DataGridView dgvusuario;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbbuscar;
        private FontAwesome.Sharp.IconButton ibtnbusca;
        private FontAwesome.Sharp.IconButton ibtnlimpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbNU;
        private FontAwesome.Sharp.IconButton ibtnsave;
        private System.Windows.Forms.ComboBox cboestado;
        private System.Windows.Forms.Label lbestado;
        private System.Windows.Forms.ComboBox cborol;
        private System.Windows.Forms.Label lbrol;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.Label lbcorreo;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.Label lbclave;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Label lbphone;
        private FontAwesome.Sharp.IconButton ibtneliminar;
        private System.Windows.Forms.DataGridViewButtonColumn dgvbtnselecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado_Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}