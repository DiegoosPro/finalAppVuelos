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
    public partial class frmRepPaises : Form
    {
        public frmRepPaises()
        {
            InitializeComponent();
        }

        private void frmRepPaises_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bddvuelosDataSet.TAB_PAISES' Puede moverla o quitarla según sea necesario.
            this.TAB_PAISESTableAdapter.Fill(this.bddvuelosDataSet.TAB_PAISES);

            this.reportViewer1.RefreshReport();
        }
    }
}
