namespace Salon_Otomasyonu
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SalonBtn = new System.Windows.Forms.Button();
            this.FotoBtn = new System.Windows.Forms.Button();
            this.ModaeviBtn = new System.Windows.Forms.Button();
            this.KantinBtn = new System.Windows.Forms.Button();
            this.KuaforBtn = new System.Windows.Forms.Button();
            this.cksBtn = new System.Windows.Forms.Button();
            this.GitBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Salon Rapor",
            "Fotoğrafçı Rapor",
            "Moda Evi Rapor",
            "Kantin Rapor",
            "Kuaför Rapor"});
            this.comboBox1.Location = new System.Drawing.Point(481, 240);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(480, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Raporlama";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "exit-icon-2.png");
            this.ımageList1.Images.SetKeyName(1, "foto ikon.PNG");
            this.ımageList1.Images.SetKeyName(2, "Kantin İkon.PNG");
            this.ımageList1.Images.SetKeyName(3, "kiralama ikon.PNG");
            this.ımageList1.Images.SetKeyName(4, "kuaför ikon.png");
            this.ımageList1.Images.SetKeyName(5, "moda evi ikonu .PNG");
            this.ımageList1.Images.SetKeyName(6, "rapor ikon.PNG");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SalonBtn);
            this.groupBox1.Controls.Add(this.FotoBtn);
            this.groupBox1.Controls.Add(this.ModaeviBtn);
            this.groupBox1.Controls.Add(this.KantinBtn);
            this.groupBox1.Controls.Add(this.KuaforBtn);
            this.groupBox1.Location = new System.Drawing.Point(30, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 74);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bölümler";
            // 
            // SalonBtn
            // 
            this.SalonBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SalonBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SalonBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SalonBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.SalonBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalonBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SalonBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SalonBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SalonBtn.ImageIndex = 3;
            this.SalonBtn.ImageList = this.ımageList1;
            this.SalonBtn.Location = new System.Drawing.Point(6, 13);
            this.SalonBtn.Name = "SalonBtn";
            this.SalonBtn.Size = new System.Drawing.Size(85, 55);
            this.SalonBtn.TabIndex = 0;
            this.SalonBtn.Text = "Salon";
            this.SalonBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.SalonBtn, "Salon Kiralama Bölümünü Açar!");
            this.SalonBtn.UseVisualStyleBackColor = false;
            this.SalonBtn.Click += new System.EventHandler(this.SalonBtn_Click);
            // 
            // FotoBtn
            // 
            this.FotoBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FotoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FotoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FotoBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.FotoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FotoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FotoBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FotoBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.FotoBtn.ImageIndex = 1;
            this.FotoBtn.ImageList = this.ımageList1;
            this.FotoBtn.Location = new System.Drawing.Point(97, 13);
            this.FotoBtn.Name = "FotoBtn";
            this.FotoBtn.Size = new System.Drawing.Size(85, 55);
            this.FotoBtn.TabIndex = 1;
            this.FotoBtn.Text = "Foto";
            this.FotoBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.FotoBtn, "Fotoğrafçı Müşteri Bölümünü Açar!");
            this.FotoBtn.UseVisualStyleBackColor = false;
            this.FotoBtn.Click += new System.EventHandler(this.FotoBtn_Click);
            // 
            // ModaeviBtn
            // 
            this.ModaeviBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ModaeviBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ModaeviBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ModaeviBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.ModaeviBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModaeviBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ModaeviBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ModaeviBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ModaeviBtn.ImageIndex = 5;
            this.ModaeviBtn.ImageList = this.ımageList1;
            this.ModaeviBtn.Location = new System.Drawing.Point(188, 13);
            this.ModaeviBtn.Name = "ModaeviBtn";
            this.ModaeviBtn.Size = new System.Drawing.Size(85, 55);
            this.ModaeviBtn.TabIndex = 2;
            this.ModaeviBtn.Text = "Moda Evi";
            this.ModaeviBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.ModaeviBtn, "Moda Evi Müşteri Bölümünü Açar!");
            this.ModaeviBtn.UseVisualStyleBackColor = false;
            this.ModaeviBtn.Click += new System.EventHandler(this.ModaeviBtn_Click);
            // 
            // KantinBtn
            // 
            this.KantinBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.KantinBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.KantinBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KantinBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.KantinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KantinBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KantinBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.KantinBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.KantinBtn.ImageIndex = 2;
            this.KantinBtn.ImageList = this.ımageList1;
            this.KantinBtn.Location = new System.Drawing.Point(279, 13);
            this.KantinBtn.Name = "KantinBtn";
            this.KantinBtn.Size = new System.Drawing.Size(85, 55);
            this.KantinBtn.TabIndex = 3;
            this.KantinBtn.Text = "Kantin";
            this.KantinBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.KantinBtn, "Kantin Gelir-Gider Bölümünü Açar!");
            this.KantinBtn.UseVisualStyleBackColor = false;
            this.KantinBtn.Click += new System.EventHandler(this.KantinBtn_Click);
            // 
            // KuaforBtn
            // 
            this.KuaforBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.KuaforBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.KuaforBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KuaforBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.KuaforBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KuaforBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KuaforBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.KuaforBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.KuaforBtn.ImageIndex = 4;
            this.KuaforBtn.ImageList = this.ımageList1;
            this.KuaforBtn.Location = new System.Drawing.Point(370, 13);
            this.KuaforBtn.Name = "KuaforBtn";
            this.KuaforBtn.Size = new System.Drawing.Size(85, 55);
            this.KuaforBtn.TabIndex = 4;
            this.KuaforBtn.Text = "Kuaför";
            this.KuaforBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.KuaforBtn, "Kuaför Müşteri Bölümünü Açar!");
            this.KuaforBtn.UseVisualStyleBackColor = false;
            this.KuaforBtn.Click += new System.EventHandler(this.KuaforBtn_Click);
            // 
            // cksBtn
            // 
            this.cksBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cksBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cksBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cksBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cksBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.cksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cksBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cksBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cksBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cksBtn.ImageIndex = 0;
            this.cksBtn.ImageList = this.ımageList1;
            this.cksBtn.Location = new System.Drawing.Point(650, 336);
            this.cksBtn.Name = "cksBtn";
            this.cksBtn.Size = new System.Drawing.Size(85, 55);
            this.cksBtn.TabIndex = 2;
            this.cksBtn.Text = "Çıkış";
            this.cksBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.cksBtn, "Programı Kapatır!");
            this.cksBtn.UseVisualStyleBackColor = false;
            this.cksBtn.Click += new System.EventHandler(this.cksBtn_Click);
            // 
            // GitBtn
            // 
            this.GitBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.GitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GitBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GitBtn.ImageIndex = 6;
            this.GitBtn.ImageList = this.ımageList1;
            this.GitBtn.Location = new System.Drawing.Point(618, 218);
            this.GitBtn.Name = "GitBtn";
            this.GitBtn.Size = new System.Drawing.Size(77, 64);
            this.GitBtn.TabIndex = 7;
            this.GitBtn.Text = "Git";
            this.GitBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.GitBtn, "Raporlama Kısmında Seçili Olan Raporlama Bölümünü Açar!");
            this.GitBtn.UseVisualStyleBackColor = false;
            this.GitBtn.Click += new System.EventHandler(this.GitBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Salon_Otomasyonu.Properties.Resources.Ebru_Balo_Salonu;
            this.pictureBox2.Location = new System.Drawing.Point(471, 111);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(249, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Salon_Otomasyonu.Properties.Resources.Salon_Reklam;
            this.pictureBox1.Location = new System.Drawing.Point(30, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(422, 299);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cksBtn;
            this.ClientSize = new System.Drawing.Size(748, 429);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GitBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cksBtn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.Text = "Giriş Ekranı       ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button KuaforBtn;
        private System.Windows.Forms.Button KantinBtn;
        private System.Windows.Forms.Button ModaeviBtn;
        private System.Windows.Forms.Button FotoBtn;
        private System.Windows.Forms.Button SalonBtn;
        private System.Windows.Forms.Button cksBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button GitBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}