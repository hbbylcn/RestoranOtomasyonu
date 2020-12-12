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
    public partial class odeme : Form
    {
        public odeme()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=SEVIM\MSSQLSERVER2;Initial Catalog=mavi_db;Integrated Security=True");

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void odeme_Load(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("select distinct sipno from siparis ", baglan);
            SqlDataReader dr;

            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["sipno"]);
            }
            baglan.Close();
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

        private void btnclose_Click(object sender, EventArgs e)
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

        private void btnekle_Click(object sender, EventArgs e)
        {
            siparis sip = new siparis();
            sip.Show();
            this.Hide();
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            garson g = new garson();
            g.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnliste_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            baglan.Open();
            SqlCommand cmd = new SqlCommand("select * from siparis where sipno='" + comboBox1.SelectedItem + "' ", baglan);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr[0].ToString());



                item.SubItems.Add(dr[3].ToString());
                item.SubItems.Add(dr[2].ToString());
                item.SubItems.Add(dr[5].ToString());
                item.SubItems.Add(dr[6].ToString());
                item.SubItems.Add(dr[7].ToString());
                item.SubItems.Add(dr[8].ToString());


                listView1.Items.Add(item);



            }
            baglan.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglan.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from siparis where sipno like '" + comboBox1.SelectedItem.ToString() + "'", baglan);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            DataView dv = dt.DefaultView;
            dataGridView1.DataSource = dv;
            baglan.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Bitmap bmp = Properties.Resources.iconfinder_Citycons_plate_1342930;
            Image newImage = bmp;
            e.Graphics.DrawImage(newImage, 25, 25, newImage.Width, newImage.Height);
            //Yazı fontumu ve çizgi çizmek için fırçamı ve kalem nesnemi oluşturdum
            Font myFont = new Font("Calibri", 28);
            SolidBrush sbrush = new SolidBrush(Color.DarkCyan);
            Pen myPen = new Pen(Color.Black);

            //Bu kısımda sipariş formu yazısını ve çizgileri yazdırıyorum
            // e.Graphics.DrawLine(myPen, 120, 120, 600, 100);

            e.Graphics.DrawString("MAVİ RESTAURANT", myFont, sbrush, 275, 100);
            e.Graphics.DrawString("Çengelköy/İSTANBUL", new Font("Calibri", 18, FontStyle.Regular), Brushes.DarkCyan, new Point(320, 140));

            //  e.Graphics.DrawLine(myPen, 120, 320, 750, 320);
            //   e.Graphics.DrawString("Hellooooooooööö", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0, 0));

            e.Graphics.DrawString("Garson Adı: " + listView1.Items[0].SubItems[2].Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(25, 200));
            e.Graphics.DrawString("Masa No: " + listView1.Items[0].SubItems[1].Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(25, 230));
            e.Graphics.DrawString("Tarih: " + DateTime.Now, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(570, 200));
            e.Graphics.DrawLine(myPen, 140, 300, 700, 300);
            e.Graphics.DrawString("Yemek Adı ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(140, 310));
            e.Graphics.DrawString(listView1.Items[0].SubItems[3].Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(140, 340));
            e.Graphics.DrawString("Adet ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(340, 310));
            e.Graphics.DrawString(listView1.Items[0].SubItems[4].Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(340, 340));
            e.Graphics.DrawString("Toplam Fiyat ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(570, 310));
            e.Graphics.DrawString(listView1.Items[0].SubItems[5].Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(570, 340));
            e.Graphics.DrawLine(myPen, 140, 500, 700, 500);
            e.Graphics.DrawString("Toplam fiyat ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(500, 510));
            e.Graphics.DrawString("Teşekkür Ederiz ", new Font("Arial", 12, FontStyle.Bold), Brushes.DarkCyan, new Point(570, 600));

        }

    }
}

    

