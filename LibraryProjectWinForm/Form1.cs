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
    public partial class Form1 : Form
    {
        KutuphaneOtomasyonuEntities db = new KutuphaneOtomasyonuEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kullanicigrsbtn_Click(object sender, EventArgs e)
        {
            string gelenAd = adGiristxt.Text;
            string gelenSifre = sifreGiristxt.Text;
            var personel = db.Personeller.Where(x => x.personel_kullaniciAd.Equals(gelenAd)&& x.personel_sifre.Equals(gelenSifre)).FirstOrDefault();

            if (personel == null)
                MessageBox.Show("Kullanıcı adı veya şifre hatalı");
            else
            {
                //MessageBox.Show("Başarılı");
                IslemPaneli panel = new IslemPaneli();
                panel.Show();
                this.Hide();
            }
                


           
        }

        private void sifreGiristxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void sifreGiristxt_MouseClick(object sender, MouseEventArgs e)
        {
            sifreGiristxt.PasswordChar = '*';
        }
    }
}
