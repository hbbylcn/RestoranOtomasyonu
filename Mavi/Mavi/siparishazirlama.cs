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
    public partial class siparishazirlama : Form
    {
        public siparishazirlama()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=SEVIM\MSSQLSERVER2;Initial Catalog=mavi_db;Integrated Security=True");
        
private void btnhazir_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("update siparis set durum=@durum where sipId=@sipid", baglan);
            cmd.Parameters.AddWithValue("@durum", "Hazır");
            cmd.Parameters.AddWithValue("@sipid",label3.Text);
            cmd.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Hazır","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            siparis s = new siparis();
           
            
            goster();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label3.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
        void goster()
        {
            baglan.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from siparis", baglan);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();
        }

        private void siparishazirlama_Load(object sender, EventArgs e)
        {
            goster();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            asci a = new asci();
            a.Show();
            this.Hide();
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
    }
}
