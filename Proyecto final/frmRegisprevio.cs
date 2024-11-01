﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_final.Utilidades;
using CapaEntidades;
using CapaNegocios;


namespace Proyecto_final
{
    public partial class frmRegisprevio : Form
    {
        private CN_USUARIOS objCD_USUARIO = new CN_USUARIOS();
        public frmRegisprevio()
        {
            InitializeComponent();
        }

        private void ibtnsave_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string phone = txtphone.Text;
            string clave = txtclave.Text;
            string correo = txtcorreo.Text;
            int id_rol = Convert.ToInt32(((optioncombo)cborol.SelectedItem).Valor);
            Boolean estado = Convert.ToInt32(((optioncombo)cboestado.SelectedItem).Valor) == 1 ? true : false;

            objCD_USUARIO.registrar(nombre, phone, clave, correo, id_rol, estado);


            this.Close();
        }
    }
    
}
