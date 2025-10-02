
namespace NPIC2024_Y3S2_DES
{
    partial class frmProduct
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
            System.Windows.Forms.Label productIDLabel;
            System.Windows.Forms.Label productNameLabel;
            System.Windows.Forms.Label stockQtyLabel;
            System.Windows.Forms.Label last_priceINLabel;
            System.Windows.Forms.Label last_priceOUTLabel;
            System.Windows.Forms.Label disabledLabel;
            System.Windows.Forms.Label userIDLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduct));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnnew = new System.Windows.Forms.ToolStripButton();
            this.btnsave = new System.Windows.Forms.ToolStripButton();
            this.btndelete = new System.Windows.Forms.ToolStripButton();
            this.txtsearch = new System.Windows.Forms.ToolStripTextBox();
            this.btnsearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.productIDTextBox = new System.Windows.Forms.TextBox();
            this.tblProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_dataset = new NPIC2024_Y3S2_DES.db_dataset();
            this.productcodTextBox = new System.Windows.Forms.TextBox();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.stockQtyTextBox = new System.Windows.Forms.TextBox();
            this.last_priceINTextBox = new System.Windows.Forms.TextBox();
            this.last_priceOUTTextBox = new System.Windows.Forms.TextBox();
            this.disabledCheckBox = new System.Windows.Forms.CheckBox();
            this.userIDComboBox = new System.Windows.Forms.ComboBox();
            this.tblProductDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblProductTableAdapter = new NPIC2024_Y3S2_DES.db_datasetTableAdapters.tblProductTableAdapter();
            this.tableAdapterManager = new NPIC2024_Y3S2_DES.db_datasetTableAdapters.TableAdapterManager();
            productIDLabel = new System.Windows.Forms.Label();
            productNameLabel = new System.Windows.Forms.Label();
            stockQtyLabel = new System.Windows.Forms.Label();
            last_priceINLabel = new System.Windows.Forms.Label();
            last_priceOUTLabel = new System.Windows.Forms.Label();
            disabledLabel = new System.Windows.Forms.Label();
            userIDLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Location = new System.Drawing.Point(21, 32);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(98, 31);
            productIDLabel.TabIndex = 0;
            productIDLabel.Text = "លេខរៀង :";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new System.Drawing.Point(21, 135);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new System.Drawing.Size(154, 31);
            productNameLabel.TabIndex = 4;
            productNameLabel.Text = "ឈ្មោះផលិតផល :";
            // 
            // stockQtyLabel
            // 
            stockQtyLabel.AutoSize = true;
            stockQtyLabel.Location = new System.Drawing.Point(21, 186);
            stockQtyLabel.Name = "stockQtyLabel";
            stockQtyLabel.Size = new System.Drawing.Size(147, 31);
            stockQtyLabel.TabIndex = 6;
            stockQtyLabel.Text = "ចំនួនក្នុង​ឃ្លាំង :";
            // 
            // last_priceINLabel
            // 
            last_priceINLabel.AutoSize = true;
            last_priceINLabel.Location = new System.Drawing.Point(546, 32);
            last_priceINLabel.Name = "last_priceINLabel";
            last_priceINLabel.Size = new System.Drawing.Size(117, 31);
            last_priceINLabel.TabIndex = 8;
            last_priceINLabel.Text = "តម្លៃនាំចូល :";
            // 
            // last_priceOUTLabel
            // 
            last_priceOUTLabel.AutoSize = true;
            last_priceOUTLabel.Location = new System.Drawing.Point(546, 80);
            last_priceOUTLabel.Name = "last_priceOUTLabel";
            last_priceOUTLabel.Size = new System.Drawing.Size(127, 31);
            last_priceOUTLabel.TabIndex = 10;
            last_priceOUTLabel.Text = "តម្លៃនាំចេញ :";
            // 
            // disabledLabel
            // 
            disabledLabel.AutoSize = true;
            disabledLabel.Location = new System.Drawing.Point(551, 194);
            disabledLabel.Name = "disabledLabel";
            disabledLabel.Size = new System.Drawing.Size(83, 31);
            disabledLabel.TabIndex = 12;
            disabledLabel.Text = "Disabled:";
            // 
            // userIDLabel
            // 
            userIDLabel.AutoSize = true;
            userIDLabel.Location = new System.Drawing.Point(546, 143);
            userIDLabel.Name = "userIDLabel";
            userIDLabel.Size = new System.Drawing.Size(88, 31);
            userIDLabel.TabIndex = 14;
            userIDLabel.Text = "បុគ្គលិក :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(21, 80);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(132, 31);
            label1.TabIndex = 16;
            label1.Text = "កូដផលិតផល:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Blue;
            this.toolStrip1.Font = new System.Drawing.Font("Khmer Muol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnnew,
            this.btnsave,
            this.btndelete,
            this.txtsearch,
            this.btnsearch,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1159, 38);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnnew
            // 
            this.btnnew.Image = ((System.Drawing.Image)(resources.GetObject("btnnew.Image")));
            this.btnnew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(177, 35);
            this.btnnew.Text = "បញ្ចូលផលិតផល";
            this.btnnew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnsave
            // 
            this.btnsave.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.Image")));
            this.btnsave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(103, 35);
            this.btnsave.Text = "រក្សាទុក";
            this.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btndelete
            // 
            this.btndelete.Image = ((System.Drawing.Image)(resources.GetObject("btndelete.Image")));
            this.btndelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(72, 35);
            this.btndelete.Text = "លុប";
            this.btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.AutoSize = false;
            this.txtsearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(300, 31);
            this.txtsearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsearch_KeyDown);
            // 
            // btnsearch
            // 
            this.btnsearch.Image = ((System.Drawing.Image)(resources.GetObject("btnsearch.Image")));
            this.btnsearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(129, 35);
            this.btnsearch.Text = "ស្រាវជ្រាវ";
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(111, 35);
            this.toolStripButton1.Text = "ឃ្លាំងផ្ទុក";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(productIDLabel);
            this.groupBox1.Controls.Add(this.productIDTextBox);
            this.groupBox1.Controls.Add(this.productcodTextBox);
            this.groupBox1.Controls.Add(productNameLabel);
            this.groupBox1.Controls.Add(this.productNameTextBox);
            this.groupBox1.Controls.Add(stockQtyLabel);
            this.groupBox1.Controls.Add(this.stockQtyTextBox);
            this.groupBox1.Controls.Add(last_priceINLabel);
            this.groupBox1.Controls.Add(this.last_priceINTextBox);
            this.groupBox1.Controls.Add(last_priceOUTLabel);
            this.groupBox1.Controls.Add(this.last_priceOUTTextBox);
            this.groupBox1.Controls.Add(disabledLabel);
            this.groupBox1.Controls.Add(this.disabledCheckBox);
            this.groupBox1.Controls.Add(userIDLabel);
            this.groupBox1.Controls.Add(this.userIDComboBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Khmer Muol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1159, 276);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // productIDTextBox
            // 
            this.productIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblProductBindingSource, "productID", true));
            this.productIDTextBox.Enabled = false;
            this.productIDTextBox.Location = new System.Drawing.Point(183, 32);
            this.productIDTextBox.Name = "productIDTextBox";
            this.productIDTextBox.ReadOnly = true;
            this.productIDTextBox.Size = new System.Drawing.Size(342, 38);
            this.productIDTextBox.TabIndex = 1;
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
            // productcodTextBox
            // 
            this.productcodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblProductBindingSource, "productcod", true));
            this.productcodTextBox.Location = new System.Drawing.Point(183, 80);
            this.productcodTextBox.Name = "productcodTextBox";
            this.productcodTextBox.Size = new System.Drawing.Size(342, 38);
            this.productcodTextBox.TabIndex = 3;
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblProductBindingSource, "productName", true));
            this.productNameTextBox.Location = new System.Drawing.Point(183, 135);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(342, 38);
            this.productNameTextBox.TabIndex = 5;
            // 
            // stockQtyTextBox
            // 
            this.stockQtyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblProductBindingSource, "StockQty", true));
            this.stockQtyTextBox.Location = new System.Drawing.Point(183, 186);
            this.stockQtyTextBox.Name = "stockQtyTextBox";
            this.stockQtyTextBox.Size = new System.Drawing.Size(342, 38);
            this.stockQtyTextBox.TabIndex = 7;
            // 
            // last_priceINTextBox
            // 
            this.last_priceINTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblProductBindingSource, "Last_priceIN", true));
            this.last_priceINTextBox.Location = new System.Drawing.Point(690, 29);
            this.last_priceINTextBox.Name = "last_priceINTextBox";
            this.last_priceINTextBox.Size = new System.Drawing.Size(439, 38);
            this.last_priceINTextBox.TabIndex = 9;
            // 
            // last_priceOUTTextBox
            // 
            this.last_priceOUTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblProductBindingSource, "Last_priceOUT", true));
            this.last_priceOUTTextBox.Location = new System.Drawing.Point(690, 77);
            this.last_priceOUTTextBox.Name = "last_priceOUTTextBox";
            this.last_priceOUTTextBox.Size = new System.Drawing.Size(439, 38);
            this.last_priceOUTTextBox.TabIndex = 11;
            // 
            // disabledCheckBox
            // 
            this.disabledCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tblProductBindingSource, "Disabled", true));
            this.disabledCheckBox.Location = new System.Drawing.Point(690, 198);
            this.disabledCheckBox.Name = "disabledCheckBox";
            this.disabledCheckBox.Size = new System.Drawing.Size(439, 24);
            this.disabledCheckBox.TabIndex = 13;
            this.disabledCheckBox.UseVisualStyleBackColor = true;
            // 
            // userIDComboBox
            // 
            this.userIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblProductBindingSource, "UserID", true));
            this.userIDComboBox.FormattingEnabled = true;
            this.userIDComboBox.Location = new System.Drawing.Point(690, 140);
            this.userIDComboBox.Name = "userIDComboBox";
            this.userIDComboBox.Size = new System.Drawing.Size(439, 39);
            this.userIDComboBox.TabIndex = 15;
            // 
            // tblProductDataGridView
            // 
            this.tblProductDataGridView.AllowUserToAddRows = false;
            this.tblProductDataGridView.AllowUserToDeleteRows = false;
            this.tblProductDataGridView.AutoGenerateColumns = false;
            this.tblProductDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblProductDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.tblProductDataGridView.ColumnHeadersHeight = 29;
            this.tblProductDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewCheckBoxColumn1});
            this.tblProductDataGridView.DataSource = this.tblProductBindingSource;
            this.tblProductDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblProductDataGridView.Location = new System.Drawing.Point(0, 314);
            this.tblProductDataGridView.Name = "tblProductDataGridView";
            this.tblProductDataGridView.ReadOnly = true;
            this.tblProductDataGridView.RowHeadersWidth = 51;
            this.tblProductDataGridView.RowTemplate.Height = 40;
            this.tblProductDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblProductDataGridView.Size = new System.Drawing.Size(1159, 305);
            this.tblProductDataGridView.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "productID";
            this.dataGridViewTextBoxColumn1.HeaderText = "លេខរៀង ";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "productcod";
            this.dataGridViewTextBoxColumn2.HeaderText = "កូដផលិតផល";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "productName";
            this.dataGridViewTextBoxColumn3.HeaderText = "ឈ្មោះផលិតផល";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "StockQty";
            this.dataGridViewTextBoxColumn4.HeaderText = "ចំនួនផលិតផល";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Last_priceIN";
            this.dataGridViewTextBoxColumn5.HeaderText = "តម្លៃនាំចូល";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Last_priceOUT";
            this.dataGridViewTextBoxColumn6.HeaderText = "តម្លៃនាំចេញ";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "UserID";
            this.dataGridViewTextBoxColumn7.HeaderText = "បុគ្គលិក";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Disabled";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Disabled";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // tblProductTableAdapter
            // 
            this.tblProductTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StblSockTableAdapter = null;
            this.tableAdapterManager.tbl_UserTableAdapter = null;
            this.tableAdapterManager.tblGenderTableAdapter = null;
            this.tableAdapterManager.tblProductTableAdapter = this.tblProductTableAdapter;
            this.tableAdapterManager.tblSaleDetailTableAdapter = null;
            this.tableAdapterManager.tblSaleTableAdapter = null;
            this.tableAdapterManager.tblSupplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NPIC2024_Y3S2_DES.db_datasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1159, 619);
            this.Controls.Add(this.tblProductDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProduct";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmProduct_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private db_dataset db_dataset;
        private System.Windows.Forms.BindingSource tblProductBindingSource;
        private db_datasetTableAdapters.tblProductTableAdapter tblProductTableAdapter;
        private db_datasetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnnew;
        private System.Windows.Forms.ToolStripButton btnsave;
        private System.Windows.Forms.ToolStripButton btndelete;
        private System.Windows.Forms.ToolStripTextBox txtsearch;
        private System.Windows.Forms.ToolStripButton btnsearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView tblProductDataGridView;
        private System.Windows.Forms.TextBox productIDTextBox;
        private System.Windows.Forms.TextBox productcodTextBox;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox stockQtyTextBox;
        private System.Windows.Forms.TextBox last_priceINTextBox;
        private System.Windows.Forms.TextBox last_priceOUTTextBox;
        private System.Windows.Forms.CheckBox disabledCheckBox;
        private System.Windows.Forms.ComboBox userIDComboBox;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}