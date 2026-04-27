namespace WindowsFormsApp1
{
    partial class anasayfaform1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblKullaniciIsmi; // Yeni eklendi

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.btn_giris = new System.Windows.Forms.Button();
            this.btnMusteriCikisForm = new System.Windows.Forms.Button();
            this.btnArsivGit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblKasaTutar = new System.Windows.Forms.Label();
            this.lblDolulukOrani = new System.Windows.Forms.Label();
            this.lblBosOda = new System.Windows.Forms.Label();
            this.lblDoluOda = new System.Windows.Forms.Label();
            this.lblToplamOda = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblKullaniciIsmi = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(220, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(556, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "🏨 DETAYLI ODA DURUMU";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_giris
            // 
            this.btn_giris.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_giris.FlatAppearance.BorderSize = 0;
            this.btn_giris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_giris.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_giris.ForeColor = System.Drawing.Color.White;
            this.btn_giris.Location = new System.Drawing.Point(220, 50);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(270, 55);
            this.btn_giris.TabIndex = 5;
            this.btn_giris.Text = "➕ YENİ MÜŞTERİ GİRİŞİ";
            this.btn_giris.UseVisualStyleBackColor = false;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // btnMusteriCikisForm
            // 
            this.btnMusteriCikisForm.BackColor = System.Drawing.Color.IndianRed;
            this.btnMusteriCikisForm.FlatAppearance.BorderSize = 0;
            this.btnMusteriCikisForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteriCikisForm.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMusteriCikisForm.ForeColor = System.Drawing.Color.White;
            this.btnMusteriCikisForm.Location = new System.Drawing.Point(506, 50);
            this.btnMusteriCikisForm.Name = "btnMusteriCikisForm";
            this.btnMusteriCikisForm.Size = new System.Drawing.Size(270, 55);
            this.btnMusteriCikisForm.TabIndex = 4;
            this.btnMusteriCikisForm.Text = "➖ MÜŞTERİ ÇIKIŞI VER";
            this.btnMusteriCikisForm.UseVisualStyleBackColor = false;
            this.btnMusteriCikisForm.Click += new System.EventHandler(this.btnMusteriCikisForm_Click);
            // 
            // btnArsivGit
            // 
            this.btnArsivGit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.btnArsivGit.FlatAppearance.BorderSize = 0;
            this.btnArsivGit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArsivGit.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnArsivGit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnArsivGit.Location = new System.Drawing.Point(16, 116);
            this.btnArsivGit.Name = "btnArsivGit";
            this.btnArsivGit.Size = new System.Drawing.Size(180, 45);
            this.btnArsivGit.TabIndex = 3;
            this.btnArsivGit.Text = "📋 Müşteri Arşivi";
            this.btnArsivGit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArsivGit.UseVisualStyleBackColor = false;
            this.btnArsivGit.Click += new System.EventHandler(this.btnArsivGit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblKasaTutar);
            this.groupBox1.Controls.Add(this.lblDolulukOrani);
            this.groupBox1.Controls.Add(this.lblBosOda);
            this.groupBox1.Controls.Add(this.lblDoluOda);
            this.groupBox1.Controls.Add(this.lblToplamOda);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.groupBox1.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox1.Location = new System.Drawing.Point(526, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 160);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "📊 Günlük Özet";
            // 
            // lblKasaTutar
            // 
            this.lblKasaTutar.AutoSize = true;
            this.lblKasaTutar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblKasaTutar.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lblKasaTutar.Location = new System.Drawing.Point(15, 120);
            this.lblKasaTutar.Name = "lblKasaTutar";
            this.lblKasaTutar.Size = new System.Drawing.Size(79, 21);
            this.lblKasaTutar.TabIndex = 0;
            this.lblKasaTutar.Text = "Ciro: 0 TL";
            // 
            // lblDolulukOrani
            // 
            this.lblDolulukOrani.AutoSize = true;
            this.lblDolulukOrani.Location = new System.Drawing.Point(15, 90);
            this.lblDolulukOrani.Name = "lblDolulukOrani";
            this.lblDolulukOrani.Size = new System.Drawing.Size(90, 17);
            this.lblDolulukOrani.TabIndex = 1;
            this.lblDolulukOrani.Text = "Doluluk Oranı:";
            // 
            // lblBosOda
            // 
            this.lblBosOda.AutoSize = true;
            this.lblBosOda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(118)))));
            this.lblBosOda.Location = new System.Drawing.Point(130, 60);
            this.lblBosOda.Name = "lblBosOda";
            this.lblBosOda.Size = new System.Drawing.Size(61, 17);
            this.lblBosOda.TabIndex = 2;
            this.lblBosOda.Text = "Boş Oda:";
            // 
            // lblDoluOda
            // 
            this.lblDoluOda.AutoSize = true;
            this.lblDoluOda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.lblDoluOda.Location = new System.Drawing.Point(15, 60);
            this.lblDoluOda.Name = "lblDoluOda";
            this.lblDoluOda.Size = new System.Drawing.Size(67, 17);
            this.lblDoluOda.TabIndex = 3;
            this.lblDoluOda.Text = "Dolu Oda:";
            // 
            // lblToplamOda
            // 
            this.lblToplamOda.AutoSize = true;
            this.lblToplamOda.Location = new System.Drawing.Point(15, 30);
            this.lblToplamOda.Name = "lblToplamOda";
            this.lblToplamOda.Size = new System.Drawing.Size(83, 17);
            this.lblToplamOda.TabIndex = 4;
            this.lblToplamOda.Text = "Toplam Oda:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(16, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "👤 Personeller";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblKullaniciIsmi
            // 
            this.lblKullaniciIsmi.AutoSize = true;
            this.lblKullaniciIsmi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblKullaniciIsmi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblKullaniciIsmi.Location = new System.Drawing.Point(12, 15);
            this.lblKullaniciIsmi.Name = "lblKullaniciIsmi";
            this.lblKullaniciIsmi.Size = new System.Drawing.Size(103, 21);
            this.lblKullaniciIsmi.TabIndex = 0;
            this.lblKullaniciIsmi.Text = "Kullanıcı: ---";
            // 
            // anasayfaform1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblKullaniciIsmi);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnArsivGit);
            this.Controls.Add(this.btnMusteriCikisForm);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "anasayfaform1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otel Otomasyon Paneli";
            this.Load += new System.EventHandler(this.anasayfaform1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.Button btnMusteriCikisForm;
        private System.Windows.Forms.Button btnArsivGit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblKasaTutar;
        private System.Windows.Forms.Label lblDolulukOrani;
        private System.Windows.Forms.Label lblBosOda;
        private System.Windows.Forms.Label lblDoluOda;
        private System.Windows.Forms.Label lblToplamOda;
        private System.Windows.Forms.Button button2;
    }
}