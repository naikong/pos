
namespace NPIC2024_Y3S2_DES
{
    partial class frmSale
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
            System.Windows.Forms.Label saleIDLabel;
            System.Windows.Forms.Label saleDateLabel;
            System.Windows.Forms.Label userIDLabel;
            System.Windows.Forms.Label saleDetailIDLabel;
            System.Windows.Forms.Label saleIDLabel1;
            System.Windows.Forms.Label productIDLabel;
            System.Windows.Forms.Label qTYLabel;
            System.Windows.Forms.Label priceOUTLabel;
            System.Windows.Forms.Label label6;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnaddnew = new System.Windows.Forms.Button();
            this.saleIDTextBox = new System.Windows.Forms.TextBox();
            this.tblSaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_dataset = new NPIC2024_Y3S2_DES.db_dataset();
            this.saleDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
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
            this.saleDetailIDTextBox = new System.Windows.Forms.TextBox();
            this.tblSaleDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saleIDTextBox1 = new System.Windows.Forms.TextBox();
            this.productIDTextBox = new System.Windows.Forms.TextBox();
            this.qTYTextBox = new System.Windows.Forms.TextBox();
            this.priceOUTTextBox = new System.Windows.Forms.TextBox();
            this.userIDComboBox = new System.Windows.Forms.ComboBox();
            this.tblSaleTableAdapter = new NPIC2024_Y3S2_DES.db_datasetTableAdapters.tblSaleTableAdapter();
            this.tableAdapterManager = new NPIC2024_Y3S2_DES.db_datasetTableAdapters.TableAdapterManager();
            this.tblProductTableAdapter = new NPIC2024_Y3S2_DES.db_datasetTableAdapters.tblProductTableAdapter();
            this.tblSaleDetailTableAdapter = new NPIC2024_Y3S2_DES.db_datasetTableAdapters.tblSaleDetailTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtproductname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsearchproductcode = new System.Windows.Forms.TextBox();
            this.dvgshow = new System.Windows.Forms.DataGridView();
            this.pro_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtaction = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnedit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableAdapterManager1 = new NPIC2024_Y3S2_DES.db_datasetTableAdapters.TableAdapterManager();
            this.tableAdapterManager2 = new NPIC2024_Y3S2_DES.db_datasetTableAdapters.TableAdapterManager();
            this.label5 = new System.Windows.Forms.Label();
            saleIDLabel = new System.Windows.Forms.Label();
            saleDateLabel = new System.Windows.Forms.Label();
            userIDLabel = new System.Windows.Forms.Label();
            saleDetailIDLabel = new System.Windows.Forms.Label();
            saleIDLabel1 = new System.Windows.Forms.Label();
            productIDLabel = new System.Windows.Forms.Label();
            qTYLabel = new System.Windows.Forms.Label();
            priceOUTLabel = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblSaleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSaleDetailBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgshow)).BeginInit();
            this.SuspendLayout();
            // 
            // saleIDLabel
            // 
            saleIDLabel.AutoSize = true;
            saleIDLabel.Location = new System.Drawing.Point(25, 158);
            saleIDLabel.Name = "saleIDLabel";
            saleIDLabel.Size = new System.Drawing.Size(78, 33);
            saleIDLabel.TabIndex = 0;
            saleIDLabel.Text = "Sale ID:";
            // 
            // saleDateLabel
            // 
            saleDateLabel.AutoSize = true;
            saleDateLabel.Location = new System.Drawing.Point(20, 84);
            saleDateLabel.Name = "saleDateLabel";
            saleDateLabel.Size = new System.Drawing.Size(97, 33);
            saleDateLabel.TabIndex = 2;
            saleDateLabel.Text = "Sale Date:";
            // 
            // userIDLabel
            // 
            userIDLabel.AutoSize = true;
            userIDLabel.Location = new System.Drawing.Point(645, 442);
            userIDLabel.Name = "userIDLabel";
            userIDLabel.Size = new System.Drawing.Size(80, 33);
            userIDLabel.TabIndex = 4;
            userIDLabel.Text = "User ID:";
            // 
            // saleDetailIDLabel
            // 
            saleDetailIDLabel.AutoSize = true;
            saleDetailIDLabel.Location = new System.Drawing.Point(583, 408);
            saleDetailIDLabel.Name = "saleDetailIDLabel";
            saleDetailIDLabel.Size = new System.Drawing.Size(128, 33);
            saleDetailIDLabel.TabIndex = 6;
            saleDetailIDLabel.Text = "Sale Detail ID:";
            // 
            // saleIDLabel1
            // 
            saleIDLabel1.AutoSize = true;
            saleIDLabel1.Location = new System.Drawing.Point(608, 464);
            saleIDLabel1.Name = "saleIDLabel1";
            saleIDLabel1.Size = new System.Drawing.Size(78, 33);
            saleIDLabel1.TabIndex = 8;
            saleIDLabel1.Text = "Sale ID:";
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Location = new System.Drawing.Point(712, 401);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(104, 33);
            productIDLabel.TabIndex = 10;
            productIDLabel.Text = "Product ID:";
            // 
            // qTYLabel
            // 
            qTYLabel.AutoSize = true;
            qTYLabel.Location = new System.Drawing.Point(727, 464);
            qTYLabel.Name = "qTYLabel";
            qTYLabel.Size = new System.Drawing.Size(52, 33);
            qTYLabel.TabIndex = 12;
            qTYLabel.Text = "QTY:";
            // 
            // priceOUTLabel
            // 
            priceOUTLabel.AutoSize = true;
            priceOUTLabel.Location = new System.Drawing.Point(727, 416);
            priceOUTLabel.Name = "priceOUTLabel";
            priceOUTLabel.Size = new System.Drawing.Size(97, 33);
            priceOUTLabel.TabIndex = 14;
            priceOUTLabel.Text = "price OUT:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Kh Muol", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(15, 9);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(362, 50);
            label6.TabIndex = 19;
            label6.Text = "ប្រតិបត្ដិការលក់សៀវភៅ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Controls.Add(label6);
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.Controls.Add(this.btnaddnew);
            this.groupBox1.Controls.Add(saleIDLabel);
            this.groupBox1.Controls.Add(this.saleIDTextBox);
            this.groupBox1.Controls.Add(saleDateLabel);
            this.groupBox1.Controls.Add(this.saleDateDateTimePicker);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Size = new System.Drawing.Size(1488, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Kh Battambang", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Image = global::NPIC2024_Y3S2_DES.Properties.Resources.icons8_save_100;
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsave.Location = new System.Drawing.Point(1221, 21);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(199, 78);
            this.btnsave.TabIndex = 18;
            this.btnsave.Text = "រក្សាទុក";
            this.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnaddnew
            // 
            this.btnaddnew.Font = new System.Drawing.Font("Kh Battambang", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddnew.Image = global::NPIC2024_Y3S2_DES.Properties.Resources.add_to_cart;
            this.btnaddnew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaddnew.Location = new System.Drawing.Point(1221, 105);
            this.btnaddnew.Name = "btnaddnew";
            this.btnaddnew.Size = new System.Drawing.Size(199, 87);
            this.btnaddnew.TabIndex = 17;
            this.btnaddnew.Text = "លក់ទំនិញ";
            this.btnaddnew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnaddnew.UseVisualStyleBackColor = true;
            this.btnaddnew.Click += new System.EventHandler(this.btnaddnew_Click);
            // 
            // saleIDTextBox
            // 
            this.saleIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSaleBindingSource, "SaleID", true));
            this.saleIDTextBox.Location = new System.Drawing.Point(123, 147);
            this.saleIDTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.saleIDTextBox.Name = "saleIDTextBox";
            this.saleIDTextBox.Size = new System.Drawing.Size(350, 41);
            this.saleIDTextBox.TabIndex = 1;
            // 
            // tblSaleBindingSource
            // 
            this.tblSaleBindingSource.DataMember = "tblSale";
            this.tblSaleBindingSource.DataSource = this.db_dataset;
            // 
            // db_dataset
            // 
            this.db_dataset.DataSetName = "db_dataset";
            this.db_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // saleDateDateTimePicker
            // 
            this.saleDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblSaleBindingSource, "SaleDate", true));
            this.saleDateDateTimePicker.Location = new System.Drawing.Point(123, 81);
            this.saleDateDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.saleDateDateTimePicker.Name = "saleDateDateTimePicker";
            this.saleDateDateTimePicker.Size = new System.Drawing.Size(350, 41);
            this.saleDateDateTimePicker.TabIndex = 3;
            // 
            // tblProductDataGridView
            // 
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
            this.tblProductDataGridView.Location = new System.Drawing.Point(677, 450);
            this.tblProductDataGridView.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tblProductDataGridView.Name = "tblProductDataGridView";
            this.tblProductDataGridView.RowHeadersWidth = 51;
            this.tblProductDataGridView.RowTemplate.Height = 24;
            this.tblProductDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblProductDataGridView.Size = new System.Drawing.Size(68, 79);
            this.tblProductDataGridView.TabIndex = 16;
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
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "productName";
            this.dataGridViewTextBoxColumn3.HeaderText = "productName";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "StockQty";
            this.dataGridViewTextBoxColumn4.HeaderText = "StockQty";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Last_priceIN";
            this.dataGridViewTextBoxColumn5.HeaderText = "Last_priceIN";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Last_priceOUT";
            this.dataGridViewTextBoxColumn6.HeaderText = "Last_priceOUT";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Disabled";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Disabled";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "UserID";
            this.dataGridViewTextBoxColumn7.HeaderText = "UserID";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // tblProductBindingSource
            // 
            this.tblProductBindingSource.DataMember = "tblProduct";
            this.tblProductBindingSource.DataSource = this.db_dataset;
            // 
            // saleDetailIDTextBox
            // 
            this.saleDetailIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSaleDetailBindingSource, "SaleDetailID", true));
            this.saleDetailIDTextBox.Location = new System.Drawing.Point(609, 403);
            this.saleDetailIDTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.saleDetailIDTextBox.Name = "saleDetailIDTextBox";
            this.saleDetailIDTextBox.Size = new System.Drawing.Size(77, 41);
            this.saleDetailIDTextBox.TabIndex = 7;
            // 
            // tblSaleDetailBindingSource
            // 
            this.tblSaleDetailBindingSource.DataMember = "tblSaleDetail";
            this.tblSaleDetailBindingSource.DataSource = this.db_dataset;
            // 
            // saleIDTextBox1
            // 
            this.saleIDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSaleDetailBindingSource, "SaleID", true));
            this.saleIDTextBox1.Location = new System.Drawing.Point(609, 459);
            this.saleIDTextBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.saleIDTextBox1.Name = "saleIDTextBox1";
            this.saleIDTextBox1.Size = new System.Drawing.Size(77, 41);
            this.saleIDTextBox1.TabIndex = 9;
            // 
            // productIDTextBox
            // 
            this.productIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSaleDetailBindingSource, "ProductID", true));
            this.productIDTextBox.Location = new System.Drawing.Point(718, 399);
            this.productIDTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.productIDTextBox.Name = "productIDTextBox";
            this.productIDTextBox.Size = new System.Drawing.Size(100, 41);
            this.productIDTextBox.TabIndex = 11;
            // 
            // qTYTextBox
            // 
            this.qTYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSaleDetailBindingSource, "QTY", true));
            this.qTYTextBox.Location = new System.Drawing.Point(718, 455);
            this.qTYTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.qTYTextBox.Name = "qTYTextBox";
            this.qTYTextBox.Size = new System.Drawing.Size(100, 41);
            this.qTYTextBox.TabIndex = 13;
            // 
            // priceOUTTextBox
            // 
            this.priceOUTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSaleDetailBindingSource, "priceOUT", true));
            this.priceOUTTextBox.Location = new System.Drawing.Point(749, 391);
            this.priceOUTTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.priceOUTTextBox.Name = "priceOUTTextBox";
            this.priceOUTTextBox.Size = new System.Drawing.Size(100, 41);
            this.priceOUTTextBox.TabIndex = 15;
            // 
            // userIDComboBox
            // 
            this.userIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSaleBindingSource, "UserID", true));
            this.userIDComboBox.FormattingEnabled = true;
            this.userIDComboBox.Location = new System.Drawing.Point(544, 408);
            this.userIDComboBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.userIDComboBox.Name = "userIDComboBox";
            this.userIDComboBox.Size = new System.Drawing.Size(95, 41);
            this.userIDComboBox.TabIndex = 5;
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
            this.tableAdapterManager.tblProductTableAdapter = this.tblProductTableAdapter;
            this.tableAdapterManager.tblSaleDetailTableAdapter = this.tblSaleDetailTableAdapter;
            this.tableAdapterManager.tblSaleTableAdapter = this.tblSaleTableAdapter;
            this.tableAdapterManager.tblSupplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NPIC2024_Y3S2_DES.db_datasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblProductTableAdapter
            // 
            this.tblProductTableAdapter.ClearBeforeFill = true;
            // 
            // tblSaleDetailTableAdapter
            // 
            this.tblSaleDetailTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtsearch);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtprice);
            this.groupBox2.Controls.Add(this.txtproductname);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtsearchproductcode);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 207);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox2.Size = new System.Drawing.Size(1488, 145);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 33);
            this.label4.TabIndex = 17;
            this.label4.Text = "លេខកូដសៀវភៅ";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(13, 88);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(425, 41);
            this.txtsearch.TabIndex = 16;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            this.txtsearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsearch_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(476, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 33);
            this.label2.TabIndex = 11;
            this.label2.Text = "ឈ្មោះសៀវភៅ";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(980, 84);
            this.txtprice.Margin = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.txtprice.Name = "txtprice";
            this.txtprice.ReadOnly = true;
            this.txtprice.Size = new System.Drawing.Size(463, 41);
            this.txtprice.TabIndex = 12;
            // 
            // txtproductname
            // 
            this.txtproductname.Location = new System.Drawing.Point(482, 88);
            this.txtproductname.Margin = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.ReadOnly = true;
            this.txtproductname.Size = new System.Drawing.Size(415, 41);
            this.txtproductname.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(988, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 33);
            this.label3.TabIndex = 13;
            this.label3.Text = "តម្លៃ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-218, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "លេខកូដសៀវភៅ";
            // 
            // txtsearchproductcode
            // 
            this.txtsearchproductcode.Location = new System.Drawing.Point(-228, 82);
            this.txtsearchproductcode.Margin = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.txtsearchproductcode.Name = "txtsearchproductcode";
            this.txtsearchproductcode.Size = new System.Drawing.Size(78, 41);
            this.txtsearchproductcode.TabIndex = 8;
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
            this.pro_name,
            this.pro_price,
            this.pro_qty,
            this.total,
            this.txtaction,
            this.btnedit});
            this.dvgshow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgshow.Location = new System.Drawing.Point(0, 352);
            this.dvgshow.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dvgshow.Name = "dvgshow";
            this.dvgshow.ReadOnly = true;
            this.dvgshow.RowHeadersWidth = 51;
            this.dvgshow.RowTemplate.Height = 24;
            this.dvgshow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgshow.Size = new System.Drawing.Size(1488, 372);
            this.dvgshow.TabIndex = 4;
            this.dvgshow.TabStop = false;
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
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.StblSockTableAdapter = null;
            this.tableAdapterManager1.tbl_UserTableAdapter = null;
            this.tableAdapterManager1.tblGenderTableAdapter = null;
            this.tableAdapterManager1.tblProductTableAdapter = null;
            this.tableAdapterManager1.tblSaleDetailTableAdapter = this.tblSaleDetailTableAdapter;
            this.tableAdapterManager1.tblSaleTableAdapter = null;
            this.tableAdapterManager1.tblSupplierTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = NPIC2024_Y3S2_DES.db_datasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.StblSockTableAdapter = null;
            this.tableAdapterManager2.tbl_UserTableAdapter = null;
            this.tableAdapterManager2.tblGenderTableAdapter = null;
            this.tableAdapterManager2.tblProductTableAdapter = null;
            this.tableAdapterManager2.tblSaleDetailTableAdapter = null;
            this.tableAdapterManager2.tblSaleTableAdapter = this.tblSaleTableAdapter;
            this.tableAdapterManager2.tblSupplierTableAdapter = null;
            this.tableAdapterManager2.UpdateOrder = NPIC2024_Y3S2_DES.db_datasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(391, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(506, 162);
            this.label5.TabIndex = 19;
            // 
            // frmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1488, 724);
            this.Controls.Add(this.dvgshow);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(saleDetailIDLabel);
            this.Controls.Add(this.tblProductDataGridView);
            this.Controls.Add(this.userIDComboBox);
            this.Controls.Add(userIDLabel);
            this.Controls.Add(this.priceOUTTextBox);
            this.Controls.Add(priceOUTLabel);
            this.Controls.Add(this.qTYTextBox);
            this.Controls.Add(this.saleDetailIDTextBox);
            this.Controls.Add(qTYLabel);
            this.Controls.Add(saleIDLabel1);
            this.Controls.Add(this.productIDTextBox);
            this.Controls.Add(this.saleIDTextBox1);
            this.Controls.Add(productIDLabel);
            this.Font = new System.Drawing.Font("Kh Battambang", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "frmSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSale";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSale_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblSaleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSaleDetailBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgshow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private db_dataset db_dataset;
        private System.Windows.Forms.BindingSource tblSaleBindingSource;
        private db_datasetTableAdapters.tblSaleTableAdapter tblSaleTableAdapter;
        private db_datasetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox saleIDTextBox;
        private System.Windows.Forms.DateTimePicker saleDateDateTimePicker;
        private System.Windows.Forms.ComboBox userIDComboBox;
        private db_datasetTableAdapters.tblSaleDetailTableAdapter tblSaleDetailTableAdapter;
        private System.Windows.Forms.BindingSource tblSaleDetailBindingSource;
        private System.Windows.Forms.TextBox saleDetailIDTextBox;
        private System.Windows.Forms.TextBox saleIDTextBox1;
        private System.Windows.Forms.TextBox productIDTextBox;
        private System.Windows.Forms.TextBox qTYTextBox;
        private System.Windows.Forms.TextBox priceOUTTextBox;
        private db_datasetTableAdapters.tblProductTableAdapter tblProductTableAdapter;
        private System.Windows.Forms.BindingSource tblProductBindingSource;
        private System.Windows.Forms.DataGridView tblProductDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtproductname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsearchproductcode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.DataGridView dvgshow;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnaddnew;
        private db_datasetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewButtonColumn txtaction;
        private System.Windows.Forms.DataGridViewButtonColumn btnedit;
        private db_datasetTableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.Label label5;
    }
}