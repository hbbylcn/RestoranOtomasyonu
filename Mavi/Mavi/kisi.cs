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
using System.IO;
using System.Drawing.Imaging;

namespace Mavi
{
    public partial class kisi : Form
    {
        public kisi()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=SEVIM\MSSQLSERVER2;Initial Catalog=mavi_db;Integrated Security=True");
        string fotografYol;
        string fotografIsim;
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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kisi_Load(object sender, EventArgs e)
        {
            goster();
            clear();
        }
        void goster()
        {
            baglan.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select*from personelBilgi", baglan);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();
        }
        void clear()
        {
            txtperno.Text = "";
            txtkulad.Text = "";
            txtsifre.Text = "";
            comboyetki.Text = "";
            txtad.Text = "";
            txtsoyad.Text = "";
            masktc.Text = "";
            masktel.Text = "";
            txtresim.Text = "";
            richadres.Text = "";
            
    }
        private void btngeri_Click(object sender, EventArgs e)
        {
            ayarlar ayar = new ayarlar();
            ayar.Show();
            this.Hide();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            //  string kopyalanacakYer = @"C:\Users\sevimm\Desktop\Proje\Restoran proje\restoran\restoran\image" + fotografIsim;
            string kopyalanacakYer = Application.StartupPath + fotografIsim;
            File.Copy(fotografYol, kopyalanacakYer, true);
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Images|*.png;*.bmp;*.jpg";
            ImageFormat format = ImageFormat.Png;
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(sfd.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }
                kisiresim.Image.Save(sfd.FileName, format);
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = baglan;
            cmd.CommandText = "kulEkle";
            cmd.CommandType = CommandType.StoredProcedure;
            // textBox6.Text = "image/" + fotografIsim;
            cmd.Parameters.AddWithValue("@perno", txtperno.Text);
            cmd.Parameters.AddWithValue("@kulad", txtkulad.Text);
            cmd.Parameters.AddWithValue("@sifre", txtsifre.Text);
            cmd.Parameters.AddWithValue("@tür", comboyetki.SelectedItem);
            cmd.Parameters.AddWithValue("@ad", txtad.Text);
            cmd.Parameters.AddWithValue("@soyad", txtsoyad.Text);
            cmd.Parameters.AddWithValue("@tc", masktc.Text);
            cmd.Parameters.AddWithValue("@telefon", masktel.Text);
            cmd.Parameters.AddWithValue("@resim", kopyalanacakYer);
            // cmd.Parameters.AddWithValue("@FotografYol", @"C:\Users\sevimm\Desktop\Proje\Restoran proje\restoran\restoran\image" + fotografIsim);
            cmd.Parameters.AddWithValue("@adres", richadres.Text);
            cmd.ExecuteNonQuery();
            baglan.Close();
            goster();
            clear();
            MessageBox.Show("Kayıt eklendi");
        }

        private void btnresim_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdFotografSec = new OpenFileDialog();

            ofdFotografSec.FileName = "";

            ofdFotografSec.Title = "Kişinin Fotoğrafını Seçiniz";

            ofdFotografSec.Filter = "Resim Dosyaları(*.BMP;*.JPG;*.JPEG;*.PNG;*.GIF)|*.BMP;*.JPG;*.JPEG;*.PNG;*.GIF|All files (*.*)|*.*";

            ofdFotografSec.ShowDialog();

            fotografYol = ofdFotografSec.FileName;

            fotografIsim = ofdFotografSec.SafeFileName;

            kisiresim.ImageLocation = fotografYol;


        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = baglan;
            cmd.CommandText = "kulSil";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@kulad", txtkulad.Text);
            cmd.ExecuteNonQuery();
            baglan.Close();
            goster();
            clear();
            MessageBox.Show("Kayıt silindi");
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            //textBox6.Text = "image/" + fotografIsim;
            //string kopyalanacakYer = @"C:\Users\sevimm\Desktop\Proje\Restoran proje\restoran\restoran\image" + fotografIsim;
            string kopyalanacakYer = Application.StartupPath + fotografIsim;
            File.Copy(fotografYol, kopyalanacakYer, true);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = baglan;
            cmd.CommandText = "kulGüncelle";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@perno", txtperno.Text);
            cmd.Parameters.AddWithValue("@kulad", txtkulad.Text);
            cmd.Parameters.AddWithValue("@sifre", txtsifre.Text);
            cmd.Parameters.AddWithValue("@tür", comboyetki.SelectedItem);
            cmd.Parameters.AddWithValue("@ad", txtad.Text);
            cmd.Parameters.AddWithValue("@soyad", txtsoyad.Text);
            cmd.Parameters.AddWithValue("@tc", masktc.Text);
            cmd.Parameters.AddWithValue("@telefon", masktel.Text);
            cmd.Parameters.AddWithValue("@resim", kopyalanacakYer);
            cmd.Parameters.AddWithValue("@adres", richadres.Text);

            cmd.ExecuteNonQuery();
            baglan.Close();
            goster();
            clear();

            MessageBox.Show("Kayıt güncellendi");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtperno.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtkulad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtsifre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboyetki.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtad.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtsoyad.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            masktc.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            masktel.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtresim.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            richadres.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            kisiresim.ImageLocation = dataGridView1.CurrentRow.Cells[9].Value.ToString();
        }
    }
    }

