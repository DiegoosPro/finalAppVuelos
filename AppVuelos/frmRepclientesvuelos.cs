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
    public partial class frmRepclientesvuelos : Form
    {
        public frmRepclientesvuelos()
        {
            InitializeComponent();
        }

        private void frmRepclientesvuelos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bddvuelosDataSet.clientes_vuelos' Puede moverla o quitarla según sea necesario.
            this.clientes_vuelosTableAdapter.Fillclientesvuelos(this.bddvuelosDataSet.clientes_vuelos);

            this.reportViewer1.RefreshReport();
        }
    }
}
