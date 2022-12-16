using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private void button1_Click(object sender, EventArgs e)
        {
            Kaynaklar kaynaklar = new Kaynaklar();
            kaynaklar.kaynak_ad = kaynakAdtxt.Text;
            kaynaklar.kaynak_yazar = kaynakYazartxt.Text;
            kaynaklar.kaynak_yayinci = kaynakYayincitxt.Text;
            kaynaklar.kaynak_sayfasayisi =Convert.ToInt16(numericUpDown1.Value);
            kaynaklar.kaynak_basimtarihi = dateTimePicker1.Value;

            db.Kaynaklar.Add(kaynaklar);
            db.SaveChanges();

            var kliste = db.Kaynaklar.ToList();
            dataGridView1.DataSource = kliste.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void KaynakEkleForm_Load(object sender, EventArgs e)
        {

        }
    }
}
