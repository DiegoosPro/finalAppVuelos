namespace AppVuelos
{
    partial class frmPersonalizados
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.cmbroles = new System.Windows.Forms.ComboBox();
            this.tAB_ROLESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bddvuelosDataSet = new AppVuelos.bddvuelosDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.tAB_ROLESTableAdapter = new AppVuelos.bddvuelosDataSetTableAdapters.TAB_ROLESTableAdapter();
            this.tableAdapterManager = new AppVuelos.bddvuelosDataSetTableAdapters.TableAdapterManager();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbvuelosre = new System.Windows.Forms.ComboBox();
            this.tAB_AEROPUERTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btngenerarvuelos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tAB_AEROPUERTOSTableAdapter = new AppVuelos.bddvuelosDataSetTableAdapters.TAB_AEROPUERTOSTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tAB_VUELOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tAB_VUELOSTableAdapter = new AppVuelos.bddvuelosDataSetTableAdapters.TAB_VUELOSTableAdapter();
            this.dateTimeFechaS = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFechaL = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_ROLESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bddvuelosDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_AEROPUERTOSBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_VUELOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGenerar);
            this.groupBox1.Controls.Add(this.cmbroles);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(53, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Con Parametros";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(284, 34);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbroles
            // 
            this.cmbroles.DataSource = this.tAB_ROLESBindingSource;
            this.cmbroles.DisplayMember = "rol";
            this.cmbroles.FormattingEnabled = true;
            this.cmbroles.Location = new System.Drawing.Point(148, 36);
            this.cmbroles.Name = "cmbroles";
            this.cmbroles.Size = new System.Drawing.Size(121, 21);
            this.cmbroles.TabIndex = 1;
            this.cmbroles.ValueMember = "id_rol";
            this.cmbroles.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tAB_ROLESBindingSource
            // 
            this.tAB_ROLESBindingSource.DataMember = "TAB_ROLES";
            this.tAB_ROLESBindingSource.DataSource = this.bddvuelosDataSet;
            // 
            // bddvuelosDataSet
            // 
            this.bddvuelosDataSet.DataSetName = "bddvuelosDataSet";
            this.bddvuelosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione Rol De Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tAB_ROLESTableAdapter
            // 
            this.tAB_ROLESTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TAB_AEROPUERTOSTableAdapter = null;
            this.tableAdapterManager.TAB_CIUDADESTableAdapter = null;
            this.tableAdapterManager.TAB_CLIENTESTableAdapter = null;
            this.tableAdapterManager.TAB_PAISESTableAdapter = null;
            this.tableAdapterManager.TAB_PLAZASTableAdapter = null;
            this.tableAdapterManager.TAB_RESERVACIONESTableAdapter = null;
            this.tableAdapterManager.TAB_ROLESTableAdapter = this.tAB_ROLESTableAdapter;
            this.tableAdapterManager.TAB_TARJETAS_EMBARQUETableAdapter = null;
            this.tableAdapterManager.TAB_USUARIOSTableAdapter = null;
            this.tableAdapterManager.TAB_VUELOSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AppVuelos.bddvuelosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbvuelosre);
            this.groupBox2.Controls.Add(this.btngenerarvuelos);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(53, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 130);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Con Parametros";
            // 
            // cmbvuelosre
            // 
            this.cmbvuelosre.DataSource = this.tAB_AEROPUERTOSBindingSource;
            this.cmbvuelosre.DisplayMember = "CODIGO_AEROPUERTO";
            this.cmbvuelosre.FormattingEnabled = true;
            this.cmbvuelosre.Location = new System.Drawing.Point(148, 34);
            this.cmbvuelosre.Name = "cmbvuelosre";
            this.cmbvuelosre.Size = new System.Drawing.Size(121, 21);
            this.cmbvuelosre.TabIndex = 4;
            this.cmbvuelosre.ValueMember = "ID_AEROPUERTO";
            this.cmbvuelosre.SelectedIndexChanged += new System.EventHandler(this.cmbvuelosre_SelectedIndexChanged);
            // 
            // tAB_AEROPUERTOSBindingSource
            // 
            this.tAB_AEROPUERTOSBindingSource.DataMember = "TAB_AEROPUERTOS";
            this.tAB_AEROPUERTOSBindingSource.DataSource = this.bddvuelosDataSet;
            // 
            // btngenerarvuelos
            // 
            this.btngenerarvuelos.Location = new System.Drawing.Point(284, 34);
            this.btngenerarvuelos.Name = "btngenerarvuelos";
            this.btngenerarvuelos.Size = new System.Drawing.Size(75, 23);
            this.btngenerarvuelos.TabIndex = 2;
            this.btngenerarvuelos.Text = "Generar";
            this.btngenerarvuelos.UseVisualStyleBackColor = true;
            this.btngenerarvuelos.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Seleccione Reporte Vuelos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tAB_AEROPUERTOSTableAdapter
            // 
            this.tAB_AEROPUERTOSTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateTimeFechaL);
            this.groupBox3.Controls.Add(this.dateTimeFechaS);
            this.groupBox3.Controls.Add(this.btnGen);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(456, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(397, 130);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Con Parametros";
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(316, 90);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(75, 23);
            this.btnGen.TabIndex = 2;
            this.btnGen.Text = "Generar";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Seleccione Reporte Fecha";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tAB_VUELOSBindingSource
            // 
            this.tAB_VUELOSBindingSource.DataMember = "TAB_VUELOS";
            this.tAB_VUELOSBindingSource.DataSource = this.bddvuelosDataSet;
            // 
            // tAB_VUELOSTableAdapter
            // 
            this.tAB_VUELOSTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimeFechaS
            // 
            this.dateTimeFechaS.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tAB_VUELOSBindingSource, "FECHA_SALIDA", true));
            this.dateTimeFechaS.Location = new System.Drawing.Point(147, 37);
            this.dateTimeFechaS.Name = "dateTimeFechaS";
            this.dateTimeFechaS.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFechaS.TabIndex = 6;
            this.dateTimeFechaS.ValueChanged += new System.EventHandler(this.dateTimeFechaS_ValueChanged);
            // 
            // dateTimeFechaL
            // 
            this.dateTimeFechaL.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tAB_VUELOSBindingSource, "FECHA_LLEGADA", true));
            this.dateTimeFechaL.Location = new System.Drawing.Point(147, 64);
            this.dateTimeFechaL.Name = "dateTimeFechaL";
            this.dateTimeFechaL.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFechaL.TabIndex = 7;
            // 
            // frmPersonalizados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 285);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPersonalizados";
            this.Text = "frmPersonalizados";
            this.Load += new System.EventHandler(this.frmPersonalizados_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_ROLESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bddvuelosDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_AEROPUERTOSBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_VUELOSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbroles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerar;
        private bddvuelosDataSet bddvuelosDataSet;
        private System.Windows.Forms.BindingSource tAB_ROLESBindingSource;
        private bddvuelosDataSetTableAdapters.TAB_ROLESTableAdapter tAB_ROLESTableAdapter;
        private bddvuelosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbvuelosre;
        private System.Windows.Forms.Button btngenerarvuelos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource tAB_AEROPUERTOSBindingSource;
        private bddvuelosDataSetTableAdapters.TAB_AEROPUERTOSTableAdapter tAB_AEROPUERTOSTableAdapter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource tAB_VUELOSBindingSource;
        private bddvuelosDataSetTableAdapters.TAB_VUELOSTableAdapter tAB_VUELOSTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimeFechaL;
        private System.Windows.Forms.DateTimePicker dateTimeFechaS;
    }
}