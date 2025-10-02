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
    public partial class frm_hw1Show : Form
    {
        public frm_hw1Show()
        {
            InitializeComponent();
        }

        private void frm_hw1Show_Load(object sender, EventArgs e)
        {
            dvgShow.Rows.Clear();
            foreach(var entry in classHw1.plist)
            {
                dvgShow.Rows.Add(entry);
            }
        }
    }
}
