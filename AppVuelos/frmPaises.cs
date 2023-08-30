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
    public partial class frmPaises : Form
    {
        public frmPaises()
        {
            InitializeComponent();
        }

        private void tAB_PAISESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tAB_PAISESBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bddvuelosDataSet);

        }

        private void frmPaises_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bddvuelosDataSet.TAB_CIUDADES' Puede moverla o quitarla según sea necesario.
            this.tAB_CIUDADESTableAdapter.Fill(this.bddvuelosDataSet.TAB_CIUDADES);
            // TODO: esta línea de código carga datos en la tabla 'bddvuelosDataSet.TAB_PAISES' Puede moverla o quitarla según sea necesario.
            this.tAB_PAISESTableAdapter.Fill(this.bddvuelosDataSet.TAB_PAISES);

        }
    }
}
