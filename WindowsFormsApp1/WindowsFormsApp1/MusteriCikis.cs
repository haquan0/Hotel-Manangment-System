using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MusteriCikis : Form
    {
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ödev.accdb");

        public MusteriCikis()
        {
            InitializeComponent();
            // Oda no yazıldıkça ismi getiren event
            txtCikisOdaNo.TextChanged += new EventHandler(txtCikisOdaNo_TextChanged);
        }

        private void MusteriCikis_Load(object sender, EventArgs e)
        {
            ListeleBekleyenler();
        }

        // --- LİSTELEME FONKSİYONU ---
        private void ListeleBekleyenler()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                string sorgu = "SELECT OdaNo, AdSoyad, GirisTarihi FROM [Musteriler] WHERE [CikisTarihi] IS NULL";
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvBekleyenler.DataSource = dt;
            }
            catch (Exception ex) { MessageBox.Show("Liste hatası: " + ex.Message); }
            finally { baglanti.Close(); }
        }

        // --- OTOMATİK İSİM GETİRME ---
        private void txtCikisOdaNo_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCikisOdaNo.Text))
            {
                lblMusteriAdSoyad.Text = "Müşteri: ---";
                return;
            }

            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                string sorgu = "SELECT AdSoyad FROM [Musteriler] WHERE [OdaNo] = @oda AND [CikisTarihi] IS NULL";
                OleDbCommand cmd = new OleDbCommand(sorgu, baglanti);
                cmd.Parameters.AddWithValue("@oda", txtCikisOdaNo.Text);
                object sonuc = cmd.ExecuteScalar();

                if (sonuc != null)
                {
                    lblMusteriAdSoyad.Text = "Seçili: " + sonuc.ToString();
                    lblMusteriAdSoyad.ForeColor = Color.FromArgb(0, 122, 204);
                }
                else
                {
                    lblMusteriAdSoyad.Text = "Kayıt Bulunamadı!";
                    lblMusteriAdSoyad.ForeColor = Color.IndianRed;
                }
            }
            catch { }
            finally { baglanti.Close(); }
        }

        // --- ASIL ÇIKIŞ İŞLEMİ (GERİ GELDİ) ---
        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCikisOdaNo.Text))
            {
                MessageBox.Show("Lütfen bir oda numarası seçin veya yazın!");
                return;
            }

            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                // 1. Müşterinin giriş tarihini al
                string sorguGiris = "SELECT GirisTarihi FROM [Musteriler] WHERE [OdaNo] = @oda AND [CikisTarihi] IS NULL";
                OleDbCommand cmdGiris = new OleDbCommand(sorguGiris, baglanti);
                cmdGiris.Parameters.AddWithValue("@oda", txtCikisOdaNo.Text);
                object objGiris = cmdGiris.ExecuteScalar();

                if (objGiris == null)
                {
                    MessageBox.Show("Bu odada aktif müşteri yok!");
                    return;
                }

                DateTime girisTarihi = Convert.ToDateTime(objGiris);

                // 2. Odanın fiyatını al
                string sorguFiyat = "SELECT odafiyati FROM [Oda_durumları] WHERE [odano] = @oda";
                OleDbCommand cmdFiyat = new OleDbCommand(sorguFiyat, baglanti);
                cmdFiyat.Parameters.AddWithValue("@oda", txtCikisOdaNo.Text);
                int gunlukFiyat = Convert.ToInt32(cmdFiyat.ExecuteScalar());

                // 3. Hesaplama (Gün x Fiyat)
                DateTime cikisTarihi = dtpCikisTarihi.Value;
                int gunSayisi = (cikisTarihi - girisTarihi).Days;
                if (gunSayisi <= 0) gunSayisi = 1; // Aynı gün çıkış 1 gün sayılır
                int toplamTutar = gunSayisi * gunlukFiyat;

                // 4. Müşteri kaydını güncelle (Çıkış tarihi ve Tutar)
                string updateMusteri = "UPDATE [Musteriler] SET [CikisTarihi] = @cikis, [ToplamTutar] = @tutar WHERE [OdaNo] = @oda AND [CikisTarihi] IS NULL";
                OleDbCommand cmdUpMusteri = new OleDbCommand(updateMusteri, baglanti);
                cmdUpMusteri.Parameters.AddWithValue("@cikis", cikisTarihi.ToShortDateString());
                cmdUpMusteri.Parameters.AddWithValue("@tutar", toplamTutar);
                cmdUpMusteri.Parameters.AddWithValue("@oda", txtCikisOdaNo.Text);
                cmdUpMusteri.ExecuteNonQuery();

                // 5. Odayı boşalt
                string updateOda = "UPDATE [Oda_durumları] SET [odadurum] = 'Boş' WHERE [odano] = @oda";
                OleDbCommand cmdUpOda = new OleDbCommand(updateOda, baglanti);
                cmdUpOda.Parameters.AddWithValue("@oda", txtCikisOdaNo.Text);
                cmdUpOda.ExecuteNonQuery();

                MessageBox.Show($"Çıkış Başarılı!\nSüre: {gunSayisi} Gün\nToplam Borç: {toplamTutar} TL");

                baglanti.Close();
                ListeleBekleyenler(); // Listeyi yenile
                txtCikisOdaNo.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("İşlem hatası: " + ex.Message);
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            anasayfaform1 anasayfaform1 = new anasayfaform1();

            anasayfaform1.Show();

            this.Close();
        }
    }
}