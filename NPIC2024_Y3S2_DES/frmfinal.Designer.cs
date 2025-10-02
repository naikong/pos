
namespace NPIC2024_Y3S2_DES
{
    partial class frmfinal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmfinal));
            System.Windows.Forms.Label saleIDLabel;
            System.Windows.Forms.Label saleDateLabel;
            System.Windows.Forms.Label userIDLabel;
            this.db_dataset = new NPIC2024_Y3S2_DES.db_dataset();
            this.tblSaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblSaleTableAdapter = new NPIC2024_Y3S2_DES.db_datasetTableAdapters.tblSaleTableAdapter();
            this.tableAdapterManager = new NPIC2024_Y3S2_DES.db_datasetTableAdapters.TableAdapterManager();
            this.tblSaleBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tblSaleBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.saleIDTextBox = new System.Windows.Forms.TextBox();
            this.saleDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.userIDComboBox = new System.Windows.Forms.ComboBox();
            saleIDLabel = new System.Windows.Forms.Label();
            saleDateLabel = new System.Windows.Forms.Label();
            userIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.db_dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSaleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSaleBindingNavigator)).BeginInit();
            this.tblSaleBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // db_dataset
            // 
            this.db_dataset.DataSetName = "db_dataset";
            this.db_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblSaleBindingSource
            // 
            this.tblSaleBindingSource.DataMember = "tblSale";
            this.tblSaleBindingSource.DataSource = this.db_dataset;
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
            // tblSaleBindingNavigator
            // 
            this.tblSaleBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblSaleBindingNavigator.BindingSource = this.tblSaleBindingSource;
            this.tblSaleBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblSaleBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblSaleBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tblSaleBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tblSaleBindingNavigatorSaveItem});
            this.tblSaleBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblSaleBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblSaleBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblSaleBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblSaleBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblSaleBindingNavigator.Name = "tblSaleBindingNavigator";
            this.tblSaleBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblSaleBindingNavigator.Size = new System.Drawing.Size(800, 29);
            this.tblSaleBindingNavigator.TabIndex = 0;
            this.tblSaleBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 20);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
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
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 26);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // tblSaleBindingNavigatorSaveItem
            // 
            this.tblSaleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblSaleBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblSaleBindingNavigatorSaveItem.Image")));
            this.tblSaleBindingNavigatorSaveItem.Name = "tblSaleBindingNavigatorSaveItem";
            this.tblSaleBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tblSaleBindingNavigatorSaveItem.Text = "Save Data";
            this.tblSaleBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblSaleBindingNavigatorSaveItem_Click);
            // 
            // saleIDLabel
            // 
            saleIDLabel.AutoSize = true;
            saleIDLabel.Location = new System.Drawing.Point(440, 285);
            saleIDLabel.Name = "saleIDLabel";
            saleIDLabel.Size = new System.Drawing.Size(57, 17);
            saleIDLabel.TabIndex = 1;
            saleIDLabel.Text = "Sale ID:";
            // 
            // saleIDTextBox
            // 
            this.saleIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSaleBindingSource, "SaleID", true));
            this.saleIDTextBox.Location = new System.Drawing.Point(520, 282);
            this.saleIDTextBox.Name = "saleIDTextBox";
            this.saleIDTextBox.Size = new System.Drawing.Size(200, 22);
            this.saleIDTextBox.TabIndex = 2;
            // 
            // saleDateLabel
            // 
            saleDateLabel.AutoSize = true;
            saleDateLabel.Location = new System.Drawing.Point(440, 314);
            saleDateLabel.Name = "saleDateLabel";
            saleDateLabel.Size = new System.Drawing.Size(74, 17);
            saleDateLabel.TabIndex = 3;
            saleDateLabel.Text = "Sale Date:";
            // 
            // saleDateDateTimePicker
            // 
            this.saleDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblSaleBindingSource, "SaleDate", true));
            this.saleDateDateTimePicker.Location = new System.Drawing.Point(520, 310);
            this.saleDateDateTimePicker.Name = "saleDateDateTimePicker";
            this.saleDateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.saleDateDateTimePicker.TabIndex = 4;
            // 
            // userIDLabel
            // 
            userIDLabel.AutoSize = true;
            userIDLabel.Location = new System.Drawing.Point(440, 341);
            userIDLabel.Name = "userIDLabel";
            userIDLabel.Size = new System.Drawing.Size(59, 17);
            userIDLabel.TabIndex = 5;
            userIDLabel.Text = "User ID:";
            // 
            // userIDComboBox
            // 
            this.userIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSaleBindingSource, "UserID", true));
            this.userIDComboBox.FormattingEnabled = true;
            this.userIDComboBox.Location = new System.Drawing.Point(520, 338);
            this.userIDComboBox.Name = "userIDComboBox";
            this.userIDComboBox.Size = new System.Drawing.Size(200, 24);
            this.userIDComboBox.TabIndex = 6;
            // 
            // frmfinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(saleIDLabel);
            this.Controls.Add(this.saleIDTextBox);
            this.Controls.Add(saleDateLabel);
            this.Controls.Add(this.saleDateDateTimePicker);
            this.Controls.Add(userIDLabel);
            this.Controls.Add(this.userIDComboBox);
            this.Controls.Add(this.tblSaleBindingNavigator);
            this.Name = "frmfinal";
            this.Text = "frmfinal";
            this.Load += new System.EventHandler(this.frmfinal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSaleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSaleBindingNavigator)).EndInit();
            this.tblSaleBindingNavigator.ResumeLayout(false);
            this.tblSaleBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private db_dataset db_dataset;
        private System.Windows.Forms.BindingSource tblSaleBindingSource;
        private db_datasetTableAdapters.tblSaleTableAdapter tblSaleTableAdapter;
        private db_datasetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblSaleBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tblSaleBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox saleIDTextBox;
        private System.Windows.Forms.DateTimePicker saleDateDateTimePicker;
        private System.Windows.Forms.ComboBox userIDComboBox;
    }
}