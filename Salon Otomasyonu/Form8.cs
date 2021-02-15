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
    public partial class Form8 : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\sistem.mdb");
        OleDbDataAdapter adtr;
        OleDbCommand komut;
        DataTable tablo;
        public Form8()
        {
            InitializeComponent();
        }
        void griddoldur()
        {
            try
            {
                tablo = new DataTable();
                tablo.Clear();
                adtr = new OleDbDataAdapter("Select *from kantin", baglanti);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;
            }
            catch (Exception)
            {
                MessageBox.Show("Tablo Doldurulurken Hata Oluştu");
                throw;
            }
        }
        void sifirla()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
        private void Form8_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            griddoldur();
            textBox4.Enabled = false;
        }
        private void Form8_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void cksBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void KaydetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                komut = new OleDbCommand();
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "INSERT INTO kantin (sira,gelir,gider,kazanc) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + int.Parse(textBox4.Text) + "')";
                komut.ExecuteNonQuery();
                baglanti.Close();
                griddoldur();
                MessageBox.Show("Kaydedildi");
                sifirla();
            }
            catch (Exception)
            {
                MessageBox.Show("Kaydetme İşlemi Sırasında Hata Oluştu");
                throw;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = this.Text.Substring(1) + this.Text.Substring(0, 1);
        }

        private void SilBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult cevap;
                cevap = MessageBox.Show("Kaydı Silmek istediğinize Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    DataTable tablo = new DataTable();
                    komut = new OleDbCommand();
                    baglanti.Open();
                    komut.Connection = baglanti;
                    komut.CommandText = "DELETE FROM kantin WHERE sira='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    griddoldur();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Silme İşlemi Sırasında Hata Oluştu");
                throw;
            }            
        }

        private void DuzenleBtn_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void GuncelleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                komut = new OleDbCommand();
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "UPDATE kantin SET sira='" + textBox1.Text + "',gelir='" + textBox2.Text + "',gider='" + textBox3.Text + "',kazanc='" + int.Parse(textBox4.Text) + "' where sira='" + textBox1.Text + "'";
                komut.ExecuteNonQuery();
                baglanti.Close();
                griddoldur();
                sifirla();
            }
            catch (Exception)
            {
                MessageBox.Show("Güncelleme Sırasında Hata Oluştu");
                throw;
            }
        }

        private void GeriBtn_Click(object sender, EventArgs e)
        {
            Form3 gir4 = new Form3();
            gir4.Show();
            this.Hide();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08)
            {
                e.Handled = true;
            }  
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08)
            {
                e.Handled = true;
            }  
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08)
            {
                e.Handled = true;
            }  
        }
    }
}
