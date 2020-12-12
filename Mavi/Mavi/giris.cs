using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mavi
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=SEVIM\MSSQLSERVER2;Initial Catalog=mavi_db;Integrated Security=True");
        public static string kulad;
        private void label4_Click(object sender, EventArgs e)
        {
            yenisifre y = new yenisifre();
            
            y.Show();
            this.Hide();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@kulad", txtkulad.Text);
            cmd.Parameters.AddWithValue("@sifre", txtsifre.Text);
            cmd.Connection = baglan;
            cmd.CommandText = "giris";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (dr[3].ToString() == "Admin")
                {

                    admin a = new admin();
                    a.label1.Text = dr[4].ToString();

                    string path = Path.Combine(Application.StartupPath, dr[9].ToString());
                    a.adminresim.ImageLocation = path;
                   
                    a.Show();
                    this.Hide();
                    
                }
                else if (dr[3].ToString() == "Garson")
                {
                    garson b = new garson();
                    b.label1.Text = dr[4].ToString();
                    string path = Path.Combine(Application.StartupPath, dr[9].ToString());
                    b.garsonresim.ImageLocation = path;

                    b.Show();
                    this.Hide();
                }
                else if (dr[3].ToString() == "Aşçı")
                {
                    asci asci = new asci();
                    asci.label1.Text = dr[4].ToString();
                    string path = Path.Combine(Application.StartupPath, dr[9].ToString());
                    asci.asciresim.ImageLocation = path;

                    asci.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Hatalı giriş işlemi yaptınız!", "HATA", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            masa m = new masa();
          
          kulad = dr[4].ToString();
            m.label1.Text = kulad;
            baglan.Close();
           
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void giris_Load(object sender, EventArgs e)
        {

        }
    }
}
