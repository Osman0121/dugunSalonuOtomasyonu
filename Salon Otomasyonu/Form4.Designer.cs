namespace Salon_Otomasyonu
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SilBtn = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.GuncelleBtn = new System.Windows.Forms.Button();
            this.DuzenleBtn = new System.Windows.Forms.Button();
            this.KaydetBtn = new System.Windows.Forms.Button();
            this.GeriBtn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cksBtn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.BulBtn = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(861, 282);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 347);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 275);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişi Bilgileri";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(117, 139);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(179, 86);
            this.textBox4.TabIndex = 9;
            this.toolTip1.SetToolTip(this.textBox4, "Adres Bilgisini Giriniz!");
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(117, 112);
            this.maskedTextBox1.Mask = "(599) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(179, 20);
            this.maskedTextBox1.TabIndex = 8;
            this.toolTip1.SetToolTip(this.maskedTextBox1, "Telefon Numarasını Başında 05 Olmadan Giriniz!");
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(117, 85);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(179, 20);
            this.textBox3.TabIndex = 7;
            this.toolTip1.SetToolTip(this.textBox3, "Tc Kimlik No Giriniz!\r\nBu Kısıma Sadece Sayı Girişine İzin Var!\r\n");
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(117, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(179, 20);
            this.textBox2.TabIndex = 6;
            this.toolTip1.SetToolTip(this.textBox2, "Müşteri Adını Ve Soyadını Yazınız! \r\nBu Kısıma Sadece Harf Girişine İzin Var!");
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 20);
            this.textBox1.TabIndex = 5;
            this.toolTip1.SetToolTip(this.textBox1, "Bir Sıra Belirleyiniz! \r\nSıra kısmına Sadece Rakam Girişi Yapabilirsiniz!");
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(64, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(53, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(10, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC Kimlik No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(27, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adı Soyadı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(77, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sıra";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(332, 348);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 178);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Düğün Bilgileri";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Kampanya 1",
            "Kampanya 2",
            "Kampanya 3",
            "Kampanya 4"});
            this.comboBox2.Location = new System.Drawing.Point(117, 151);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 15;
            this.toolTip1.SetToolTip(this.comboBox2, "Hangi Kampanya Olacağını Seçiniz!");
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(117, 124);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(121, 20);
            this.textBox7.TabIndex = 14;
            this.toolTip1.SetToolTip(this.textBox7, "Burayı Sadece Ücret ve Ödenen Ücret Girildiğinde Görebilirsiniz!\r\nBuraya Herhangi" +
        " Bir Giriş Yapılmasına İzin Yoktur!");
            this.textBox7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_KeyPress);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(117, 96);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(121, 20);
            this.textBox6.TabIndex = 13;
            this.toolTip1.SetToolTip(this.textBox6, "Ödenen Ücreti Giriniz!\r\nBu Kısıma Sadece Sayı Girişine İzin Var!");
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(117, 70);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(121, 20);
            this.textBox5.TabIndex = 12;
            this.toolTip1.SetToolTip(this.textBox5, "Ücreti Giriniz! Bu Kısıma Sadece Sayı Girişine İzin Var!");
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "10.00-13.00",
            "14.00-18.00",
            "19.00-23.00"});
            this.comboBox1.Location = new System.Drawing.Point(117, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            this.toolTip1.SetToolTip(this.comboBox1, "Düğünün Olacağı Saat Aralığını Seçiniz!");
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(115, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            this.toolTip1.SetToolTip(this.dateTimePicker1, "Düğünün Olacağı Tarihi Seçiniz!");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(12, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 16);
            this.label11.TabIndex = 5;
            this.label11.Text = "Kampanyalar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(22, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "Kalan Ücret";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(9, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Ödenen Ücret";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(68, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Ücret";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(72, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Saat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(77, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Gün";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SilBtn);
            this.groupBox3.Controls.Add(this.GuncelleBtn);
            this.groupBox3.Controls.Add(this.DuzenleBtn);
            this.groupBox3.Controls.Add(this.KaydetBtn);
            this.groupBox3.Location = new System.Drawing.Point(673, 348);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 169);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İşlemler";
            // 
            // SilBtn
            // 
            this.SilBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SilBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SilBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.SilBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SilBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SilBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SilBtn.ImageIndex = 1;
            this.SilBtn.ImageList = this.ımageList1;
            this.SilBtn.Location = new System.Drawing.Point(114, 96);
            this.SilBtn.Name = "SilBtn";
            this.SilBtn.Size = new System.Drawing.Size(80, 59);
            this.SilBtn.TabIndex = 19;
            this.SilBtn.Text = "Sil";
            this.SilBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.SilBtn, "Seçilen Satırdaki Kişiyi Veritabanından Silinir!");
            this.SilBtn.UseVisualStyleBackColor = false;
            this.SilBtn.Click += new System.EventHandler(this.SilBtn_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "ekle.jpg");
            this.ımageList1.Images.SetKeyName(1, "kişi sil1.jpg");
            this.ımageList1.Images.SetKeyName(2, "exit-icon-2.png");
            this.ımageList1.Images.SetKeyName(3, "indir (2) copy copy.PNG");
            this.ımageList1.Images.SetKeyName(4, "kişi güncelle.png");
            this.ımageList1.Images.SetKeyName(5, "xmag.png");
            // 
            // GuncelleBtn
            // 
            this.GuncelleBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GuncelleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GuncelleBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.GuncelleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuncelleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GuncelleBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuncelleBtn.ImageIndex = 3;
            this.GuncelleBtn.ImageList = this.ımageList1;
            this.GuncelleBtn.Location = new System.Drawing.Point(7, 96);
            this.GuncelleBtn.Name = "GuncelleBtn";
            this.GuncelleBtn.Size = new System.Drawing.Size(80, 59);
            this.GuncelleBtn.TabIndex = 18;
            this.GuncelleBtn.Text = "Güncelle";
            this.GuncelleBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.GuncelleBtn, "Düzenlenen Bilgileri Güncelle!");
            this.GuncelleBtn.UseVisualStyleBackColor = false;
            this.GuncelleBtn.Click += new System.EventHandler(this.GuncelleBtn_Click);
            // 
            // DuzenleBtn
            // 
            this.DuzenleBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DuzenleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DuzenleBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.DuzenleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DuzenleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DuzenleBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DuzenleBtn.ImageIndex = 4;
            this.DuzenleBtn.ImageList = this.ımageList1;
            this.DuzenleBtn.Location = new System.Drawing.Point(114, 30);
            this.DuzenleBtn.Name = "DuzenleBtn";
            this.DuzenleBtn.Size = new System.Drawing.Size(80, 56);
            this.DuzenleBtn.TabIndex = 17;
            this.DuzenleBtn.Text = "Düzenle";
            this.DuzenleBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.DuzenleBtn, "Veri Tabanındaki Bilgileri Kendi Alanlarına Yazılır!");
            this.DuzenleBtn.UseVisualStyleBackColor = false;
            this.DuzenleBtn.Click += new System.EventHandler(this.DuzenleBtn_Click);
            // 
            // KaydetBtn
            // 
            this.KaydetBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.KaydetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KaydetBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.KaydetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KaydetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KaydetBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.KaydetBtn.ImageIndex = 0;
            this.KaydetBtn.ImageList = this.ımageList1;
            this.KaydetBtn.Location = new System.Drawing.Point(7, 30);
            this.KaydetBtn.Name = "KaydetBtn";
            this.KaydetBtn.Size = new System.Drawing.Size(80, 56);
            this.KaydetBtn.TabIndex = 17;
            this.KaydetBtn.Text = "Kaydet";
            this.KaydetBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.KaydetBtn, "Girilen Bilgileri Kaydeder!\r\nBilgileri Çıkartacağınız PDF Dosyası Açılır!");
            this.KaydetBtn.UseVisualStyleBackColor = false;
            this.KaydetBtn.Click += new System.EventHandler(this.KaydetBtn_Click);
            // 
            // GeriBtn
            // 
            this.GeriBtn.BackgroundImage = global::Salon_Otomasyonu.Properties.Resources.geri;
            this.GeriBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GeriBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GeriBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.GeriBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.GeriBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GeriBtn.Location = new System.Drawing.Point(12, 2);
            this.GeriBtn.Name = "GeriBtn";
            this.GeriBtn.Size = new System.Drawing.Size(57, 50);
            this.GeriBtn.TabIndex = 21;
            this.toolTip1.SetToolTip(this.GeriBtn, "Giriş Ekranına Geri Döner!");
            this.GeriBtn.UseVisualStyleBackColor = true;
            this.GeriBtn.Click += new System.EventHandler(this.GeriBtn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(331, 534);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 16);
            this.label12.TabIndex = 6;
            this.label12.Text = "Ekstra Yapılacaklar";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(486, 532);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(186, 90);
            this.textBox8.TabIndex = 16;
            this.toolTip1.SetToolTip(this.textBox8, "Ekstra Yapılacak Olan İşlemleri Yazınız!");
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cksBtn
            // 
            this.cksBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cksBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cksBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.cksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cksBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cksBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cksBtn.ImageIndex = 2;
            this.cksBtn.ImageList = this.ımageList1;
            this.cksBtn.Location = new System.Drawing.Point(787, 541);
            this.cksBtn.Name = "cksBtn";
            this.cksBtn.Size = new System.Drawing.Size(80, 57);
            this.cksBtn.TabIndex = 20;
            this.cksBtn.Text = "Çıkış";
            this.cksBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.cksBtn, "Program Kapanır!");
            this.cksBtn.UseVisualStyleBackColor = false;
            this.cksBtn.Click += new System.EventHandler(this.cksBtn_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(174, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 16);
            this.label13.TabIndex = 22;
            this.label13.Text = "İsme Göre Ara";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(282, 19);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(116, 20);
            this.textBox9.TabIndex = 23;
            this.toolTip1.SetToolTip(this.textBox9, "Aranacak Olan İsimi Yazınız!");
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            this.textBox9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox9_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(450, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(119, 16);
            this.label14.TabIndex = 24;
            this.label14.Text = "Tarihe Göre Ara";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(571, 18);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 25;
            this.toolTip1.SetToolTip(this.dateTimePicker2, "Aranacak Tarihi Seçiniz!");
            // 
            // BulBtn
            // 
            this.BulBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BulBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BulBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BulBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BulBtn.ImageIndex = 5;
            this.BulBtn.ImageList = this.ımageList1;
            this.BulBtn.Location = new System.Drawing.Point(781, 12);
            this.BulBtn.Name = "BulBtn";
            this.BulBtn.Size = new System.Drawing.Size(71, 40);
            this.BulBtn.TabIndex = 26;
            this.BulBtn.Text = "Bul";
            this.BulBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.BulBtn, "Aranmasını İstediğiniz Tarihteki Düğünleri Bulur!");
            this.BulBtn.UseVisualStyleBackColor = false;
            this.BulBtn.Click += new System.EventHandler(this.BulBtn_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form4
            // 
            this.AcceptButton = this.KaydetBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Salon_Otomasyonu.Properties.Resources.Salon_İçi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.GeriBtn;
            this.ClientSize = new System.Drawing.Size(885, 653);
            this.Controls.Add(this.BulBtn);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.GeriBtn);
            this.Controls.Add(this.cksBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Salon Kiralama       ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button SilBtn;
        private System.Windows.Forms.Button GuncelleBtn;
        private System.Windows.Forms.Button DuzenleBtn;
        private System.Windows.Forms.Button KaydetBtn;
        private System.Windows.Forms.Button cksBtn;
        private System.Windows.Forms.Button GeriBtn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button BulBtn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}