using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KitaplıkProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Tur_Listele();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=SAMET\SQLEXPRESS;Initial Catalog=Kitaplik;Integrated Security=True;");

        private void btnlst_Click(object sender, EventArgs e)
        {
            Listele();
        }
        void Temizle()
        {
            txtıd.Clear();
            txtad.Clear();
            txtfyt.Clear();
            txtsyf.Clear();
            txtyynevi.Clear();
            txtyzr.Clear();
        }
        void Listele()
        {
            SqlCommand cmd = new SqlCommand("Listele", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void Tur_Listele()
        {
            SqlCommand cmd = new SqlCommand("Select * from Tbl_Turler", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbTur.ValueMember = "TurId";
            cmbTur.DisplayMember = "TurAd";
            cmbTur.DataSource = dt;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtıd.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtyzr.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtsyf.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtfyt.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtyynevi.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            cmbTur.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmdsil = new SqlCommand("delete from Tbl_Kitaplar where KitapId=@p1", baglanti);
            cmdsil.Parameters.AddWithValue("@p1",txtıd.Text);
            cmdsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap veritabanından silindi","BİLGİ",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Listele();
            Temizle();
        }

        private void btnkyt_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmdekle = new SqlCommand("insert into Tbl_Kitaplar (KitapAd,Yazar,Sayfa,Fiyat,Yayinevi,Tur) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            cmdekle.Parameters.AddWithValue("@p1",txtad.Text);
            cmdekle.Parameters.AddWithValue("@p2",txtyzr.Text);
            cmdekle.Parameters.AddWithValue("@p3",txtsyf.Text);
            cmdekle.Parameters.AddWithValue("@p4",txtfyt.Text);
            cmdekle.Parameters.AddWithValue("@p5",txtyynevi.Text);
            cmdekle.Parameters.AddWithValue("@p6",cmbTur.SelectedIndex+1);
            cmdekle.Parameters.AddWithValue("@p7",txtıd.Text);
            cmdekle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Veri Tabanına Eklendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            Temizle();
        }

        private void btngnclle_Click(object sender, EventArgs e)    
        {
            baglanti.Open();
            SqlCommand cmdekle = new SqlCommand("update Tbl_Kitaplar set KitapAd=@p1,Yazar=@p2,Sayfa=@p3,Fiyat=@p4,Yayinevi=@p5,Tur=@p6 where KitapId=@p7", baglanti);
            cmdekle.Parameters.AddWithValue("@p1", txtad.Text);
            cmdekle.Parameters.AddWithValue("@p2", txtyzr.Text);
            cmdekle.Parameters.AddWithValue("@p3", txtsyf.Text);
            cmdekle.Parameters.AddWithValue("@p4", txtfyt.Text);
            cmdekle.Parameters.AddWithValue("@p5", txtyynevi.Text);
            cmdekle.Parameters.AddWithValue("@p6", cmbTur.SelectedIndex+1);
            cmdekle.Parameters.AddWithValue("@p7", txtıd.Text);
            cmdekle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Veri Tabanına Güncellendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            Temizle();
        }
    }
}
