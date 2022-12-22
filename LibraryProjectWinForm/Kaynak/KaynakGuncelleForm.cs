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
    public partial class KaynakGuncelleForm : Form
    {
        public KaynakGuncelleForm()
        {
            InitializeComponent();
        }
        KutuphaneOtomasyonuEntities db = new KutuphaneOtomasyonuEntities();
        public void listele()
        {
            
            var kaynaklar = db.Kaynaklar.ToList();
            dataGridView1.DataSource = kaynaklar.ToList();
        }

        private void KaynakGuncelleForm_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            int secilenid= Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var kaynak = db.Kaynaklar.Where(x => x.kaynak_id == secilenid).FirstOrDefault();
            kaynak.kaynak_ad = kaynakAdtxt.Text;
            kaynak.kaynak_yazar = kaynakYazartxt.Text;
            kaynak.kaynak_yayinci = kaynakYayincitxt.Text;
            kaynak.kaynak_sayfasayisi = Convert.ToInt16(numericUpDown1.Value);
            
            kaynak.kaynak_tur_id = comboBox1.SelectedIndex;

            db.SaveChanges();
            //listele();

        }
    }
}
