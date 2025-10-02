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
    public partial class frm_inputShow : Form
    {
        public frm_inputShow()
        {
            InitializeComponent();
        }

        private void frm_inputShow_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(pbclass.plist[0], pbclass.plist[1], pbclass.plist[2], pbclass.plist[3]);
        }
    }
}
