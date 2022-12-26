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
    public partial class KaynakSilForm : Form
    {
        public KaynakSilForm()
        {
            InitializeComponent();
        }
        KutuphaneOtomasyonuEntities db = new KutuphaneOtomasyonuEntities();

        public void listele()
        {
            var kaynaklar = db.Kaynaklar.ToList();
            dataGridView1.DataSource = kaynaklar.ToList();
        }
        private void KaynakSilForm_Load(object sender, EventArgs e)
        {
            listele();
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string gelenad = textBox1.Text;
            var bulunanisim = db.Kaynaklar.Where(x => x.kaynak_ad.Contains(gelenad)).ToList();
            dataGridView1.DataSource = bulunanisim;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secilenkaynak = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var kaynak = db.Kaynaklar.Where(x => x.kaynak_id == secilenkaynak).FirstOrDefault();
            db.Kaynaklar.Remove(kaynak);
            db.SaveChanges();
            listele();
        }
    }
}
