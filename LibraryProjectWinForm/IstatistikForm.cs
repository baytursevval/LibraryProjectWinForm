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

namespace LibraryProjectWinForm
{
    public partial class IstatistikForm : Form
    {
        public IstatistikForm()
        {
            InitializeComponent();
        }

        private void IstatistikForm_Load(object sender, EventArgs e)
        {
            GrafikOlustur();
        }
        private void GrafikOlustur()
        {
            SqlConnection con = new SqlConnection("Data Source = SEVO\\SQLEXPRESS; Initial Catalog = KutuphaneOtomasyonu; Integrated Security = True");
            DataSet ds = new DataSet();
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("Select tur_id,tur from KaynakTurler", con);
            adapt.Fill(ds);
            chart1.DataSource = ds;
            chart1.Series["Turler"].XValueMember = "tur";
            chart1.Series["Turler"].YValueMembers = "tur_id";
            chart1.Titles.Add("Tur grafiği");
            con.Close();
        }
    }
}
