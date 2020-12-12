using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mavi
{
    public partial class asci : Form
    {
        public asci()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnklit_Click(object sender, EventArgs e)
        {

            mavi m = new mavi();
            m.Show();
            this.Hide();
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnsiparis_Click(object sender, EventArgs e)
        {
            siparishazirlama sh = new siparishazirlama();
            sh.Show();
            this.Hide();
        }

        private void btnstok_Click(object sender, EventArgs e)
        {
            stok s = new stok();
            s.Show();
            this.Hide();
        }
    }
}
