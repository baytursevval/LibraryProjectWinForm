﻿using System;
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
    public partial class OduncVerForm : Form
    {
        public OduncVerForm()
        {
            InitializeComponent();
        }
        KutuphaneOtomasyonuEntities db = new KutuphaneOtomasyonuEntities();
        private void OduncVerForm_Load(object sender, EventArgs e)
        {
            var kullanicilist = db.Kullanicilar.ToList();
            dataGridView3.DataSource = kullanicilist.ToList();

            //kayıtları listeleme
            var kayitList = db.Kayitlar.ToList();
            var kaynakList = db.Kaynaklar.ToList();
            dataGridView1.DataSource = kayitList.ToList();

            //kaynakları listeleme
            var kaynaklist = db.Kaynaklar.Where(x=> x.kaynak_durum=="True").ToList();
            dataGridView2.DataSource = kaynaklist.ToList();

            //istenmeyen kolonları gizleme
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;

            //kolon adları düzenleme

            //dataGridView1.Columns[1].HeaderText = "Kullanıcı";
            //dataGridView1.Columns[2].HeaderText = "Kaynak Ad";
            dataGridView3.Columns[6].Visible = false;
            dataGridView3.Columns[7].Visible = false;

            dataGridView2.Columns[8].Visible = false;
            dataGridView2.Columns[9].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tc=textBox1.Text;
            var kullaniciVarMi = db.Kullanicilar.Where(x => x.kullanici_tc == tc).FirstOrDefault();

            if (kullaniciVarMi != null)
                label2.Text = kullaniciVarMi.kullanici_ad + " " + kullaniciVarMi.kullanici_soyad;
            else
                label2.Text = "Böyle bir kullanıcı yok";
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string gelenad = textBox2.Text;
            var bulunankaynak = db.Kaynaklar.Where(x => x.kaynak_ad.Contains(gelenad)).ToList();
            dataGridView2.DataSource = bulunankaynak;
        }

        public void listele()
        {
            var kaynaklar = db.Kaynaklar.ToList();
            dataGridView1.DataSource = kaynaklar.ToList();
        }
        private void button2_Click(object sender, EventArgs e)
        {
           
                //kişi aldık
                string secilenkisiTC = textBox1.Text;
                var secilenkisi = db.Kullanicilar.Where(x => x.kullanici_tc.Equals(secilenkisiTC)).FirstOrDefault();

                //kitap aldık
                int secilenkitapID = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
                var secilenkitap = db.Kaynaklar.Where(x => x.kaynak_id == secilenkitapID).FirstOrDefault();
                secilenkitap.kaynak_durum = "False";
                Kayitlar yenikayit = new Kayitlar();
                //yenikayit.kitap_id = secilenkitap.kaynak_id;
                yenikayit.kitap_id = secilenkitapID;
                yenikayit.kullanici_id = secilenkisi.kullanici_id;
                yenikayit.alis_tarih = DateTime.Today;
                yenikayit.son_tarih = DateTime.Today.AddDays(15);
                yenikayit.kayit_durum = "False";

                secilenkitap.okunma_sayisi += 1;

                db.Kayitlar.Add(yenikayit);
                db.SaveChanges();
                //listele();
                var kayitlist = db.Kayitlar.ToList();
                dataGridView1.DataSource = kayitlist.ToList();
                
                //dataGridView2.Hide();
                //dataGridView2.Show();

                var kaynaklist = db.Kaynaklar.Where(x => x.kaynak_durum == "True").ToList();
                dataGridView2.DataSource = kaynaklist.ToList();

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string gelenad = textBox1.Text;
            var bulunankisi = db.Kullanicilar.Where(x => x.kullanici_ad.Contains(gelenad)).ToList();
            dataGridView3.DataSource = bulunankisi;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
