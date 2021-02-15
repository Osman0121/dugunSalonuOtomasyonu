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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\sistem.mdb");
        OleDbCommand komut=new OleDbCommand();
        // şifre oluşturmak için metot oluşturuyoruz.
        public bool sifrele(string kulAdi, string sifre)
        {
            try
            {
                baglanti.Open();
                komut = new OleDbCommand("Select Sifre From sifre where KullaniciAdi='" + kulAdi + "'", baglanti);
                OleDbDataReader okuyucu = komut.ExecuteReader();
                while (okuyucu.Read())
                {

                    string si = okuyucu["Sifre"].ToString();
                    if (sifre == si)
                    {
                        baglanti.Close();
                        return true;
                    }
                }
                baglanti.Close();
                return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Şifre Oluşturmada Bir Hata Oluştu!");
                throw;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void KaydolBtn_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }
        private void GrsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (sifrele(textBox1.Text, textBox2.Text))
                {
                    Form3 frm3 = new Form3(textBox1.Text);
                    frm3.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre yanlış girildi");
                    textBox2.Text = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bir Hata Oluştu");
                throw;
            }
        }

        private void cksBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = this.Text.Substring(1) + this.Text.Substring(0, 1);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
