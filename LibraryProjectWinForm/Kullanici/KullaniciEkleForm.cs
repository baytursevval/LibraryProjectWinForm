using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProjectWinForm.NewFolder1
{
    public partial class KullaniciEkleForm : Form
    {
        public KullaniciEkleForm()
        {
            InitializeComponent();
        }
        KutuphaneOtomasyonuEntities db = new KutuphaneOtomasyonuEntities();

        public void listele()
        {
            KutuphaneOtomasyonuEntities db = new KutuphaneOtomasyonuEntities();
            var kullanicilar = db.Kullanicilar.ToList();
            dataGridView1.DataSource = kullanicilar.ToList();
        }
        private void KullaniciEkleForm_Load(object sender, EventArgs e)
        {
            kullaniciCezatxt.Text = "0";
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kullanicilar kullanicilar = new Kullanicilar();
            kullanicilar.kullanici_ad = kullaniciAdtxt.Text;
            kullanicilar.kullanici_soyad = kullaniciSoyadtxt.Text;
            kullanicilar.kullanici_tc = kullaniciTctxt.Text;
            kullanicilar.kullanici_tel = kullaniciteltxt.Text;
            kullanicilar.kullanici_mail = kullaniciMailtxt.Text;
            //kullanicilar.kullanici_ceza = Convert.ToDouble("0");
            //kullaniciCezatxt.Text = "0";
            if (radioButton1.Checked)
                kullanicilar.kullanici_cinsiyet = "E";
            else if (radioButton2.Checked)
                kullanicilar.kullanici_cinsiyet = "K";

            db.Kullanicilar.Add(kullanicilar);
            db.SaveChanges();
            listele();
            
        }

        private void kullaniciCezatxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
