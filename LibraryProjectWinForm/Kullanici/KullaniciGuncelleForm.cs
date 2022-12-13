﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProjectWinForm.Kullanici
{
    public partial class KullaniciGuncelleForm : Form
    {
        public KullaniciGuncelleForm()
        {
            InitializeComponent();
        }
        KutuphaneOtomasyonuEntities db = new KutuphaneOtomasyonuEntities();
        public void listele()
        {
           
            var kullanicilar = db.Kullanicilar.ToList();
            dataGridView1.DataSource = kullanicilar.ToList();
        }
        private void KullaniciGuncelleForm_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            kullaniciAdtxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            kullaniciSoyadtxt.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();
            kullaniciTctxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            kullaniciMailtxt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            kullaniciteltxt.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            //kullaniciCezatxt.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[7].Value.ToString().Equals("E"))
                radioButton1.Checked = true;
            else if (dataGridView1.CurrentRow.Cells[7].Value.ToString().Equals("K"))
                radioButton2.Checked = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secilenid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var kullanici = db.Kullanicilar.Where(x => x.kullanici_id == secilenid).FirstOrDefault();
           
            kullanici.kullanici_ad = kullaniciAdtxt.Text;
            kullanici.kullanici_soyad = kullaniciSoyadtxt.Text;
            kullanici.kullanici_tc = kullaniciTctxt.Text;
            kullanici.kullanici_tel = kullaniciteltxt.Text;
            kullanici.kullanici_mail = kullaniciMailtxt.Text;
            //kullanicilar.kullanici_ceza = Convert.ToDouble(kullaniciCezatxt.Text);
            if (radioButton1.Checked)
                kullanici.kullanici_cinsiyet = "E";
            else if (radioButton2.Checked)
                kullanici.kullanici_cinsiyet = "K";
            db.SaveChanges();
            listele();
        }
    }
}
