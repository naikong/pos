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
    public partial class frmSupplier : Form
    {
        public frmSupplier()
        {
            InitializeComponent();
        }


        String UserID;
        private void tblSupplierBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblSupplierBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_dataset);

        }

        private void frmSupplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_dataset.tblSupplier' table. You can move, or remove it, as needed.
            this.tblSupplierTableAdapter.Fill(this.db_dataset.tblSupplier);
            UserID = pbclass.Userlog[0];
            userIDComboBox.SelectedValue = UserID;
            userIDComboBox.Items.Add(UserID);

        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            //insert 
            try
            {
                this.tblSupplierBindingSource.AddNew();
                userIDComboBox.Text = UserID;
                userIDComboBox.Items.Add(UserID);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //save data
            try
            {

                this.Validate();
                this.tblSupplierBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.db_dataset);
                MessageBox.Show("Save Data");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.tblSupplierBindingSource.Filter = "SupplierName+Phone LIKE '%" + txtsearch.Text.Replace("'", "''") + "%'";


        }

        private void txtsearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                toolStripButton1_Click(sender, e);
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            // Dalate
            try
            {
                var msg = MessageBox.Show("Are you want to delete!", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg == DialogResult.Yes)
                {
                    this.tblSupplierBindingSource.RemoveCurrent();
                    this.Validate();
                    this.tblSupplierBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.db_dataset);




                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
