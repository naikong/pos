
namespace NPIC2024_Y3S2_DES
{
    partial class frmReportSale
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.db_dataset = new NPIC2024_Y3S2_DES.db_dataset();
            this.View_invoiceReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.View_invoiceReportTableAdapter = new NPIC2024_Y3S2_DES.db_datasetTableAdapters.View_invoiceReportTableAdapter();
            this.StblSockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StblSockTableAdapter = new NPIC2024_Y3S2_DES.db_datasetTableAdapters.StblSockTableAdapter();
            this.viewinvoiceReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.db_dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_invoiceReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StblSockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewinvoiceReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.View_invoiceReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "NPIC2024_Y3S2_DES.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ServerReport.ReportServerUrl = new System.Uri("", System.UriKind.Relative);
            this.reportViewer1.Size = new System.Drawing.Size(749, 558);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // db_dataset
            // 
            this.db_dataset.DataSetName = "db_dataset";
            this.db_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // View_invoiceReportBindingSource
            // 
            this.View_invoiceReportBindingSource.DataMember = "View_invoiceReport";
            this.View_invoiceReportBindingSource.DataSource = this.db_dataset;
            // 
            // View_invoiceReportTableAdapter
            // 
            this.View_invoiceReportTableAdapter.ClearBeforeFill = true;
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
            // viewinvoiceReportBindingSource
            // 
            this.viewinvoiceReportBindingSource.DataMember = "View_invoiceReport";
            this.viewinvoiceReportBindingSource.DataSource = this.db_dataset;
            // 
            // frmReportSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 558);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Kh Battambang", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmReportSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReportSale";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReportSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_invoiceReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StblSockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewinvoiceReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource View_invoiceReportBindingSource;
        private db_dataset db_dataset;
        private db_datasetTableAdapters.View_invoiceReportTableAdapter View_invoiceReportTableAdapter;
        private System.Windows.Forms.BindingSource StblSockBindingSource;
        private db_datasetTableAdapters.StblSockTableAdapter StblSockTableAdapter;
        private System.Windows.Forms.BindingSource viewinvoiceReportBindingSource;
    }
}