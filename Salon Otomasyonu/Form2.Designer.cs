namespace Salon_Otomasyonu
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
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
            this.GeriBtn = new System.Windows.Forms.Button();
            this.cksBtn = new System.Windows.Forms.Button();
            this.kaydolBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(208, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(228, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yeni Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(177, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tekrar Yeni Şifre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(257, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(308, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            this.toolTip1.SetToolTip(this.textBox1, "Kullanıı Adı Oluşturunuz!");
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(308, 115);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            this.toolTip1.SetToolTip(this.textBox2, "Yeni Şifre Oluşturunuz, En Az 6 Karakter Olmalı!");
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(308, 144);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            this.toolTip1.SetToolTip(this.textBox3, "Yeni Şifre İle Aynı Olmalı!");
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(308, 174);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            this.toolTip1.SetToolTip(this.textBox4, "Düğün Bilgilerini Almak İçin Email Hesabınızı Giriniz!");
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "exit-icon-2.png");
            this.ımageList1.Images.SetKeyName(1, "tick.gif");
            // 
            // GeriBtn
            // 
            this.GeriBtn.BackgroundImage = global::Salon_Otomasyonu.Properties.Resources.geri;
            this.GeriBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GeriBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GeriBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.GeriBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.GeriBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GeriBtn.Location = new System.Drawing.Point(13, 6);
            this.GeriBtn.Name = "GeriBtn";
            this.GeriBtn.Size = new System.Drawing.Size(65, 59);
            this.GeriBtn.TabIndex = 11;
            this.toolTip1.SetToolTip(this.GeriBtn, "Salon Otomasyonu Sayfasını Açar!");
            this.GeriBtn.UseVisualStyleBackColor = true;
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
            this.cksBtn.ImageIndex = 0;
            this.cksBtn.ImageList = this.ımageList1;
            this.cksBtn.Location = new System.Drawing.Point(315, 221);
            this.cksBtn.Name = "cksBtn";
            this.cksBtn.Size = new System.Drawing.Size(90, 53);
            this.cksBtn.TabIndex = 10;
            this.cksBtn.Text = "Çıkış";
            this.cksBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.cksBtn, "Programı Kapatır!");
            this.cksBtn.UseVisualStyleBackColor = false;
            this.cksBtn.Click += new System.EventHandler(this.cksBtn_Click);
            // 
            // kaydolBtn
            // 
            this.kaydolBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kaydolBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kaydolBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.kaydolBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kaydolBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydolBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.kaydolBtn.ImageIndex = 1;
            this.kaydolBtn.ImageList = this.ımageList1;
            this.kaydolBtn.Location = new System.Drawing.Point(211, 221);
            this.kaydolBtn.Name = "kaydolBtn";
            this.kaydolBtn.Size = new System.Drawing.Size(90, 53);
            this.kaydolBtn.TabIndex = 9;
            this.kaydolBtn.Text = "Tamamla";
            this.kaydolBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.kaydolBtn, "Kayıt olma İşlemini Bitirir!");
            this.kaydolBtn.UseVisualStyleBackColor = false;
            this.kaydolBtn.Click += new System.EventHandler(this.kaydolBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Salon_Otomasyonu.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(13, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AcceptButton = this.kaydolBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.GeriBtn;
            this.ClientSize = new System.Drawing.Size(431, 330);
            this.Controls.Add(this.GeriBtn);
            this.Controls.Add(this.cksBtn);
            this.Controls.Add(this.kaydolBtn);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Kaydolma Bölümü       ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button kaydolBtn;
        private System.Windows.Forms.Button cksBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button GeriBtn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}