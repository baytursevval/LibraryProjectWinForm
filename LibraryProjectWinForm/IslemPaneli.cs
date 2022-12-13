using LibraryProjectWinForm.NewFolder1;
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
    public partial class IslemPaneli : Form
    {
        public IslemPaneli()
        {
            InitializeComponent();
        }
        KutuphaneOtomasyonuEntities db = new KutuphaneOtomasyonuEntities();

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ekleKullanicibtn.Visible = false;
            gnclleKullanicibtn.Visible = false;
            silKullanicibtn.Visible = false;

            KullaniciListeForm klisteform = new KullaniciListeForm();
            klisteform.MdiParent = this;
            klisteform.Show();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void IslemPaneli_Load(object sender, EventArgs e)
        {
           
        }

        private void ekleKullanicibtn_Click(object sender, EventArgs e)
        {
            KullaniciEkleForm ekleForm = new KullaniciEkleForm();
            ekleForm.MdiParent = this;
            ekleForm.Show();
        }
    }
}
