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
    public partial class frmRepVueloReservacion : Form
    {
        DateTime fechaSalida;
        DateTime fechaLlegada;

        public frmRepVueloReservacion(DateTime fechaSalida, DateTime fechaLlegada)
        {
            InitializeComponent();
            this.fechaSalida = fechaSalida;
            this.fechaLlegada = fechaLlegada;
            
        }

        private void frmRepVueloReservacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bddvuelosDataSet.VuelosReservacion' Puede moverla o quitarla según sea necesario.
            this.VuelosReservacionTableAdapter.FillVueloReservacion(this.bddvuelosDataSet.VuelosReservacion, fechaSalida, fechaLlegada);

            this.reportViewer1.RefreshReport();
        }
    }
}
