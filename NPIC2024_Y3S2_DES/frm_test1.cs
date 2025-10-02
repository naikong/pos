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
    public partial class frm_test1 : Form
    {
        public frm_test1()
        {
            InitializeComponent();
        }

        private void frm_test2_Click(object sender, EventArgs e)
        {
            new frm_test2().ShowDialog();
        }

        private void tblSaleDetailBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblSaleDetailBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_dataset);

        }

        private void frm_test1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_dataset.tblSaleDetail' table. You can move, or remove it, as needed.
            this.tblSaleDetailTableAdapter.Fill(this.db_dataset.tblSaleDetail);

        }
    }
}
