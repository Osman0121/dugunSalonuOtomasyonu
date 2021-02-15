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
    public partial class Salon : Form
    {
        public Salon()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\sistem.mdb");
        DataTable tablo = new DataTable();
        private void Salon_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select sira,adsoyad,telefon,ucret From kiraListe", baglanti);
            adtr.Fill(tablo);
            SalonRapor rap = new SalonRapor();
            rap.SetDataSource(tablo);
            crystalReportViewer1.ReportSource = rap;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = this.Text.Substring(1) + this.Text.Substring(0, 1);
        }
    }
}
