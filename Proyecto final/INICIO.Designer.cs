
namespace Proyecto_final
{
    partial class INICIO
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
            this.menutitulo = new System.Windows.Forms.MenuStrip();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbtitulo = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuusuarios = new FontAwesome.Sharp.IconMenuItem();
            this.menuventas = new FontAwesome.Sharp.IconMenuItem();
            this.submenuregitarventa = new FontAwesome.Sharp.IconMenuItem();
            this.submenuverdetalleventa = new FontAwesome.Sharp.IconMenuItem();
            this.menuvisitas = new FontAwesome.Sharp.IconMenuItem();
            this.menumiembros = new FontAwesome.Sharp.IconMenuItem();
            this.menuinventario = new FontAwesome.Sharp.IconMenuItem();
            this.submenucategoria = new FontAwesome.Sharp.IconMenuItem();
            this.submenuproducto = new FontAwesome.Sharp.IconMenuItem();
            this.menureportes = new FontAwesome.Sharp.IconMenuItem();
            this.menuacercade = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.btnsalir = new FontAwesome.Sharp.IconButton();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menutitulo
            // 
            this.menutitulo.AutoSize = false;
            this.menutitulo.BackColor = System.Drawing.Color.SlateGray;
            this.menutitulo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menutitulo.Location = new System.Drawing.Point(0, 0);
            this.menutitulo.Name = "menutitulo";
            this.menutitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menutitulo.Size = new System.Drawing.Size(1186, 73);
            this.menutitulo.TabIndex = 2;
            this.menutitulo.Text = "menuStrip2";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.Color.SlateGray;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.ForeColor = System.Drawing.Color.White;
            this.lblusuario.Location = new System.Drawing.Point(966, 28);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(71, 18);
            this.lblusuario.TabIndex = 7;
            this.lblusuario.Text = "lblusuario";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.BackColor = System.Drawing.Color.SlateGray;
            this.lbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.ForeColor = System.Drawing.Color.White;
            this.lbUsuario.Location = new System.Drawing.Point(882, 28);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(89, 18);
            this.lbUsuario.TabIndex = 6;
            this.lbUsuario.Text = "USUARIOS:";
            // 
            // lbtitulo
            // 
            this.lbtitulo.AutoSize = true;
            this.lbtitulo.BackColor = System.Drawing.Color.SlateGray;
            this.lbtitulo.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitulo.ForeColor = System.Drawing.Color.White;
            this.lbtitulo.Location = new System.Drawing.Point(58, 13);
            this.lbtitulo.Name = "lbtitulo";
            this.lbtitulo.Size = new System.Drawing.Size(248, 33);
            this.lbtitulo.TabIndex = 8;
            this.lbtitulo.Text = "Nombre del GYM";
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuusuarios,
            this.menuventas,
            this.menuvisitas,
            this.menumiembros,
            this.menuinventario,
            this.menureportes,
            this.menuacercade});
            this.menu.Location = new System.Drawing.Point(0, 73);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1186, 78);
            this.menu.TabIndex = 9;
            this.menu.Text = "menuStrip1";
            // 
            // menuusuarios
            // 
            this.menuusuarios.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.menuusuarios.IconColor = System.Drawing.Color.Black;
            this.menuusuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuusuarios.IconSize = 50;
            this.menuusuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuusuarios.Name = "menuusuarios";
            this.menuusuarios.Size = new System.Drawing.Size(79, 74);
            this.menuusuarios.Text = "Usuarios";
            this.menuusuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuusuarios.Click += new System.EventHandler(this.menuusuarios_Click);
            // 
            // menuventas
            // 
            this.menuventas.AutoSize = false;
            this.menuventas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuregitarventa,
            this.submenuverdetalleventa});
            this.menuventas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.menuventas.IconColor = System.Drawing.Color.Black;
            this.menuventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuventas.IconSize = 50;
            this.menuventas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuventas.Name = "menuventas";
            this.menuventas.Size = new System.Drawing.Size(80, 74);
            this.menuventas.Text = "Ventas";
            this.menuventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // submenuregitarventa
            // 
            this.submenuregitarventa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuregitarventa.IconColor = System.Drawing.Color.Black;
            this.submenuregitarventa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuregitarventa.Name = "submenuregitarventa";
            this.submenuregitarventa.Size = new System.Drawing.Size(224, 26);
            this.submenuregitarventa.Text = "REGISTAR";
            this.submenuregitarventa.Click += new System.EventHandler(this.submenuregitarventa_Click);
            // 
            // submenuverdetalleventa
            // 
            this.submenuverdetalleventa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuverdetalleventa.IconColor = System.Drawing.Color.Black;
            this.submenuverdetalleventa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuverdetalleventa.Name = "submenuverdetalleventa";
            this.submenuverdetalleventa.Size = new System.Drawing.Size(224, 26);
            this.submenuverdetalleventa.Text = "VER DETALLE";
            this.submenuverdetalleventa.Click += new System.EventHandler(this.submenuverdetalleventa_Click);
            // 
            // menuvisitas
            // 
            this.menuvisitas.IconChar = FontAwesome.Sharp.IconChar.UserClock;
            this.menuvisitas.IconColor = System.Drawing.Color.Black;
            this.menuvisitas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuvisitas.IconSize = 50;
            this.menuvisitas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuvisitas.Name = "menuvisitas";
            this.menuvisitas.Size = new System.Drawing.Size(86, 74);
            this.menuvisitas.Text = "Visitantes";
            this.menuvisitas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuvisitas.Click += new System.EventHandler(this.menuvisitas_Click);
            // 
            // menumiembros
            // 
            this.menumiembros.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.menumiembros.IconColor = System.Drawing.Color.Black;
            this.menumiembros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menumiembros.IconSize = 50;
            this.menumiembros.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menumiembros.Name = "menumiembros";
            this.menumiembros.Size = new System.Drawing.Size(90, 74);
            this.menumiembros.Text = "Miembros";
            this.menumiembros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menumiembros.Click += new System.EventHandler(this.menumiembros_Click);
            // 
            // menuinventario
            // 
            this.menuinventario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenucategoria,
            this.submenuproducto});
            this.menuinventario.IconChar = FontAwesome.Sharp.IconChar.Inbox;
            this.menuinventario.IconColor = System.Drawing.Color.Black;
            this.menuinventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuinventario.IconSize = 50;
            this.menuinventario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuinventario.Name = "menuinventario";
            this.menuinventario.Size = new System.Drawing.Size(89, 74);
            this.menuinventario.Text = "Inventario";
            this.menuinventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // submenucategoria
            // 
            this.submenucategoria.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenucategoria.IconColor = System.Drawing.Color.Black;
            this.submenucategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenucategoria.Name = "submenucategoria";
            this.submenucategoria.Size = new System.Drawing.Size(224, 26);
            this.submenucategoria.Text = "CATEGORIA";
            this.submenucategoria.Click += new System.EventHandler(this.submenucategoria_Click);
            // 
            // submenuproducto
            // 
            this.submenuproducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuproducto.IconColor = System.Drawing.Color.Black;
            this.submenuproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuproducto.Name = "submenuproducto";
            this.submenuproducto.Size = new System.Drawing.Size(224, 26);
            this.submenuproducto.Text = "PRODUCTO";
            this.submenuproducto.Click += new System.EventHandler(this.submenuproducto_Click);
            // 
            // menureportes
            // 
            this.menureportes.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.menureportes.IconColor = System.Drawing.Color.Black;
            this.menureportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menureportes.IconSize = 50;
            this.menureportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menureportes.Name = "menureportes";
            this.menureportes.Size = new System.Drawing.Size(82, 74);
            this.menureportes.Text = "Reportes";
            this.menureportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menureportes.Click += new System.EventHandler(this.menureportes_Click);
            // 
            // menuacercade
            // 
            this.menuacercade.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.menuacercade.IconColor = System.Drawing.Color.Black;
            this.menuacercade.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuacercade.IconSize = 50;
            this.menuacercade.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuacercade.Name = "menuacercade";
            this.menuacercade.Size = new System.Drawing.Size(101, 74);
            this.menuacercade.Text = "ACERCA DE";
            this.menuacercade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem1.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(32, 19);
            this.iconMenuItem1.Text = "iconMenuItem1";
            // 
            // Contenedor
            // 
            this.Contenedor.Location = new System.Drawing.Point(0, 154);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(1186, 324);
            this.Contenedor.TabIndex = 11;
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.SlateGray;
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalir.FlatAppearance.BorderSize = 0;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.IconChar = FontAwesome.Sharp.IconChar.LongArrowLeft;
            this.btnsalir.IconColor = System.Drawing.Color.Black;
            this.btnsalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsalir.Location = new System.Drawing.Point(12, 18);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(40, 28);
            this.btnsalir.TabIndex = 12;
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // INICIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 476);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.lbtitulo);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.menutitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "INICIO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INICIO";
            this.Load += new System.EventHandler(this.INICIO_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menutitulo;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbtitulo;
        private System.Windows.Forms.MenuStrip menu;
        private FontAwesome.Sharp.IconMenuItem menuusuarios;
        private FontAwesome.Sharp.IconMenuItem menuinventario;
        private FontAwesome.Sharp.IconMenuItem submenucategoria;
        private FontAwesome.Sharp.IconMenuItem submenuproducto;
        private FontAwesome.Sharp.IconMenuItem menuventas;
        private FontAwesome.Sharp.IconMenuItem submenuregitarventa;
        private FontAwesome.Sharp.IconMenuItem submenuverdetalleventa;
        private FontAwesome.Sharp.IconMenuItem menumiembros;
        private FontAwesome.Sharp.IconMenuItem menureportes;
        private FontAwesome.Sharp.IconMenuItem menuacercade;
        private FontAwesome.Sharp.IconMenuItem menuvisitas;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private System.Windows.Forms.Panel Contenedor;
        private FontAwesome.Sharp.IconButton btnsalir;
    }
}