using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salon_Otomasyonu
{
    public partial class Kuafor : Form
    {
        public Kuafor()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\sistem.mdb");
        DataTable tablo = new DataTable();
        private void Kuafor_Load(object sender, EventArgs e)
        {
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select sira,gelinAdsoyad,telefon,toplamucret From kuafor", baglanti);
            adtr.Fill(tablo);
            KuaforRapor rap = new KuaforRapor();
            rap.SetDataSource(tablo);
            crystalReportViewer1.ReportSource = rap;
        }
    }
}
