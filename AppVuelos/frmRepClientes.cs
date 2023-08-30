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
    public partial class frmRepClientes : Form
    {
        public frmRepClientes()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmRepClientes rep = new frmRepClientes();
            rep.ShowDialog();
        }

        private void frmRepClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bddvuelosDataSet.TAB_CLIENTES' Puede moverla o quitarla según sea necesario.
            this.TAB_CLIENTESTableAdapter.Fill(this.bddvuelosDataSet.TAB_CLIENTES);

            this.reportViewer1.RefreshReport();
        }
    }
}
