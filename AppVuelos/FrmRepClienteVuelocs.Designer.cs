namespace AppVuelos
{
    partial class FrmRepClienteVuelocs
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
            this.TAB_PAISESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TAB_PAISESTableAdapter = new AppVuelos.bddvuelosDataSetTableAdapters.TAB_PAISESTableAdapter();
            this.ClienteVueloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClienteVueloTableAdapter = new AppVuelos.bddvuelosDataSetTableAdapters.ClienteVueloTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bddvuelosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TAB_PAISESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteVueloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ClienteVueloBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AppVuelos.RepClienteVuelo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(45, 50);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(844, 397);
            this.reportViewer1.TabIndex = 0;
            // 
            // bddvuelosDataSet
            // 
            this.bddvuelosDataSet.DataSetName = "bddvuelosDataSet";
            this.bddvuelosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TAB_PAISESBindingSource
            // 
            this.TAB_PAISESBindingSource.DataMember = "TAB_PAISES";
            this.TAB_PAISESBindingSource.DataSource = this.bddvuelosDataSet;
            // 
            // TAB_PAISESTableAdapter
            // 
            this.TAB_PAISESTableAdapter.ClearBeforeFill = true;
            // 
            // ClienteVueloBindingSource
            // 
            this.ClienteVueloBindingSource.DataMember = "ClienteVuelo";
            this.ClienteVueloBindingSource.DataSource = this.bddvuelosDataSet;
            // 
            // ClienteVueloTableAdapter
            // 
            this.ClienteVueloTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRepClienteVuelocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 564);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRepClienteVuelocs";
            this.Text = "FrmRepClienteVuelocs";
            this.Load += new System.EventHandler(this.FrmRepClienteVuelocs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bddvuelosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TAB_PAISESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteVueloBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TAB_PAISESBindingSource;
        private bddvuelosDataSet bddvuelosDataSet;
        private bddvuelosDataSetTableAdapters.TAB_PAISESTableAdapter TAB_PAISESTableAdapter;
        private System.Windows.Forms.BindingSource ClienteVueloBindingSource;
        private bddvuelosDataSetTableAdapters.ClienteVueloTableAdapter ClienteVueloTableAdapter;

    }
}