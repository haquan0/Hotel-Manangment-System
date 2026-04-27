namespace WindowsFormsApp1
{
    partial class CalisanYonetimi
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCalisanlar = new System.Windows.Forms.DataGridView();
            this.cmbDurumSec = new System.Windows.Forms.ComboBox();
            this.btnDurumGuncelle = new System.Windows.Forms.Button();
            this.lblAktifPersonel = new System.Windows.Forms.Label();
            this.lblMoladakiPersonel = new System.Windows.Forms.Label();
            this.lblIzinliPersonel = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.lblSeciliPersonel = new System.Windows.Forms.Label();
            this.btnRastgeleVardiya = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalisanlar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCalisanlar
            // 
            this.dgvCalisanlar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.dgvCalisanlar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCalisanlar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCalisanlar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dgvCalisanlar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCalisanlar.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCalisanlar.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCalisanlar.EnableHeadersVisualStyles = false;
            this.dgvCalisanlar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.dgvCalisanlar.Location = new System.Drawing.Point(288, 71);
            this.dgvCalisanlar.Name = "dgvCalisanlar";
            this.dgvCalisanlar.ReadOnly = true;
            this.dgvCalisanlar.RowHeadersVisible = false;
            this.dgvCalisanlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCalisanlar.Size = new System.Drawing.Size(496, 264);
            this.dgvCalisanlar.TabIndex = 0;
            this.dgvCalisanlar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCalisanlar_CellClick);
            // 
            // cmbDurumSec
            // 
            this.cmbDurumSec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.cmbDurumSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDurumSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDurumSec.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDurumSec.ForeColor = System.Drawing.Color.White;
            this.cmbDurumSec.FormattingEnabled = true;
            this.cmbDurumSec.Items.AddRange(new object[] {
            "Çalışıyor",
            "İzinli",
            "Molada"});
            this.cmbDurumSec.Location = new System.Drawing.Point(53, 180);
            this.cmbDurumSec.Name = "cmbDurumSec";
            this.cmbDurumSec.Size = new System.Drawing.Size(180, 25);
            this.cmbDurumSec.TabIndex = 1;
            // 
            // btnDurumGuncelle
            // 
            this.btnDurumGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(150)))));
            this.btnDurumGuncelle.FlatAppearance.BorderSize = 0;
            this.btnDurumGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDurumGuncelle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDurumGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnDurumGuncelle.Location = new System.Drawing.Point(53, 220);
            this.btnDurumGuncelle.Name = "btnDurumGuncelle";
            this.btnDurumGuncelle.Size = new System.Drawing.Size(180, 40);
            this.btnDurumGuncelle.TabIndex = 2;
            this.btnDurumGuncelle.Text = "Durumu Güncelle";
            this.btnDurumGuncelle.UseVisualStyleBackColor = false;
            this.btnDurumGuncelle.Click += new System.EventHandler(this.btnDurumGuncelle_Click);
            // 
            // lblAktifPersonel
            // 
            this.lblAktifPersonel.AutoSize = true;
            this.lblAktifPersonel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblAktifPersonel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(118)))));
            this.lblAktifPersonel.Location = new System.Drawing.Point(50, 42);
            this.lblAktifPersonel.Name = "lblAktifPersonel";
            this.lblAktifPersonel.Size = new System.Drawing.Size(125, 20);
            this.lblAktifPersonel.TabIndex = 3;
            this.lblAktifPersonel.Text = "Aktif Personel: 0";
            // 
            // lblMoladakiPersonel
            // 
            this.lblMoladakiPersonel.AutoSize = true;
            this.lblMoladakiPersonel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblMoladakiPersonel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            this.lblMoladakiPersonel.Location = new System.Drawing.Point(50, 75);
            this.lblMoladakiPersonel.Name = "lblMoladakiPersonel";
            this.lblMoladakiPersonel.Size = new System.Drawing.Size(78, 20);
            this.lblMoladakiPersonel.TabIndex = 4;
            this.lblMoladakiPersonel.Text = "Molada: 0";
            // 
            // lblIzinliPersonel
            // 
            this.lblIzinliPersonel.AutoSize = true;
            this.lblIzinliPersonel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblIzinliPersonel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.lblIzinliPersonel.Location = new System.Drawing.Point(50, 110);
            this.lblIzinliPersonel.Name = "lblIzinliPersonel";
            this.lblIzinliPersonel.Size = new System.Drawing.Size(59, 20);
            this.lblIzinliPersonel.TabIndex = 5;
            this.lblIzinliPersonel.Text = "İzinli: 0";
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.btnGeri.FlatAppearance.BorderSize = 0;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeri.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGeri.ForeColor = System.Drawing.Color.White;
            this.btnGeri.Location = new System.Drawing.Point(863, 12);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 30);
            this.btnGeri.TabIndex = 6;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // lblSeciliPersonel
            // 
            this.lblSeciliPersonel.AutoSize = true;
            this.lblSeciliPersonel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Italic);
            this.lblSeciliPersonel.ForeColor = System.Drawing.Color.LightGray;
            this.lblSeciliPersonel.Location = new System.Drawing.Point(285, 44);
            this.lblSeciliPersonel.Name = "lblSeciliPersonel";
            this.lblSeciliPersonel.Size = new System.Drawing.Size(134, 19);
            this.lblSeciliPersonel.TabIndex = 7;
            this.lblSeciliPersonel.Text = "Seçilen Personel: ---";
            // 
            // btnRastgeleVardiya
            // 
            this.btnRastgeleVardiya.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.btnRastgeleVardiya.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnRastgeleVardiya.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRastgeleVardiya.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnRastgeleVardiya.ForeColor = System.Drawing.Color.White;
            this.btnRastgeleVardiya.Location = new System.Drawing.Point(288, 356);
            this.btnRastgeleVardiya.Name = "btnRastgeleVardiya";
            this.btnRastgeleVardiya.Size = new System.Drawing.Size(180, 43);
            this.btnRastgeleVardiya.TabIndex = 8;
            this.btnRastgeleVardiya.Text = "🎲 Vardiyaları Dağıt";
            this.btnRastgeleVardiya.UseVisualStyleBackColor = false;
            this.btnRastgeleVardiya.Click += new System.EventHandler(this.btnRastgeleVardiya_Click);
            // 
            // CalisanYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(982, 450);
            this.Controls.Add(this.btnRastgeleVardiya);
            this.Controls.Add(this.lblSeciliPersonel);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.lblIzinliPersonel);
            this.Controls.Add(this.lblMoladakiPersonel);
            this.Controls.Add(this.lblAktifPersonel);
            this.Controls.Add(this.btnDurumGuncelle);
            this.Controls.Add(this.cmbDurumSec);
            this.Controls.Add(this.dgvCalisanlar);
            this.Name = "CalisanYonetimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Yönetim Paneli";
            this.Load += new System.EventHandler(this.CalisanYonetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalisanlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCalisanlar;
        private System.Windows.Forms.ComboBox cmbDurumSec;
        private System.Windows.Forms.Button btnDurumGuncelle;
        private System.Windows.Forms.Label lblAktifPersonel;
        private System.Windows.Forms.Label lblMoladakiPersonel;
        private System.Windows.Forms.Label lblIzinliPersonel;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label lblSeciliPersonel;
        private System.Windows.Forms.Button btnRastgeleVardiya;
    }
}