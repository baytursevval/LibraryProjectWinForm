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
            kaynak.kaynak_tur = comboBox1.Text;

            db.SaveChanges();
            listele();

        }
    }
}
