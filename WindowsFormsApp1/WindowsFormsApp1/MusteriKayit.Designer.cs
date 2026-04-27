namespace WindowsFormsApp1
{
    partial class MusteriKayit
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
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.dtpGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtOdaNo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbOdaTipi = new System.Windows.Forms.ComboBox();
            this.btnOdaBul = new System.Windows.Forms.Button();
            this.lblOdaFiyati = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            System.Windows.Forms.Label lblHeader = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblGirisTarihBaslik = new System.Windows.Forms.Label();
            System.Windows.Forms.Panel pnlSeparator = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            lblHeader.ForeColor = System.Drawing.Color.White;
            lblHeader.Location = new System.Drawing.Point(40, 25);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new System.Drawing.Size(262, 37);
            lblHeader.TabIndex = 15;
            lblHeader.Text = "YENİ MÜŞTERİ KAYDI";
            // 
            // pnlSeparator
            // 
            pnlSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            pnlSeparator.Location = new System.Drawing.Point(47, 70);
            pnlSeparator.Name = "pnlSeparator";
            pnlSeparator.Size = new System.Drawing.Size(700, 2);
            pnlSeparator.TabIndex = 16;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.txtAdSoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdSoyad.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtAdSoyad.ForeColor = System.Drawing.Color.White;
            this.txtAdSoyad.Location = new System.Drawing.Point(60, 128);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(300, 27);
            this.txtAdSoyad.TabIndex = 0;
            // 
            // dtpGirisTarihi
            // 
            this.dtpGirisTarihi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpGirisTarihi.Location = new System.Drawing.Point(420, 268);
            this.dtpGirisTarihi.Name = "dtpGirisTarihi";
            this.dtpGirisTarihi.Size = new System.Drawing.Size(300, 25);
            this.dtpGirisTarihi.TabIndex = 2;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(60, 360);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(660, 50);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "MÜŞTERİ KAYDINI TAMAMLA";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtOdaNo
            // 
            this.txtOdaNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.txtOdaNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOdaNo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtOdaNo.ForeColor = System.Drawing.Color.White;
            this.txtOdaNo.Location = new System.Drawing.Point(420, 128);
            this.txtOdaNo.Name = "txtOdaNo";
            this.txtOdaNo.Size = new System.Drawing.Size(150, 27);
            this.txtOdaNo.TabIndex = 4;
            this.txtOdaNo.TextChanged += new System.EventHandler(this.txtOdaNo_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(680, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "← GERİ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(60, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "AD SOYAD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(420, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "ODA NUMARASI";
            // 
            // cmbOdaTipi
            // 
            this.cmbOdaTipi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.cmbOdaTipi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbOdaTipi.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbOdaTipi.ForeColor = System.Drawing.Color.White;
            this.cmbOdaTipi.FormattingEnabled = true;
            this.cmbOdaTipi.Items.AddRange(new object[] {
            "Tek",
            "Suit",
            "Kral Dairesi"});
            this.cmbOdaTipi.Location = new System.Drawing.Point(420, 198);
            this.cmbOdaTipi.Name = "cmbOdaTipi";
            this.cmbOdaTipi.Size = new System.Drawing.Size(300, 28);
            this.cmbOdaTipi.TabIndex = 8;
            // 
            // btnOdaBul
            // 
            this.btnOdaBul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.btnOdaBul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdaBul.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnOdaBul.ForeColor = System.Drawing.Color.White;
            this.btnOdaBul.Location = new System.Drawing.Point(580, 128);
            this.btnOdaBul.Name = "btnOdaBul";
            this.btnOdaBul.Size = new System.Drawing.Size(140, 27);
            this.btnOdaBul.TabIndex = 9;
            this.btnOdaBul.Text = "BOŞ ODA ARA";
            this.btnOdaBul.UseVisualStyleBackColor = false;
            this.btnOdaBul.Click += new System.EventHandler(this.btnOdaBul_Click);
            // 
            // lblOdaFiyati
            // 
            this.lblOdaFiyati.AutoSize = true;
            this.lblOdaFiyati.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblOdaFiyati.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblOdaFiyati.Location = new System.Drawing.Point(420, 315);
            this.lblOdaFiyati.Name = "lblOdaFiyati";
            this.lblOdaFiyati.Size = new System.Drawing.Size(126, 25);
            this.lblOdaFiyati.TabIndex = 10;
            this.lblOdaFiyati.Text = "Fiyat: 0.00 TL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(60, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "T.C. KİMLİK NO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(60, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "TELEFON";
            // 
            // txtTC
            // 
            this.txtTC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.txtTC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTC.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTC.ForeColor = System.Drawing.Color.White;
            this.txtTC.Location = new System.Drawing.Point(60, 198);
            this.txtTC.MaxLength = 11;
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(300, 27);
            this.txtTC.TabIndex = 13;
            // 
            // txtTelefon
            // 
            this.txtTelefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.txtTelefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefon.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTelefon.ForeColor = System.Drawing.Color.White;
            this.txtTelefon.Location = new System.Drawing.Point(60, 268);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(300, 27);
            this.txtTelefon.TabIndex = 14;
            // 
            // lblGirisTarihBaslik
            // 
            lblGirisTarihBaslik.AutoSize = true;
            lblGirisTarihBaslik.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            lblGirisTarihBaslik.ForeColor = System.Drawing.Color.LightGray;
            lblGirisTarihBaslik.Location = new System.Drawing.Point(420, 245);
            lblGirisTarihBaslik.Name = "lblGirisTarihBaslik";
            lblGirisTarihBaslik.Size = new System.Drawing.Size(86, 19);
            lblGirisTarihBaslik.TabIndex = 17;
            lblGirisTarihBaslik.Text = "GİRİŞ TARİHİ";
            // 
            // MusteriKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(lblGirisTarihBaslik);
            this.Controls.Add(pnlSeparator);
            this.Controls.Add(lblHeader);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblOdaFiyati);
            this.Controls.Add(this.btnOdaBul);
            this.Controls.Add(this.cmbOdaTipi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtOdaNo);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dtpGirisTarihi);
            this.Controls.Add(this.txtAdSoyad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MusteriKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otel Otomasyonu | Müşteri Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.DateTimePicker dtpGirisTarihi;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtOdaNo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbOdaTipi;
        private System.Windows.Forms.Button btnOdaBul;
        private System.Windows.Forms.Label lblOdaFiyati;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.TextBox txtTelefon;
    }
}