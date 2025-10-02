
namespace NPIC2024_Y3S2_DES
{
    partial class frmSaleProduct
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
            System.Windows.Forms.Label saleDateLabel;
            System.Windows.Forms.Label saleIDLabel;
            System.Windows.Forms.Label label4;
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.QTY = new System.Windows.Forms.Label();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtproductname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsearchproductcode = new System.Windows.Forms.TextBox();
            this.tblProductDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_dataset = new NPIC2024_Y3S2_DES.db_dataset();
            this.dvgshow = new System.Windows.Forms.DataGridView();
            this.pro_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtaction = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnedit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.userIDComboBox = new System.Windows.Forms.ComboBox();
            this.tblSaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblsum = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tblSaleDetailDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblSaleDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saleIDTextBox1 = new System.Windows.Forms.TextBox();
            this.saleDateDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.txtsave = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnaddnew = new System.Windows.Forms.Button();
            this.btninvoice = new System.Windows.Forms.Button();
            this.tblSaleTableAdapter = new NPIC2024_Y3S2_DES.db_datasetTableAdapters.tblSaleTableAdapter();
            this.tableAdapterManager = new NPIC2024_Y3S2_DES.db_datasetTableAdapters.TableAdapterManager();
            this.tblSaleDetailTableAdapter = new NPIC2024_Y3S2_DES.db_datasetTableAdapters.tblSaleDetailTableAdapter();
            this.tblProductTableAdapter = new NPIC2024_Y3S2_DES.db_datasetTableAdapters.tblProductTableAdapter();
            saleDateLabel = new System.Windows.Forms.Label();
            saleIDLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgshow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSaleBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblSaleDetailDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSaleDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // saleDateLabel
            // 
            saleDateLabel.AutoSize = true;
            saleDateLabel.Location = new System.Drawing.Point(45, 112);
            saleDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            saleDateLabel.Name = "saleDateLabel";
            saleDateLabel.Size = new System.Drawing.Size(119, 33);
            saleDateLabel.TabIndex = 10;
            saleDateLabel.Text = "ថ្ងៃ ខែ ឆ្នាំលក់​ :";
            // 
            // saleIDLabel
            // 
            saleIDLabel.AutoSize = true;
            saleIDLabel.Location = new System.Drawing.Point(58, 65);
            saleIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            saleIDLabel.Name = "saleIDLabel";
            saleIDLabel.Size = new System.Drawing.Size(91, 33);
            saleIDLabel.TabIndex = 8;
            saleIDLabel.Text = "លេខរៀង​​ :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Kh Muol", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(176, 9);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(362, 50);
            label4.TabIndex = 14;
            label4.Text = "ប្រតិបត្ដិការលក់សៀវភៅ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox2.Controls.Add(this.QTY);
            this.groupBox2.Controls.Add(this.txtqty);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtprice);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtproductname);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtsearchproductcode);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 216);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupBox2.Size = new System.Drawing.Size(1502, 132);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // QTY
            // 
            this.QTY.AutoSize = true;
            this.QTY.Location = new System.Drawing.Point(1124, 27);
            this.QTY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QTY.Name = "QTY";
            this.QTY.Size = new System.Drawing.Size(51, 33);
            this.QTY.TabIndex = 7;
            this.QTY.Text = "ចំនួន";
            // 
            // txtqty
            // 
            this.txtqty.Location = new System.Drawing.Point(1128, 65);
            this.txtqty.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(331, 41);
            this.txtqty.TabIndex = 6;
            this.txtqty.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(732, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "តម្លៃ";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(726, 65);
            this.txtprice.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtprice.Name = "txtprice";
            this.txtprice.ReadOnly = true;
            this.txtprice.Size = new System.Drawing.Size(370, 41);
            this.txtprice.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "ឈ្មោះសៀវភៅ";
            // 
            // txtproductname
            // 
            this.txtproductname.Location = new System.Drawing.Point(329, 65);
            this.txtproductname.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.ReadOnly = true;
            this.txtproductname.Size = new System.Drawing.Size(358, 41);
            this.txtproductname.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "លេខកូដសៀវភៅ";
            // 
            // txtsearchproductcode
            // 
            this.txtsearchproductcode.Location = new System.Drawing.Point(10, 65);
            this.txtsearchproductcode.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtsearchproductcode.Name = "txtsearchproductcode";
            this.txtsearchproductcode.Size = new System.Drawing.Size(268, 41);
            this.txtsearchproductcode.TabIndex = 0;
            this.txtsearchproductcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsearchproductcode_KeyDown);
            // 
            // tblProductDataGridView
            // 
            this.tblProductDataGridView.AllowUserToAddRows = false;
            this.tblProductDataGridView.AllowUserToDeleteRows = false;
            this.tblProductDataGridView.AutoGenerateColumns = false;
            this.tblProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblProductDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn7});
            this.tblProductDataGridView.DataSource = this.tblProductBindingSource;
            this.tblProductDataGridView.Location = new System.Drawing.Point(122, 627);
            this.tblProductDataGridView.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tblProductDataGridView.Name = "tblProductDataGridView";
            this.tblProductDataGridView.ReadOnly = true;
            this.tblProductDataGridView.RowHeadersWidth = 51;
            this.tblProductDataGridView.RowTemplate.Height = 24;
            this.tblProductDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblProductDataGridView.Size = new System.Drawing.Size(156, 83);
            this.tblProductDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "productID";
            this.dataGridViewTextBoxColumn1.HeaderText = "productID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "productcod";
            this.dataGridViewTextBoxColumn2.HeaderText = "productcod";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "productName";
            this.dataGridViewTextBoxColumn3.HeaderText = "productName";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "StockQty";
            this.dataGridViewTextBoxColumn4.HeaderText = "StockQty";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Last_priceIN";
            this.dataGridViewTextBoxColumn5.HeaderText = "Last_priceIN";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Last_priceOUT";
            this.dataGridViewTextBoxColumn6.HeaderText = "Last_priceOUT";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Disabled";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Disabled";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "UserID";
            this.dataGridViewTextBoxColumn7.HeaderText = "UserID";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // tblProductBindingSource
            // 
            this.tblProductBindingSource.DataMember = "tblProduct";
            this.tblProductBindingSource.DataSource = this.db_dataset;
            // 
            // db_dataset
            // 
            this.db_dataset.DataSetName = "db_dataset";
            this.db_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dvgshow
            // 
            this.dvgshow.AllowUserToAddRows = false;
            this.dvgshow.AllowUserToDeleteRows = false;
            this.dvgshow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgshow.BackgroundColor = System.Drawing.Color.White;
            this.dvgshow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgshow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pro_id,
            this.pro_cod,
            this.pro_name,
            this.pro_price,
            this.pro_qty,
            this.total,
            this.txtaction,
            this.btnedit});
            this.dvgshow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgshow.Location = new System.Drawing.Point(0, 348);
            this.dvgshow.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dvgshow.Name = "dvgshow";
            this.dvgshow.ReadOnly = true;
            this.dvgshow.RowHeadersWidth = 51;
            this.dvgshow.RowTemplate.Height = 24;
            this.dvgshow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgshow.Size = new System.Drawing.Size(1502, 707);
            this.dvgshow.TabIndex = 3;
            this.dvgshow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgshow_CellContentClick);
            // 
            // pro_id
            // 
            this.pro_id.HeaderText = "លេខរៀង";
            this.pro_id.MinimumWidth = 6;
            this.pro_id.Name = "pro_id";
            this.pro_id.ReadOnly = true;
            this.pro_id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // pro_cod
            // 
            this.pro_cod.HeaderText = "លេខកូដសៀវភៅ";
            this.pro_cod.MinimumWidth = 6;
            this.pro_cod.Name = "pro_cod";
            this.pro_cod.ReadOnly = true;
            // 
            // pro_name
            // 
            this.pro_name.HeaderText = "ឈ្មោះសៀវភៅ";
            this.pro_name.MinimumWidth = 6;
            this.pro_name.Name = "pro_name";
            this.pro_name.ReadOnly = true;
            // 
            // pro_price
            // 
            this.pro_price.HeaderText = "តម្លែ";
            this.pro_price.MinimumWidth = 6;
            this.pro_price.Name = "pro_price";
            this.pro_price.ReadOnly = true;
            // 
            // pro_qty
            // 
            this.pro_qty.HeaderText = "ចំនួន";
            this.pro_qty.MinimumWidth = 6;
            this.pro_qty.Name = "pro_qty";
            this.pro_qty.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "តម្លៃសរុប";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // txtaction
            // 
            this.txtaction.HeaderText = "Action";
            this.txtaction.MinimumWidth = 6;
            this.txtaction.Name = "txtaction";
            this.txtaction.ReadOnly = true;
            this.txtaction.Text = "Delete";
            this.txtaction.UseColumnTextForButtonValue = true;
            // 
            // btnedit
            // 
            this.btnedit.HeaderText = "Edit";
            this.btnedit.MinimumWidth = 6;
            this.btnedit.Name = "btnedit";
            this.btnedit.ReadOnly = true;
            this.btnedit.Text = "Edit";
            this.btnedit.UseColumnTextForButtonValue = true;
            // 
            // userIDComboBox
            // 
            this.userIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSaleBindingSource, "UserID", true));
            this.userIDComboBox.FormattingEnabled = true;
            this.userIDComboBox.Location = new System.Drawing.Point(766, 46);
            this.userIDComboBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.userIDComboBox.Name = "userIDComboBox";
            this.userIDComboBox.Size = new System.Drawing.Size(46, 41);
            this.userIDComboBox.TabIndex = 13;
            // 
            // tblSaleBindingSource
            // 
            this.tblSaleBindingSource.DataMember = "tblSale";
            this.tblSaleBindingSource.DataSource = this.db_dataset;
            // 
            // lblsum
            // 
            this.lblsum.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblsum.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsum.ForeColor = System.Drawing.Color.Red;
            this.lblsum.Location = new System.Drawing.Point(699, 112);
            this.lblsum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsum.Name = "lblsum";
            this.lblsum.Size = new System.Drawing.Size(244, 93);
            this.lblsum.TabIndex = 7;
            this.lblsum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Controls.Add(this.tblSaleDetailDataGridView);
            this.groupBox1.Controls.Add(this.saleIDTextBox1);
            this.groupBox1.Controls.Add(this.saleDateDateTimePicker1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(label4);
            this.groupBox1.Controls.Add(saleIDLabel);
            this.groupBox1.Controls.Add(saleDateLabel);
            this.groupBox1.Controls.Add(this.txtsave);
            this.groupBox1.Controls.Add(this.lblsum);
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Controls.Add(this.btnaddnew);
            this.groupBox1.Controls.Add(this.userIDComboBox);
            this.groupBox1.Controls.Add(this.btninvoice);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupBox1.Size = new System.Drawing.Size(1502, 216);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tblSaleDetailDataGridView
            // 
            this.tblSaleDetailDataGridView.AutoGenerateColumns = false;
            this.tblSaleDetailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblSaleDetailDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.tblSaleDetailDataGridView.DataSource = this.tblSaleDetailBindingSource;
            this.tblSaleDetailDataGridView.Location = new System.Drawing.Point(602, 12);
            this.tblSaleDetailDataGridView.Name = "tblSaleDetailDataGridView";
            this.tblSaleDetailDataGridView.RowHeadersWidth = 51;
            this.tblSaleDetailDataGridView.RowTemplate.Height = 24;
            this.tblSaleDetailDataGridView.Size = new System.Drawing.Size(56, 34);
            this.tblSaleDetailDataGridView.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "SaleDetailID";
            this.dataGridViewTextBoxColumn8.HeaderText = "SaleDetailID";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "SaleID";
            this.dataGridViewTextBoxColumn9.HeaderText = "SaleID";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ProductID";
            this.dataGridViewTextBoxColumn10.HeaderText = "ProductID";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "QTY";
            this.dataGridViewTextBoxColumn11.HeaderText = "QTY";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "priceOUT";
            this.dataGridViewTextBoxColumn12.HeaderText = "priceOUT";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // tblSaleDetailBindingSource
            // 
            this.tblSaleDetailBindingSource.DataMember = "FK_tblSaleDetail_tblSale";
            this.tblSaleDetailBindingSource.DataSource = this.tblSaleBindingSource;
            // 
            // saleIDTextBox1
            // 
            this.saleIDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSaleBindingSource, "SaleID", true));
            this.saleIDTextBox1.Location = new System.Drawing.Point(185, 65);
            this.saleIDTextBox1.Name = "saleIDTextBox1";
            this.saleIDTextBox1.Size = new System.Drawing.Size(473, 41);
            this.saleIDTextBox1.TabIndex = 19;
            // 
            // saleDateDateTimePicker1
            // 
            this.saleDateDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblSaleBindingSource, "SaleDate", true));
            this.saleDateDateTimePicker1.Location = new System.Drawing.Point(185, 112);
            this.saleDateDateTimePicker1.Name = "saleDateDateTimePicker1";
            this.saleDateDateTimePicker1.Size = new System.Drawing.Size(473, 41);
            this.saleDateDateTimePicker1.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Image = global::NPIC2024_Y3S2_DES.Properties.Resources.logout1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1163, 50);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 63);
            this.button1.TabIndex = 15;
            this.button1.Text = "ចាកចេញ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtsave
            // 
            this.txtsave.Image = global::NPIC2024_Y3S2_DES.Properties.Resources.diskette1;
            this.txtsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtsave.Location = new System.Drawing.Point(987, 50);
            this.txtsave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtsave.Name = "txtsave";
            this.txtsave.Size = new System.Drawing.Size(167, 63);
            this.txtsave.TabIndex = 8;
            this.txtsave.Text = "រក្សាទុក";
            this.txtsave.UseVisualStyleBackColor = true;
            this.txtsave.Click += new System.EventHandler(this.txtsave_Click);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Kh Battambang", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Image = global::NPIC2024_Y3S2_DES.Properties.Resources.bag__1_;
            this.btnadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadd.Location = new System.Drawing.Point(1162, 149);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(204, 43);
            this.btnadd.TabIndex = 6;
            this.btnadd.Text = "លក់";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnaddnew
            // 
            this.btnaddnew.Image = global::NPIC2024_Y3S2_DES.Properties.Resources.shopping_cart;
            this.btnaddnew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaddnew.Location = new System.Drawing.Point(691, 39);
            this.btnaddnew.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnaddnew.Name = "btnaddnew";
            this.btnaddnew.Size = new System.Drawing.Size(204, 53);
            this.btnaddnew.TabIndex = 1;
            this.btnaddnew.Text = "បញ្ជូលលក់ថ្មី";
            this.btnaddnew.UseVisualStyleBackColor = true;
            this.btnaddnew.Click += new System.EventHandler(this.btnaddnew_Click);
            // 
            // btninvoice
            // 
            this.btninvoice.Image = global::NPIC2024_Y3S2_DES.Properties.Resources.diskette1;
            this.btninvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btninvoice.Location = new System.Drawing.Point(987, 125);
            this.btninvoice.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btninvoice.Name = "btninvoice";
            this.btninvoice.Size = new System.Drawing.Size(167, 67);
            this.btninvoice.TabIndex = 16;
            this.btninvoice.Text = "INVOID";
            this.btninvoice.UseVisualStyleBackColor = true;
            this.btninvoice.Click += new System.EventHandler(this.btninvoice_Click_1);
            // 
            // tblSaleTableAdapter
            // 
            this.tblSaleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StblSockTableAdapter = null;
            this.tableAdapterManager.tbl_UserTableAdapter = null;
            this.tableAdapterManager.tblGenderTableAdapter = null;
            this.tableAdapterManager.tblProductTableAdapter = null;
            this.tableAdapterManager.tblSaleDetailTableAdapter = null;
            this.tableAdapterManager.tblSaleTableAdapter = this.tblSaleTableAdapter;
            this.tableAdapterManager.tblSupplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NPIC2024_Y3S2_DES.db_datasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblSaleDetailTableAdapter
            // 
            this.tblSaleDetailTableAdapter.ClearBeforeFill = true;
            // 
            // tblProductTableAdapter
            // 
            this.tblProductTableAdapter.ClearBeforeFill = true;
            // 
            // frmSaleProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1502, 1055);
            this.Controls.Add(this.dvgshow);
            this.Controls.Add(this.tblProductDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Kh Battambang", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "frmSaleProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmsale";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSaleProduct_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgshow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSaleBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblSaleDetailDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSaleDetailBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private db_dataset db_dataset;
        private System.Windows.Forms.BindingSource tblSaleBindingSource;
        private db_datasetTableAdapters.tblSaleTableAdapter tblSaleTableAdapter;
        private db_datasetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label QTY;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtproductname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsearchproductcode;
        private System.Windows.Forms.BindingSource tblSaleDetailBindingSource;
        private db_datasetTableAdapters.tblSaleDetailTableAdapter tblSaleDetailTableAdapter;
        private System.Windows.Forms.BindingSource tblProductBindingSource;
        private db_datasetTableAdapters.tblProductTableAdapter tblProductTableAdapter;
        private System.Windows.Forms.DataGridView tblProductDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridView dvgshow;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewButtonColumn txtaction;
        private System.Windows.Forms.DataGridViewButtonColumn btnedit;
        private System.Windows.Forms.Button btninvoice;
        private System.Windows.Forms.ComboBox userIDComboBox;
        private System.Windows.Forms.Button btnaddnew;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label lblsum;
        private System.Windows.Forms.Button txtsave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox saleIDTextBox1;
        private System.Windows.Forms.DateTimePicker saleDateDateTimePicker1;
        private System.Windows.Forms.DataGridView tblSaleDetailDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}