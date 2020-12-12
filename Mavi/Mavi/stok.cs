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
    public partial class stok : Form
    {
        public stok()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=SEVIM\MSSQLSERVER2;Initial Catalog=mavi_db;Integrated Security=True");
        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void stok_Load(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("select distinct tür from urun ", baglan);
            SqlDataReader dr;

            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                combotur.Items.Add(dr["tür"]);
            }
            baglan.Close();
            goster();

            //baglan.Open();
            //DataTable dt = baglan.GetSchema("urun");

            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    combotur.Items.Add(dt.Rows[i]["tür"]);
            //}
            //baglan.Close();

        }
        void goster()
        {
            baglan.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from urun", baglan);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();
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

        private void combotur_SelectedIndexChanged(object sender, EventArgs e)
        {
            //combotur.Items.Clear();
            baglan.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select tür,ad,stok from urun where tür like '"+combotur.SelectedItem.ToString()+"'", baglan);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            DataView dv = dt.DefaultView;
            dataGridView1.DataSource = dv;
            baglan.Close();
        }

        private void txturunad_TextChanged(object sender, EventArgs e)
        {
            baglan.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select tür,ad,stok from urun where ad like '" + txturunad.Text + "%'", baglan);

            da.Fill(dt);
            dataGridView1.DataSource = dt;

            baglan.Close();
        }
    }

    }

