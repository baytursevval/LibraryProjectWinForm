using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProjectWinForm
{
    public partial class OduncAlForm : Form
    {
        KutuphaneOtomasyonuEntities db = new KutuphaneOtomasyonuEntities();

        public void listele()
        {
            var kayitlar = db.Kayitlar.Where(x => x.kayit_durum == "True").ToList();
            dataGridView1.DataSource = kayitlar.ToList();
        }
        public OduncAlForm()
        {
            InitializeComponent();
        }

        private void OduncAlForm_Load(object sender, EventArgs e)
        {
            var kayitList = db.Kayitlar.Where(x => x.kayit_durum == "False").ToList();


            dataGridView1.DataSource = kayitList.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //int secilenkitapID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);
            int secilenid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var kayit = db.Kayitlar.Where(x => x.kayit_id == secilenid).FirstOrDefault();
            kayit.kayit_durum = "True";
            //yenikayit.kitap_id = secilenkitapID;
            
            //yenikayit.kayit_durum = "False";
            db.Kayitlar.Remove(kayit);
            
            db.SaveChanges();
            listele();
        }
    }
}
