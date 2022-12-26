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
    public partial class KullaniciListeForm : Form
    {
        public KullaniciListeForm()
        {
            InitializeComponent();
        }
        public void listele()
        {
            KutuphaneOtomasyonuEntities db = new KutuphaneOtomasyonuEntities();
            var kullanicilar = db.Kullanicilar.ToList();

            dataGridView1.DataSource = kullanicilar.ToList();
        }
        private void KullaniciListeForm_Load(object sender, EventArgs e)
        {

            listele();
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
