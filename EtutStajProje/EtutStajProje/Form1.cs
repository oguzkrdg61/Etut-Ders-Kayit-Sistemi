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
using System.IO;

namespace EtutStajProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source = KARADAĞ\KARADAG; 
            Initial Catalog = EtütProje; Integrated Security = True");

        void derslistesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From tblders", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbDers.ValueMember = "dersID";
            cmbDers.DisplayMember = "dersAD";
            cmbDers.DataSource = dt;
        }

        //Etüt Listesi
        void etutlistesi()
        {
            SqlDataAdapter da3 = new SqlDataAdapter("execute etut1",baglanti);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dataGridView1.DataSource = dt3;
        }
            private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            derslistesi();
            etutlistesi();
        }

        private void cmbDers_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da2 = new SqlDataAdapter("Select * from tblogretmen where bransID=" +
                cmbDers.SelectedValue, baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            cmbOgrtmen.ValueMember = "ogrtID";
            cmbOgrtmen.DisplayMember = "AD";
            cmbOgrtmen.DataSource = dt2;
        }

        private void btnEtutOlstr_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into " +
                "tbletut(dersıd,ogrtıd,tarıh,saat) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", cmbDers.SelectedValue);
            komut.Parameters.AddWithValue("@p2", cmbOgrtmen.SelectedValue);
            komut.Parameters.AddWithValue("@p3", mskTarih.Text);
            komut.Parameters.AddWithValue("@p4", mskSaat.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Etüt Oluşturuldu", "Bilgi", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtetutid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update tbletut set ogrID=@p1,durum=@p2 where ıd=@p3",
                baglanti);
            komut.Parameters.AddWithValue("@p1", txtetutid.Text);
            komut.Parameters.AddWithValue("@p2", "True");
            komut.Parameters.AddWithValue("@p3", txtetutid.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Etüt Öğrenciye Verildi", "Bilgi", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tblogrencı (ad,soyad,fotograf,sınıf,telefon,mail) " +
                "values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", pictureBox1.ImageLocation);
            komut.Parameters.AddWithValue("@p4", txtSınıf.Text);
            komut.Parameters.AddWithValue("@p5", mskTel.Text);
            komut.Parameters.AddWithValue("@p6", txtMail.Text);
            komut.ExecuteNonQuery();
            baglanti.Close(); 
            MessageBox.Show("Öğrenci Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnFotograf_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }
    }
}
