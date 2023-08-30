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
    public partial class frmPersonalizados : Form
    {
        public frmPersonalizados()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRepUsuariosRoles usu = new frmRepUsuariosRoles(cmbroles.Text);
            usu.ShowDialog();
        }

        private void frmPersonalizados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bddvuelosDataSet.TAB_VUELOS' Puede moverla o quitarla según sea necesario.
            this.tAB_VUELOSTableAdapter.Fill(this.bddvuelosDataSet.TAB_VUELOS);
            // TODO: esta línea de código carga datos en la tabla 'bddvuelosDataSet.TAB_AEROPUERTOS' Puede moverla o quitarla según sea necesario.
            this.tAB_AEROPUERTOSTableAdapter.Fill(this.bddvuelosDataSet.TAB_AEROPUERTOS);
            // TODO: esta línea de código carga datos en la tabla 'bddvuelosDataSet.TAB_ROLES' Puede moverla o quitarla según sea necesario.
            this.tAB_ROLESTableAdapter.Fill(this.bddvuelosDataSet.TAB_ROLES);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmRepaeropuertovuelos usu = new frmRepaeropuertovuelos(cmbvuelosre.Text);
            usu.ShowDialog();
        }

        private void cmbvuelosre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmbFechaS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGen_Click(object sender, EventArgs e)
        {

            DateTime fechaSalidaSeleccionada = dateTimeFechaS.Value;
            DateTime fechaLlegadaSeleccionada = dateTimeFechaL.Value;

            frmRepVueloReservacion usu = new frmRepVueloReservacion(fechaSalidaSeleccionada, fechaLlegadaSeleccionada);
            usu.ShowDialog();

        }

        private void dateTimeFechaS_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
