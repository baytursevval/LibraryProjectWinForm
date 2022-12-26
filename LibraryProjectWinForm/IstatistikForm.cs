using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LibraryProjectWinForm
{
    public partial class IstatistikForm : Form
    {
        KutuphaneOtomasyonuEntities db = new KutuphaneOtomasyonuEntities();
        public IstatistikForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = SEVO\\SQLEXPRESS; Initial Catalog = KutuphaneOtomasyonu; Integrated Security = True");
        private void IstatistikForm_Load(object sender, EventArgs e)
        {
            this.chart1.Titles.Add("okunan tür grafiği");

            
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select T.tur_id, SUM(K.okunma_sayisi) as 'toplam' from Kaynaklar K, KaynakTurler T where T.tur_id=K.kaynak_tur_id group by  T.tur_id", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                chart1.Series["Turler"].Points.AddXY(oku[0].ToString(), oku[1].ToString());
            }
            //db.SaveChanges();
            baglanti.Close();
            
        }

       
    }
}
