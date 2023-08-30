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
    public partial class Autenticacion : Form
    {
        private bddvuelosDataSetTableAdapters.tab_usuariosTableAdapter uta = new bddvuelosDataSetTableAdapters.tab_usuariosTableAdapter();
        private bddvuelosDataSet.tab_usuariosDataTable tab_usuariosDataTable = new
        bddvuelosDataSet.tab_usuariosDataTable();
        public Autenticacion()
        {
            InitializeComponent();
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            object valuea = uta.FillByUsuarioClave(tab_usuariosDataTable, txtusuario.Text, txtcontraseña.Text);
            if (tab_usuariosDataTable.Rows.Count > 0)
            {

                bddvuelosDataSet.tab_usuariosRow row =
                (bddvuelosDataSet.tab_usuariosRow)tab_usuariosDataTable.Rows[0];
                MessageBox.Show("WELCOME " + row.username);
                Form1 frm = new Form1();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("ERROR datos incorrectos");
            }
        }

        private void Autenticacion_Load(object sender, EventArgs e)
        {

        }
    }
}
