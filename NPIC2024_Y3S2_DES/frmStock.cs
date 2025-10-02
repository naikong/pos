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
    public partial class frmStock : Form
    {
        string userID;
        public frmStock()
        {
            InitializeComponent();
        }

        private void stblSockBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stblSockBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_dataset);

        }

        private void frmStock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_dataset.tblSupplier' table. You can move, or remove it, as needed.
            this.tblSupplierTableAdapter.Fill(this.db_dataset.tblSupplier);
            // TODO: This line of code loads data into the 'db_dataset.tblProduct' table. You can move, or remove it, as needed.
            this.tblProductTableAdapter.Fill(this.db_dataset.tblProduct);
            // TODO: This line of code loads data into the 'db_dataset.StblSock' table. You can move, or remove it, as needed.
            this.stblSockTableAdapter.FillBy(this.db_dataset.StblSock,Convert.ToInt32(pbclass.gb_productID))   ;
            userID = pbclass.Userlog[0];
            userIDComboBox.Items.Add(userID);


        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            this.stblSockBindingSource.AddNew();
            productIDComboBox.SelectedValue = pbclass.gb_productID;
            stockDateDateTimePicker.Text = "01-02-2024";
            stockDateDateTimePicker.Value = DateTime.Today;
             userIDComboBox.SelectedValue = userID;
             userIDComboBox.Text = userID;
        }

        private void txtsaves_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stblSockBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_dataset);
            MessageBox.Show("Save sucessfull");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Are you want to delete?", "Comfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes)
            {
                this.stblSockBindingSource.RemoveCurrent();
                this.Validate();
                this.stblSockBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.db_dataset);
                MessageBox.Show("Delete Successfull!");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
