using System;
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
    public partial class frmRepaeropuertovuelos : Form
    {
        string texto = "";
        public frmRepaeropuertovuelos(string texto)
        {
            InitializeComponent();
            this.texto = texto;
        }

        private void frmRepaeropuertovuelos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bddvuelosDataSet.Rep_aeropuertovuelo' Puede moverla o quitarla según sea necesario.
            this.Rep_aeropuertovueloTableAdapter.Fillaeropuertovuelo(this.bddvuelosDataSet.Rep_aeropuertovuelo,texto);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
