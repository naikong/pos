
namespace NPIC2024_Y3S2_DES
{
    partial class frmReportUser
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.viewinvoiceReportBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.db_dataset = new NPIC2024_Y3S2_DES.db_dataset();
            this.tbl_UserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StblSockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StblSockTableAdapter = new NPIC2024_Y3S2_DES.db_datasetTableAdapters.StblSockTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbl_UserTableAdapter = new NPIC2024_Y3S2_DES.db_datasetTableAdapters.tbl_UserTableAdapter();
            this.viewinvoiceReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_invoiceReportTableAdapter = new NPIC2024_Y3S2_DES.db_datasetTableAdapters.View_invoiceReportTableAdapter();
            this.fKStblSocktblUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.viewinvoiceReportBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_UserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StblSockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewinvoiceReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKStblSocktblUserBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // viewinvoiceReportBindingSource1
            // 
            this.viewinvoiceReportBindingSource1.DataMember = "View_invoiceReport";
            this.viewinvoiceReportBindingSource1.DataSource = this.db_dataset;
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
            // StblSockBindingSource
            // 
            this.StblSockBindingSource.DataMember = "StblSock";
            this.StblSockBindingSource.DataSource = this.db_dataset;
            // 
            // StblSockTableAdapter
            // 
            this.StblSockTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbl_UserBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "NPIC2024_Y3S2_DES.rpUser.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // tbl_UserTableAdapter
            // 
            this.tbl_UserTableAdapter.ClearBeforeFill = true;
            // 
            // viewinvoiceReportBindingSource
            // 
            this.viewinvoiceReportBindingSource.DataMember = "View_invoiceReport";
            this.viewinvoiceReportBindingSource.DataSource = this.db_dataset;
            // 
            // view_invoiceReportTableAdapter
            // 
            this.view_invoiceReportTableAdapter.ClearBeforeFill = true;
            // 
            // fKStblSocktblUserBindingSource
            // 
            this.fKStblSocktblUserBindingSource.DataMember = "FK_StblSock_tbl_User";
            this.fKStblSocktblUserBindingSource.DataSource = this.tbl_UserBindingSource;
            // 
            // frmReportUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReportUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReportUser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReportUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewinvoiceReportBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_UserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StblSockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewinvoiceReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKStblSocktblUserBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource StblSockBindingSource;
        private db_dataset db_dataset;
        private db_datasetTableAdapters.StblSockTableAdapter StblSockTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbl_UserBindingSource;
        private db_datasetTableAdapters.tbl_UserTableAdapter tbl_UserTableAdapter;
        private System.Windows.Forms.BindingSource viewinvoiceReportBindingSource;
        private db_datasetTableAdapters.View_invoiceReportTableAdapter view_invoiceReportTableAdapter;
        private System.Windows.Forms.BindingSource viewinvoiceReportBindingSource1;
        private System.Windows.Forms.BindingSource fKStblSocktblUserBindingSource;
    }
}