using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPIC2024_Y3S2_DES
{
    public partial class frmSaleProduct : Form

    {
        String UserID;
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["NPIC2024_Y3S2_DES.Properties.Settings.db_NPICY3S2ConnectionString"].ConnectionString);
     
        bool data_exited = false;
        Double Sum_price;
        private void clear_text()
        {
            txtsearchproductcode.Text = "";
            txtproductname.Text = "";
            txtprice.Text = "";
            txtqty.Text = "";
            txtsearchproductcode.Focus();
            Sum_price = dvgshow.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDouble(t.Cells[5].Value));
            lblsum.Text = Sum_price.ToString();


        }
        public frmSaleProduct()
        {
            InitializeComponent();
        }

        private void tblSaleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblSaleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_dataset);

        }

        private void frmSaleProduct_Load(object sender, EventArgs e)
        {
            try
            {
                this.tblSaleTableAdapter.Fill(this.db_dataset.tblSale);
                this.tblSaleDetailTableAdapter.Fill(this.db_dataset.tblSaleDetail);
                this.tblProductTableAdapter.Fill(this.db_dataset.tblProduct);
                // TODO: This line of code loads data into the 'db_dataset.tblSale' table. You can move, or remove it, as needed.               
               
                // TODO: This line of code loads data into the 'db_dataset.tblProduct' table. You can move, or remove it, as needed.
                txtsearchproductcode.Focus();
                UserID = pbclass.Userlog[0];
                userIDComboBox.Items.Add(UserID);
                btnaddnew_Click(sender, e);
 

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void btnaddnew_Click(object sender, EventArgs e)
        {

            try
            {
              
                this.tblSaleBindingSource.AddNew();
                saleDateDateTimePicker1.Text = "01-01-2020";
                saleDateDateTimePicker1.Value = DateTime.Today;
                UserID = pbclass.Userlog[0];
                userIDComboBox.Items.Add(UserID);


                this.Validate();
                this.tblSaleBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.db_dataset);

               
                



            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void txtsearchproductcode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    this.tblProductBindingSource.Filter = "productcod='" + txtsearchproductcode.Text.Trim().Replace("'", "'") + "'";
                    foreach (DataGridViewRow r in tblProductDataGridView.SelectedRows)
                    {
                        txtproductname.Text = r.Cells[2].Value.ToString();
                        txtprice.Text = r.Cells[5].Value.ToString();

                        if (Convert.ToInt32(r.Cells[5].Value) <= 0)
                        {
                            MessageBox.Show("Invalide in stock!", "Please check Product Stoct!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            txtqty.Text = "0";
                        }
                        else
                        {
                            txtqty.Text = "1";
                        }
                       btnaddnew_Click(sender, e);
                       btnadd_Click(sender,e);
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void btnadd_Click(object sender, EventArgs e)
        {

           try
            {
                if (dvgshow.RowCount == 0)
                {
                    foreach (DataGridViewRow drow in tblProductDataGridView.SelectedRows)
                    {
                             dvgshow.Rows.Add(
                            drow.Cells[0].Value.ToString(),
                            drow.Cells[1].Value.ToString(),
                            drow.Cells[2].Value.ToString(),
                            drow.Cells[5].Value.ToString(),
                            txtqty.Text,
                            Convert.ToInt32(txtqty.Text) * Convert.ToDouble(drow.Cells[5].Value)
                            );

                    }
                    clear_text();
                }
                else
                {
                    foreach (DataGridViewRow r in dvgshow.Rows)
                    {

                        if (r.Cells[1].Value.ToString() == txtsearchproductcode.Text)
                        {
                            MessageBox.Show("Exiting");
                            r.Cells[4].Value = Convert.ToInt32(r.Cells[4].Value) + 1;
                            r.Cells[5].Value = Convert.ToInt32(r.Cells[4].Value) * Convert.ToDouble(r.Cells[3].Value);
                            clear_text();
                            data_exited = true;
                            return;
                        }
                        else
                        {
                            data_exited = false;
                        }
                    }
                    if (data_exited == false)
                    {
                        // code in DataGridViewShow Add Form Textbox
                        foreach (DataGridViewRow drow in tblProductDataGridView.SelectedRows)
                        {
                            dvgshow.Rows.Add(
                                drow.Cells[0].Value.ToString(),
                                drow.Cells[1].Value.ToString(),
                                drow.Cells[2].Value.ToString(),
                                drow.Cells[5].Value.ToString(),
                                txtqty.Text,
                                Convert.ToInt32(txtqty.Text) * Convert.ToDouble(drow.Cells[5].Value)
                                );
                        }
                       clear_text();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void dvgshow_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {
            if (dvgshow.Columns[e.ColumnIndex].Name == "txtaction")
            {
                if (MessageBox.Show("Are you Sure want to delete this record?", "Comfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                    dvgshow.Rows.Remove(dvgshow.CurrentRow);
            }
            clear_text();
            if (dvgshow.Columns[e.ColumnIndex].Name == "btnedit")
            {
                if (MessageBox.Show("Are you Sure want to Edit this record?", "Comfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)

                    foreach (DataGridViewRow r in dvgshow.SelectedRows)
                    {

                        txtsearchproductcode.Text = r.Cells[1].Value.ToString();
                        txtproductname.Text = r.Cells[2].Value.ToString();
                        txtprice.Text = r.Cells[5].Value.ToString();
                        txtqty.Text = r.Cells[4].Value.ToString();
                        if (dvgshow.Columns[e.ColumnIndex].Name == "btnedit")
                        {
                            txtsearchproductcode.Text = r.Cells[1].Value.ToString();
                            txtproductname.Text = r.Cells[2].Value.ToString();
                            txtprice.Text = r.Cells[5].Value.ToString();
                            txtqty.Text = r.Cells[4].Value.ToString();
                            
                            dvgshow.Rows.Remove(dvgshow.CurrentRow);
    
                        }

                    }
            }
        }
        private void Doinsert(String a1, String a2, String a3, String a4)
        {
                con.Open();
                SqlCommand cmd = new SqlCommand(String.Format("INSERT INTO tblSaleDetail VALUES (@v1, @v2, @v3, @v4)"), con);
                cmd.Parameters.AddWithValue("v1", a1);
                cmd.Parameters.AddWithValue("v2", a2);
                cmd.Parameters.AddWithValue("v3", a3);
                cmd.Parameters.AddWithValue("v4", a4);
                cmd.ExecuteNonQuery();
                con.Close();
        }
            bool sav_yn = false;
        private void txtsave_Click(object sender, EventArgs e)
        {
        try
            {
                UserID = pbclass.Userlog[0];
                userIDComboBox.Items.Add(UserID);
                userIDComboBox.Text = pbclass.Userlog[0];
                //pbclass.invoice_id = saleIDTextBox1.Text;
                new frmReport_sale().ShowDialog();

                foreach (DataGridViewRow r in dvgshow.Rows)
                {
                    Doinsert(
                        saleIDTextBox1.Text
                        , r.Cells[0].Value.ToString()
                        , r.Cells[4].Value.ToString()
                        , r.Cells[3].Value.ToString()

                        );
                    sav_yn = true;
                  
                }
                
                if (sav_yn == true)
                  {
                            MessageBox.Show("Inserted successful.", "Message system", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            sav_yn = false;

                        }
                        else
                        {
                            MessageBox.Show("Error insert Data.", "Message system", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

             }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            pbclass.invoice_id = saleIDTextBox1.Text;
            txtproductname.Clear();
            txtproductname.Clear();
            txtprice.Clear();
            dvgshow.Rows.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      

        private void btninvoice_Click_1(object sender, EventArgs e)
        {
            pbclass.invoice_id = saleIDTextBox1.Text;
            new frmReport_sale().ShowDialog();
            UserID = pbclass.Userlog[0];
            userIDComboBox.Items.Add(UserID);
            this.Dispose();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
