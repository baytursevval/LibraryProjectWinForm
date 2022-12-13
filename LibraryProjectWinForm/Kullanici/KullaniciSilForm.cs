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
    public partial class KullaniciSilForm : Form
    {
        public KullaniciSilForm()
        {
            InitializeComponent();
        }
        KutuphaneOtomasyonuEntities db = new KutuphaneOtomasyonuEntities();
        public void listele()
        {
            
            var kullanicilar = db.Kullanicilar.ToList();
            dataGridView1.DataSource = kullanicilar.ToList();
        }

        private void KullaniciSilForm_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secilenid =Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var kullanici = db.Kullanicilar.Where(x => x.kullanici_id == secilenid).FirstOrDefault();
            db.Kullanicilar.Remove(kullanici);
            db.SaveChanges();
            listele();
        }
    }
}