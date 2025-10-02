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
    public partial class frm_hw1 : Form
    {
        public frm_hw1()
        {
            InitializeComponent();
        }
        private void btnsend_Click(object sender, EventArgs e)
        {
            double total;
            int qty = Convert.ToInt32(txtqty.Text);
            double price = Convert.ToDouble(txtPrice.Text);
             total = (double)(qty * price);
            // create a new entry 
            string[] array = new string[7];
            array[0] = txtname.Text;
            array[1] = rafood.Checked ? rafood.Text : radrink.Text;
            array[2] = txtdtp.Text;
            array[3] = txtphone.Text;
            array[4] = txtPrice.Text;
            array[5] = txtqty.Text;
            array[6] = total.ToString();


            classHw1.plist.Add(array);
            new frm_hw1Show().ShowDialog();

           
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtdtp.Value = DateTime.Now;
            txtname.Focus();
            txtname.Text = "";
            radrink.Checked = false;
            rafood.Checked = true;
            txtqty.Value = 0;
            txtPrice.Clear();
            txtphone.Clear();
         

        }

        private void frm_hw1_Load(object sender, EventArgs e)
        {
            rafood.Checked = true;
            txtname.Focus();
            
        }
    }
}
