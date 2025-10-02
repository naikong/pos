
namespace NPIC2024_Y3S2_DES
{
    partial class frmSupplier
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
            System.Windows.Forms.Label supplierIDLabel;
            System.Windows.Forms.Label supplierNameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label disabledLabel;
            System.Windows.Forms.Label userIDLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupplier));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnnew = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.txtsearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.supplierIDTextBox = new System.Windows.Forms.TextBox();
            this.tblSupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_dataset = new NPIC2024_Y3S2_DES.db_dataset();
            this.supplierNameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.disabledCheckBox = new System.Windows.Forms.CheckBox();
            this.userIDComboBox = new System.Windows.Forms.ComboBox();
            this.tblSupplierTableAdapter = new NPIC2024_Y3S2_DES.db_datasetTableAdapters.tblSupplierTableAdapter();
            this.tableAdapterManager = new NPIC2024_Y3S2_DES.db_datasetTableAdapters.TableAdapterManager();
            this.tblSupplierDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            supplierIDLabel = new System.Windows.Forms.Label();
            supplierNameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            disabledLabel = new System.Windows.Forms.Label();
            userIDLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblSupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSupplierDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // supplierIDLabel
            // 
            supplierIDLabel.AutoSize = true;
            supplierIDLabel.Location = new System.Drawing.Point(11, 37);
            supplierIDLabel.Name = "supplierIDLabel";
            supplierIDLabel.Size = new System.Drawing.Size(140, 31);
            supplierIDLabel.TabIndex = 0;
            supplierIDLabel.Text = "ID  អ្នកផ្គត់ផ្គង :";
            // 
            // supplierNameLabel
            // 
            supplierNameLabel.AutoSize = true;
            supplierNameLabel.Location = new System.Drawing.Point(11, 88);
            supplierNameLabel.Name = "supplierNameLabel";
            supplierNameLabel.Size = new System.Drawing.Size(161, 31);
            supplierNameLabel.TabIndex = 2;
            supplierNameLabel.Text = "ឈ្មោះអ្នកផ្គត់ផ្គង់ :";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(11, 144);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(101, 31);
            addressLabel.TabIndex = 4;
            addressLabel.Text = "អាសដ្ឋាន :";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(567, 91);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(121, 31);
            phoneLabel.TabIndex = 6;
            phoneLabel.Text = "លេខទូរស័ព្ទ :";
            // 
            // disabledLabel
            // 
            disabledLabel.AutoSize = true;
            disabledLabel.Location = new System.Drawing.Point(564, 130);
            disabledLabel.Name = "disabledLabel";
            disabledLabel.Size = new System.Drawing.Size(83, 31);
            disabledLabel.TabIndex = 8;
            disabledLabel.Text = "Disabled:";
            // 
            // userIDLabel
            // 
            userIDLabel.AutoSize = true;
            userIDLabel.Location = new System.Drawing.Point(363, -22);
            userIDLabel.Name = "userIDLabel";
            userIDLabel.Size = new System.Drawing.Size(76, 31);
            userIDLabel.TabIndex = 10;
            userIDLabel.Text = "User ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(564, 37);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(114, 31);
            label1.TabIndex = 12;
            label1.Text = "បុគ្គលិក ID  :";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Blue;
            this.toolStrip1.Font = new System.Drawing.Font("Khmer Muol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnnew,
            this.btnSave,
            this.btnDelete,
            this.txtsearch,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1112, 38);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnnew
            // 
            this.btnnew.ForeColor = System.Drawing.Color.White;
            this.btnnew.Image = ((System.Drawing.Image)(resources.GetObject("btnnew.Image")));
            this.btnnew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(193, 35);
            this.btnnew.Text = "បញ្ជូលអ្នកផ្គតផ្គង់";
            this.btnnew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 35);
            this.btnSave.Text = "រក្សាទុក";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(170, 35);
            this.btnDelete.Text = "លុបអ្នកផ្គងផ្គង";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.AutoSize = false;
            this.txtsearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(300, 31);
            this.txtsearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsearch_KeyDown);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.ForeColor = System.Drawing.Color.White;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(135, 35);
            this.toolStripButton1.Text = "ស្រាវជ្រាវ";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(supplierIDLabel);
            this.groupBox1.Controls.Add(this.supplierIDTextBox);
            this.groupBox1.Controls.Add(supplierNameLabel);
            this.groupBox1.Controls.Add(this.supplierNameTextBox);
            this.groupBox1.Controls.Add(addressLabel);
            this.groupBox1.Controls.Add(this.addressTextBox);
            this.groupBox1.Controls.Add(phoneLabel);
            this.groupBox1.Controls.Add(this.phoneTextBox);
            this.groupBox1.Controls.Add(disabledLabel);
            this.groupBox1.Controls.Add(this.disabledCheckBox);
            this.groupBox1.Controls.Add(userIDLabel);
            this.groupBox1.Controls.Add(this.userIDComboBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Khmer Muol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1112, 211);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // supplierIDTextBox
            // 
            this.supplierIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSupplierBindingSource, "SupplierID", true));
            this.supplierIDTextBox.Enabled = false;
            this.supplierIDTextBox.Location = new System.Drawing.Point(172, 32);
            this.supplierIDTextBox.Name = "supplierIDTextBox";
            this.supplierIDTextBox.ReadOnly = true;
            this.supplierIDTextBox.Size = new System.Drawing.Size(347, 38);
            this.supplierIDTextBox.TabIndex = 1;
            // 
            // tblSupplierBindingSource
            // 
            this.tblSupplierBindingSource.DataMember = "tblSupplier";
            this.tblSupplierBindingSource.DataSource = this.db_dataset;
            // 
            // db_dataset
            // 
            this.db_dataset.DataSetName = "db_dataset";
            this.db_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplierNameTextBox
            // 
            this.supplierNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSupplierBindingSource, "SupplierName", true));
            this.supplierNameTextBox.Location = new System.Drawing.Point(172, 83);
            this.supplierNameTextBox.Name = "supplierNameTextBox";
            this.supplierNameTextBox.Size = new System.Drawing.Size(347, 38);
            this.supplierNameTextBox.TabIndex = 3;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSupplierBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(172, 139);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(347, 38);
            this.addressTextBox.TabIndex = 5;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSupplierBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(730, 91);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(368, 38);
            this.phoneTextBox.TabIndex = 7;
            // 
            // disabledCheckBox
            // 
            this.disabledCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tblSupplierBindingSource, "Disabled", true));
            this.disabledCheckBox.Location = new System.Drawing.Point(730, 130);
            this.disabledCheckBox.Name = "disabledCheckBox";
            this.disabledCheckBox.Size = new System.Drawing.Size(368, 24);
            this.disabledCheckBox.TabIndex = 9;
            this.disabledCheckBox.UseVisualStyleBackColor = true;
            // 
            // userIDComboBox
            // 
            this.userIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSupplierBindingSource, "UserID", true));
            this.userIDComboBox.Enabled = false;
            this.userIDComboBox.FormattingEnabled = true;
            this.userIDComboBox.Location = new System.Drawing.Point(730, 37);
            this.userIDComboBox.Name = "userIDComboBox";
            this.userIDComboBox.Size = new System.Drawing.Size(368, 39);
            this.userIDComboBox.TabIndex = 11;
            // 
            // tblSupplierTableAdapter
            // 
            this.tblSupplierTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StblSockTableAdapter = null;
            this.tableAdapterManager.tbl_UserTableAdapter = null;
            this.tableAdapterManager.tblGenderTableAdapter = null;
            this.tableAdapterManager.tblProductTableAdapter = null;
            this.tableAdapterManager.tblSaleDetailTableAdapter = null;
            this.tableAdapterManager.tblSaleTableAdapter = null;
            this.tableAdapterManager.tblSupplierTableAdapter = this.tblSupplierTableAdapter;
            this.tableAdapterManager.UpdateOrder = NPIC2024_Y3S2_DES.db_datasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblSupplierDataGridView
            // 
            this.tblSupplierDataGridView.AllowUserToAddRows = false;
            this.tblSupplierDataGridView.AllowUserToDeleteRows = false;
            this.tblSupplierDataGridView.AutoGenerateColumns = false;
            this.tblSupplierDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblSupplierDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.tblSupplierDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblSupplierDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn1});
            this.tblSupplierDataGridView.DataSource = this.tblSupplierBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblSupplierDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.tblSupplierDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblSupplierDataGridView.Location = new System.Drawing.Point(0, 249);
            this.tblSupplierDataGridView.Name = "tblSupplierDataGridView";
            this.tblSupplierDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblSupplierDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tblSupplierDataGridView.RowHeadersWidth = 51;
            this.tblSupplierDataGridView.RowTemplate.Height = 24;
            this.tblSupplierDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblSupplierDataGridView.Size = new System.Drawing.Size(1112, 504);
            this.tblSupplierDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SupplierID";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Khmer Muol", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID  អ្នកផ្គត់ផ្គង ";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SupplierName";
            this.dataGridViewTextBoxColumn2.HeaderText = "ឈ្មោះអ្នកផ្គត់ផ្គង់ ";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn3.HeaderText = "អាសដ្ឋាន";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn4.HeaderText = "លេខទូរស័ព្ទ ";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "UserID";
            this.dataGridViewTextBoxColumn5.HeaderText = "បុគ្គលិក ID ";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Disabled";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Disabled";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // frmSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1112, 753);
            this.Controls.Add(this.tblSupplierDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSupplier";
            this.Load += new System.EventHandler(this.frmSupplier_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblSupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSupplierDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnnew;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripTextBox txtsearch;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private db_dataset db_dataset;
        private System.Windows.Forms.BindingSource tblSupplierBindingSource;
        private db_datasetTableAdapters.tblSupplierTableAdapter tblSupplierTableAdapter;
        private db_datasetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox supplierIDTextBox;
        private System.Windows.Forms.TextBox supplierNameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.CheckBox disabledCheckBox;
        private System.Windows.Forms.ComboBox userIDComboBox;
        private System.Windows.Forms.DataGridView tblSupplierDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}