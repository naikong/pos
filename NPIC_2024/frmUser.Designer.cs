
namespace NPIC_2024
{
    partial class frmUser
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
            System.Windows.Forms.Label useridLabel;
            System.Windows.Forms.Label firstnameLabel;
            System.Windows.Forms.Label lastnameLabel;
            System.Windows.Forms.Label emailidLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label contactnumberLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new NPIC_2024.DataSet1();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtcontactnumber = new System.Windows.Forms.TextBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnaddnew = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.userTableAdapter = new NPIC_2024.DataSet1TableAdapters.userTableAdapter();
            this.tableAdapterManager = new NPIC_2024.DataSet1TableAdapters.TableAdapterManager();
            this.dvgshow = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            useridLabel = new System.Windows.Forms.Label();
            firstnameLabel = new System.Windows.Forms.Label();
            lastnameLabel = new System.Windows.Forms.Label();
            emailidLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            contactnumberLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgshow)).BeginInit();
            this.SuspendLayout();
            // 
            // useridLabel
            // 
            useridLabel.AutoSize = true;
            useridLabel.Location = new System.Drawing.Point(51, 46);
            useridLabel.Name = "useridLabel";
            useridLabel.Size = new System.Drawing.Size(0, 22);
            useridLabel.TabIndex = 13;
            // 
            // firstnameLabel
            // 
            firstnameLabel.AutoSize = true;
            firstnameLabel.Location = new System.Drawing.Point(40, 60);
            firstnameLabel.Name = "firstnameLabel";
            firstnameLabel.Size = new System.Drawing.Size(89, 22);
            firstnameLabel.TabIndex = 15;
            firstnameLabel.Text = "firstname:";
            // 
            // lastnameLabel
            // 
            lastnameLabel.AutoSize = true;
            lastnameLabel.Location = new System.Drawing.Point(44, 101);
            lastnameLabel.Name = "lastnameLabel";
            lastnameLabel.Size = new System.Drawing.Size(85, 22);
            lastnameLabel.TabIndex = 17;
            lastnameLabel.Text = "lastname:";
            // 
            // emailidLabel
            // 
            emailidLabel.AutoSize = true;
            emailidLabel.Location = new System.Drawing.Point(40, 132);
            emailidLabel.Name = "emailidLabel";
            emailidLabel.Size = new System.Drawing.Size(79, 22);
            emailidLabel.TabIndex = 19;
            emailidLabel.Text = "Emailid:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(40, 168);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(93, 22);
            passwordLabel.TabIndex = 21;
            passwordLabel.Text = "password:";
            // 
            // contactnumberLabel
            // 
            contactnumberLabel.AutoSize = true;
            contactnumberLabel.Location = new System.Drawing.Point(40, 204);
            contactnumberLabel.Name = "contactnumberLabel";
            contactnumberLabel.Size = new System.Drawing.Size(130, 22);
            contactnumberLabel.TabIndex = 23;
            contactnumberLabel.Text = "contactnumber:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(useridLabel);
            this.groupBox1.Controls.Add(firstnameLabel);
            this.groupBox1.Controls.Add(this.txtfirstname);
            this.groupBox1.Controls.Add(lastnameLabel);
            this.groupBox1.Controls.Add(this.txtlastname);
            this.groupBox1.Controls.Add(emailidLabel);
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(passwordLabel);
            this.groupBox1.Controls.Add(this.txtpassword);
            this.groupBox1.Controls.Add(contactnumberLabel);
            this.groupBox1.Controls.Add(this.txtcontactnumber);
            this.groupBox1.Controls.Add(this.btncancel);
            this.groupBox1.Controls.Add(this.btnaddnew);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(926, 339);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Registration Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtfirstname
            // 
            this.txtfirstname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "firstname", true));
            this.txtfirstname.Location = new System.Drawing.Point(176, 57);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(396, 30);
            this.txtfirstname.TabIndex = 16;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "user";
            this.userBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtlastname
            // 
            this.txtlastname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "lastname", true));
            this.txtlastname.Location = new System.Drawing.Point(176, 93);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(396, 30);
            this.txtlastname.TabIndex = 18;
            // 
            // txtemail
            // 
            this.txtemail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Emailid", true));
            this.txtemail.Location = new System.Drawing.Point(176, 129);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(396, 30);
            this.txtemail.TabIndex = 20;
            // 
            // txtpassword
            // 
            this.txtpassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "password", true));
            this.txtpassword.Location = new System.Drawing.Point(176, 165);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(396, 30);
            this.txtpassword.TabIndex = 22;
            // 
            // txtcontactnumber
            // 
            this.txtcontactnumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "contactnumber", true));
            this.txtcontactnumber.Location = new System.Drawing.Point(176, 201);
            this.txtcontactnumber.Name = "txtcontactnumber";
            this.txtcontactnumber.Size = new System.Drawing.Size(396, 30);
            this.txtcontactnumber.TabIndex = 24;
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(474, 237);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(98, 44);
            this.btncancel.TabIndex = 13;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // btnaddnew
            // 
            this.btnaddnew.Location = new System.Drawing.Point(341, 237);
            this.btnaddnew.Name = "btnaddnew";
            this.btnaddnew.Size = new System.Drawing.Size(98, 44);
            this.btnaddnew.TabIndex = 12;
            this.btnaddnew.Text = "Addnew";
            this.btnaddnew.UseVisualStyleBackColor = true;
            this.btnaddnew.Click += new System.EventHandler(this.btnaddnew_Click);
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = NPIC_2024.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = this.userTableAdapter;
            // 
            // dvgshow
            // 
            this.dvgshow.AllowUserToAddRows = false;
            this.dvgshow.AllowUserToDeleteRows = false;
            this.dvgshow.AutoGenerateColumns = false;
            this.dvgshow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgshow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.edit,
            this.delete});
            this.dvgshow.DataSource = this.userBindingSource;
            this.dvgshow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgshow.Location = new System.Drawing.Point(0, 339);
            this.dvgshow.Name = "dvgshow";
            this.dvgshow.ReadOnly = true;
            this.dvgshow.RowHeadersWidth = 51;
            this.dvgshow.RowTemplate.Height = 24;
            this.dvgshow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgshow.Size = new System.Drawing.Size(926, 313);
            this.dvgshow.TabIndex = 1;
            this.dvgshow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "firstname";
            this.dataGridViewTextBoxColumn2.HeaderText = "firstname";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "lastname";
            this.dataGridViewTextBoxColumn3.HeaderText = "lastname";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Emailid";
            this.dataGridViewTextBoxColumn4.HeaderText = "Emailid";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "password";
            this.dataGridViewTextBoxColumn5.HeaderText = "password";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "contactnumber";
            this.dataGridViewTextBoxColumn6.HeaderText = "contactnumber";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // edit
            // 
            this.edit.DataPropertyName = "userid";
            this.edit.HeaderText = "Edit";
            this.edit.MinimumWidth = 6;
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Text = "Edit";
            this.edit.UseColumnTextForButtonValue = true;
            this.edit.Width = 125;
            // 
            // delete
            // 
            this.delete.DataPropertyName = "userid";
            this.delete.HeaderText = "Delete";
            this.delete.MinimumWidth = 6;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Text = "Delete";
            this.delete.UseColumnTextForButtonValue = true;
            this.delete.Width = 125;
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 652);
            this.Controls.Add(this.dvgshow);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUser";
            this.Load += new System.EventHandler(this.frmUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgshow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private DataSet1TableAdapters.userTableAdapter userTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnaddnew;
        private System.Windows.Forms.DataGridView dvgshow;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtcontactnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}