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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void tAB_CLIENTESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tAB_CLIENTESBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bddvuelosDataSet);

        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bddvuelosDataSet.TAB_CLIENTES' Puede moverla o quitarla según sea necesario.
            this.tAB_CLIENTESTableAdapter.Fill(this.bddvuelosDataSet.TAB_CLIENTES);

        }

        private void tAB_CLIENTESDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
