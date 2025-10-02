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
    public partial class frmStockview : Form
    {
        public frmStockview()
        {
            InitializeComponent();
        }

        private void tblProductBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblProductBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_dataset);

        }

        private void frmStockview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_dataset.tblProduct' table. You can move, or remove it, as needed.
            this.tblProductTableAdapter.Fill(this.db_dataset.tblProduct);
            txtsearch.Focus();

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblProductBindingSource.Filter = "productcod+productName like'%" + txtsearch.Text.Replace("'", "'") + "%'";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtsearch_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                btnsearch_Click(sender, e);
            }
        }
    }
}
