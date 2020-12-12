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
    public partial class siparis : Form
    {
        public siparis()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=SEVIM\MSSQLSERVER2;Initial Catalog=mavi_db;Integrated Security=True");
        DataSet dataset = new DataSet();
        public int sayi;
        private void btncorba_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglan.Open();
            SqlCommand cmd = new SqlCommand("select * from urun", baglan);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (dr[1].ToString() == "Çorba")
                {

                    ListViewItem item = new ListViewItem(dr[0].ToString());
                    item.SubItems.Add(dr[2].ToString());
                    listView1.FullRowSelect = true;
                    listView1.Items.Add(item);

                }
            }
            baglan.Close();
        }

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

        private void siparis_Load(object sender, EventArgs e)
        {
            goster();
            
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
        void clear()
        {
          
            txtadet.Text = "";
            txttoplamfiyat.Text = "";
            txtid.Text = "";
            txtkod.Text = "";
            txtno.Text = "";
            txturunad.Text = "";
            richaciklama.Text = "";
        }
        private void btngeri_Click(object sender, EventArgs e)
        {

            baglan.Open();
            SqlCommand cmd = new SqlCommand("update masa set durum=@durum where masaid=@mid", baglan);

            cmd.Parameters.AddWithValue("@durum", "0");

            cmd.Parameters.AddWithValue("@mid", label1.Text);


            cmd.ExecuteNonQuery();

            baglan.Close();

            giris f = new giris();
            masa m = new masa();

            m.label1.Text = giris.kulad;

            m.Show();
            this.Hide();
        }

        private void btnmakarna_Click(object sender, EventArgs e)
        {

            listView1.Items.Clear();
            baglan.Open();
            SqlCommand cmd = new SqlCommand("select * from urun where tür IN('Makarna','Mantı')", baglan);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (dr[1].ToString() == "Makarna")
                {

                    ListViewItem item = new ListViewItem(dr[0].ToString());
                    item.SubItems.Add(dr[2].ToString());
                    listView1.FullRowSelect = true;
                    listView1.Items.Add(item);

                }
                else if (dr[1].ToString() == "Mantı")
                {

                    ListViewItem item = new ListViewItem(dr[0].ToString());
                    item.SubItems.Add(dr[2].ToString());
                    listView1.FullRowSelect = true;
                    listView1.Items.Add(item);

                }

            }
            baglan.Close();
        }

        private void btnyemek_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglan.Open();
            SqlCommand cmd = new SqlCommand("select * from urun", baglan);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (dr[1].ToString() == "Ana Yemek")
                {

                    ListViewItem item = new ListViewItem(dr[0].ToString());
                    item.SubItems.Add(dr[2].ToString());
                    listView1.FullRowSelect = true;
                    listView1.Items.Add(item);


                }

            }
            baglan.Close();
        }

        private void btnaperatif_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglan.Open();
            SqlCommand cmd = new SqlCommand("select * from urun where tür IN('Aperatif','Kahvaltı-Aperatif')", baglan);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (dr[1].ToString() == "Aperatif")
                {

                    ListViewItem item = new ListViewItem(dr[0].ToString());
                    item.SubItems.Add(dr[2].ToString());
                    listView1.FullRowSelect = true;
                    listView1.Items.Add(item);

                }
                else if (dr[1].ToString() == "Kahvaltı-Aperatif")
                {

                    ListViewItem item = new ListViewItem(dr[0].ToString());
                    item.SubItems.Add(dr[2].ToString());
                    listView1.FullRowSelect = true;
                    listView1.Items.Add(item);

                }

            }
            baglan.Close();
        }

        private void btnkahvalti_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglan.Open();
            SqlCommand cmd = new SqlCommand("select * from urun", baglan);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (dr[1].ToString() == "Kahvaltı")
                {

                    ListViewItem item = new ListViewItem(dr[0].ToString());
                    item.SubItems.Add(dr[2].ToString());
                    listView1.FullRowSelect = true;
                    listView1.Items.Add(item);


                }

            }
            baglan.Close();
        }

        private void btnpizza_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglan.Open();
            SqlCommand cmd = new SqlCommand("select * from urun", baglan);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (dr[1].ToString() == "Pizza")
                {

                    ListViewItem item = new ListViewItem(dr[0].ToString());
                    item.SubItems.Add(dr[2].ToString());
                    listView1.FullRowSelect = true;
                    listView1.Items.Add(item);

                }
            }
            baglan.Close();
        }

        private void btnsalata_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglan.Open();
            SqlCommand cmd = new SqlCommand("select * from urun", baglan);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (dr[1].ToString() == "Salata")
                {

                    ListViewItem item = new ListViewItem(dr[0].ToString());
                    item.SubItems.Add(dr[2].ToString());
                    listView1.FullRowSelect = true;
                    listView1.Items.Add(item);

                }

            }
            baglan.Close();
        }

        private void btntatli_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglan.Open();
            SqlCommand cmd = new SqlCommand("select * from urun", baglan);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (dr[1].ToString() == "Tatlı")
                {

                    ListViewItem item = new ListViewItem(dr[0].ToString());
                    item.SubItems.Add(dr[2].ToString());
                    listView1.FullRowSelect = true;
                    listView1.Items.Add(item);

                }

            }
            baglan.Close();
        }

        private void btnicecek_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglan.Open();
            SqlCommand cmd = new SqlCommand("select * from urun where tür IN('Çay','Bitki','Kahve','Çikolata','Kutu İçecekler','Salep')", baglan);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (dr[1].ToString() == "Çay")
                {

                    ListViewItem item = new ListViewItem(dr[0].ToString());
                    item.SubItems.Add(dr[2].ToString());
                    listView1.FullRowSelect = true;
                    listView1.Items.Add(item);

                }
                else if (dr[1].ToString() == "Bitki")
                {
                    ListViewItem item = new ListViewItem(dr[0].ToString());
                    item.SubItems.Add(dr[2].ToString());
                    listView1.FullRowSelect = true;
                    listView1.Items.Add(item);
                }
                else if (dr[1].ToString() == "Kahve")
                {
                    ListViewItem item = new ListViewItem(dr[0].ToString());
                    item.SubItems.Add(dr[2].ToString());
                    listView1.FullRowSelect = true;
                    listView1.Items.Add(item);
                }
                else if (dr[1].ToString() == "Çikolata")
                {

                    ListViewItem item = new ListViewItem(dr[0].ToString());
                    item.SubItems.Add(dr[2].ToString());
                    listView1.FullRowSelect = true;
                    listView1.Items.Add(item);
                }

                else if (dr[1].ToString() == "Kutu İçecekler")
                {

                    ListViewItem item = new ListViewItem(dr[0].ToString());
                    item.SubItems.Add(dr[2].ToString());
                    listView1.FullRowSelect = true;
                    listView1.Items.Add(item);
                }

                else if (dr[1].ToString() == "Salep")
                {
                    ListViewItem item = new ListViewItem(dr[0].ToString());
                    item.SubItems.Add(dr[2].ToString());
                    listView1.FullRowSelect = true;
                    listView1.Items.Add(item);
                }


            }
            baglan.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)

            {

                ListViewItem item = listView1.SelectedItems[0];

                txtkod.Text = item.SubItems[0].Text;

                txturunad.Text = item.SubItems[1].Text;
                listView1.GridLines = true;
            }
        }

        private void txtkod_TextChanged(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                txtno.Text = "";
                txturunad.Text = "";
                
                richaciklama.Text = "";
            }
            baglan.Open();
            SqlCommand cmd = new SqlCommand("select * from urun where urunkod like '" + txtkod.Text + "'", baglan);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                // textBox5.Text = dr["ad"].ToString();
                lblfiyat.Text = dr["fiyat"].ToString();
                richaciklama.Text = dr["aciklama"].ToString();
                sipresim.ImageLocation = dr["resim"].ToString();








            }
            baglan.Close();
        }

        private void btnarti_Click(object sender, EventArgs e)
        {
            sayi = Convert.ToInt32(txtadet.Text);
            sayi = sayi + 1;
            txtadet.Text = sayi.ToString();
        }

        private void btneksi_Click(object sender, EventArgs e)
        {
            
          
            int sayi = Convert.ToInt32(txtadet.Text);

            sayi = sayi - 1;
            txtadet.Text = sayi.ToString();
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtno.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtkod.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txturunad.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtadet.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txttoplamfiyat.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            odeme o = new odeme();
            o.Show();
            this.Hide();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            if (txtno.Text == "")
            {
                MessageBox.Show(" Sipariş Numarası Boş geçilemez!!","Uyarı!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < listView2.Items.Count; i++)
                {
                    baglan.Open();

                    SqlCommand cmd = new SqlCommand();
                    SqlCommand cmd2 = new SqlCommand("update urun set stok=stok-'" + Convert.ToInt32(txtadet.Text) + "' where urunkod='" + txtkod.Text + "'", baglan);
                    cmd.Connection = baglan;
                    cmd.CommandText = "siparisEkle";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sipno", txtno.Text);
                    cmd.Parameters.AddWithValue("@kulad", label2.Text);
                    cmd.Parameters.AddWithValue("@masaid", label1.Text);

                    cmd.Parameters.AddWithValue("@urunkod", listView2.Items[i].SubItems[0].Text);
                    cmd.Parameters.AddWithValue("@urunad", listView2.Items[i].SubItems[1].Text);
                    cmd.Parameters.AddWithValue("@adet", listView2.Items[i].SubItems[2].Text);
                    cmd.Parameters.AddWithValue("@fiyat", listView2.Items[i].SubItems[3].Text);

                    cmd.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                    cmd.Parameters.AddWithValue("@durum", "Hazırlanıyor");

                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    SqlCommand cmd3 = new SqlCommand("Select*from urun",baglan);
                    SqlDataReader dr = cmd3.ExecuteReader();
                    while (dr.Read())
                    {
                        if (dr[3].Equals(0))
                        {
                            MessageBox.Show("Stok tükenmiştir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        

                    }
                    baglan.Close();
                }

                goster();
                clear();
                listView2.Items.Clear();

                MessageBox.Show("Siparişiniz Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);


            }

        }
    

        private void btnlistele_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(txtkod.Text);
            item.SubItems.Add(txturunad.Text);
            item.SubItems.Add(txtadet.Text);
            item.SubItems.Add(txttoplamfiyat.Text);
            listView2.Items.Add(item);
            listView2.GridLines = true;
           

        }

        private void btnsil_Click(object sender, EventArgs e)
        {

            baglan.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = baglan;
            cmd.CommandText = "siparisSil";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@sipId", txtid.Text);
            cmd.ExecuteNonQuery();
            baglan.Close();
            goster();
            clear();
            MessageBox.Show("Siparişiniz silindi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = baglan;
            cmd.CommandText = "siparisGüncelle";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sipId", txtid.Text);
            cmd.Parameters.AddWithValue("@sipno", txtno.Text);
            cmd.Parameters.AddWithValue("@kulad", label2.Text);
            cmd.Parameters.AddWithValue("@masaid", label1.Text);
            cmd.Parameters.AddWithValue("@urunkod", txtkod.Text);
            cmd.Parameters.AddWithValue("@urunad", txturunad.Text);
            cmd.Parameters.AddWithValue("@adet", txtadet.Text);
            cmd.Parameters.AddWithValue("@fiyat", lblfiyat.Text);
            cmd.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
            cmd.ExecuteNonQuery();
            baglan.Close();
            goster();
            clear();
            MessageBox.Show("Siparişiniz Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtadet_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txttoplamfiyat.Text = (int.Parse(lblfiyat.Text) * int.Parse(txtadet.Text)).ToString();
            }
            catch (Exception)
            {
                ;
            }
        }
    }
}
