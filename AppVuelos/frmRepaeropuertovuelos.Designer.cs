namespace AppVuelos
{
    partial class frmRepaeropuertovuelos
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
            this.Rep_aeropuertovueloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bddvuelosDataSet = new AppVuelos.bddvuelosDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Rep_aeropuertovueloTableAdapter = new AppVuelos.bddvuelosDataSetTableAdapters.Rep_aeropuertovueloTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Rep_aeropuertovueloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bddvuelosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Rep_aeropuertovueloBindingSource
            // 
            this.Rep_aeropuertovueloBindingSource.DataMember = "Rep_aeropuertovuelo";
            this.Rep_aeropuertovueloBindingSource.DataSource = this.bddvuelosDataSet;
            // 
            // bddvuelosDataSet
            // 
            this.bddvuelosDataSet.DataSetName = "bddvuelosDataSet";
            this.bddvuelosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Rep_aeropuertovueloBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AppVuelos.Repaeropuerto_vuelos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(82, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // Rep_aeropuertovueloTableAdapter
            // 
            this.Rep_aeropuertovueloTableAdapter.ClearBeforeFill = true;
            // 
            // frmRepaeropuertovuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 261);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRepaeropuertovuelos";
            this.Text = "frmRepaeropuertovuelos";
            this.Load += new System.EventHandler(this.frmRepaeropuertovuelos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Rep_aeropuertovueloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bddvuelosDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Rep_aeropuertovueloBindingSource;
        private bddvuelosDataSet bddvuelosDataSet;
        private bddvuelosDataSetTableAdapters.Rep_aeropuertovueloTableAdapter Rep_aeropuertovueloTableAdapter;
    }
}