
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
            this.submenuvisitantes = new FontAwesome.Sharp.IconMenuItem();
            this.submenuvervisitantes = new FontAwesome.Sharp.IconMenuItem();
            this.menumiembros = new FontAwesome.Sharp.IconMenuItem();
            this.submenumiembros = new FontAwesome.Sharp.IconMenuItem();
            this.submenuvermiembros = new FontAwesome.Sharp.IconMenuItem();
            this.menumantenedor = new FontAwesome.Sharp.IconMenuItem();
            this.submenucategoria = new FontAwesome.Sharp.IconMenuItem();
            this.submenuproducto = new FontAwesome.Sharp.IconMenuItem();
            this.menureportes = new FontAwesome.Sharp.IconMenuItem();
            this.menuacercade = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.Contenedor = new System.Windows.Forms.Panel();
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
            this.lbtitulo.Location = new System.Drawing.Point(12, 18);
            this.lbtitulo.Name = "lbtitulo";
            this.lbtitulo.Size = new System.Drawing.Size(280, 33);
            this.lbtitulo.TabIndex = 8;
            this.lbtitulo.Text = "SISTEMA DE VENTAS";
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuusuarios,
            this.menuventas,
            this.menuvisitas,
            this.menumiembros,
            this.menumantenedor,
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
            this.submenuregitarventa.Size = new System.Drawing.Size(180, 26);
            this.submenuregitarventa.Text = "REGISTAR";
            // 
            // submenuverdetalleventa
            // 
            this.submenuverdetalleventa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuverdetalleventa.IconColor = System.Drawing.Color.Black;
            this.submenuverdetalleventa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuverdetalleventa.Name = "submenuverdetalleventa";
            this.submenuverdetalleventa.Size = new System.Drawing.Size(180, 26);
            this.submenuverdetalleventa.Text = "VER DETALLE";
            // 
            // menuvisitas
            // 
            this.menuvisitas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuvisitantes,
            this.submenuvervisitantes});
            this.menuvisitas.IconChar = FontAwesome.Sharp.IconChar.UserClock;
            this.menuvisitas.IconColor = System.Drawing.Color.Black;
            this.menuvisitas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuvisitas.IconSize = 50;
            this.menuvisitas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuvisitas.Name = "menuvisitas";
            this.menuvisitas.Size = new System.Drawing.Size(86, 74);
            this.menuvisitas.Text = "Visitantes";
            this.menuvisitas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // submenuvisitantes
            // 
            this.submenuvisitantes.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuvisitantes.IconColor = System.Drawing.Color.Black;
            this.submenuvisitantes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuvisitantes.Name = "submenuvisitantes";
            this.submenuvisitantes.Size = new System.Drawing.Size(180, 26);
            this.submenuvisitantes.Text = "Registra";
            // 
            // submenuvervisitantes
            // 
            this.submenuvervisitantes.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuvervisitantes.IconColor = System.Drawing.Color.Black;
            this.submenuvervisitantes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuvervisitantes.Name = "submenuvervisitantes";
            this.submenuvervisitantes.Size = new System.Drawing.Size(180, 26);
            this.submenuvervisitantes.Text = "Ver Visitantes";
            // 
            // menumiembros
            // 
            this.menumiembros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenumiembros,
            this.submenuvermiembros});
            this.menumiembros.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.menumiembros.IconColor = System.Drawing.Color.Black;
            this.menumiembros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menumiembros.IconSize = 50;
            this.menumiembros.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menumiembros.Name = "menumiembros";
            this.menumiembros.Size = new System.Drawing.Size(90, 74);
            this.menumiembros.Text = "Miembros";
            this.menumiembros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // submenumiembros
            // 
            this.submenumiembros.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenumiembros.IconColor = System.Drawing.Color.Black;
            this.submenumiembros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenumiembros.Name = "submenumiembros";
            this.submenumiembros.Size = new System.Drawing.Size(184, 26);
            this.submenumiembros.Text = "Registra";
            // 
            // submenuvermiembros
            // 
            this.submenuvermiembros.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuvermiembros.IconColor = System.Drawing.Color.Black;
            this.submenuvermiembros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuvermiembros.Name = "submenuvermiembros";
            this.submenuvermiembros.Size = new System.Drawing.Size(184, 26);
            this.submenuvermiembros.Text = "Ver Miembros";
            // 
            // menumantenedor
            // 
            this.menumantenedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenucategoria,
            this.submenuproducto});
            this.menumantenedor.IconChar = FontAwesome.Sharp.IconChar.Inbox;
            this.menumantenedor.IconColor = System.Drawing.Color.Black;
            this.menumantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menumantenedor.IconSize = 50;
            this.menumantenedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menumantenedor.Name = "menumantenedor";
            this.menumantenedor.Size = new System.Drawing.Size(89, 74);
            this.menumantenedor.Text = "Inventario";
            this.menumantenedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // submenucategoria
            // 
            this.submenucategoria.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenucategoria.IconColor = System.Drawing.Color.Black;
            this.submenucategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenucategoria.Name = "submenucategoria";
            this.submenucategoria.Size = new System.Drawing.Size(170, 26);
            this.submenucategoria.Text = "CATEGORIA";
            // 
            // submenuproducto
            // 
            this.submenuproducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuproducto.IconColor = System.Drawing.Color.Black;
            this.submenuproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuproducto.Name = "submenuproducto";
            this.submenuproducto.Size = new System.Drawing.Size(170, 26);
            this.submenuproducto.Text = "PRODUCTO";
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
            // INICIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 476);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.lbtitulo);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.menutitulo);
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
        private FontAwesome.Sharp.IconMenuItem menumantenedor;
        private FontAwesome.Sharp.IconMenuItem submenucategoria;
        private FontAwesome.Sharp.IconMenuItem submenuproducto;
        private FontAwesome.Sharp.IconMenuItem menuventas;
        private FontAwesome.Sharp.IconMenuItem submenuregitarventa;
        private FontAwesome.Sharp.IconMenuItem submenuverdetalleventa;
        private FontAwesome.Sharp.IconMenuItem menumiembros;
        private FontAwesome.Sharp.IconMenuItem menureportes;
        private FontAwesome.Sharp.IconMenuItem menuacercade;
        private FontAwesome.Sharp.IconMenuItem submenumiembros;
        private FontAwesome.Sharp.IconMenuItem submenuvermiembros;
        private FontAwesome.Sharp.IconMenuItem menuvisitas;
        private FontAwesome.Sharp.IconMenuItem submenuvisitantes;
        private FontAwesome.Sharp.IconMenuItem submenuvervisitantes;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private System.Windows.Forms.Panel Contenedor;
    }
}