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
    public partial class frmcalculator : Form
    {
        public frmcalculator()
        {
            InitializeComponent();
        }

        Double result;
        private void frmcalculator_Load(object sender, EventArgs e)
        {

        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            txtnum1.Text = "";
            txtnum2.Text = "";
            txtresult.Text = "";
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnpluse_Click(object sender, EventArgs e)
        {
             result = Convert.ToDouble(txtnum1.Text) + Convert.ToDouble(txtnum2.Text);
            txtresult.Text = result.ToString();
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            result = Convert.ToDouble(txtnum1.Text) - Convert.ToDouble(txtnum2.Text);
            txtresult.Text = result.ToString();
        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {
             result = Convert.ToDouble(txtnum1.Text) * Convert.ToDouble(txtnum2.Text);
            txtresult.Text = result.ToString();
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            result = Convert.ToDouble(txtnum1.Text) / Convert.ToDouble(txtnum2.Text);
            txtresult.Text = result.ToString();
        }
    }
}
