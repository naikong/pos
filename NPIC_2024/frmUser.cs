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

namespace NPIC_2024
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["NPIC_2024.Properties.Settings.db_npic_2024ConnectionString"].ConnectionString);
        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.user' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.dataSet1.user);

            txtfirstname.Text = "";
            txtlastname.Text = "";
            txtemail.Text = "";
            txtpassword.Text = "";
            txtcontactnumber.Text = "";


        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void userDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dvgshow.Columns[e.ColumnIndex].Name == "delete")
           {
                if (MessageBox.Show("Are you Sure want to delete this record?", "Comfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                    dvgshow.Rows.Remove(dvgshow.CurrentRow);

            }
           
            //if (dvgshow.Columns[e.ColumnIndex].Name == "btnedit")
            //{
            //    if (MessageBox.Show("Are you Sure want to Edit this record?", "Comfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            //        == DialogResult.Yes)


            //        foreach (DataGridViewRow r in dvgshow.SelectedRows)
            //        {


            //            txtsearchproductcode.Text = r.Cells[1].Value.ToString();
            //            txtproductname.Text = r.Cells[2].Value.ToString();
            //            txtprice.Text = r.Cells[5].Value.ToString();
            //            txtqty.Text = r.Cells[4].Value.ToString();
            //            if (dvgshow.Columns[e.ColumnIndex].Name == "btnedit")
            //            {
            //                txtsearchproductcode.Text = r.Cells[1].Value.ToString();
            //                txtproductname.Text = r.Cells[2].Value.ToString();
            //                txtprice.Text = r.Cells[5].Value.ToString();
            //                txtqty.Text = r.Cells[4].Value.ToString();
            //                dvgshow.Rows.Remove(dvgshow.CurrentRow);

            //            }


            //        }
            //}

        }



            
        private void btnaddnew_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(string.Format("INSERT INTO user VALUES (@firstname,@lastname,@Emailid,@password,@contactnumber)"), con);
                cmd.Parameters.AddWithValue("firstname", txtfirstname.Text);
                cmd.Parameters.AddWithValue("lastname", txtlastname);
                cmd.Parameters.AddWithValue("Emailid", txtemail.Text);
                cmd.Parameters.AddWithValue("password", txtpassword.Text);
                cmd.Parameters.AddWithValue("contactnumber", txtcontactnumber.Text);
                cmd.ExecuteNonQuery();
                con.Close();


             MessageBox.Show("Insert successfull ", "Message system", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message system", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
    }
}
