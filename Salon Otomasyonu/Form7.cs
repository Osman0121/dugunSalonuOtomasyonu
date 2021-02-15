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
    public partial class Form7 : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\sistem.mdb");
        OleDbDataAdapter adtr;
        OleDbCommand komut;
        DataSet ds;
        DataTable tablo;
        void griddoldur()
        {
            try
            {
                tablo = new DataTable();
                tablo.Clear();
                adtr = new OleDbDataAdapter("Select *from modaevi", baglanti);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            }
            catch (Exception)
            {
                MessageBox.Show("Tablo Doldurulurken Hata İle Karşılaşıldı");
                throw;
            }

        }
        void sifirla()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            maskedTextBox1.Text = "";
            dateTimePicker1.Text = "";
            comboBox1.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";   
        }
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            griddoldur();
            textBox5.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = this.Text.Substring(1) + this.Text.Substring(0, 1);
        }

        private void DuzenleBtn_Click(object sender, EventArgs e)
        {

            textBox1.Enabled = false;
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            
        }

        private void KaydetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                komut = new OleDbCommand();
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "INSERT INTO modaevi (sira,gelinadsoyad,telefon,ucret,odenenucret,kalanucret,tarih,saat) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + maskedTextBox1.Text + "','" + int.Parse(textBox3.Text) + "','" + textBox4.Text + "','" + textBox5.Text + "','" + dateTimePicker1.Text + "','" + comboBox1.Text + "')";
                komut.ExecuteNonQuery();
                baglanti.Close();
                griddoldur();
                MessageBox.Show("Kişi Başarıyla Kaydedildi");
                sifirla();
            }
            catch (Exception)
            {
                MessageBox.Show("Kişi Kaydedilirken Hata İle Karşılaşıldı");

                throw;
            }
        }

        private void GuncelleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                komut = new OleDbCommand();
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "UPDATE modaevi SET sira='" + textBox1.Text + "',gelinadsoyad='" + textBox2.Text + "',telefon='" + maskedTextBox1.Text + "',tarih='" + dateTimePicker1.Text + "',saat='" + comboBox1.Text + "',ucret='" +int.Parse(textBox3.Text) + "',odenenucret='" + textBox4.Text + "',kalanucret='" + textBox5.Text + "'  where sira='" + textBox1.Text + "'";
                komut.ExecuteNonQuery();
                baglanti.Close();
                griddoldur();
                sifirla();

            }
            catch (Exception)
            {
                MessageBox.Show("Günceleme İşleminde Hata Oluştu");
                throw;
            }
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
                    komut.CommandText = "DELETE FROM modaevi WHERE sira='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    griddoldur();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Silme İşleminde Hata Oluştu");
                throw;
            }
        }

        private void cksBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void GeriBtn_Click(object sender, EventArgs e)
        {
            Form3 gir3 = new Form3();
            gir3.Show();
            this.Hide();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                adtr = new OleDbDataAdapter("SELECT *from modaevi Where gelinadsoyad like '" + textBox6.Text + "%'", baglanti);
                ds = new DataSet();
                baglanti.Open();
                adtr.Fill(ds, "modaevi");
                dataGridView1.DataSource = ds.Tables["modaevi"];
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Veritabanından Okuma Başarısız.");
                throw;
            }  
        }

        private void BulBtn_Click(object sender, EventArgs e)
        {
            try
            {
                adtr = new OleDbDataAdapter("SELECT *from modaevi Where tarih like '" + dateTimePicker2.Text + "%'", baglanti);
                ds = new DataSet();
                baglanti.Open();
                adtr.Fill(ds, "modaevi");
                dataGridView1.DataSource = ds.Tables["moadevi"];
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Veritabanından Okuma Başarısız.");
                throw;
            }  
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "" && textBox4.Text != "")
            {
                int gelir = int.Parse(textBox3.Text);
                int gider = int.Parse(textBox4.Text);
                textBox5.Text = (gelir - gider) + "";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "" && textBox4.Text != "")
            {
                int gelir = int.Parse(textBox3.Text);
                int gider = int.Parse(textBox4.Text);
                textBox5.Text = (gelir - gider) + "";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08)
            {
                e.Handled = true;
            }  
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08)
            {
                e.Handled = true;
            }  
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)32)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)32)
            {
                e.Handled = true;
            }
        }
    }
}
