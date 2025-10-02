
namespace NPIC2024_Y3S2_DES
{
    partial class frm_test1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_test1));
            System.Windows.Forms.Label saleDetailIDLabel;
            System.Windows.Forms.Label saleIDLabel;
            System.Windows.Forms.Label productIDLabel;
            System.Windows.Forms.Label qTYLabel;
            System.Windows.Forms.Label priceOUTLabel;
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.frm_test2 = new System.Windows.Forms.Button();
            this.db_dataset = new NPIC2024_Y3S2_DES.db_dataset();
            this.tblSaleDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblSaleDetailTableAdapter = new NPIC2024_Y3S2_DES.db_datasetTableAdapters.tblSaleDetailTableAdapter();
            this.tableAdapterManager = new NPIC2024_Y3S2_DES.db_datasetTableAdapters.TableAdapterManager();
            this.tblSaleDetailBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tblSaleDetailBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.saleDetailIDTextBox = new System.Windows.Forms.TextBox();
            this.saleIDTextBox = new System.Windows.Forms.TextBox();
            this.productIDTextBox = new System.Windows.Forms.TextBox();
            this.qTYTextBox = new System.Windows.Forms.TextBox();
            this.priceOUTTextBox = new System.Windows.Forms.TextBox();
            saleDetailIDLabel = new System.Windows.Forms.Label();
            saleIDLabel = new System.Windows.Forms.Label();
            productIDLabel = new System.Windows.Forms.Label();
            qTYLabel = new System.Windows.Forms.Label();
            priceOUTLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.db_dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSaleDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSaleDetailBindingNavigator)).BeginInit();
            this.tblSaleDetailBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // frm_test2
            // 
            this.frm_test2.Location = new System.Drawing.Point(107, 101);
            this.frm_test2.Name = "frm_test2";
            this.frm_test2.Size = new System.Drawing.Size(268, 192);
            this.frm_test2.TabIndex = 0;
            this.frm_test2.Text = " ";
            this.frm_test2.UseVisualStyleBackColor = true;
            this.frm_test2.Click += new System.EventHandler(this.frm_test2_Click);
            // 
            // db_dataset
            // 
            this.db_dataset.DataSetName = "db_dataset";
            this.db_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblSaleDetailBindingSource
            // 
            this.tblSaleDetailBindingSource.DataMember = "tblSaleDetail";
            this.tblSaleDetailBindingSource.DataSource = this.db_dataset;
            // 
            // tblSaleDetailTableAdapter
            // 
            this.tblSaleDetailTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StblSockTableAdapter = null;
            this.tableAdapterManager.tbl_UserTableAdapter = null;
            this.tableAdapterManager.tblGenderTableAdapter = null;
            this.tableAdapterManager.tblProductTableAdapter = null;
            this.tableAdapterManager.tblSaleDetailTableAdapter = this.tblSaleDetailTableAdapter;
            this.tableAdapterManager.tblSaleTableAdapter = null;
            this.tableAdapterManager.tblSupplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NPIC2024_Y3S2_DES.db_datasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblSaleDetailBindingNavigator
            // 
            this.tblSaleDetailBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblSaleDetailBindingNavigator.BindingSource = this.tblSaleDetailBindingSource;
            this.tblSaleDetailBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblSaleDetailBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblSaleDetailBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tblSaleDetailBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tblSaleDetailBindingNavigatorSaveItem});
            this.tblSaleDetailBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblSaleDetailBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblSaleDetailBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblSaleDetailBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblSaleDetailBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblSaleDetailBindingNavigator.Name = "tblSaleDetailBindingNavigator";
            this.tblSaleDetailBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblSaleDetailBindingNavigator.Size = new System.Drawing.Size(900, 27);
            this.tblSaleDetailBindingNavigator.TabIndex = 1;
            this.tblSaleDetailBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
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
            // tblSaleDetailBindingNavigatorSaveItem
            // 
            this.tblSaleDetailBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblSaleDetailBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblSaleDetailBindingNavigatorSaveItem.Image")));
            this.tblSaleDetailBindingNavigatorSaveItem.Name = "tblSaleDetailBindingNavigatorSaveItem";
            this.tblSaleDetailBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tblSaleDetailBindingNavigatorSaveItem.Text = "Save Data";
            this.tblSaleDetailBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblSaleDetailBindingNavigatorSaveItem_Click);
            // 
            // saleDetailIDLabel
            // 
            saleDetailIDLabel.AutoSize = true;
            saleDetailIDLabel.Location = new System.Drawing.Point(540, 227);
            saleDetailIDLabel.Name = "saleDetailIDLabel";
            saleDetailIDLabel.Size = new System.Drawing.Size(110, 19);
            saleDetailIDLabel.TabIndex = 2;
            saleDetailIDLabel.Text = "Sale Detail ID:";
            // 
            // saleDetailIDTextBox
            // 
            this.saleDetailIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSaleDetailBindingSource, "SaleDetailID", true));
            this.saleDetailIDTextBox.Location = new System.Drawing.Point(656, 224);
            this.saleDetailIDTextBox.Name = "saleDetailIDTextBox";
            this.saleDetailIDTextBox.Size = new System.Drawing.Size(100, 27);
            this.saleDetailIDTextBox.TabIndex = 3;
            // 
            // saleIDLabel
            // 
            saleIDLabel.AutoSize = true;
            saleIDLabel.Location = new System.Drawing.Point(540, 260);
            saleIDLabel.Name = "saleIDLabel";
            saleIDLabel.Size = new System.Drawing.Size(64, 19);
            saleIDLabel.TabIndex = 4;
            saleIDLabel.Text = "Sale ID:";
            // 
            // saleIDTextBox
            // 
            this.saleIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSaleDetailBindingSource, "SaleID", true));
            this.saleIDTextBox.Location = new System.Drawing.Point(656, 257);
            this.saleIDTextBox.Name = "saleIDTextBox";
            this.saleIDTextBox.Size = new System.Drawing.Size(100, 27);
            this.saleIDTextBox.TabIndex = 5;
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Location = new System.Drawing.Point(540, 293);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(89, 19);
            productIDLabel.TabIndex = 6;
            productIDLabel.Text = "Product ID:";
            // 
            // productIDTextBox
            // 
            this.productIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSaleDetailBindingSource, "ProductID", true));
            this.productIDTextBox.Location = new System.Drawing.Point(656, 290);
            this.productIDTextBox.Name = "productIDTextBox";
            this.productIDTextBox.Size = new System.Drawing.Size(100, 27);
            this.productIDTextBox.TabIndex = 7;
            // 
            // qTYLabel
            // 
            qTYLabel.AutoSize = true;
            qTYLabel.Location = new System.Drawing.Point(540, 326);
            qTYLabel.Name = "qTYLabel";
            qTYLabel.Size = new System.Drawing.Size(44, 19);
            qTYLabel.TabIndex = 8;
            qTYLabel.Text = "QTY:";
            // 
            // qTYTextBox
            // 
            this.qTYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSaleDetailBindingSource, "QTY", true));
            this.qTYTextBox.Location = new System.Drawing.Point(656, 323);
            this.qTYTextBox.Name = "qTYTextBox";
            this.qTYTextBox.Size = new System.Drawing.Size(100, 27);
            this.qTYTextBox.TabIndex = 9;
            // 
            // priceOUTLabel
            // 
            priceOUTLabel.AutoSize = true;
            priceOUTLabel.Location = new System.Drawing.Point(540, 359);
            priceOUTLabel.Name = "priceOUTLabel";
            priceOUTLabel.Size = new System.Drawing.Size(85, 19);
            priceOUTLabel.TabIndex = 10;
            priceOUTLabel.Text = "price OUT:";
            // 
            // priceOUTTextBox
            // 
            this.priceOUTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSaleDetailBindingSource, "priceOUT", true));
            this.priceOUTTextBox.Location = new System.Drawing.Point(656, 356);
            this.priceOUTTextBox.Name = "priceOUTTextBox";
            this.priceOUTTextBox.Size = new System.Drawing.Size(100, 27);
            this.priceOUTTextBox.TabIndex = 11;
            // 
            // frm_test1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(900, 534);
            this.Controls.Add(saleDetailIDLabel);
            this.Controls.Add(this.saleDetailIDTextBox);
            this.Controls.Add(saleIDLabel);
            this.Controls.Add(this.saleIDTextBox);
            this.Controls.Add(productIDLabel);
            this.Controls.Add(this.productIDTextBox);
            this.Controls.Add(qTYLabel);
            this.Controls.Add(this.qTYTextBox);
            this.Controls.Add(priceOUTLabel);
            this.Controls.Add(this.priceOUTTextBox);
            this.Controls.Add(this.tblSaleDetailBindingNavigator);
            this.Controls.Add(this.frm_test2);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_test1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_test1";
            this.Load += new System.EventHandler(this.frm_test1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSaleDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSaleDetailBindingNavigator)).EndInit();
            this.tblSaleDetailBindingNavigator.ResumeLayout(false);
            this.tblSaleDetailBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button frm_test2;
        private db_dataset db_dataset;
        private System.Windows.Forms.BindingSource tblSaleDetailBindingSource;
        private db_datasetTableAdapters.tblSaleDetailTableAdapter tblSaleDetailTableAdapter;
        private db_datasetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblSaleDetailBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tblSaleDetailBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox saleDetailIDTextBox;
        private System.Windows.Forms.TextBox saleIDTextBox;
        private System.Windows.Forms.TextBox productIDTextBox;
        private System.Windows.Forms.TextBox qTYTextBox;
        private System.Windows.Forms.TextBox priceOUTTextBox;
    }
}