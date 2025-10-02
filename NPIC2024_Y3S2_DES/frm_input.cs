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
    public partial class frm_input : Form
    {
        public frm_input()
        {
            InitializeComponent();
        }

        private void frm_input_Load(object sender, EventArgs e)
        {
            raMale.Checked = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPhone.Clear();
            raMale.Checked = true;
            raFemal.Checked = false;
            dtp.Value = DateTime.Now;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            pbclass.plist[0] = txtName.Text;
            if (raMale.Checked== true)
            {
                pbclass.plist[1] = raMale.Text;
            }
            else
            {
                pbclass.plist[1] = raFemal.Text;
            }
            pbclass.plist[2] = dtp.Text;
            pbclass.plist[3] = txtPhone.Text;


            new frm_inputShow().ShowDialog();
        }
    }
}
