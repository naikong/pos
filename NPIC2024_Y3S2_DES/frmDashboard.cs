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
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                tblshow.Text = "Logined BY :" + pbclass.Userlog[1] + ", AS :" +" "+ pbclass.Userlog[2];
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

       

        private void button13_Click(object sender, EventArgs e)
        {
            new frmSaleProduct().ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
          new frmUser1().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmSupplier().ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            new frmStockview().ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new frmSale().ShowDialog();
         //   new frmsale().ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            new frmcalculator().ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new frmProduct().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new frmReportStock().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new frmReportUser().ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new frmReportProduct().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new frmReportSupplier().ShowDialog();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
