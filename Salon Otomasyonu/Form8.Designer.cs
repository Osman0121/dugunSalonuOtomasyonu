namespace Salon_Otomasyonu
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.KaydetBtn = new System.Windows.Forms.Button();
            this.GeriBtn = new System.Windows.Forms.Button();
            this.cksBtn = new System.Windows.Forms.Button();
            this.SilBtn = new System.Windows.Forms.Button();
            this.GuncelleBtn = new System.Windows.Forms.Button();
            this.DuzenleBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(579, 219);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(63, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sıra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(58, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gelir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(53, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Gider";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(40, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kazanç";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 300);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            this.toolTip1.SetToolTip(this.textBox1, "Bir Sıra Belirleyiniz!");
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(103, 327);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 12;
            this.toolTip1.SetToolTip(this.textBox2, "Geliri Giriniz! Sadece Rakam Girişi Yapabilirsiniz!");
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(103, 356);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 13;
            this.toolTip1.SetToolTip(this.textBox3, "Giderleri Yazınız! Sadece Rakam Girişi YApabilirsiniz!");
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(103, 385);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 14;
            this.toolTip1.SetToolTip(this.textBox4, "Gelir ve Gider Girildikten Sonra Otomatik Gelir!");
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.KaydetBtn.Location = new System.Drawing.Point(309, 286);
            this.KaydetBtn.Name = "KaydetBtn";
            this.KaydetBtn.Size = new System.Drawing.Size(85, 62);
            this.KaydetBtn.TabIndex = 5;
            this.KaydetBtn.Text = "Kaydet";
            this.KaydetBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.KaydetBtn, "Girilen Bilgileri Kaydeder!");
            this.KaydetBtn.UseVisualStyleBackColor = false;
            this.KaydetBtn.Click += new System.EventHandler(this.KaydetBtn_Click);
            // 
            // GeriBtn
            // 
            this.GeriBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GeriBtn.BackgroundImage = global::Salon_Otomasyonu.Properties.Resources.geri;
            this.GeriBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GeriBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GeriBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.GeriBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.GeriBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GeriBtn.Location = new System.Drawing.Point(12, 1);
            this.GeriBtn.Name = "GeriBtn";
            this.GeriBtn.Size = new System.Drawing.Size(59, 54);
            this.GeriBtn.TabIndex = 10;
            this.toolTip1.SetToolTip(this.GeriBtn, "Giriş Ekranına Geri Döner !");
            this.GeriBtn.UseVisualStyleBackColor = false;
            this.GeriBtn.Click += new System.EventHandler(this.GeriBtn_Click);
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
            this.cksBtn.Location = new System.Drawing.Point(414, 423);
            this.cksBtn.Name = "cksBtn";
            this.cksBtn.Size = new System.Drawing.Size(85, 61);
            this.cksBtn.TabIndex = 9;
            this.cksBtn.Text = "Çıkış";
            this.cksBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.cksBtn, "Programı Kapatır !");
            this.cksBtn.UseVisualStyleBackColor = false;
            this.cksBtn.Click += new System.EventHandler(this.cksBtn_Click);
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
            this.SilBtn.Location = new System.Drawing.Point(414, 354);
            this.SilBtn.Name = "SilBtn";
            this.SilBtn.Size = new System.Drawing.Size(85, 63);
            this.SilBtn.TabIndex = 8;
            this.SilBtn.Text = "Sil";
            this.SilBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.SilBtn, "Seçilen Sırayı Siler!");
            this.SilBtn.UseVisualStyleBackColor = false;
            this.SilBtn.Click += new System.EventHandler(this.SilBtn_Click);
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
            this.GuncelleBtn.Location = new System.Drawing.Point(309, 354);
            this.GuncelleBtn.Name = "GuncelleBtn";
            this.GuncelleBtn.Size = new System.Drawing.Size(85, 63);
            this.GuncelleBtn.TabIndex = 7;
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
            this.DuzenleBtn.Location = new System.Drawing.Point(414, 286);
            this.DuzenleBtn.Name = "DuzenleBtn";
            this.DuzenleBtn.Size = new System.Drawing.Size(85, 62);
            this.DuzenleBtn.TabIndex = 6;
            this.DuzenleBtn.Text = "Düzenle";
            this.DuzenleBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.DuzenleBtn, "Seçilen Bİlgileri Düzenlemek İçin İlgili Alanlara Yazar!");
            this.DuzenleBtn.UseVisualStyleBackColor = false;
            this.DuzenleBtn.Click += new System.EventHandler(this.DuzenleBtn_Click);
            // 
            // Form8
            // 
            this.AcceptButton = this.KaydetBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Salon_Otomasyonu.Properties.Resources.kantin;
            this.CancelButton = this.GeriBtn;
            this.ClientSize = new System.Drawing.Size(604, 487);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.GeriBtn);
            this.Controls.Add(this.cksBtn);
            this.Controls.Add(this.SilBtn);
            this.Controls.Add(this.GuncelleBtn);
            this.Controls.Add(this.DuzenleBtn);
            this.Controls.Add(this.KaydetBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form8";
            this.Text = "Kantin Gelir-Gider Bölümü        ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form8_FormClosing);
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button KaydetBtn;
        private System.Windows.Forms.Button DuzenleBtn;
        private System.Windows.Forms.Button GuncelleBtn;
        private System.Windows.Forms.Button SilBtn;
        private System.Windows.Forms.Button cksBtn;
        private System.Windows.Forms.Button GeriBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}