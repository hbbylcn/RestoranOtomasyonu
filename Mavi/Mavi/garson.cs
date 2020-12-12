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

namespace Mavi
{
    public partial class garson : Form
    {
        public garson()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=SEVIM\MSSQLSERVER2;Initial Catalog=mavi_db;Integrated Security=True");

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnklit_Click(object sender, EventArgs e)
        {
            mavi m = new mavi();
            m.Show();
            this.Hide();
        }

        private void garson_Load(object sender, EventArgs e)
        {

        }

        private void btnmasa_Click(object sender, EventArgs e)
        {
            masa m = new masa();
           
            m.label1.Text = giris.kulad;
            m.Show();
            this.Hide();
        }

        private void btnsiparis_Click(object sender, EventArgs e)
        {
            siparis sip = new siparis();
            sip.Show();
            this.Hide();
        }

        private void btnodeme_Click(object sender, EventArgs e)
        {
            garson g = new garson();
            g.Show();
            this.Hide();
        }
    }
}
