using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CalisanYonetimi : Form
    {
        // Veritabanı bağlantısı - bin\Debug klasöründe ödev.accdb olmalı
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ödev.accdb");

        public CalisanYonetimi()
        {
            InitializeComponent();
        }

        // --- 1. PERSONEL LİSTESİNİ GETİR VE RENKLENDİR ---
        void CalisanlariListele()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                string sorgu = "SELECT CalisanID, AdSoyad, Gorev, VardiyaSaat, Durum FROM Calisanlar";
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCalisanlar.DataSource = dt;

                // Duruma göre satırları boya
                foreach (DataGridViewRow row in dgvCalisanlar.Rows)
                {
                    if (row.Cells["Durum"].Value != null)
                    {
                        string durum = row.Cells["Durum"].Value.ToString();
                        if (durum == "Çalışıyor") row.DefaultCellStyle.BackColor = Color.LightGreen;
                        else if (durum == "Molada") row.DefaultCellStyle.BackColor = Color.Khaki;
                        else if (durum == "İzinli") row.DefaultCellStyle.BackColor = Color.LightCoral;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Liste yükleme hatası: " + ex.Message); }
            finally { baglanti.Close(); }
        }

        // --- 2. ÜSTTEKİ SAYI LABELLARINI GÜNCELLE ---
        void IstatistikleriGuncelle()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                lblAktifPersonel.Text = "Aktif: " + new OleDbCommand("SELECT COUNT(*) FROM Calisanlar WHERE Durum = 'Çalışıyor'", baglanti).ExecuteScalar().ToString();
                lblMoladakiPersonel.Text = "Molada: " + new OleDbCommand("SELECT COUNT(*) FROM Calisanlar WHERE Durum = 'Molada'", baglanti).ExecuteScalar().ToString();
                lblIzinliPersonel.Text = "İzinli: " + new OleDbCommand("SELECT COUNT(*) FROM Calisanlar WHERE Durum = 'İzinli'", baglanti).ExecuteScalar().ToString();
            }
            catch { }
            finally { baglanti.Close(); }
        }

        // --- 3. FORM AÇILDIĞINDA OTOMATİK ÇALIŞAN KISIM ---
        private void CalisanYonetimi_Load(object sender, EventArgs e)
        {
            CalisanlariListele();
            IstatistikleriGuncelle();
        }

        // --- 4. TABLODAN BİRİNE TIKLANDIĞINDA İSMİNİ YAKALA ---
        private void dgvCalisanlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Başlık satırı (-1) değilse ve geçerli bir satırsa
            if (e.RowIndex >= 0)
            {
                // Salt okunur modda olduğumuz için dgvCalisanlar.Rows[e.RowIndex] üzerinden veriyi çekiyoruz
                string ad = dgvCalisanlar.Rows[e.RowIndex].Cells["AdSoyad"].Value.ToString();
                lblSeciliPersonel.Text = "Seçilen: " + ad;

                // Satırı görsel olarak da seçili hale getirelim (Garanti olsun)
                dgvCalisanlar.Rows[e.RowIndex].Selected = true;
            }
        }

        // --- 5. DURUM GÜNCELLEME BUTONU ---
        private void btnDurumGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvCalisanlar.CurrentRow == null || cmbDurumSec.SelectedItem == null)
            {
                MessageBox.Show("Lütfen önce listeden bir personel, sonra bir durum seçin!");
                return;
            }

            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                string seciliID = dgvCalisanlar.CurrentRow.Cells["CalisanID"].Value.ToString();
                string yeniDurum = cmbDurumSec.SelectedItem.ToString();

                string sorgu = "UPDATE Calisanlar SET Durum = @durum WHERE CalisanID = @id";
                OleDbCommand cmd = new OleDbCommand(sorgu, baglanti);
                cmd.Parameters.AddWithValue("@durum", yeniDurum);
                cmd.Parameters.AddWithValue("@id", seciliID);
                cmd.ExecuteNonQuery();

                baglanti.Close(); // İstatistikler için kapatıyoruz

                CalisanlariListele();
                IstatistikleriGuncelle();

                MessageBox.Show("Personel durumu başarıyla güncellendi.");
            }
            catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }
            finally { if (baglanti.State == ConnectionState.Open) baglanti.Close(); }
        }

        // --- 6. GERİ BUTONU ---
        private void btnGeri_Click(object sender, EventArgs e)
        {
            anasayfaform1 ana = new anasayfaform1();
            ana.Show();
            this.Close();
        }

        private void btnRastgeleVardiya_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Vardiya seçeneklerimizi bir diziye tanımlıyoruz
                string[] vardiyalar = { "08:00 - 16:00", "16:00 - 00:00", "00:00 - 08:00" };
                Random rnd = new Random();

                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                // 2. Tüm çalışanların ID'lerini çekiyoruz
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter("SELECT CalisanID FROM Calisanlar", baglanti);
                da.Fill(dt);

                // 3. Her çalışan için rastgele bir vardiya seçip güncelliyoruz
                foreach (DataRow row in dt.Rows)
                {
                    int rastgeleIndeks = rnd.Next(vardiyalar.Length); // 0, 1 veya 2 seçer
                    string secilenVardiya = vardiyalar[rastgeleIndeks];
                    string id = row["CalisanID"].ToString();

                    string guncelleSorgu = "UPDATE Calisanlar SET VardiyaSaat = @v WHERE CalisanID = @id";
                    OleDbCommand cmd = new OleDbCommand(guncelleSorgu, baglanti);
                    cmd.Parameters.AddWithValue("@v", secilenVardiya);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Tüm personellerin vardiyaları rastgele güncellendi!");

                // 4. Ekranı tazele
                CalisanlariListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }
    }
}