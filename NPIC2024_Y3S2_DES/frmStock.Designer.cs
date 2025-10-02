

namespace NPIC2024_Y3S2_DES
{
    partial class frmStock
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
            System.Windows.Forms.Label stockDateLabel;
            System.Windows.Forms.Label qtyLabel;
            System.Windows.Forms.Label productIDLabel;
            System.Windows.Forms.Label stockIDLabel;
            System.Windows.Forms.Label priceINLabel;
            System.Windows.Forms.Label priceOUTLabel;
            System.Windows.Forms.Label supplierIDLabel;
            System.Windows.Forms.Label userIDLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.supplierIDComboBox = new System.Windows.Forms.ComboBox();
            this.stblSockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_dataset = new NPIC2024_Y3S2_DES.db_dataset();
            this.tblSupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userIDComboBox = new System.Windows.Forms.ComboBox();
            this.priceOUTTextBox = new System.Windows.Forms.TextBox();
            this.priceINTextBox = new System.Windows.Forms.TextBox();
            this.stockDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.stockIDTextBox = new System.Windows.Forms.TextBox();
            this.qtyTextBox = new System.Windows.Forms.TextBox();
            this.productIDComboBox = new System.Windows.Forms.ComboBox();
            this.tblProductBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.stblSockTableAdapter = new NPIC2024_Y3S2_DES.db_datasetTableAdapters.StblSockTableAdapter();
            this.tableAdapterManager = new NPIC2024_Y3S2_DES.db_datasetTableAdapters.TableAdapterManager();
            this.stblSockDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblProductTableAdapter = new NPIC2024_Y3S2_DES.db_datasetTableAdapters.tblProductTableAdapter();
            this.tblProductBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblSupplierTableAdapter = new NPIC2024_Y3S2_DES.db_datasetTableAdapters.tblSupplierTableAdapter();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtsaves = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            stockDateLabel = new System.Windows.Forms.Label();
            qtyLabel = new System.Windows.Forms.Label();
            productIDLabel = new System.Windows.Forms.Label();
            stockIDLabel = new System.Windows.Forms.Label();
            priceINLabel = new System.Windows.Forms.Label();
            priceOUTLabel = new System.Windows.Forms.Label();
            supplierIDLabel = new System.Windows.Forms.Label();
            userIDLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stblSockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stblSockDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // stockDateLabel
            // 
            stockDateLabel.AutoSize = true;
            stockDateLabel.Location = new System.Drawing.Point(23, 133);
            stockDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            stockDateLabel.Name = "stockDateLabel";
            stockDateLabel.Size = new System.Drawing.Size(177, 31);
            stockDateLabel.TabIndex = 4;
            stockDateLabel.Text = "ថ្ងៃ/ខែ/ឆ្នាំចូលឃ្លាំង :";
            // 
            // qtyLabel
            // 
            qtyLabel.AutoSize = true;
            qtyLabel.Location = new System.Drawing.Point(23, 184);
            qtyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            qtyLabel.Name = "qtyLabel";
            qtyLabel.Size = new System.Drawing.Size(69, 31);
            qtyLabel.TabIndex = 6;
            qtyLabel.Text = "ចំនួន :";
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Location = new System.Drawing.Point(23, 73);
            productIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(181, 31);
            productIDLabel.TabIndex = 2;
            productIDLabel.Text = "លេខរៀងផលិតផល :";
            // 
            // stockIDLabel
            // 
            stockIDLabel.AutoSize = true;
            stockIDLabel.Location = new System.Drawing.Point(23, 16);
            stockIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            stockIDLabel.Name = "stockIDLabel";
            stockIDLabel.Size = new System.Drawing.Size(98, 31);
            stockIDLabel.TabIndex = 0;
            stockIDLabel.Text = "លេខរៀង :";
            // 
            // priceINLabel
            // 
            priceINLabel.AutoSize = true;
            priceINLabel.Location = new System.Drawing.Point(16, 12);
            priceINLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            priceINLabel.Name = "priceINLabel";
            priceINLabel.Size = new System.Drawing.Size(117, 31);
            priceINLabel.TabIndex = 8;
            priceINLabel.Text = "តម្លៃនាំចូល :";
            // 
            // priceOUTLabel
            // 
            priceOUTLabel.AutoSize = true;
            priceOUTLabel.Location = new System.Drawing.Point(16, 64);
            priceOUTLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            priceOUTLabel.Name = "priceOUTLabel";
            priceOUTLabel.Size = new System.Drawing.Size(127, 31);
            priceOUTLabel.TabIndex = 10;
            priceOUTLabel.Text = "តម្លៃនាំចេញ :";
            // 
            // supplierIDLabel
            // 
            supplierIDLabel.AutoSize = true;
            supplierIDLabel.Location = new System.Drawing.Point(16, 117);
            supplierIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            supplierIDLabel.Name = "supplierIDLabel";
            supplierIDLabel.Size = new System.Drawing.Size(130, 31);
            supplierIDLabel.TabIndex = 12;
            supplierIDLabel.Text = "អ្នកផ្គត់ផ្គង ID:";
            // 
            // userIDLabel
            // 
            userIDLabel.AutoSize = true;
            userIDLabel.Location = new System.Drawing.Point(16, 175);
            userIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            userIDLabel.Name = "userIDLabel";
            userIDLabel.Size = new System.Drawing.Size(109, 31);
            userIDLabel.TabIndex = 14;
            userIDLabel.Text = "បុគ្គលិក ID :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Font = new System.Drawing.Font("Khmer Muol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 59);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1290, 371);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(stockIDLabel);
            this.panel2.Controls.Add(this.stockDateDateTimePicker);
            this.panel2.Controls.Add(this.stockIDTextBox);
            this.panel2.Controls.Add(this.qtyTextBox);
            this.panel2.Controls.Add(productIDLabel);
            this.panel2.Controls.Add(qtyLabel);
            this.panel2.Controls.Add(this.productIDComboBox);
            this.panel2.Controls.Add(stockDateLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(4, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1286, 332);
            this.panel2.TabIndex = 17;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.supplierIDComboBox);
            this.panel1.Controls.Add(this.userIDComboBox);
            this.panel1.Controls.Add(userIDLabel);
            this.panel1.Controls.Add(supplierIDLabel);
            this.panel1.Controls.Add(this.priceOUTTextBox);
            this.panel1.Controls.Add(priceOUTLabel);
            this.panel1.Controls.Add(this.priceINTextBox);
            this.panel1.Controls.Add(priceINLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(668, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 332);
            this.panel1.TabIndex = 17;
            // 
            // supplierIDComboBox
            // 
            this.supplierIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.stblSockBindingSource, "SupplierID", true));
            this.supplierIDComboBox.DataSource = this.tblSupplierBindingSource;
            this.supplierIDComboBox.DisplayMember = "SupplierName";
            this.supplierIDComboBox.FormattingEnabled = true;
            this.supplierIDComboBox.Location = new System.Drawing.Point(160, 114);
            this.supplierIDComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.supplierIDComboBox.Name = "supplierIDComboBox";
            this.supplierIDComboBox.Size = new System.Drawing.Size(445, 39);
            this.supplierIDComboBox.TabIndex = 13;
            this.supplierIDComboBox.ValueMember = "SupplierID";
            // 
            // stblSockBindingSource
            // 
            this.stblSockBindingSource.DataMember = "StblSock";
            this.stblSockBindingSource.DataSource = this.db_dataset;
            // 
            // db_dataset
            // 
            this.db_dataset.DataSetName = "db_dataset";
            this.db_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblSupplierBindingSource
            // 
            this.tblSupplierBindingSource.DataMember = "tblSupplier";
            this.tblSupplierBindingSource.DataSource = this.db_dataset;
            // 
            // userIDComboBox
            // 
            this.userIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stblSockBindingSource, "UserID", true));
            this.userIDComboBox.FormattingEnabled = true;
            this.userIDComboBox.Location = new System.Drawing.Point(160, 172);
            this.userIDComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.userIDComboBox.Name = "userIDComboBox";
            this.userIDComboBox.Size = new System.Drawing.Size(445, 39);
            this.userIDComboBox.TabIndex = 15;
            // 
            // priceOUTTextBox
            // 
            this.priceOUTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stblSockBindingSource, "PriceOUT", true));
            this.priceOUTTextBox.Location = new System.Drawing.Point(160, 61);
            this.priceOUTTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.priceOUTTextBox.Name = "priceOUTTextBox";
            this.priceOUTTextBox.Size = new System.Drawing.Size(445, 38);
            this.priceOUTTextBox.TabIndex = 11;
            // 
            // priceINTextBox
            // 
            this.priceINTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stblSockBindingSource, "PriceIN", true));
            this.priceINTextBox.Location = new System.Drawing.Point(160, 9);
            this.priceINTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.priceINTextBox.Name = "priceINTextBox";
            this.priceINTextBox.Size = new System.Drawing.Size(445, 38);
            this.priceINTextBox.TabIndex = 9;
            // 
            // stockDateDateTimePicker
            // 
            this.stockDateDateTimePicker.CustomFormat = "dddd-MMMM-yyyy";
            this.stockDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stblSockBindingSource, "StockDate", true));
            this.stockDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.stockDateDateTimePicker.Location = new System.Drawing.Point(213, 124);
            this.stockDateDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.stockDateDateTimePicker.Name = "stockDateDateTimePicker";
            this.stockDateDateTimePicker.Size = new System.Drawing.Size(419, 38);
            this.stockDateDateTimePicker.TabIndex = 5;
            // 
            // stockIDTextBox
            // 
            this.stockIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stblSockBindingSource, "StockID", true));
            this.stockIDTextBox.Enabled = false;
            this.stockIDTextBox.Location = new System.Drawing.Point(213, 9);
            this.stockIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.stockIDTextBox.Name = "stockIDTextBox";
            this.stockIDTextBox.ReadOnly = true;
            this.stockIDTextBox.Size = new System.Drawing.Size(419, 38);
            this.stockIDTextBox.TabIndex = 1;
            // 
            // qtyTextBox
            // 
            this.qtyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stblSockBindingSource, "Qty", true));
            this.qtyTextBox.Location = new System.Drawing.Point(213, 177);
            this.qtyTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.qtyTextBox.Name = "qtyTextBox";
            this.qtyTextBox.Size = new System.Drawing.Size(419, 38);
            this.qtyTextBox.TabIndex = 7;
            // 
            // productIDComboBox
            // 
            this.productIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.stblSockBindingSource, "ProductID", true));
            this.productIDComboBox.DataSource = this.tblProductBindingSource2;
            this.productIDComboBox.DisplayMember = "productName";
            this.productIDComboBox.Enabled = false;
            this.productIDComboBox.FormattingEnabled = true;
            this.productIDComboBox.Location = new System.Drawing.Point(213, 66);
            this.productIDComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.productIDComboBox.Name = "productIDComboBox";
            this.productIDComboBox.Size = new System.Drawing.Size(419, 39);
            this.productIDComboBox.TabIndex = 3;
            this.productIDComboBox.ValueMember = "productID";
            // 
            // tblProductBindingSource2
            // 
            this.tblProductBindingSource2.DataMember = "tblProduct";
            this.tblProductBindingSource2.DataSource = this.db_dataset;
            // 
            // stblSockTableAdapter
            // 
            this.stblSockTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StblSockTableAdapter = this.stblSockTableAdapter;
            this.tableAdapterManager.tbl_UserTableAdapter = null;
            this.tableAdapterManager.tblGenderTableAdapter = null;
            this.tableAdapterManager.tblProductTableAdapter = null;
            this.tableAdapterManager.tblSaleDetailTableAdapter = null;
            this.tableAdapterManager.tblSaleTableAdapter = null;
            this.tableAdapterManager.tblSupplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NPIC2024_Y3S2_DES.db_datasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // stblSockDataGridView
            // 
            this.stblSockDataGridView.AllowUserToAddRows = false;
            this.stblSockDataGridView.AllowUserToDeleteRows = false;
            this.stblSockDataGridView.AutoGenerateColumns = false;
            this.stblSockDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stblSockDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.stblSockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stblSockDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.stblSockDataGridView.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.stblSockDataGridView.DataSource = this.stblSockBindingSource;
            this.stblSockDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stblSockDataGridView.Location = new System.Drawing.Point(0, 388);
            this.stblSockDataGridView.Name = "stblSockDataGridView";
            this.stblSockDataGridView.ReadOnly = true;
            this.stblSockDataGridView.RowHeadersWidth = 51;
            this.stblSockDataGridView.RowTemplate.Height = 24;
            this.stblSockDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stblSockDataGridView.Size = new System.Drawing.Size(1290, 257);
            this.stblSockDataGridView.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "StockID";
            this.dataGridViewTextBoxColumn1.HeaderText = "លេខរៀង";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "StockDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "ថ្ងៃ/ខែ/ឆ្នាំចូលឃ្លាំង";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Qty";
            this.dataGridViewTextBoxColumn4.HeaderText = "ចំនួន";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PriceIN";
            this.dataGridViewTextBoxColumn5.HeaderText = "តម្លៃនាំចូល";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PriceOUT";
            this.dataGridViewTextBoxColumn6.HeaderText = "តម្លៃនាំចេញ";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "SupplierID";
            this.dataGridViewTextBoxColumn7.HeaderText = "អ្នកផ្គត់ផ្គង ID";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "UserID";
            this.dataGridViewTextBoxColumn8.HeaderText = "បុគ្គលិក ID ";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // tblProductBindingSource
            // 
            this.tblProductBindingSource.DataMember = "tblProduct";
            this.tblProductBindingSource.DataSource = this.db_dataset;
            // 
            // tblProductTableAdapter
            // 
            this.tblProductTableAdapter.ClearBeforeFill = true;
            // 
            // tblProductBindingSource1
            // 
            this.tblProductBindingSource1.DataMember = "tblProduct";
            this.tblProductBindingSource1.DataSource = this.db_dataset;
            // 
            // tblSupplierTableAdapter
            // 
            this.tblSupplierTableAdapter.ClearBeforeFill = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Blue;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1290, 0);
            this.toolStrip1.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1290, 10);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // txtsaves
            // 
            this.txtsaves.Font = new System.Drawing.Font("Khmer Muol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsaves.Image = global::NPIC2024_Y3S2_DES.Properties.Resources.diskette;
            this.txtsaves.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtsaves.Location = new System.Drawing.Point(915, 12);
            this.txtsaves.Name = "txtsaves";
            this.txtsaves.Size = new System.Drawing.Size(151, 60);
            this.txtsaves.TabIndex = 24;
            this.txtsaves.Text = "រក្សាផលិតផល";
            this.txtsaves.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtsaves.UseVisualStyleBackColor = true;
            this.txtsaves.Click += new System.EventHandler(this.txtsaves_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Khmer Muol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::NPIC2024_Y3S2_DES.Properties.Resources.delete__1_;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(755, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 60);
            this.button2.TabIndex = 23;
            this.button2.Text = "លុបផលិតផល";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Khmer Muol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::NPIC2024_Y3S2_DES.Properties.Resources.icons8_add_new_64;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1072, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 60);
            this.button1.TabIndex = 22;
            this.button1.Text = "បញ្ជូលផលិតផល";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1290, 645);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtsaves);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.stblSockDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStock";
            this.Load += new System.EventHandler(this.frmStock_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stblSockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stblSockDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private db_dataset db_dataset;
        private System.Windows.Forms.BindingSource stblSockBindingSource;
        private db_datasetTableAdapters.StblSockTableAdapter stblSockTableAdapter;
        private db_datasetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView stblSockDataGridView;
        private System.Windows.Forms.BindingSource tblProductBindingSource;
        private db_datasetTableAdapters.tblProductTableAdapter tblProductTableAdapter;
        private System.Windows.Forms.BindingSource tblProductBindingSource2;
        private System.Windows.Forms.BindingSource tblProductBindingSource1;
        private System.Windows.Forms.BindingSource tblSupplierBindingSource;
        private db_datasetTableAdapters.tblSupplierTableAdapter tblSupplierTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox supplierIDComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox userIDComboBox;
        private System.Windows.Forms.TextBox priceOUTTextBox;
        private System.Windows.Forms.TextBox priceINTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button txtsaves;
        private System.Windows.Forms.DateTimePicker stockDateDateTimePicker;
        private System.Windows.Forms.TextBox stockIDTextBox;
        private System.Windows.Forms.TextBox qtyTextBox;
        private System.Windows.Forms.ComboBox productIDComboBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}