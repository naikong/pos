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
    public partial class frmReportSupplier : Form
    {
        public frmReportSupplier()
        {
            InitializeComponent();
        }

        private void frmReportSupplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_dataset.tblSupplier' table. You can move, or remove it, as needed.
            this.tblSupplierTableAdapter.Fill(this.db_dataset.tblSupplier);
            this.reportViewer1.RefreshReport();

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
