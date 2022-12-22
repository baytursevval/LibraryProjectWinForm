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

namespace LibraryProjectWinForm.Kaynak
{
    public partial class KaynakEkleForm : Form
    {
        public KaynakEkleForm()
        {
            InitializeComponent();
        }
        KutuphaneOtomasyonuEntities db = new KutuphaneOtomasyonuEntities();

        public void listele()
        {
            var kaynaklar = db.Kaynaklar.ToList();
            dataGridView1.DataSource = kaynaklar.ToList();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Kaynaklar kaynaklar = new Kaynaklar();
            
            kaynaklar.kaynak_ad = kaynakAdtxt.Text;
            kaynaklar.kaynak_yazar = kaynakYazartxt.Text;
            kaynaklar.kaynak_yayinci = kaynakYayincitxt.Text;
            kaynaklar.kaynak_sayfasayisi =Convert.ToInt16(numericUpDown1.Value);
            //kaynaklar.kaynak_tur = comboBox1.Text;
           
            kaynaklar.kaynak_tur_id= comboBox1.SelectedIndex;

            db.Kaynaklar.Add(kaynaklar);
            db.SaveChanges();

            var kliste = db.Kaynaklar.ToList();
            dataGridView1.DataSource = kliste.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        //SqlConnection baglanti=new SqlConnection("Data Source=SEVO\\SQLEXPRESS;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=SSPI");
        
        private void KaynakEkleForm_Load(object sender, EventArgs e)
        {
            
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source = SEVO\\SQLEXPRESS; Initial Catalog = KutuphaneOtomasyonu; Integrated Security = True";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM KaynakTurler";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["tur"]);
            }
            baglanti.Close();
            

            listele();

        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
