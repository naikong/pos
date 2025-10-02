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
    public partial class frmTest3 : Form
    {
        public frmTest3()
        {
            InitializeComponent();
        }

        private void frmTest3_Load(object sender, EventArgs e)
        {

        }
        int i = 1;
        int x;
        private void btnadd_Click(object sender, EventArgs e) 
        
        {
            if (btnadd.Text == "Add")
            {
                dgshow.Rows.Add(i.ToString(), txtname.Text, cmb.Text, dtp.Text);
                i++;
            }
            else
            {
                dgshow.Rows.RemoveAt(x);
                dgshow.Rows.Add(i.ToString(), txtname.Text, cmb.Text, dtp.Text);
                int c = 1;
                foreach(DataGridViewRow d in dgshow.Rows)
                {
                    d.Cells[0].Value=c;
                    c++;
                }
                btnadd.Text = "Add";
            }
        }
        private void dgshow_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach(DataGridViewRow dr in dgshow.SelectedRows)
            {
                txtname.Text = dr.Cells[1].Value.ToString();
                cmb.Text = dr.Cells[2].Value.ToString();
                dtp.Text = dr.Cells[3].Value.ToString();
                x = dr.Index;
            }
            btnadd.Text = "Update";
            MessageBox.Show(x.ToString());
        }

        private void dgshow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach(DataGridViewRow d in dgshow.SelectedRows)
            {
                var result = MessageBox.Show("Are you sure you want to deletd recorred?" + 
                    d.Cells[0].Value.ToString(),"confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    dgshow.Rows.RemoveAt(d.Index);
                }
            }
        }
    }
}
