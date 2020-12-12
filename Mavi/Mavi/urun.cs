using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mavi
{
    public partial class urun : Form
    {
        public urun()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=SEVIM\MSSQLSERVER2;Initial Catalog=mavi_db;Integrated Security=True");

        string resim;
        string fotografYol;
        string fotografIsim;

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

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
      
        private void urun_Load(object sender, EventArgs e)
        {
            goster();
            clear();
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
        void clear()
        {
            txtkod.Text = "";
            combtur.Text = "";
            txturunad.Text = "";
            txtstok.Text = "";
            txtresim.Text = "";
            txtfiyat.Text = "";
            richaciklama.Text = "";


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
                urunresim.Image.Save(sfd.FileName, format);
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = baglan;
            cmd.CommandText = "urunEkle";
            cmd.CommandType = CommandType.StoredProcedure;
            // textBox6.Text = "image/" + fotografIsim;
            cmd.Parameters.AddWithValue("@urunkod", txtkod.Text);
            cmd.Parameters.AddWithValue("@tür", combtur.SelectedItem);
            cmd.Parameters.AddWithValue("@ad", txturunad.Text);
            cmd.Parameters.AddWithValue("@stok", txtstok.Text);
            cmd.Parameters.AddWithValue("@resim", kopyalanacakYer);
            cmd.Parameters.AddWithValue("@fiyat", txtfiyat.Text);
            cmd.Parameters.AddWithValue("@aciklama", richaciklama.Text);
           
            // cmd.Parameters.AddWithValue("@FotografYol", @"C:\Users\sevimm\Desktop\Proje\Restoran proje\restoran\restoran\image" + fotografIsim);
            
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

            ofdFotografSec.Title = " Fotoğraf Seçiniz";

            ofdFotografSec.Filter = "Resim Dosyaları(*.BMP;*.JPG;*.JPEG;*.PNG;*.GIF)|*.BMP;*.JPG;*.JPEG;*.PNG;*.GIF|All files (*.*)|*.*";

            ofdFotografSec.ShowDialog();

            resim = ofdFotografSec.FileName;

            fotografIsim = ofdFotografSec.SafeFileName;

            urunresim.ImageLocation = resim;

        }

        private void btnsil_Click(object sender, EventArgs e)
        {

            baglan.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = baglan;
            cmd.CommandText = "urunSil";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@urunkod", txtkod.Text);
            cmd.ExecuteNonQuery();
            baglan.Close();
            goster();
            clear();
            MessageBox.Show("Kayıt silindi");
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string kopyalanacakYer = Application.StartupPath + fotografIsim;
            File.Copy(resim, kopyalanacakYer, true);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = baglan;
            cmd.CommandText = "urunGüncelle";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@urunkod", txtkod.Text);
            cmd.Parameters.AddWithValue("@tür", combtur.SelectedItem);
            cmd.Parameters.AddWithValue("@ad", txturunad.Text);
            cmd.Parameters.AddWithValue("@stok", txtstok.Text);
            cmd.Parameters.AddWithValue("@resim", kopyalanacakYer);
            cmd.Parameters.AddWithValue("@fiyat", txtfiyat.Text);
            cmd.Parameters.AddWithValue("@aciklama", richaciklama.Text);

            cmd.ExecuteNonQuery();
            baglan.Close();
            goster();
            clear();

            MessageBox.Show("Kayıt güncellendi");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtkod.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            combtur.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txturunad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtstok.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtresim.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtfiyat.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            richaciklama.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void combtur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
