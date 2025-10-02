using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPIC2024_Y3S2_DES
{
    public partial class frmReportSale : Form
    {
        public frmReportSale()
        {
            InitializeComponent();
        }

        private void frmReportSale_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_dataset.StblSock' table. You can move, or remove it, as needed.
            this.StblSockTableAdapter.Fill(this.db_dataset.StblSock);
            // TODO: This line of code loads data into the 'db_dataset.View_invoiceReport' table. You can move, or remove it, as needed.
          //  this.View_invoiceReportTableAdapter.Fill(this.db_dataset.View_invoiceReport);
            this.View_invoiceReportTableAdapter.FillBySaleID(this.db_dataset.View_invoiceReport, Convert.ToInt32(pbclass.invoice_id));


            this.reportViewer1.RefreshReport();
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            this.reportViewer1.ZoomPercent = 100;
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
