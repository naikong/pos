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
    public partial class frmLogin : Form
    {
        private bool isPasswordVisible;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void tbl_UserBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_UserBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_dataset);

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_dataset.tbl_User' table. You can move, or remove it, as needed.
           this.tbl_UserTableAdapter.FillByunable(this.db_dataset.tbl_User);



        }

       
        private void btnok_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtname.Text == "" || txtpassword.Text == "")
                {
                    MessageBox.Show("Please in put uername and password", "Comfirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    this.tbl_UserBindingSource.Filter = $"Username = '{txtname.Text.Replace("'", "''")}' AND password = '{txtpassword.Text.Replace("'", "''")}'";
                   // this.tbl_UserBindingSource.Filter = "Username + Password LIKE '%" + txtname.Text.Replace("'", "''") + txtpassword.Text.Replace("'", "''") + "%'";
                    if (tbl_UserDataGridView.Rows.Count == 1)
                    {
                        MessageBox.Show("Login Sucessfull !", "Comfirmation", MessageBoxButtons.OK
                            , MessageBoxIcon.Question);
                        foreach (DataGridViewRow dr in tbl_UserDataGridView.SelectedRows)
                        {
                            pbclass.Userlog = new string[]
                            {
                                dr.Cells[0].Value.ToString(),
                                dr.Cells[1].Value.ToString(),
                                dr.Cells[7].Value.ToString()
                            };
                        }
                        this.Hide();
                        new frmDashboard().ShowDialog();
                        txtname.Text = "";
                       
                        this.Show();
                        txtname.Focus();

                    }
                    else
                    {
                        MessageBox.Show("Please in put the correct Username and password !", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        txtname.Text = "";
                        
                        txtname.Focus();

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
                
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnok_Click(sender, e);
            }
        }
        private void txtname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtpassword.Focus();
            }
        }
        private void pictureBox_open_Click_1(object sender, EventArgs e)
        {
            // Show the password and toggle icons
            //txtpassword.PasswordChar = '\0';
            txtpassword.PasswordChar = '*';
            pictureBox_open.Visible = false;
            pictureBox_close.Visible = true;
            isPasswordVisible = false;


        }

        private void pictureBox_close_Click_1(object sender, EventArgs e)
        {
            // Hide the password and toggle icons
            txtpassword.PasswordChar = '\0';
            //txtpassword.PasswordChar = '*';
            pictureBox_open.Visible = true;
            pictureBox_close.Visible = false;
            isPasswordVisible = true;
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

