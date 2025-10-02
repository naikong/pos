
namespace NPIC2024_Y3S2_DES
{
    partial class frmReport_sale
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
            this.View_invoiceReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_dataset = new NPIC2024_Y3S2_DES.db_dataset();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.viewinvoiceReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.View_invoiceReportTableAdapter = new NPIC2024_Y3S2_DES.db_datasetTableAdapters.View_invoiceReportTableAdapter();
            this.viewinvoiceReportBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.viewinvoiceReportBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.viewinvoiceReportBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.View_invoiceReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewinvoiceReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewinvoiceReportBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewinvoiceReportBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewinvoiceReportBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // View_invoiceReportBindingSource
            // 
            this.View_invoiceReportBindingSource.DataMember = "View_invoiceReport";
            this.View_invoiceReportBindingSource.DataSource = this.db_dataset;
            // 
            // db_dataset
            // 
            this.db_dataset.DataSetName = "db_dataset";
            this.db_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet";
            reportDataSource1.Value = this.View_invoiceReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "NPIC2024_Y3S2_DES.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 675);
            this.reportViewer1.TabIndex = 0;
            // 
            // viewinvoiceReportBindingSource
            // 
            this.viewinvoiceReportBindingSource.DataMember = "View_invoiceReport";
            this.viewinvoiceReportBindingSource.DataSource = this.db_dataset;
            // 
            // View_invoiceReportTableAdapter
            // 
            this.View_invoiceReportTableAdapter.ClearBeforeFill = true;
            // 
            // viewinvoiceReportBindingSource1
            // 
            this.viewinvoiceReportBindingSource1.DataMember = "View_invoiceReport";
            this.viewinvoiceReportBindingSource1.DataSource = this.db_dataset;
            // 
            // viewinvoiceReportBindingSource2
            // 
            this.viewinvoiceReportBindingSource2.DataMember = "View_invoiceReport";
            this.viewinvoiceReportBindingSource2.DataSource = this.db_dataset;
            // 
            // viewinvoiceReportBindingSource3
            // 
            this.viewinvoiceReportBindingSource3.DataMember = "View_invoiceReport";
            this.viewinvoiceReportBindingSource3.DataSource = this.db_dataset;
            // 
            // frmReport_sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 675);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Khmer OS Content", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmReport_sale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReport_sale";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReport_sale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.View_invoiceReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewinvoiceReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewinvoiceReportBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewinvoiceReportBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewinvoiceReportBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource View_invoiceReportBindingSource;
        private db_dataset db_dataset;
        private db_datasetTableAdapters.View_invoiceReportTableAdapter View_invoiceReportTableAdapter;
        private System.Windows.Forms.BindingSource viewinvoiceReportBindingSource;
        private System.Windows.Forms.BindingSource viewinvoiceReportBindingSource1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource viewinvoiceReportBindingSource2;
        private System.Windows.Forms.BindingSource viewinvoiceReportBindingSource3;
    }
}