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
    public partial class frmUser1 : Form
    {
        public frmUser1()
        {
            InitializeComponent();
        }

        private void frmUser1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_dataset.tblGender' table. You can move, or remove it, as needed.
            this.tblGenderTableAdapter.Fill(this.db_dataset.tblGender);
            // TODO: This line of code loads data into the 'db_dataset.tbl_User' table. You can move, or remove it, as needed.
            this.tbl_UserTableAdapter.Fill(this.db_dataset.tbl_User);

        }

        private void tbl_UserBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_UserBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_dataset);
            //

        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbl_UserBindingSource.AddNew();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_UserBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_dataset);
            MessageBox.Show("Save Successfull");
            this.tblGenderTableAdapter.Fill(this.db_dataset.tblGender);



        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Are your sure you want to delete?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes)
            {
                this.tbl_UserBindingSource.RemoveCurrent();
                this.Validate();
                this.tbl_UserBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.db_dataset);


                //
               
                }


        }

        private void tbl_UserDataGridView_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow dr in tbl_UserDataGridView.SelectedRows)
            {
                this.tbl_UserTableAdapter.FillByUserID(this.db_dataset.tbl_User,Convert.ToInt32(dr.Cells[0].Value));


            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbl_UserBindingSource.Filter = "Userlabel+DOB+Phone+Username Like'%" + txtsearch.Text.Replace("'", "'") + "%'";
                //'%" +txtsearch.Text.Replace("'", "''") + " % '";

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
                btnsearch_Click(sender,e);
            }
        }

       

        

       

       
    }
}
