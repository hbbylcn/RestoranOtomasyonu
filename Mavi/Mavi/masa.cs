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
    public partial class masa : Form
    {
        public masa()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=SEVIM\MSSQLSERVER2;Initial Catalog=mavi_db;Integrated Security=True");

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

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void masa_Load(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("select * from masa", baglan);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                foreach (Control item in this.Controls)
                {
                    if (item is Button)
                    {
                        if (item.Name == "btnmasa" + dr["masaid"].ToString() && dr["durum"].ToString() == "False")
                        {

                            item.BackColor = (System.Drawing.Color.Transparent);
                        }
                        else if (item.Name == "btnmasa" + dr["masaid"].ToString() && dr["durum"].ToString() == "True")
                        {
                            item.BackColor = (System.Drawing.Color.Red);
                        }

                    }
                }

            }

            baglan.Close();


        }

        private void btnmasa1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("update masa set durum=@durum,kisisayisi=@ksayi where masaid=@mid", baglan);
            cmd.Parameters.AddWithValue("@durum", "1");
            cmd.Parameters.AddWithValue("@mid", "1");
            cmd.Parameters.AddWithValue("@ksayi", txtkisi.Text);

            cmd.ExecuteNonQuery();
            baglan.Close();

            siparis s = new siparis();

            s.label2.Text = label1.Text;
            s.label1.Text = "1";
            s.Show();
            giris f = new giris();
            masa m = new masa();

            m.label1.Text = giris.kulad;

            this.Hide();



        }

        private void btnmasa2_Click(object sender, EventArgs e)
        {

            baglan.Open();
            SqlCommand cmd = new SqlCommand("update masa set durum=@durum,kisisayisi=@ksayi where masaid=@mid", baglan);
            cmd.Parameters.AddWithValue("@durum", "1");
            cmd.Parameters.AddWithValue("@mid", "2");
            cmd.Parameters.AddWithValue("@ksayi", txtkisi.Text);
            cmd.ExecuteNonQuery();
            baglan.Close();
            
            siparis s = new siparis();
            s.label2.Text = label1.Text;
            s.label1.Text = "2";
            s.Show();
            giris f = new giris();
            masa m = new masa();

            m.label1.Text = giris.kulad;
            this.Hide();
        }

        private void btnmasa3_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("update masa set durum=@durum,kisisayisi=@ksayi where masaid=@mid", baglan);
            cmd.Parameters.AddWithValue("@durum", "1");
            cmd.Parameters.AddWithValue("@mid", "3");
            cmd.Parameters.AddWithValue("@ksayi", txtkisi.Text);
            cmd.ExecuteNonQuery();
            baglan.Close();
            siparis s = new siparis();
            s.label2.Text = label1.Text;
            s.label1.Text = "3";
            s.Show();
            giris f = new giris();
            masa m = new masa();

            m.label1.Text = giris.kulad;
            this.Hide();
        }

        private void btnmasa4_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("update masa set durum=@durum,kisisayisi=@ksayi where masaid=@mid", baglan);
            cmd.Parameters.AddWithValue("@durum", "1");
            cmd.Parameters.AddWithValue("@mid", "4");
            cmd.Parameters.AddWithValue("@ksayi", txtkisi.Text);

            cmd.ExecuteNonQuery();
            baglan.Close();
            siparis s = new siparis();
            s.label2.Text = label1.Text;
            s.label1.Text = "4";
            s.Show();
            giris f = new giris();
            masa m = new masa();

            m.label1.Text = giris.kulad;
            this.Hide();
        }

        private void btnmasa5_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("update masa set durum=@durum,kisisayisi=@ksayi where masaid=@mid", baglan);
            cmd.Parameters.AddWithValue("@durum", "1");
            cmd.Parameters.AddWithValue("@mid", "5");
            cmd.Parameters.AddWithValue("@ksayi", txtkisi.Text);

            cmd.ExecuteNonQuery();
            baglan.Close();
            siparis s = new siparis();
            s.label2.Text = label1.Text;
            s.label1.Text = "5";
            s.Show();
            giris f = new giris();
            masa m = new masa();

            m.label1.Text = giris.kulad;
            this.Hide();
        }

        private void btnmasa6_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("update masa set durum=@durum,kisisayisi=@ksayi where masaid=@mid", baglan);
            cmd.Parameters.AddWithValue("@durum", "1");
            cmd.Parameters.AddWithValue("@mid", "6");
            cmd.Parameters.AddWithValue("@ksayi", txtkisi.Text);
            cmd.ExecuteNonQuery();
            baglan.Close();
            siparis s = new siparis();
            s.label2.Text = label1.Text;
            s.label1.Text = "6";
            s.Show();
            giris f = new giris();
            masa m = new masa();

            m.label1.Text = giris.kulad;
            this.Hide();
        }

        private void btnmasa7_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("update masa set durum=@durum ,kisisayisi=@ksayi where masaid=@mid", baglan);
            cmd.Parameters.AddWithValue("@durum", "1");
            cmd.Parameters.AddWithValue("@mid", "7");
            cmd.Parameters.AddWithValue("@ksayi", txtkisi.Text);

            cmd.ExecuteNonQuery();
            baglan.Close();
            siparis s = new siparis();
            s.label2.Text = label1.Text;
            s.label1.Text = "7";
            s.Show();
            giris f = new giris();
            masa m = new masa();

            m.label1.Text = giris.kulad;
            this.Hide();
        }

        private void btnmasa8_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("update masa set durum=@durum,kisisayisi=@ksayi where masaid=@mid", baglan);
            cmd.Parameters.AddWithValue("@durum", "1");
            cmd.Parameters.AddWithValue("@mid", "8");
            cmd.Parameters.AddWithValue("@ksayi", txtkisi.Text);


            cmd.ExecuteNonQuery();
            baglan.Close();
            siparis s = new siparis();
            s.label2.Text = label1.Text;
            s.label1.Text = "8";
            s.Show();
            giris f = new giris();
            masa m = new masa();

            m.label1.Text = giris.kulad;
            this.Hide();
        }

        private void btnmasa9_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("update masa set durum=@durum ,kisisayisi=@ksayi where masaid=@mid", baglan);
            cmd.Parameters.AddWithValue("@durum", "1");
            cmd.Parameters.AddWithValue("@mid", "9");
            cmd.Parameters.AddWithValue("@ksayi", txtkisi.Text);

            cmd.ExecuteNonQuery();
            baglan.Close();
            siparis s = new siparis();
            s.label2.Text = label1.Text;
            s.label1.Text = "9";
            s.Show();
            this.Hide();
        }

        private void btnmasa10_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("update masa set durum=@durum ,kisisayisi=@ksayi where masaid=@mid", baglan);
            cmd.Parameters.AddWithValue("@durum", "1");
            cmd.Parameters.AddWithValue("@mid", "10");
            cmd.Parameters.AddWithValue("@ksayi", txtkisi.Text);

            cmd.ExecuteNonQuery();
            baglan.Close();
            siparis s = new siparis();
            s.label2.Text = label1.Text;
            s.label1.Text = "10";
            s.Show();
            giris f = new giris();
            masa m = new masa();

            m.label1.Text = giris.kulad;
            this.Hide();
        }

        private void btnmasa11_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("update masa set durum=@durum ,kisisayisi=@ksayi where masaid=@mid", baglan);
            cmd.Parameters.AddWithValue("@durum", "1");
            cmd.Parameters.AddWithValue("@mid", "11");
            cmd.Parameters.AddWithValue("@ksayi", txtkisi.Text);

            cmd.ExecuteNonQuery();
            baglan.Close();
            siparis s = new siparis();
            s.label2.Text = label1.Text;
            s.label1.Text = "11";
            s.Show();
            giris f = new giris();
            masa m = new masa();

            m.label1.Text = giris.kulad;
            this.Hide();
        }

        private void btnmasa12_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("update masa set durum=@durum ,kisisayisi=@ksayi where masaid=@mid", baglan);
            cmd.Parameters.AddWithValue("@durum", "1");
            cmd.Parameters.AddWithValue("@mid", "12");
            cmd.Parameters.AddWithValue("@ksayi", txtkisi.Text);

            cmd.ExecuteNonQuery();
            baglan.Close();
            siparis s = new siparis();
            s.label2.Text = label1.Text;
            s.label1.Text = "12";
            s.Show();
            giris f = new giris();
            masa m = new masa();

            m.label1.Text = giris.kulad;
            this.Hide();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            garson g = new garson();
            g.Show();
            this.Hide();
        }
    }
}
