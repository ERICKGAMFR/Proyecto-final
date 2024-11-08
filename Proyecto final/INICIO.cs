﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using CapaEntidades;
//using CapaNegocios;
using FontAwesome.Sharp;

namespace Proyecto_final
{
    public partial class INICIO : Form
    {
        private static IconButton a = null;
        private static Form FormularioActivo = null;

        public INICIO()
        {
            InitializeComponent();
        }

        private void INICIO_Load(object sender, EventArgs e)
        {
            Con_botonee.BackColor = Color.SlateGray;
        }

        
        private void Abrirformulariobtn(IconButton b, Form formulario)
        {
           
            if (a != null)
            {
                a.BackColor = Color.White; 
            }

            
            b.BackColor = Color.DarkGray;
            a = b;

           
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            
            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

           
            Contenedor.Controls.Clear();

            
            Contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        
        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void btnusuario_Click(object sender, EventArgs e)
        {
            Abrirformulariobtn(ibtnusuario, new frmUsuario());
        }

        
        private void ibtnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void ibtnvisita_Click(object sender, EventArgs e)
        {
            Abrirformulariobtn(ibtnvisita, new frmregistar_Visitantes());
        }

        
        private void ibtnmiembros_Click(object sender, EventArgs e)
        {
            Abrirformulariobtn(ibtnmiembros, new frmMienbros());
        }

       
        private void ibtnventas_Click(object sender, EventArgs e)
        {
            Abrirformulariobtn(ibtnventas, new frmVenta());
        }

        
        private void ibtninventario_Click(object sender, EventArgs e)
        {
            Abrirformulariobtn(ibtninventario, new frmProducto());
        }

        
        private void iconButton1_Click(object sender, EventArgs e)
        {
           
            Contenedor.Controls.Clear();
            Contenedor.BackColor = Color.White;

            
            if (a != null)
            {
                a.BackColor = Color.White; 
                a = null; 
            }

            
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
                FormularioActivo = null;
            }
        }
    }
}

