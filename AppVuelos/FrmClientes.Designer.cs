namespace AppVuelos
{
    partial class frmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            System.Windows.Forms.Label iD_CLIENTELabel;
            System.Windows.Forms.Label nRO_IDENTIFICACIONLabel;
            System.Windows.Forms.Label nOMBRESLabel;
            System.Windows.Forms.Label aPELLIDOSLabel;
            System.Windows.Forms.Label dIRECCIONLabel;
            System.Windows.Forms.Label tELEFONOLabel;
            System.Windows.Forms.Label nRO_TARJETALabel;
            System.Windows.Forms.Label dATOSLabel;
            this.bddvuelosDataSet = new AppVuelos.bddvuelosDataSet();
            this.tAB_CLIENTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tAB_CLIENTESTableAdapter = new AppVuelos.bddvuelosDataSetTableAdapters.TAB_CLIENTESTableAdapter();
            this.tableAdapterManager = new AppVuelos.bddvuelosDataSetTableAdapters.TableAdapterManager();
            this.tAB_CLIENTESBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tAB_CLIENTESBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tAB_CLIENTESDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iD_CLIENTETextBox = new System.Windows.Forms.TextBox();
            this.nRO_IDENTIFICACIONTextBox = new System.Windows.Forms.TextBox();
            this.nOMBRESTextBox = new System.Windows.Forms.TextBox();
            this.aPELLIDOSTextBox = new System.Windows.Forms.TextBox();
            this.dIRECCIONTextBox = new System.Windows.Forms.TextBox();
            this.tELEFONOTextBox = new System.Windows.Forms.TextBox();
            this.nRO_TARJETATextBox = new System.Windows.Forms.TextBox();
            this.dATOSTextBox = new System.Windows.Forms.TextBox();
            iD_CLIENTELabel = new System.Windows.Forms.Label();
            nRO_IDENTIFICACIONLabel = new System.Windows.Forms.Label();
            nOMBRESLabel = new System.Windows.Forms.Label();
            aPELLIDOSLabel = new System.Windows.Forms.Label();
            dIRECCIONLabel = new System.Windows.Forms.Label();
            tELEFONOLabel = new System.Windows.Forms.Label();
            nRO_TARJETALabel = new System.Windows.Forms.Label();
            dATOSLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bddvuelosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_CLIENTESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_CLIENTESBindingNavigator)).BeginInit();
            this.tAB_CLIENTESBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_CLIENTESDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bddvuelosDataSet
            // 
            this.bddvuelosDataSet.DataSetName = "bddvuelosDataSet";
            this.bddvuelosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tAB_CLIENTESBindingSource
            // 
            this.tAB_CLIENTESBindingSource.DataMember = "TAB_CLIENTES";
            this.tAB_CLIENTESBindingSource.DataSource = this.bddvuelosDataSet;
            // 
            // tAB_CLIENTESTableAdapter
            // 
            this.tAB_CLIENTESTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TAB_AEROPUERTOSTableAdapter = null;
            this.tableAdapterManager.TAB_CIUDADESTableAdapter = null;
            this.tableAdapterManager.TAB_CLIENTESTableAdapter = this.tAB_CLIENTESTableAdapter;
            this.tableAdapterManager.TAB_PAISESTableAdapter = null;
            this.tableAdapterManager.TAB_PLAZASTableAdapter = null;
            this.tableAdapterManager.TAB_RESERVACIONESTableAdapter = null;
            this.tableAdapterManager.TAB_ROLESTableAdapter = null;
            this.tableAdapterManager.TAB_TARJETAS_EMBARQUETableAdapter = null;
            this.tableAdapterManager.TAB_USUARIOSTableAdapter = null;
            this.tableAdapterManager.TAB_VUELOSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AppVuelos.bddvuelosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tAB_CLIENTESBindingNavigator
            // 
            this.tAB_CLIENTESBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tAB_CLIENTESBindingNavigator.BindingSource = this.tAB_CLIENTESBindingSource;
            this.tAB_CLIENTESBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tAB_CLIENTESBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tAB_CLIENTESBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tAB_CLIENTESBindingNavigatorSaveItem});
            this.tAB_CLIENTESBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tAB_CLIENTESBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tAB_CLIENTESBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tAB_CLIENTESBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tAB_CLIENTESBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tAB_CLIENTESBindingNavigator.Name = "tAB_CLIENTESBindingNavigator";
            this.tAB_CLIENTESBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tAB_CLIENTESBindingNavigator.Size = new System.Drawing.Size(913, 25);
            this.tAB_CLIENTESBindingNavigator.TabIndex = 0;
            this.tAB_CLIENTESBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // tAB_CLIENTESBindingNavigatorSaveItem
            // 
            this.tAB_CLIENTESBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tAB_CLIENTESBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tAB_CLIENTESBindingNavigatorSaveItem.Image")));
            this.tAB_CLIENTESBindingNavigatorSaveItem.Name = "tAB_CLIENTESBindingNavigatorSaveItem";
            this.tAB_CLIENTESBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tAB_CLIENTESBindingNavigatorSaveItem.Text = "Guardar datos";
            this.tAB_CLIENTESBindingNavigatorSaveItem.Click += new System.EventHandler(this.tAB_CLIENTESBindingNavigatorSaveItem_Click);
            // 
            // tAB_CLIENTESDataGridView
            // 
            this.tAB_CLIENTESDataGridView.AutoGenerateColumns = false;
            this.tAB_CLIENTESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tAB_CLIENTESDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.tAB_CLIENTESDataGridView.DataSource = this.tAB_CLIENTESBindingSource;
            this.tAB_CLIENTESDataGridView.Location = new System.Drawing.Point(12, 255);
            this.tAB_CLIENTESDataGridView.Name = "tAB_CLIENTESDataGridView";
            this.tAB_CLIENTESDataGridView.Size = new System.Drawing.Size(863, 165);
            this.tAB_CLIENTESDataGridView.TabIndex = 1;
            this.tAB_CLIENTESDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tAB_CLIENTESDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_CLIENTE";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_CLIENTE";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NRO_IDENTIFICACION";
            this.dataGridViewTextBoxColumn2.HeaderText = "NRO_IDENTIFICACION";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NOMBRES";
            this.dataGridViewTextBoxColumn3.HeaderText = "NOMBRES";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "APELLIDOS";
            this.dataGridViewTextBoxColumn4.HeaderText = "APELLIDOS";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DIRECCION";
            this.dataGridViewTextBoxColumn5.HeaderText = "DIRECCION";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TELEFONO";
            this.dataGridViewTextBoxColumn6.HeaderText = "TELEFONO";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "NRO_TARJETA";
            this.dataGridViewTextBoxColumn7.HeaderText = "NRO_TARJETA";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DATOS";
            this.dataGridViewTextBoxColumn8.HeaderText = "DATOS";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // iD_CLIENTELabel
            // 
            iD_CLIENTELabel.AutoSize = true;
            iD_CLIENTELabel.Location = new System.Drawing.Point(204, 50);
            iD_CLIENTELabel.Name = "iD_CLIENTELabel";
            iD_CLIENTELabel.Size = new System.Drawing.Size(69, 13);
            iD_CLIENTELabel.TabIndex = 2;
            iD_CLIENTELabel.Text = "ID CLIENTE:";
            // 
            // iD_CLIENTETextBox
            // 
            this.iD_CLIENTETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_CLIENTESBindingSource, "ID_CLIENTE", true));
            this.iD_CLIENTETextBox.Location = new System.Drawing.Point(332, 47);
            this.iD_CLIENTETextBox.Name = "iD_CLIENTETextBox";
            this.iD_CLIENTETextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_CLIENTETextBox.TabIndex = 3;
            // 
            // nRO_IDENTIFICACIONLabel
            // 
            nRO_IDENTIFICACIONLabel.AutoSize = true;
            nRO_IDENTIFICACIONLabel.Location = new System.Drawing.Point(204, 76);
            nRO_IDENTIFICACIONLabel.Name = "nRO_IDENTIFICACIONLabel";
            nRO_IDENTIFICACIONLabel.Size = new System.Drawing.Size(122, 13);
            nRO_IDENTIFICACIONLabel.TabIndex = 4;
            nRO_IDENTIFICACIONLabel.Text = "NRO IDENTIFICACION:";
            // 
            // nRO_IDENTIFICACIONTextBox
            // 
            this.nRO_IDENTIFICACIONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_CLIENTESBindingSource, "NRO_IDENTIFICACION", true));
            this.nRO_IDENTIFICACIONTextBox.Location = new System.Drawing.Point(332, 73);
            this.nRO_IDENTIFICACIONTextBox.Name = "nRO_IDENTIFICACIONTextBox";
            this.nRO_IDENTIFICACIONTextBox.Size = new System.Drawing.Size(100, 20);
            this.nRO_IDENTIFICACIONTextBox.TabIndex = 5;
            // 
            // nOMBRESLabel
            // 
            nOMBRESLabel.AutoSize = true;
            nOMBRESLabel.Location = new System.Drawing.Point(204, 102);
            nOMBRESLabel.Name = "nOMBRESLabel";
            nOMBRESLabel.Size = new System.Drawing.Size(64, 13);
            nOMBRESLabel.TabIndex = 6;
            nOMBRESLabel.Text = "NOMBRES:";
            // 
            // nOMBRESTextBox
            // 
            this.nOMBRESTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_CLIENTESBindingSource, "NOMBRES", true));
            this.nOMBRESTextBox.Location = new System.Drawing.Point(332, 99);
            this.nOMBRESTextBox.Name = "nOMBRESTextBox";
            this.nOMBRESTextBox.Size = new System.Drawing.Size(100, 20);
            this.nOMBRESTextBox.TabIndex = 7;
            // 
            // aPELLIDOSLabel
            // 
            aPELLIDOSLabel.AutoSize = true;
            aPELLIDOSLabel.Location = new System.Drawing.Point(204, 128);
            aPELLIDOSLabel.Name = "aPELLIDOSLabel";
            aPELLIDOSLabel.Size = new System.Drawing.Size(69, 13);
            aPELLIDOSLabel.TabIndex = 8;
            aPELLIDOSLabel.Text = "APELLIDOS:";
            // 
            // aPELLIDOSTextBox
            // 
            this.aPELLIDOSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_CLIENTESBindingSource, "APELLIDOS", true));
            this.aPELLIDOSTextBox.Location = new System.Drawing.Point(332, 125);
            this.aPELLIDOSTextBox.Name = "aPELLIDOSTextBox";
            this.aPELLIDOSTextBox.Size = new System.Drawing.Size(100, 20);
            this.aPELLIDOSTextBox.TabIndex = 9;
            // 
            // dIRECCIONLabel
            // 
            dIRECCIONLabel.AutoSize = true;
            dIRECCIONLabel.Location = new System.Drawing.Point(204, 154);
            dIRECCIONLabel.Name = "dIRECCIONLabel";
            dIRECCIONLabel.Size = new System.Drawing.Size(69, 13);
            dIRECCIONLabel.TabIndex = 10;
            dIRECCIONLabel.Text = "DIRECCION:";
            // 
            // dIRECCIONTextBox
            // 
            this.dIRECCIONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_CLIENTESBindingSource, "DIRECCION", true));
            this.dIRECCIONTextBox.Location = new System.Drawing.Point(332, 151);
            this.dIRECCIONTextBox.Name = "dIRECCIONTextBox";
            this.dIRECCIONTextBox.Size = new System.Drawing.Size(100, 20);
            this.dIRECCIONTextBox.TabIndex = 11;
            // 
            // tELEFONOLabel
            // 
            tELEFONOLabel.AutoSize = true;
            tELEFONOLabel.Location = new System.Drawing.Point(204, 180);
            tELEFONOLabel.Name = "tELEFONOLabel";
            tELEFONOLabel.Size = new System.Drawing.Size(67, 13);
            tELEFONOLabel.TabIndex = 12;
            tELEFONOLabel.Text = "TELEFONO:";
            // 
            // tELEFONOTextBox
            // 
            this.tELEFONOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_CLIENTESBindingSource, "TELEFONO", true));
            this.tELEFONOTextBox.Location = new System.Drawing.Point(332, 177);
            this.tELEFONOTextBox.Name = "tELEFONOTextBox";
            this.tELEFONOTextBox.Size = new System.Drawing.Size(100, 20);
            this.tELEFONOTextBox.TabIndex = 13;
            // 
            // nRO_TARJETALabel
            // 
            nRO_TARJETALabel.AutoSize = true;
            nRO_TARJETALabel.Location = new System.Drawing.Point(204, 206);
            nRO_TARJETALabel.Name = "nRO_TARJETALabel";
            nRO_TARJETALabel.Size = new System.Drawing.Size(85, 13);
            nRO_TARJETALabel.TabIndex = 14;
            nRO_TARJETALabel.Text = "NRO TARJETA:";
            // 
            // nRO_TARJETATextBox
            // 
            this.nRO_TARJETATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_CLIENTESBindingSource, "NRO_TARJETA", true));
            this.nRO_TARJETATextBox.Location = new System.Drawing.Point(332, 203);
            this.nRO_TARJETATextBox.Name = "nRO_TARJETATextBox";
            this.nRO_TARJETATextBox.Size = new System.Drawing.Size(100, 20);
            this.nRO_TARJETATextBox.TabIndex = 15;
            // 
            // dATOSLabel
            // 
            dATOSLabel.AutoSize = true;
            dATOSLabel.Location = new System.Drawing.Point(204, 232);
            dATOSLabel.Name = "dATOSLabel";
            dATOSLabel.Size = new System.Drawing.Size(47, 13);
            dATOSLabel.TabIndex = 16;
            dATOSLabel.Text = "DATOS:";
            // 
            // dATOSTextBox
            // 
            this.dATOSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_CLIENTESBindingSource, "DATOS", true));
            this.dATOSTextBox.Location = new System.Drawing.Point(332, 229);
            this.dATOSTextBox.Name = "dATOSTextBox";
            this.dATOSTextBox.Size = new System.Drawing.Size(100, 20);
            this.dATOSTextBox.TabIndex = 17;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 432);
            this.Controls.Add(iD_CLIENTELabel);
            this.Controls.Add(this.iD_CLIENTETextBox);
            this.Controls.Add(nRO_IDENTIFICACIONLabel);
            this.Controls.Add(this.nRO_IDENTIFICACIONTextBox);
            this.Controls.Add(nOMBRESLabel);
            this.Controls.Add(this.nOMBRESTextBox);
            this.Controls.Add(aPELLIDOSLabel);
            this.Controls.Add(this.aPELLIDOSTextBox);
            this.Controls.Add(dIRECCIONLabel);
            this.Controls.Add(this.dIRECCIONTextBox);
            this.Controls.Add(tELEFONOLabel);
            this.Controls.Add(this.tELEFONOTextBox);
            this.Controls.Add(nRO_TARJETALabel);
            this.Controls.Add(this.nRO_TARJETATextBox);
            this.Controls.Add(dATOSLabel);
            this.Controls.Add(this.dATOSTextBox);
            this.Controls.Add(this.tAB_CLIENTESDataGridView);
            this.Controls.Add(this.tAB_CLIENTESBindingNavigator);
            this.Name = "frmClientes";
            this.Text = "frmClientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bddvuelosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_CLIENTESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_CLIENTESBindingNavigator)).EndInit();
            this.tAB_CLIENTESBindingNavigator.ResumeLayout(false);
            this.tAB_CLIENTESBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_CLIENTESDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bddvuelosDataSet bddvuelosDataSet;
        private System.Windows.Forms.BindingSource tAB_CLIENTESBindingSource;
        private bddvuelosDataSetTableAdapters.TAB_CLIENTESTableAdapter tAB_CLIENTESTableAdapter;
        private bddvuelosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tAB_CLIENTESBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tAB_CLIENTESBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tAB_CLIENTESDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox iD_CLIENTETextBox;
        private System.Windows.Forms.TextBox nRO_IDENTIFICACIONTextBox;
        private System.Windows.Forms.TextBox nOMBRESTextBox;
        private System.Windows.Forms.TextBox aPELLIDOSTextBox;
        private System.Windows.Forms.TextBox dIRECCIONTextBox;
        private System.Windows.Forms.TextBox tELEFONOTextBox;
        private System.Windows.Forms.TextBox nRO_TARJETATextBox;
        private System.Windows.Forms.TextBox dATOSTextBox;
    }
}