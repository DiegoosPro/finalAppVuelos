namespace AppVuelos
{
    partial class frmRepVueloReservacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bddvuelosDataSet = new AppVuelos.bddvuelosDataSet();
            this.VuelosReservacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VuelosReservacionTableAdapter = new AppVuelos.bddvuelosDataSetTableAdapters.VuelosReservacionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bddvuelosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VuelosReservacionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.VuelosReservacionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AppVuelos.RepVueloReservacion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(148, 35);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // bddvuelosDataSet
            // 
            this.bddvuelosDataSet.DataSetName = "bddvuelosDataSet";
            this.bddvuelosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VuelosReservacionBindingSource
            // 
            this.VuelosReservacionBindingSource.DataMember = "VuelosReservacion";
            this.VuelosReservacionBindingSource.DataSource = this.bddvuelosDataSet;
            // 
            // VuelosReservacionTableAdapter
            // 
            this.VuelosReservacionTableAdapter.ClearBeforeFill = true;
            // 
            // frmRepVueloReservacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 301);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRepVueloReservacion";
            this.Text = "frmRepVueloReservacion";
            this.Load += new System.EventHandler(this.frmRepVueloReservacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bddvuelosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VuelosReservacionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VuelosReservacionBindingSource;
        private bddvuelosDataSet bddvuelosDataSet;
        private bddvuelosDataSetTableAdapters.VuelosReservacionTableAdapter VuelosReservacionTableAdapter;

    }
}