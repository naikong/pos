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
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }
        string UserID;
        private void tblProductBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblProductBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_dataset);

        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'db_dataset.tblProduct' table. You can move, or remove it, as needed.
            this.tblProductTableAdapter.Fill(this.db_dataset.tblProduct);
            
            UserID = pbclass.Userlog[0];
            userIDComboBox.Items.Add(UserID);



        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblProductBindingSource.AddNew();
                //userIDComboBox.SelectedValue = UserID;
                userIDComboBox.Text = UserID;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.tblProductBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.db_dataset);
                MessageBox.Show("Do you want to save?");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                var msg = MessageBox.Show("Are you want to delete?", "Comfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg == DialogResult.Yes)
                {
                    this.tblProductBindingSource.RemoveCurrent();
                    this.Validate();
                    this.tblProductBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.db_dataset);
                    MessageBox.Show("Delete Successfull!");
                }
               
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            this.tblProductBindingSource.Filter = "productcod+productName like'%" + txtsearch.Text.Replace("'", "'") + "%'";
        }

        private void txtsearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnsearch_Click(sender, e);
            }
        }

       

        private void toolStripButton1_Click(object sender, EventArgs e)

        {
            pbclass.gb_productID = productIDTextBox.Text;
            frmStock stockForm = new frmStock();
            stockForm.FormClosed += new FormClosedEventHandler(StockForm_FormClosed);
            stockForm.Show();

        }
        private void StockForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.tblProductTableAdapter.Fill(this.db_dataset.tblProduct);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
