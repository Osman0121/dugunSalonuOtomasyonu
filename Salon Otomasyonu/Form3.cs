using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Threading;
using System.Net.NetworkInformation;

namespace Salon_Otomasyonu
{
    public partial class Form3 : Form
    {
        public string Kad { get; set; }
        public Form1 frm1;
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(string kullaniciAdi)
        {
            InitializeComponent();
            Kad = kullaniciAdi;
        }
        OleDbConnection baglanti;
        OleDbCommand komut;
        public string posta()
        {
            string mail;
            baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\sistem.mdb");
            baglanti.Open();
            komut = new OleDbCommand("SELECT mail From sifre WHERE KullaniciAdi='" + Kad + "'", baglanti);
            OleDbDataReader okuyucu = komut.ExecuteReader();
            okuyucu.Read();
            mail = okuyucu[0].ToString();
            return mail;
            
        }
        public void Gonder(string konu, string icerik)
        {

            DateTime yarin = DateTime.Now.AddDays(1);
            baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\sistem.mdb");
            baglanti.Open();
            komut = new OleDbCommand("select * from kiraListe  where tarih='" + yarin.ToLongDateString() + "'", baglanti);
            OleDbDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                string message = "";
                string adsoyad = okuyucu["adsoyad"].ToString();
                string telefon = okuyucu["telefon"].ToString();
                string saat = okuyucu["saat"].ToString();
                string ucret = okuyucu["ucret"].ToString();
                string odenenucret = okuyucu["odenenucret"].ToString();
                string kalanucret = okuyucu["kalanucret"].ToString();
                string kampanya = okuyucu["kampanya"].ToString();
                string bilgi = okuyucu["bilgi"].ToString();
                message = "Adı Soyadı:" + adsoyad +
                    Environment.NewLine +
                    "Telefon Numarası:" + telefon +
                    Environment.NewLine +
                    "Saat:" + saat +
                    Environment.NewLine +
                    "Ücret:" + ucret +
                    Environment.NewLine +
                    "Ödenen:" + odenenucret +
                    Environment.NewLine +
                    "Kalan:" + kalanucret +
                    Environment.NewLine +
                    "Kampanya:" + kampanya +
                    Environment.NewLine +
                    "Ekstra Yapılacaaklar:" + bilgi;
                Thread thnew = new Thread(new ParameterizedThreadStart(SendMail));
                thnew.Start(message);
            }
            baglanti.Close();
        }
        private void SendMail(object mesaj)
        {
                string message = mesaj.ToString();
                MailMessage ePosta = new MailMessage();
                ePosta.From = new MailAddress("posta@gmail.com");
                ePosta.To.Add(posta());
                ePosta.Subject = "Düğün Bildirimi";
                ePosta.Body = message;
                SmtpClient smtp = new SmtpClient();
                smtp.Credentials = new System.Net.NetworkCredential("14545037o@gmail.com", "14545037");
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.Send(ePosta);                               
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            Gonder("Bildirim", "İçerik");          
        }

        private void SalonBtn_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
            this.Hide();
        }

        private void FotoBtn_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.Show();
            this.Hide();
        }
        private void ModaeviBtn_Click(object sender, EventArgs e)
        {
            Form7 frm7 = new Form7();
            frm7.Show();
            this.Hide();
        }
        private void KantinBtn_Click(object sender, EventArgs e)
        {
            Form8 frm8 = new Form8();
            frm8.Show();
            this.Hide();
        }
        private void KuaforBtn_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
            this.Hide();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = this.Text.Substring(1) + this.Text.Substring(0, 1);
        }
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void cksBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void GitBtn_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Salon sal = new Salon();
                sal.ShowDialog();
            } 
            if (comboBox1.SelectedIndex == 1)
            {
                foto f = new foto();
                f.ShowDialog();           
            }
            if (comboBox1.SelectedIndex == 2)
            {
                Modaevi moda = new Modaevi();
                moda.ShowDialog();       
            }
            if (comboBox1.SelectedIndex == 3)
            {
                Kantin kntn = new Kantin();
                kntn.ShowDialog();        
            }
            if (comboBox1.SelectedIndex == 4)
            {
                Kuafor kfr = new Kuafor();
                kfr.ShowDialog();            
            }
        }
    }
}
