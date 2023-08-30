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
    public partial class frmReservaciones : Form
    {
        public frmReservaciones()
        {
            InitializeComponent();
        }

        private void tAB_RESERVACIONESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tAB_RESERVACIONESBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bddvuelosDataSet);

        }

        private void frmReservaciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bddvuelosDataSet.TAB_TARJETAS_EMBARQUE' Puede moverla o quitarla según sea necesario.
            this.tAB_TARJETAS_EMBARQUETableAdapter.Fill(this.bddvuelosDataSet.TAB_TARJETAS_EMBARQUE);
            // TODO: esta línea de código carga datos en la tabla 'bddvuelosDataSet.TAB_VUELOS' Puede moverla o quitarla según sea necesario.
            this.tAB_VUELOSTableAdapter.Fill(this.bddvuelosDataSet.TAB_VUELOS);
            // TODO: esta línea de código carga datos en la tabla 'bddvuelosDataSet.TAB_CLIENTES' Puede moverla o quitarla según sea necesario.
            this.tAB_CLIENTESTableAdapter.Fill(this.bddvuelosDataSet.TAB_CLIENTES);
            // TODO: esta línea de código carga datos en la tabla 'bddvuelosDataSet.TAB_PLAZAS' Puede moverla o quitarla según sea necesario.
            this.tAB_PLAZASTableAdapter.Fill(this.bddvuelosDataSet.TAB_PLAZAS);
            // TODO: esta línea de código carga datos en la tabla 'bddvuelosDataSet.TAB_RESERVACIONES' Puede moverla o quitarla según sea necesario.
            this.tAB_RESERVACIONESTableAdapter.Fill(this.bddvuelosDataSet.TAB_RESERVACIONES);

        }

        private void sUBTOTALLabel_Click(object sender, EventArgs e)
        {

        }

        private void tAB_PLAZASDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iD_CLIENTEComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tAB_PLAZASDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7 && tAB_PLAZASDataGridView[7, e.RowIndex].Value != null)
            {
                calcularTotales();
            }
        }
            public void calcularTotales(){
                Decimal subTotal = 0;
                for (int i = 0; i < tAB_PLAZASDataGridView.Rows.Count - 1; i++)
                {

                    Decimal precio = Decimal.Parse(tAB_PLAZASDataGridView[7, i].Value.ToString());
                    subTotal += precio;

                }
                sUBTOTALTextBox.Text = subTotal.ToString();
                Decimal iva = Decimal.Multiply(subTotal, new Decimal(0.12));
                Decimal total = Decimal.Multiply(subTotal, new Decimal(1.12));
                iva = Math.Round(iva, 2);
                total = Math.Round(total, 2);
                iVATextBox.Text = iva.ToString();
                tOTALTextBox.Text = total.ToString();
        }
    }
}
