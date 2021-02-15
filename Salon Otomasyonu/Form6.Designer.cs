namespace Salon_Otomasyonu
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SilBtn = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.GuncelleBtn = new System.Windows.Forms.Button();
            this.DuzenleBtn = new System.Windows.Forms.Button();
            this.KaydetBtn = new System.Windows.Forms.Button();
            this.GeriBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cksBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.BulBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(974, 266);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 350);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 233);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişi Bilgileri";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(124, 201);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 17;
            this.toolTip1.SetToolTip(this.dateTimePicker2, "Teslim Tarihini Seçiniz!");
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(124, 178);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 16;
            this.toolTip1.SetToolTip(this.textBox5, "Ücret ve Ödenen Ücretler Girilince Otomatik Değer Gelir!");
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(124, 154);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 15;
            this.toolTip1.SetToolTip(this.textBox4, "Ödenen Ücreti Giriniz! Sadece Rakam Girişi Yapmaya İzin Var!");
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(124, 131);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 14;
            this.toolTip1.SetToolTip(this.textBox3, "Ücreti Giriniz! Sadece Rakam Girişi Yapabilirsiniz!");
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(124, 107);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 13;
            this.toolTip1.SetToolTip(this.comboBox1, "Düğünün Olacağı Saati Seçiniz!");
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(124, 84);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 12;
            this.toolTip1.SetToolTip(this.dateTimePicker1, "Düğünün Olduğu Günü Seçiniz!");
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(124, 61);
            this.maskedTextBox1.Mask = "(599) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(124, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 10;
            this.toolTip1.SetToolTip(this.textBox2, "Müşterinin Adını Soyadını Giriniz!\r\nSadece Harf Girişi Yapabilirsiniz!");
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            this.toolTip1.SetToolTip(this.textBox1, "Bir Sıra Belirleyiniz!\r\nSadece Rakam Girişi Yapabilirsiniz!");
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(18, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Teslim Tarihi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(27, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Kalan Ücret";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(14, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ödenen Ücret";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(73, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ücret";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(77, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Saat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(82, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gün";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(57, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(31, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adı Soyadı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(81, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sıra";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SilBtn);
            this.groupBox2.Controls.Add(this.GuncelleBtn);
            this.groupBox2.Controls.Add(this.DuzenleBtn);
            this.groupBox2.Controls.Add(this.KaydetBtn);
            this.groupBox2.Location = new System.Drawing.Point(412, 350);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 162);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // SilBtn
            // 
            this.SilBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SilBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SilBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.SilBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SilBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SilBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SilBtn.ImageIndex = 4;
            this.SilBtn.ImageList = this.ımageList1;
            this.SilBtn.Location = new System.Drawing.Point(116, 83);
            this.SilBtn.Name = "SilBtn";
            this.SilBtn.Size = new System.Drawing.Size(81, 60);
            this.SilBtn.TabIndex = 3;
            this.SilBtn.Text = "Sil";
            this.SilBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.SilBtn, "Seçilen Kişinin Bilgilerini Siler!");
            this.SilBtn.UseVisualStyleBackColor = false;
            this.SilBtn.Click += new System.EventHandler(this.SilBtn_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "ekle.jpg");
            this.ımageList1.Images.SetKeyName(1, "exit-icon-2.png");
            this.ımageList1.Images.SetKeyName(2, "indir (2) copy copy.PNG");
            this.ımageList1.Images.SetKeyName(3, "kişi güncelle.png");
            this.ımageList1.Images.SetKeyName(4, "kişi sil1.jpg");
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
            this.GuncelleBtn.ImageIndex = 2;
            this.GuncelleBtn.ImageList = this.ımageList1;
            this.GuncelleBtn.Location = new System.Drawing.Point(16, 83);
            this.GuncelleBtn.Name = "GuncelleBtn";
            this.GuncelleBtn.Size = new System.Drawing.Size(81, 60);
            this.GuncelleBtn.TabIndex = 2;
            this.GuncelleBtn.Text = "Güncelle";
            this.GuncelleBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.GuncelleBtn, "Düzenlenen Bilgileri Günceller!");
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
            this.DuzenleBtn.ImageIndex = 3;
            this.DuzenleBtn.ImageList = this.ımageList1;
            this.DuzenleBtn.Location = new System.Drawing.Point(116, 20);
            this.DuzenleBtn.Name = "DuzenleBtn";
            this.DuzenleBtn.Size = new System.Drawing.Size(81, 60);
            this.DuzenleBtn.TabIndex = 1;
            this.DuzenleBtn.Text = "Düzenle";
            this.DuzenleBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.DuzenleBtn, "Bilgileri Çeker ve İlgili Alanlar Yazar!");
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
            this.KaydetBtn.Location = new System.Drawing.Point(16, 20);
            this.KaydetBtn.Name = "KaydetBtn";
            this.KaydetBtn.Size = new System.Drawing.Size(81, 60);
            this.KaydetBtn.TabIndex = 0;
            this.KaydetBtn.Text = "Kaydet";
            this.KaydetBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.KaydetBtn, "Bütün Bilgileri Kaydeder!");
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
            this.GeriBtn.Location = new System.Drawing.Point(12, 8);
            this.GeriBtn.Name = "GeriBtn";
            this.GeriBtn.Size = new System.Drawing.Size(51, 44);
            this.GeriBtn.TabIndex = 4;
            this.toolTip1.SetToolTip(this.GeriBtn, "Giriş Ekranına Geri Döner !");
            this.GeriBtn.UseVisualStyleBackColor = true;
            this.GeriBtn.Click += new System.EventHandler(this.GeriBtn_Click);
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
            this.cksBtn.ImageIndex = 1;
            this.cksBtn.ImageList = this.ımageList1;
            this.cksBtn.Location = new System.Drawing.Point(528, 527);
            this.cksBtn.Name = "cksBtn";
            this.cksBtn.Size = new System.Drawing.Size(81, 56);
            this.cksBtn.TabIndex = 4;
            this.cksBtn.Text = "Çıkış";
            this.cksBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.cksBtn, "Programı Kapatır!");
            this.cksBtn.UseVisualStyleBackColor = false;
            this.cksBtn.Click += new System.EventHandler(this.cksBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(109, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "İsme Göre Ara";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(369, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 16);
            this.label11.TabIndex = 6;
            this.label11.Text = "Tarihe Göre Ara";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(218, 25);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 7;
            this.toolTip1.SetToolTip(this.textBox6, "Yazılan İsmi Arar!");
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(491, 22);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker3.TabIndex = 8;
            this.toolTip1.SetToolTip(this.dateTimePicker3, "Aranmasını İstediğiniz Tarihi Seçiniz!");
            // 
            // BulBtn
            // 
            this.BulBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BulBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BulBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.BulBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BulBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BulBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BulBtn.ImageIndex = 5;
            this.BulBtn.ImageList = this.ımageList1;
            this.BulBtn.Location = new System.Drawing.Point(715, 8);
            this.BulBtn.Name = "BulBtn";
            this.BulBtn.Size = new System.Drawing.Size(65, 44);
            this.BulBtn.TabIndex = 9;
            this.BulBtn.Text = "Bul";
            this.BulBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.BulBtn, "Aranmasını İstediğiniz Tarihteki Düğünleri Sıralar!");
            this.BulBtn.UseVisualStyleBackColor = false;
            this.BulBtn.Click += new System.EventHandler(this.BulBtn_Click);
            // 
            // Form6
            // 
            this.AcceptButton = this.KaydetBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Salon_Otomasyonu.Properties.Resources.foto;
            this.CancelButton = this.GeriBtn;
            this.ClientSize = new System.Drawing.Size(999, 606);
            this.Controls.Add(this.BulBtn);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.GeriBtn);
            this.Controls.Add(this.cksBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form6";
            this.Text = "Fotoğrafçı Müşteri Bölümü       ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form6_FormClosing);
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SilBtn;
        private System.Windows.Forms.Button GuncelleBtn;
        private System.Windows.Forms.Button DuzenleBtn;
        private System.Windows.Forms.Button KaydetBtn;
        private System.Windows.Forms.Button cksBtn;
        private System.Windows.Forms.Button GeriBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Button BulBtn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}