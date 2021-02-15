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
    public partial class Form2 : Form
    {
        public Form1 frm1;
        public Form2()
        {
            InitializeComponent();
        }
        public static string KullaniciAdi;
        public static string Sifre;
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\sistem.mdb");

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void kaydolBtn_Click(object sender, EventArgs e)
        {
            try
            {
                KullaniciAdi = textBox1.Text;
                Sifre = textBox2.Text;
                if (textBox2.Text != textBox3.Text)
                {
                    MessageBox.Show("Şifreler Aynı Değil");
                    textBox2.Text = "";
                    textBox3.Text = "";
                }
                else if (textBox2.Text.Length <= 6 && textBox1.Text == textBox2.Text)
                {
                    MessageBox.Show("Şifre En Az 6 Karakterden Oluşmalıdır Ve Kullanıcı Adı İle Aynı Olmamalıdır!");
                    textBox2.Text = "";
                }
                else
                {
                    MessageBox.Show("Kayıt İşlemi Başarıyla Gerçekleştirildi");
                    baglanti.Open();
                    string ekle = "insert into sifre(KullaniciAdi,Sifre,mail) values (@KullaniciAdi,@Sifre,@mail)";
                    OleDbCommand komut = new OleDbCommand(ekle, baglanti);
                    komut.Parameters.AddWithValue("@KullaniciAdi", textBox1.Text);
                    komut.Parameters.AddWithValue("@Sifre", textBox2.Text);
                    komut.Parameters.AddWithValue("@mail", textBox4.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Kaydolurken Bir Hata Oluştu.");
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

        private void GeriBtn_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }
    }
}
