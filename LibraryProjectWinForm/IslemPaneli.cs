//using LibraryProjectWinForm.Kayitlar;
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

        //KullaniciListeForm klisteform = new KullaniciListeForm();
        private KullaniciListeForm klisteform;
        private void button1_Click(object sender, EventArgs e)
        {
            if (ekleKullanicibtn.Visible == false)
            {
                ekleKullanicibtn.Visible = true;
                gnclleKullanicibtn.Visible = true;
                silKullanicibtn.Visible = true;

                klisteform = new KullaniciListeForm();
                klisteform.MdiParent = this;
                klisteform.Show();
            }
            else
            {
                ekleKullanicibtn.Visible = false;
                gnclleKullanicibtn.Visible = false;
                silKullanicibtn.Visible = false;
                klisteform.Close();
            }
            
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

        private KullaniciEkleForm ekleForm;
        private bool ekleKullaniciDurum = false;
        private void ekleKullanicibtn_Click(object sender, EventArgs e)
        {

            if (ekleKullaniciDurum==false)
            {
                ekleForm = new KullaniciEkleForm();
                ekleForm.MdiParent = this;
                ekleForm.Show();
                ekleKullaniciDurum = true;
            }
            else 
            {
                ekleForm.Close();
                ekleKullaniciDurum = false;
            }
        }
        private KullaniciSilForm ksil;
        private bool silKullaniciDurum = false;
        private void silKullanicibtn_Click(object sender, EventArgs e)
        {
            if (silKullaniciDurum == false)
            {
                ksil = new KullaniciSilForm();
                ksil.MdiParent = this;
                ksil.Show();
                silKullaniciDurum = true;
            }
            else
            {
                ksil.Close();
                silKullaniciDurum = false;
            }
        }
        private KullaniciGuncelleForm kguncel;
        private bool gncelleKullaniciDurum = false;
        private void gnclleKullanicibtn_Click(object sender, EventArgs e)
        {
            if (gncelleKullaniciDurum == false)
            {
                kguncel = new KullaniciGuncelleForm();
                kguncel.MdiParent = this;
                kguncel.Show();
                gncelleKullaniciDurum = true;
            }
            else
            {
                kguncel.Close();
                gncelleKullaniciDurum = false;
            }
            
        }
        private KaynakListeForm kliste;
        private void button5_Click(object sender, EventArgs e)
        {
            if (ekleKitapbtn.Visible == false)
            {
                kliste = new KaynakListeForm();
                ekleKitapbtn.Visible = true;
                guncelleKitapbtn.Visible = true;
                silKitapbtn.Visible = true;
                kliste.MdiParent = this;
                kliste.Show();
            }
            else
            {
                ekleKitapbtn.Visible = false;
                guncelleKitapbtn.Visible = false;
                silKitapbtn.Visible = false;
                kliste.Close();
            }
            
            
        }
        private KaynakEkleForm kekle;
        private bool kekleDurum = false;
        private void ekleKitapbtn_Click(object sender, EventArgs e)
        {
            if (kekleDurum == false)
            {
                kekle = new KaynakEkleForm();
                kekle.MdiParent = this;
                kekle.Show();
                kekleDurum = true;
            }
            else
            {
                kekle.Close();
                kekleDurum = false;
            }
        }
        private OduncVerForm odunc;
        private bool oduncverdurum = false;
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (oduncverdurum == false)
            {
                odunc= new OduncVerForm();
                odunc.MdiParent = this;
                odunc.Show();
                oduncverdurum = true;
            }
            else
            {
                odunc.Close();
                oduncverdurum = false;
            }
            
        }

        private KaynakSilForm kasil;
        private bool kaSilDurum = false;
        private void silKitapbtn_Click(object sender, EventArgs e)
        {
            if (kaSilDurum == false)
            {
                kasil = new KaynakSilForm();
                kasil.MdiParent = this;
                kasil.Show();
                kaSilDurum = true;
            }
            else
            {
                kasil.Close();
                kaSilDurum = false;
            }
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Çıkmak istiyor musunuz?","confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
                Application.Exit();
        }

        private KaynakGuncelleForm kaynakguncelle;
        private bool kaynakguncDurum = false;
        private void guncelleKitapbtn_Click(object sender, EventArgs e)
        {
            if (kaynakguncDurum == false)
            {
                kaynakguncelle = new KaynakGuncelleForm();
                kaynakguncelle.MdiParent = this;
                kaynakguncelle.Show();
                kaynakguncDurum = true;
            }
            else
            {
                kaynakguncelle.Close();
                kaynakguncDurum = false;
            }
        }
        private OduncAlForm oduncal;
        private bool oduncalDurum;
        private void button3_Click(object sender, EventArgs e)
        {
            if (oduncalDurum == false)
            {
                oduncal = new OduncAlForm();
                oduncal.MdiParent = this;
                oduncal.Show();
                oduncalDurum = true;
            }
            else
            {
                oduncal.Close();
                oduncalDurum = false;
            }
        }
        private IstatistikForm istatistik;

        private void button4_Click(object sender, EventArgs e)
        {
            istatistik = new IstatistikForm();
            istatistik.Show();
            istatistik.MdiParent = this;
            //this.Hide();
        }
    }
}
