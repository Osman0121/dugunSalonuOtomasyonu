namespace Salon_Otomasyonu
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cksBtn = new System.Windows.Forms.Button();
            this.KaydolBtn = new System.Windows.Forms.Button();
            this.GrsBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(178, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(228, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(269, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.toolTip1.SetToolTip(this.textBox1, "Kullanıcı Adınızı Giriniz!");
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(269, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            this.toolTip1.SetToolTip(this.textBox2, "Şifrenizi Giriniz!");
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
            this.ımageList1.Images.SetKeyName(1, "images.png");
            this.ımageList1.Images.SetKeyName(2, "üye-girişi.png");
            // 
            // cksBtn
            // 
            this.cksBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cksBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cksBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cksBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.cksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cksBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cksBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cksBtn.ImageIndex = 0;
            this.cksBtn.ImageList = this.ımageList1;
            this.cksBtn.Location = new System.Drawing.Point(271, 206);
            this.cksBtn.Name = "cksBtn";
            this.cksBtn.Size = new System.Drawing.Size(93, 59);
            this.cksBtn.TabIndex = 7;
            this.cksBtn.Text = "Çıkış";
            this.cksBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.cksBtn, "Programı Kapatır!");
            this.cksBtn.UseVisualStyleBackColor = false;
            this.cksBtn.Click += new System.EventHandler(this.cksBtn_Click);
            // 
            // KaydolBtn
            // 
            this.KaydolBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.KaydolBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KaydolBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.KaydolBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KaydolBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KaydolBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.KaydolBtn.ImageIndex = 1;
            this.KaydolBtn.ImageList = this.ımageList1;
            this.KaydolBtn.Location = new System.Drawing.Point(165, 206);
            this.KaydolBtn.Name = "KaydolBtn";
            this.KaydolBtn.Size = new System.Drawing.Size(93, 59);
            this.KaydolBtn.TabIndex = 6;
            this.KaydolBtn.Text = "Kaydol";
            this.KaydolBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.KaydolBtn, "Kaydolma Bölümünü Açar!");
            this.KaydolBtn.UseVisualStyleBackColor = false;
            this.KaydolBtn.Click += new System.EventHandler(this.KaydolBtn_Click);
            // 
            // GrsBtn
            // 
            this.GrsBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GrsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GrsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.GrsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GrsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GrsBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GrsBtn.ImageIndex = 2;
            this.GrsBtn.ImageList = this.ımageList1;
            this.GrsBtn.Location = new System.Drawing.Point(270, 95);
            this.GrsBtn.Name = "GrsBtn";
            this.GrsBtn.Size = new System.Drawing.Size(95, 62);
            this.GrsBtn.TabIndex = 5;
            this.GrsBtn.Text = "Giriş";
            this.GrsBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.GrsBtn, "Giriş Ekranını Açar!");
            this.GrsBtn.UseVisualStyleBackColor = false;
            this.GrsBtn.Click += new System.EventHandler(this.GrsBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Salon_Otomasyonu.Properties.Resources.Kilit;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.GrsBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cksBtn;
            this.ClientSize = new System.Drawing.Size(383, 278);
            this.Controls.Add(this.cksBtn);
            this.Controls.Add(this.KaydolBtn);
            this.Controls.Add(this.GrsBtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Salon Otomasyonu     ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button GrsBtn;
        private System.Windows.Forms.Button KaydolBtn;
        private System.Windows.Forms.Button cksBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

