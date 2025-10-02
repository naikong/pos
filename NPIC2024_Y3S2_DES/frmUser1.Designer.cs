
namespace NPIC2024_Y3S2_DES
{
    partial class frmUser1
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
            System.Windows.Forms.Label userIDLabel;
            System.Windows.Forms.Label userlabelLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label dOBLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label userlavelLabel;
            System.Windows.Forms.Label disableLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnnew = new System.Windows.Forms.ToolStripButton();
            this.btnsave = new System.Windows.Forms.ToolStripButton();
            this.btndelete = new System.Windows.Forms.ToolStripButton();
            this.txtsearch = new System.Windows.Forms.ToolStripTextBox();
            this.btnsearch = new System.Windows.Forms.ToolStripButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.db_dataset = new NPIC2024_Y3S2_DES.db_dataset();
            this.tbl_UserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_UserTableAdapter = new NPIC2024_Y3S2_DES.db_datasetTableAdapters.tbl_UserTableAdapter();
            this.tableAdapterManager = new NPIC2024_Y3S2_DES.db_datasetTableAdapters.TableAdapterManager();
            this.tblGenderTableAdapter = new NPIC2024_Y3S2_DES.db_datasetTableAdapters.tblGenderTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.userIDTextBox = new System.Windows.Forms.TextBox();
            this.userlabelTextBox = new System.Windows.Forms.TextBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.tblGenderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dOBDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.userlavelComboBox = new System.Windows.Forms.ComboBox();
            this.disableCheckBox = new System.Windows.Forms.CheckBox();
            this.tbl_UserDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            userIDLabel = new System.Windows.Forms.Label();
            userlabelLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            dOBLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            userlavelLabel = new System.Windows.Forms.Label();
            disableLabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_UserBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblGenderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_UserDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // userIDLabel
            // 
            userIDLabel.AutoSize = true;
            userIDLabel.Location = new System.Drawing.Point(12, 69);
            userIDLabel.Name = "userIDLabel";
            userIDLabel.Size = new System.Drawing.Size(109, 31);
            userIDLabel.TabIndex = 0;
            userIDLabel.Text = " បុគ្កលិក ID:";
            // 
            // userlabelLabel
            // 
            userlabelLabel.AutoSize = true;
            userlabelLabel.Location = new System.Drawing.Point(12, 117);
            userlabelLabel.Name = "userlabelLabel";
            userlabelLabel.Size = new System.Drawing.Size(135, 31);
            userlabelLabel.TabIndex = 2;
            userlabelLabel.Text = "ឈ្មោះបុគ្គលិក :";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(12, 166);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(61, 31);
            genderLabel.TabIndex = 4;
            genderLabel.Text = "ភេទ :";
            // 
            // dOBLabel
            // 
            dOBLabel.AutoSize = true;
            dOBLabel.Location = new System.Drawing.Point(12, 212);
            dOBLabel.Name = "dOBLabel";
            dOBLabel.Size = new System.Drawing.Size(158, 31);
            dOBLabel.TabIndex = 6;
            dOBLabel.Text = "ថ្ងៃ/ខែ/ឆ្នាំកំណើត:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(554, 112);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(116, 31);
            phoneLabel.TabIndex = 8;
            phoneLabel.Text = "លេខទូរស័ព្ទ:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(545, 56);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(173, 31);
            usernameLabel.TabIndex = 10;
            usernameLabel.Text = "ឈ្មោះអ្នកប្រើប្រាស:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(554, 175);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(150, 31);
            passwordLabel.TabIndex = 12;
            passwordLabel.Text = "លេខកូដសម្ងាត :";
            // 
            // userlavelLabel
            // 
            userlavelLabel.AutoSize = true;
            userlavelLabel.Location = new System.Drawing.Point(554, 216);
            userlavelLabel.Name = "userlavelLabel";
            userlavelLabel.Size = new System.Drawing.Size(83, 31);
            userlavelLabel.TabIndex = 14;
            userlavelLabel.Text = "មុខងារ :";
            // 
            // disableLabel
            // 
            disableLabel.AutoSize = true;
            disableLabel.Location = new System.Drawing.Point(554, 264);
            disableLabel.Name = "disableLabel";
            disableLabel.Size = new System.Drawing.Size(74, 31);
            disableLabel.TabIndex = 16;
            disableLabel.Text = "Disable:";
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
            this.btnsearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1206, 38);
            this.toolStrip1.TabIndex = 18;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnnew
            // 
            this.btnnew.ForeColor = System.Drawing.Color.White;
            this.btnnew.Image = ((System.Drawing.Image)(resources.GetObject("btnnew.Image")));
            this.btnnew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(158, 35);
            this.btnnew.Text = "បញ្ជូលបុគ្គលិក";
            this.btnnew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnsave
            // 
            this.btnsave.ForeColor = System.Drawing.Color.White;
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
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Image = ((System.Drawing.Image)(resources.GetObject("btndelete.Image")));
            this.btndelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(183, 35);
            this.btndelete.Text = "លុបឈ្មោះបុគ្គលិក";
            this.btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.AutoSize = false;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(300, 31);
            this.txtsearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsearch_KeyDown);
            // 
            // btnsearch
            // 
            this.btnsearch.ForeColor = System.Drawing.Color.White;
            this.btnsearch.Image = ((System.Drawing.Image)(resources.GetObject("btnsearch.Image")));
            this.btnsearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(129, 35);
            this.btnsearch.Text = "ស្រាវជ្រាវ";
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // db_dataset
            // 
            this.db_dataset.DataSetName = "db_dataset";
            this.db_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_UserBindingSource
            // 
            this.tbl_UserBindingSource.DataMember = "tbl_User";
            this.tbl_UserBindingSource.DataSource = this.db_dataset;
            // 
            // tbl_UserTableAdapter
            // 
            this.tbl_UserTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StblSockTableAdapter = null;
            this.tableAdapterManager.tbl_UserTableAdapter = this.tbl_UserTableAdapter;
            this.tableAdapterManager.tblGenderTableAdapter = this.tblGenderTableAdapter;
            this.tableAdapterManager.tblProductTableAdapter = null;
            this.tableAdapterManager.tblSaleDetailTableAdapter = null;
            this.tableAdapterManager.tblSaleTableAdapter = null;
            this.tableAdapterManager.tblSupplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NPIC2024_Y3S2_DES.db_datasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblGenderTableAdapter
            // 
            this.tblGenderTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Controls.Add(userIDLabel);
            this.groupBox1.Controls.Add(this.userIDTextBox);
            this.groupBox1.Controls.Add(userlabelLabel);
            this.groupBox1.Controls.Add(this.userlabelTextBox);
            this.groupBox1.Controls.Add(genderLabel);
            this.groupBox1.Controls.Add(this.genderComboBox);
            this.groupBox1.Controls.Add(dOBLabel);
            this.groupBox1.Controls.Add(this.dOBDateTimePicker);
            this.groupBox1.Controls.Add(phoneLabel);
            this.groupBox1.Controls.Add(this.phoneTextBox);
            this.groupBox1.Controls.Add(usernameLabel);
            this.groupBox1.Controls.Add(this.usernameTextBox);
            this.groupBox1.Controls.Add(passwordLabel);
            this.groupBox1.Controls.Add(this.passwordTextBox);
            this.groupBox1.Controls.Add(userlavelLabel);
            this.groupBox1.Controls.Add(this.userlavelComboBox);
            this.groupBox1.Controls.Add(disableLabel);
            this.groupBox1.Controls.Add(this.disableCheckBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Khmer Muol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1206, 311);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // userIDTextBox
            // 
            this.userIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_UserBindingSource, "UserID", true));
            this.userIDTextBox.Enabled = false;
            this.userIDTextBox.Location = new System.Drawing.Point(173, 56);
            this.userIDTextBox.Name = "userIDTextBox";
            this.userIDTextBox.ReadOnly = true;
            this.userIDTextBox.Size = new System.Drawing.Size(359, 38);
            this.userIDTextBox.TabIndex = 1;
            // 
            // userlabelTextBox
            // 
            this.userlabelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_UserBindingSource, "Userlabel", true));
            this.userlabelTextBox.Location = new System.Drawing.Point(173, 109);
            this.userlabelTextBox.Name = "userlabelTextBox";
            this.userlabelTextBox.Size = new System.Drawing.Size(359, 38);
            this.userlabelTextBox.TabIndex = 3;
            // 
            // genderComboBox
            // 
            this.genderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbl_UserBindingSource, "Gender", true));
            this.genderComboBox.DataSource = this.tblGenderBindingSource;
            this.genderComboBox.DisplayMember = "gender_title_kh_full";
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(173, 158);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(359, 39);
            this.genderComboBox.TabIndex = 5;
            this.genderComboBox.ValueMember = "genderID";
            // 
            // tblGenderBindingSource
            // 
            this.tblGenderBindingSource.DataMember = "tblGender";
            this.tblGenderBindingSource.DataSource = this.db_dataset;
            // 
            // dOBDateTimePicker
            // 
            this.dOBDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_UserBindingSource, "DOB", true));
            this.dOBDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dOBDateTimePicker.Location = new System.Drawing.Point(173, 207);
            this.dOBDateTimePicker.Name = "dOBDateTimePicker";
            this.dOBDateTimePicker.Size = new System.Drawing.Size(359, 38);
            this.dOBDateTimePicker.TabIndex = 7;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_UserBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(724, 104);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(388, 38);
            this.phoneTextBox.TabIndex = 9;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_UserBindingSource, "Username", true));
            this.usernameTextBox.Location = new System.Drawing.Point(728, 49);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(388, 38);
            this.usernameTextBox.TabIndex = 11;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_UserBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(724, 158);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(388, 38);
            this.passwordTextBox.TabIndex = 13;
            // 
            // userlavelComboBox
            // 
            this.userlavelComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_UserBindingSource, "Userlavel", true));
            this.userlavelComboBox.FormattingEnabled = true;
            this.userlavelComboBox.Items.AddRange(new object[] {
            "User",
            "Admin"});
            this.userlavelComboBox.Location = new System.Drawing.Point(724, 216);
            this.userlavelComboBox.Name = "userlavelComboBox";
            this.userlavelComboBox.Size = new System.Drawing.Size(388, 39);
            this.userlavelComboBox.TabIndex = 15;
            // 
            // disableCheckBox
            // 
            this.disableCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tbl_UserBindingSource, "Disable", true));
            this.disableCheckBox.Location = new System.Drawing.Point(724, 268);
            this.disableCheckBox.Name = "disableCheckBox";
            this.disableCheckBox.Size = new System.Drawing.Size(441, 24);
            this.disableCheckBox.TabIndex = 17;
            this.disableCheckBox.UseVisualStyleBackColor = true;
            // 
            // tbl_UserDataGridView
            // 
            this.tbl_UserDataGridView.AllowUserToAddRows = false;
            this.tbl_UserDataGridView.AllowUserToDeleteRows = false;
            this.tbl_UserDataGridView.AutoGenerateColumns = false;
            this.tbl_UserDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbl_UserDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.tbl_UserDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbl_UserDataGridView.ColumnHeadersHeight = 29;
            this.tbl_UserDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewCheckBoxColumn1});
            this.tbl_UserDataGridView.DataSource = this.tbl_UserBindingSource;
            this.tbl_UserDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbl_UserDataGridView.Location = new System.Drawing.Point(0, 349);
            this.tbl_UserDataGridView.Name = "tbl_UserDataGridView";
            this.tbl_UserDataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbl_UserDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tbl_UserDataGridView.RowHeadersWidth = 51;
            this.tbl_UserDataGridView.RowTemplate.Height = 24;
            this.tbl_UserDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbl_UserDataGridView.Size = new System.Drawing.Size(1206, 384);
            this.tbl_UserDataGridView.TabIndex = 19;
            this.tbl_UserDataGridView.Click += new System.EventHandler(this.tbl_UserDataGridView_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "UserID";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Khmer Muol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn1.FillWeight = 120F;
            this.dataGridViewTextBoxColumn1.HeaderText = " បុគ្កលិក ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Userlabel";
            this.dataGridViewTextBoxColumn2.FillWeight = 120F;
            this.dataGridViewTextBoxColumn2.HeaderText = "ឈ្មោះបុគ្គលិក ";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Gender";
            this.dataGridViewTextBoxColumn3.HeaderText = "ភេទ";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DOB";
            this.dataGridViewTextBoxColumn4.FillWeight = 120F;
            this.dataGridViewTextBoxColumn4.HeaderText = "ថ្ងៃ/ខែ/ឆ្នាំកំណើត";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn5.HeaderText = "លេខទូរស័ព្ទ";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Username";
            this.dataGridViewTextBoxColumn6.FillWeight = 120F;
            this.dataGridViewTextBoxColumn6.HeaderText = "ឈ្មោះអ្នកប្រើប្រាស";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Userlavel";
            this.dataGridViewTextBoxColumn8.HeaderText = "មុខងារ";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Disable";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Disable";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // frmUser1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1227, 732);
            this.Controls.Add(this.tbl_UserDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUser1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUser1";
            this.Load += new System.EventHandler(this.frmUser1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_UserBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblGenderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_UserDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnnew;
        private System.Windows.Forms.ToolStripButton btnsave;
        private System.Windows.Forms.ToolStripButton btndelete;
        private System.Windows.Forms.ToolStripTextBox txtsearch;
        private System.Windows.Forms.ToolStripButton btnsearch;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private db_dataset db_dataset;
        private System.Windows.Forms.BindingSource tbl_UserBindingSource;
        private db_datasetTableAdapters.tbl_UserTableAdapter tbl_UserTableAdapter;
        private db_datasetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox userIDTextBox;
        private System.Windows.Forms.TextBox userlabelTextBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.DateTimePicker dOBDateTimePicker;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.ComboBox userlavelComboBox;
        private System.Windows.Forms.CheckBox disableCheckBox;
        private System.Windows.Forms.DataGridView tbl_UserDataGridView;
        private db_datasetTableAdapters.tblGenderTableAdapter tblGenderTableAdapter;
        private System.Windows.Forms.BindingSource tblGenderBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}