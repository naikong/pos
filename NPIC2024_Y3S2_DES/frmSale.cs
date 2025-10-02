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
    public partial class frmSale : Form
    {
        public frmSale()
        {
            InitializeComponent();
        }
        Double Sum_price;
        //private void clear_text()
        //{
        //    txtsearchproductcode.Text = "";
        //    txtproductname.Text = "";
        //    txtprice.Text = "";
            
        //    txtsearchproductcode.Focus();
        //    Sum_price = dvgshow.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDouble(t.Cells[4].Value));
        //    lblsum.Text = Sum_price.ToString();


        //}
        private void tblSaleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblSaleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_dataset);

        }

        private void frmSale_Load(object sender, EventArgs e)
        {
            this.tblSaleTableAdapter.Fill(this.db_dataset.tblSale);
            // TODO: This line of code loads data into the 'db_dataset.tblProduct' table. You can move, or remove it, as needed.
            this.tblSaleDetailTableAdapter.Fill(this.db_dataset.tblSaleDetail);
            // TODO: This line of code loads data into the 'db_dataset.tblSale' table. You can move, or remove it, as needed.
            this.tblProductTableAdapter.Fill(this.db_dataset.tblProduct);
            // TODO: This line of code loads data into the 'db_dataset.tblSaleDetail' table. You can move, or remove it, as needed.
            txtsearch.Focus();

        }

        private void txtsearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.tblProductBindingSource.Filter = "productcod='" + txtsearch.Text.Trim().Replace("'", "'") + "'";
                    foreach (DataGridViewRow dr in tblProductDataGridView.SelectedRows)
                    {
                        txtproductname.Text = dr.Cells[2].Value.ToString();
                        txtprice.Text = dr.Cells[5].Value.ToString();

                        if (dvgshow.Rows.Count <= 0)
                        {
                            dvgshow.Rows.Add(dr.Cells[0].Value.ToString(),
                            dr.Cells[2].Value.ToString(),
                            dr.Cells[5].Value.ToString(),
                            1,
                            1 * Convert.ToDouble(dr.Cells[5].Value.ToString()));
                            return;
                        }
                        else
                        {
                            foreach (DataGridViewRow tr in dvgshow.Rows)
                            {
                                if (tr.Cells[0].Value.ToString() == dr.Cells[0].Value.ToString())
                                {
                                    //MessageBox.Show("");
                                    tr.Cells[3].Value = Convert.ToInt32(tr.Cells[3].Value.ToString()) + 1;
                                    tr.Cells[4].Value =
                                          Convert.ToInt32(tr.Cells[3].Value.ToString())
                                        * Convert.ToDouble(tr.Cells[2].Value.ToString());
                                    return;
                                }
                            }
                            dvgshow.Rows.Add(dr.Cells[0].Value.ToString(),
                            dr.Cells[2].Value.ToString(),
                            dr.Cells[5].Value.ToString(),
                            1,
                            1 * Convert.ToDouble(dr.Cells[5].Value.ToString()));
                            return;
                        }
                    }
                }
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
                foreach (DataGridViewRow dr in dvgshow.Rows)
                {
                    this.tblSaleDetailBindingSource.AddNew();

                    saleIDTextBox1.Text = saleIDTextBox.Text;
                    productIDTextBox.Text = dr.Cells[0].Value.ToString();
                    qTYTextBox.Text = dr.Cells[3].Value.ToString();
                    priceOUTTextBox.Text = dr.Cells[2].Value.ToString();

                    this.Validate();
                    this.tblSaleDetailBindingSource.EndEdit();
                    this.tableAdapterManager1.UpdateAll(this.db_dataset);
                }
                pbclass.invoice_id = saleIDTextBox.Text;
                new frmReportSale().ShowDialog();
                txtsearch.Focus();
               

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           

        }

        private void btnaddnew_Click(object sender, EventArgs e)
        {
           // saleDetailIDTextBox.Text = saleIDTextBox.Text;
            this.tblSaleBindingSource.AddNew();
            saleDateDateTimePicker.Text = "01-01-01";
            saleDateDateTimePicker.Value = DateTime.Now;
            userIDComboBox.Text = pbclass.Userlog[0];

            this.Validate();
            this.tblSaleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_dataset);

            txtsearch.Clear();
            txtproductname.Clear();
            txtprice.Clear();
            dvgshow.Rows.Clear();
            txtsearch.Focus();
            
        }

        

        private void dvgshow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dvgshow.Columns[e.ColumnIndex].Name == "txtaction")
            {
                if (MessageBox.Show("Are you Sure want to delete this record?", "Comfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                    dvgshow.Rows.Remove(dvgshow.CurrentRow);
            }
           
            if (dvgshow.Columns[e.ColumnIndex].Name == "btnedit")
            {
                if (MessageBox.Show("Are you Sure want to Edit this record?", "Comfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)

                    foreach (DataGridViewRow r in dvgshow.SelectedRows)
                    {
                        txtsearchproductcode.Text = r.Cells[1].Value.ToString();
                        txtproductname.Text = r.Cells[2].Value.ToString();
                        txtprice.Text = r.Cells[5].Value.ToString();
                      
                        if (dvgshow.Columns[e.ColumnIndex].Name == "btnedit")
                        {
                            txtsearchproductcode.Text = r.Cells[1].Value.ToString();
                            txtproductname.Text = r.Cells[2].Value.ToString();
                            txtprice.Text = r.Cells[5].Value.ToString();
                            dvgshow.Rows.Remove(dvgshow.CurrentRow);
                        }

                    }
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
