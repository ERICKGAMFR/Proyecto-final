
namespace Proyecto_final
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btncancelar = new FontAwesome.Sharp.IconButton();
            this.btningresar = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lbNombreUsuario = new System.Windows.Forms.Label();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.txtnomusuario = new System.Windows.Forms.TextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.DimGray;
            this.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.IconChar = FontAwesome.Sharp.IconChar.CircleXmark;
            this.btncancelar.IconColor = System.Drawing.Color.White;
            this.btncancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncancelar.IconSize = 21;
            this.btncancelar.Location = new System.Drawing.Point(431, 195);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(132, 57);
            this.btncancelar.TabIndex = 17;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btningresar
            // 
            this.btningresar.BackColor = System.Drawing.Color.Gray;
            this.btningresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btningresar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btningresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btningresar.ForeColor = System.Drawing.Color.White;
            this.btningresar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btningresar.IconColor = System.Drawing.Color.White;
            this.btningresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btningresar.IconSize = 21;
            this.btningresar.Location = new System.Drawing.Point(269, 195);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(132, 57);
            this.btningresar.TabIndex = 16;
            this.btningresar.Text = "INGRESAR";
            this.btningresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btningresar.UseVisualStyleBackColor = false;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Contraseña";
            // 
            // lbNombreUsuario
            // 
            this.lbNombreUsuario.AutoSize = true;
            this.lbNombreUsuario.Location = new System.Drawing.Point(266, 25);
            this.lbNombreUsuario.Name = "lbNombreUsuario";
            this.lbNombreUsuario.Size = new System.Drawing.Size(131, 17);
            this.lbNombreUsuario.TabIndex = 14;
            this.lbNombreUsuario.Text = "Nombre de Usuario";
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(268, 106);
            this.txtclave.Name = "txtclave";
            this.txtclave.PasswordChar = '*';
            this.txtclave.Size = new System.Drawing.Size(295, 22);
            this.txtclave.TabIndex = 13;
            // 
            // txtnomusuario
            // 
            this.txtnomusuario.Location = new System.Drawing.Point(269, 45);
            this.txtnomusuario.Name = "txtnomusuario";
            this.txtnomusuario.Size = new System.Drawing.Size(295, 22);
            this.txtnomusuario.TabIndex = 12;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Gray;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserLock;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 153;
            this.iconPictureBox1.Location = new System.Drawing.Point(43, 37);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(153, 158);
            this.iconPictureBox1.TabIndex = 11;
            this.iconPictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "GYM REGISTRO";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 319);
            this.label1.TabIndex = 9;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(606, 319);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbNombreUsuario);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.txtnomusuario);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btncancelar;
        private FontAwesome.Sharp.IconButton btningresar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbNombreUsuario;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.TextBox txtnomusuario;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

