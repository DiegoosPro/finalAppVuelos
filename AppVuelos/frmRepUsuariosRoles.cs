﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppVuelos
{
    public partial class frmRepUsuariosRoles : Form
    {
        string texto = "";
        public frmRepUsuariosRoles( string texto)
        {
            InitializeComponent();
            this.texto = texto;
        }

        private void frmRepUsuariosRoles_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bddvuelosDataSet.RepUsuarios' Puede moverla o quitarla según sea necesario.
            this.RepUsuariosTableAdapter.FillPUsuario(this.bddvuelosDataSet.RepUsuarios,texto);

            this.reportViewer1.RefreshReport();
        }
    }
}
