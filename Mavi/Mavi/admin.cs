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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {

        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnclose_Click(object sender, EventArgs e)
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

        private void btnodeme_Click(object sender, EventArgs e)
        {
            odeme o = new odeme();
            o.Show();
            this.Hide();
        }

        private void btnayarlar_Click(object sender, EventArgs e)
        {
            ayarlar ayar = new ayarlar();
            ayar.Show();
            this.Hide();
        }

        private void btnmasa_Click(object sender, EventArgs e)
        {
            masa m = new masa();
            m.Show();
            m.btnmasa1.Enabled = false;
            m.btnmasa2.Enabled = false;
            m.btnmasa3.Enabled = false;
            m.btnmasa4.Enabled = false;
            m.btnmasa5.Enabled = false;
            m.btnmasa6.Enabled = false;
            m.btnmasa7.Enabled = false;
            m.btnmasa8.Enabled = false;
            m.btnmasa9.Enabled = false;
            m.btnmasa10.Enabled = false;
            m.btnmasa11.Enabled = false;
            m.btnmasa12.Enabled = false;
            m.btngeri.Hide();
            this.Hide();
        }

        private void btnsiparis_Click(object sender, EventArgs e)
        {
            
        }

        private void btnistatistik_Click(object sender, EventArgs e)
        {
            istatistik istatistik = new istatistik();
            istatistik.Show();
            this.Hide();
        }

        private void btnstok_Click(object sender, EventArgs e)
        {
            stok st = new stok();
            st.Show();
            this.Hide();
        }
    }
}
