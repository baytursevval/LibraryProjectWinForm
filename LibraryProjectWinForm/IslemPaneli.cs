using LibraryProjectWinForm.Kaynak;
using LibraryProjectWinForm.Kullanici;
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
            if (ekleKullanicibtn.Visible == false)
            {
                ekleKullanicibtn.Visible = true;
                gnclleKullanicibtn.Visible = true;
                silKullanicibtn.Visible = true;
            }
            else
            {
                ekleKullanicibtn.Visible = false;
                gnclleKullanicibtn.Visible = false;
                silKullanicibtn.Visible = false;
            }
            

            KullaniciListeForm klisteform = new KullaniciListeForm();
            klisteform.MdiParent = this;
            klisteform.Show();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void IslemPaneli_Load(object sender, EventArgs e)
        {
            ekleKullanicibtn.Visible = false;
            gnclleKullanicibtn.Visible = false;
            silKullanicibtn.Visible = false;

            ekleKitapbtn.Visible = false;
            guncelleKitapbtn.Visible = false;
            silKitapbtn.Visible = false;
        }

        private void ekleKullanicibtn_Click(object sender, EventArgs e)
        {
            KullaniciEkleForm ekleForm = new KullaniciEkleForm();
            ekleForm.MdiParent = this;
            ekleForm.Show();
        }

        private void silKullanicibtn_Click(object sender, EventArgs e)
        {
            KullaniciSilForm ksil = new KullaniciSilForm();
            ksil.MdiParent = this;
            ksil.Show();
        }

        private void gnclleKullanicibtn_Click(object sender, EventArgs e)
        {
            KullaniciGuncelleForm kguncel = new KullaniciGuncelleForm();
            kguncel.MdiParent = this;
            kguncel.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ekleKitapbtn.Visible == false)
            {
                ekleKitapbtn.Visible = true;
                guncelleKitapbtn.Visible = true;
                silKitapbtn.Visible = true;
            }
            else
            {
                ekleKitapbtn.Visible = false;
                guncelleKitapbtn.Visible = false;
                silKitapbtn.Visible = false;
            }
            KaynakListeForm kliste = new KaynakListeForm();
            kliste.MdiParent = this;
            kliste.Show();
        }

        private void ekleKitapbtn_Click(object sender, EventArgs e)
        {
            KaynakEkleForm kekle = new KaynakEkleForm();
            kekle.MdiParent = this;
            kekle.Show();
        }
    }
}
