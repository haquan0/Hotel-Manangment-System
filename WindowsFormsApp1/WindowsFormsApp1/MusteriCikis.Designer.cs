namespace WindowsFormsApp1
{
    partial class MusteriCikis
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
            System.Windows.Forms.DataGridViewCellStyle dgvStil = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvHeaderStil = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnCikisYap = new System.Windows.Forms.Button();
            this.lblOdaNo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCikisOdaNo = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblMusteriAdSoyad = new System.Windows.Forms.Label();
            this.dgvBekleyenler = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBekleyenler)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(450, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "🛎️ ÇIKIŞ BEKLEYEN ODALAR";
            // 
            // dgvBekleyenler
            // 
            this.dgvBekleyenler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBekleyenler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.dgvBekleyenler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBekleyenler.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBekleyenler.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dgvHeaderStil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dgvHeaderStil.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dgvHeaderStil.ForeColor = System.Drawing.Color.White;
            this.dgvBekleyenler.ColumnHeadersDefaultCellStyle = dgvHeaderStil;
            this.dgvBekleyenler.ColumnHeadersHeight = 35;
            dgvStil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            dgvStil.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dgvStil.ForeColor = System.Drawing.Color.White;
            dgvStil.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.dgvBekleyenler.DefaultCellStyle = dgvStil;
            this.dgvBekleyenler.EnableHeadersVisualStyles = false;
            this.dgvBekleyenler.Location = new System.Drawing.Point(450, 100);
            this.dgvBekleyenler.Name = "dgvBekleyenler";
            this.dgvBekleyenler.RowHeadersVisible = false;
            this.dgvBekleyenler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBekleyenler.Size = new System.Drawing.Size(480, 310);
            this.dgvBekleyenler.TabIndex = 9;
            // 
            // dtpCikisTarihi
            // 
            this.dtpCikisTarihi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpCikisTarihi.Location = new System.Drawing.Point(180, 204);
            this.dtpCikisTarihi.Name = "dtpCikisTarihi";
            this.dtpCikisTarihi.Size = new System.Drawing.Size(220, 25);
            this.dtpCikisTarihi.TabIndex = 0;
            // 
            // btnCikisYap
            // 
            this.btnCikisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnCikisYap.FlatAppearance.BorderSize = 0;
            this.btnCikisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikisYap.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCikisYap.ForeColor = System.Drawing.Color.White;
            this.btnCikisYap.Location = new System.Drawing.Point(180, 255);
            this.btnCikisYap.Name = "btnCikisYap";
            this.btnCikisYap.Size = new System.Drawing.Size(220, 50);
            this.btnCikisYap.TabIndex = 2;
            this.btnCikisYap.Text = "ÇIKIŞI ONAYLA";
            this.btnCikisYap.UseVisualStyleBackColor = false;
            this.btnCikisYap.Click += new System.EventHandler(this.btnCikisYap_Click);
            // 
            // lblOdaNo
            // 
            this.lblOdaNo.AutoSize = true;
            this.lblOdaNo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblOdaNo.ForeColor = System.Drawing.Color.LightGray;
            this.lblOdaNo.Location = new System.Drawing.Point(70, 163);
            this.lblOdaNo.Name = "lblOdaNo";
            this.lblOdaNo.Size = new System.Drawing.Size(104, 19);
            this.lblOdaNo.TabIndex = 3;
            this.lblOdaNo.Text = "Oda Numarası:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(90, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Çıkış Tarihi:";
            // 
            // txtCikisOdaNo
            // 
            this.txtCikisOdaNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.txtCikisOdaNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCikisOdaNo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCikisOdaNo.ForeColor = System.Drawing.Color.White;
            this.txtCikisOdaNo.Location = new System.Drawing.Point(180, 160);
            this.txtCikisOdaNo.Name = "txtCikisOdaNo";
            this.txtCikisOdaNo.Size = new System.Drawing.Size(220, 27);
            this.txtCikisOdaNo.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(840, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 35);
            this.button2.TabIndex = 6;
            this.button2.Text = "← GERİ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblMusteriAdSoyad
            // 
            this.lblMusteriAdSoyad.AutoSize = true;
            this.lblMusteriAdSoyad.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic);
            this.lblMusteriAdSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblMusteriAdSoyad.Location = new System.Drawing.Point(180, 130);
            this.lblMusteriAdSoyad.Name = "lblMusteriAdSoyad";
            this.lblMusteriAdSoyad.Size = new System.Drawing.Size(91, 20);
            this.lblMusteriAdSoyad.TabIndex = 7;
            this.lblMusteriAdSoyad.Text = "Müşteri: ---";
            // 
            // MusteriCikis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(960, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvBekleyenler);
            this.Controls.Add(this.lblMusteriAdSoyad);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtCikisOdaNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOdaNo);
            this.Controls.Add(this.btnCikisYap);
            this.Controls.Add(this.dtpCikisTarihi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MusteriCikis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otel Otomasyonu | Müşteri Çıkış";
            this.Load += new System.EventHandler(this.MusteriCikis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBekleyenler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpCikisTarihi;
        private System.Windows.Forms.Button btnCikisYap;
        private System.Windows.Forms.Label lblOdaNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCikisOdaNo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblMusteriAdSoyad;
        private System.Windows.Forms.DataGridView dgvBekleyenler;
        private System.Windows.Forms.Label label3;
    }
}