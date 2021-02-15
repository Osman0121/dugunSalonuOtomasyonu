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
    public partial class Form4 : Form
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
                adtr = new OleDbDataAdapter("Select *from kiraListe", baglanti);
                adtr.Fill(tablo); 
                dataGridView1.DataSource = tablo;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                
            }
            catch (Exception)
            {
                MessageBox.Show("Tablo Dolduralamıyor.");

                throw;
            }
        }
        void sifirla()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            maskedTextBox1.Text = "";
            textBox4.Text = "";
            dateTimePicker1.Text = "";
            comboBox1.Text = "";
            textBox5.Text = "";           
            textBox6.Text = "";
            textBox7.Text = "";
            comboBox2.Text = "";
            textBox8.Text = "";           
        }
        public Form4()
        {
            InitializeComponent();
        }
        public bool tarihKontrol(string tar)
        {
            komut = new OleDbCommand("SELECT *from kiraListe Where tarih ='" + tar + "'", baglanti);
            baglanti.Open();
            OleDbDataReader okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())
            {
                string saat = okuyucu["saat"].ToString();
                if (saat == comboBox1.Text)
                {
                    return false;
                }
            }
            baglanti.Close();
            return true;
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            textBox3.MaxLength = 11;
            griddoldur();
            timer1.Enabled = true;
            textBox7.Enabled = false;      
        }

        private void cksBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void KaydetBtn_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            if (tarihKontrol((string)dateTimePicker1.Text))
            {
                komut = new OleDbCommand();
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "INSERT INTO kiraListe (sira,adsoyad,tc,telefon,adres,tarih,saat,ucret,odenenucret,kalanucret,kampanya,bilgi) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + maskedTextBox1.Text + "','" + textBox4.Text + "','" + dateTimePicker1.Text + "','" + comboBox1.Text + "','" + int.Parse(textBox5.Text) + "','" + textBox6.Text + "','" + textBox7.Text + "','" + comboBox2.Text + "','" + textBox8.Text + "')";
                komut.ExecuteNonQuery();
                baglanti.Close();
                griddoldur();
                MessageBox.Show("Kişi Başarıyla Kaydedildi");
                sifirla();
            }
            else
            {
                MessageBox.Show("Başka Saat Aralığı Seçiniz");
                comboBox1.Text = "";
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
                    komut.CommandText = "DELETE FROM kiraListe WHERE sira='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    griddoldur();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Silme İşlemi Başarısız.");
                throw;
            }           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = this.Text.Substring(1) + this.Text.Substring(0, 1);
        }

        private void GuncelleBtn_Click(object sender, EventArgs e)
        {
            
                komut = new OleDbCommand();
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "UPDATE kiraListe SET sira='" + textBox1.Text + "',adsoyad='" + textBox2.Text + "',tc='" + textBox3.Text + "',telefon='" + maskedTextBox1.Text + "',adres='" + textBox4.Text + "',tarih='" + dateTimePicker1.Text + "',saat='" + comboBox1.Text + "',ucret='" + int.Parse(textBox5.Text) + "',odenenucret='" + textBox6.Text + "',kalanucret='" + textBox7.Text + "',kampanya='" + comboBox2.Text + "',bilgi='" + textBox8.Text + "' where sira='" + textBox1.Text + "'";
                komut.ExecuteNonQuery();
                baglanti.Close();
                griddoldur();
                textBox1.Enabled = true;
                sifirla();
                  
        }

        private void DuzenleBtn_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
        }

        private void GeriBtn_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3();
            fr3.Show();
            this.Hide();
        }
        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)32)
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

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08)
            {
                e.Handled = true;
            }   
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08)
            {
                e.Handled = true;
            }   
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08)
            {
                e.Handled = true;
            }   
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text != "" && textBox6.Text != "")
            {
                int gelir = int.Parse(textBox5.Text);
                int gider = int.Parse(textBox6.Text);
                textBox7.Text = (gelir - gider) + "";
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text != "" && textBox6.Text != "")
            {
                int gelir = int.Parse(textBox5.Text);
                int gider = int.Parse(textBox6.Text);
                textBox7.Text = (gelir - gider) + "";
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            try
            {
                adtr = new OleDbDataAdapter("SELECT *from kiraListe Where adsoyad like '" + textBox9.Text + "%'", baglanti);
                ds = new DataSet();
                baglanti.Open();
                adtr.Fill(ds, "kiraListe");
                dataGridView1.DataSource = ds.Tables["kiraListe"];
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
                adtr = new OleDbDataAdapter("SELECT *from kiraListe Where tarih like '" + dateTimePicker2.Text + "%'", baglanti);
                ds = new DataSet();
                baglanti.Open();
                adtr.Fill(ds, "kiraListe");
                dataGridView1.DataSource = ds.Tables["kiraListe"];
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Veritabanından Okuma Başarısız.");
                throw;
            }  
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)32)
            {
                e.Handled = true;
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font baslık = new Font("Calibri", 26, FontStyle.Bold);
            Font altbaslık = new Font("Calibri", 22, FontStyle.Bold);
            Font icerik = new Font("Calibri", 18, FontStyle.Bold);
            SolidBrush osman = new SolidBrush(Color.Black);
            StringFormat kk = new StringFormat();
            kk.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("Bilgi Fişi", baslık, osman, 300, 100, kk);
            e.Graphics.DrawString("Adı Soyadı:\nTc Kimlik No:\nDüğün Tarihi:\nSaat:\nKampanya:\nEkstra:\nÜcret:\nÖdenen Ücret:\nKalan Ücret:\n\n\n\n\nMüşteri İmza                  Müdür İmza", altbaslık, osman, 150, 250, kk);
            for (int i = 0; i < 1; i++)
            {
                e.Graphics.DrawString(textBox2.Text, icerik, osman, 350, 250, kk);
                e.Graphics.DrawString(textBox3.Text, icerik, osman, 350, 287, kk);
                e.Graphics.DrawString(dateTimePicker1.Text, icerik, osman, 350, 324, kk);
                e.Graphics.DrawString(comboBox1.Text, icerik, osman, 350, 361, kk);
                e.Graphics.DrawString(comboBox2.Text, icerik, osman, 350, 408, kk);
                e.Graphics.DrawString(textBox8.Text, icerik, osman, 350, 445, kk);
                e.Graphics.DrawString(textBox5.Text, icerik, osman, 350, 482, kk);
                e.Graphics.DrawString(textBox6.Text, icerik, osman, 350, 519, kk);
                e.Graphics.DrawString(textBox7.Text, icerik, osman, 350, 556, kk);
            }
        }
    }
}
