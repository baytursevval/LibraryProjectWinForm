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
            //kayıtları listeleme
            var kayitList = db.Kayitlar.ToList();
            dataGridView1.DataSource = kayitList.ToList();

            //kaynakları listeleme
            var kaynaklist = db.Kaynaklar.ToList();
            dataGridView2.DataSource = kaynaklist.ToList();

            //istenmeyen kolonları gizleme
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;

            //kolon adları düzenleme
            dataGridView1.Columns[1].HeaderText = "Kullanıcı";
            dataGridView1.Columns[2].HeaderText = "Kaynak Ad";
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string gelenad = textBox2.Text;
            var bulunankaynak = db.Kaynaklar.Where(x => x.kaynak_ad.Contains(gelenad)).ToList();
            dataGridView2.DataSource = bulunankaynak.ToList();
        }
    }
}