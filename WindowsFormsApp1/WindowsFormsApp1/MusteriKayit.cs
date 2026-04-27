using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    public partial class MusteriKayit : Form
    {
        public anasayfaform1 anaForm;
        // Flag to avoid triggering TextChanged handler when we set txtOdaNo programmatically
        private bool suppressOdaNoTextChanged = false;
        private readonly string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ödev.accdb";

        public MusteriKayit()
        {
            InitializeComponent();
        }

        // --- KAYDET BUTONU ---
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTC.Text) || string.IsNullOrWhiteSpace(txtAdSoyad.Text) ||
                string.IsNullOrWhiteSpace(txtOdaNo.Text) || string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();

                    // Oda gerçekten boş mu son kontrol
                    string kontrolSorgu = "SELECT COUNT(*) FROM [Oda_durumları] WHERE odano = @oda AND odadurum = 'Boş'";
                    using (OleDbCommand kontrolKomut = new OleDbCommand(kontrolSorgu, conn))
                    {
                        kontrolKomut.Parameters.AddWithValue("@oda", txtOdaNo.Text);
                        if (Convert.ToInt32(kontrolKomut.ExecuteScalar()) == 0)
                        {
                            MessageBox.Show("Bu oda şu an müsait değil!");
                            return;
                        }
                    }

                    // Kayıt Ekleme
                    string musteriEkle = "INSERT INTO Musteriler (TC, AdSoyad, Telefon, OdaNo, GirisTarihi) VALUES (@tc, @ad, @tel, @oda, @tarih)";
                    using (OleDbCommand komut1 = new OleDbCommand(musteriEkle, conn))
                    {
                        komut1.Parameters.AddWithValue("@tc", txtTC.Text);
                        komut1.Parameters.AddWithValue("@ad", txtAdSoyad.Text);
                        komut1.Parameters.AddWithValue("@tel", txtTelefon.Text);
                        komut1.Parameters.AddWithValue("@oda", txtOdaNo.Text);
                        komut1.Parameters.AddWithValue("@tarih", dtpGirisTarihi.Value.ToShortDateString());
                        komut1.ExecuteNonQuery();
                    }

                    // Odayı Dolu Yap
                    string odaGuncelle = "UPDATE [Oda_durumları] SET [odadurum] = 'Dolu' WHERE [odano] = @odaNo";
                    using (OleDbCommand komut2 = new OleDbCommand(odaGuncelle, conn))
                    {
                        komut2.Parameters.AddWithValue("@odaNo", txtOdaNo.Text);
                        komut2.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Kayıt Başarılı!");
                if (anaForm != null) anaForm.DashboardGuncelle();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt Hatası: " + ex.Message);
            }
        }

        // --- ODA BUL BUTONU (Hata Veren Yer 1) ---
        private void btnOdaBul_Click(object sender, EventArgs e)
        {
            if (cmbOdaTipi.SelectedItem == null)
            {
                MessageBox.Show("Lütfen önce bir oda tipi seçiniz!");
                return;
            }

            try
            {
                string sorgu = "SELECT TOP 1 odano, odafiyati FROM [Oda_durumları] WHERE [odatipi] = @tip AND [odadurum] = 'Boş'";
                string foundOdaNo = null;
                string foundFiyat = null;

                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    using (OleDbCommand cmd = new OleDbCommand(sorgu, conn))
                    {
                        cmd.Parameters.AddWithValue("@tip", cmbOdaTipi.SelectedItem.ToString());

                        using (OleDbDataReader dr = cmd.ExecuteReader())
                        {
                            // Eğer en az bir satır geliyorsa dr.Read() true döner, sütunlara indeksle erişmek
                            if (dr.Read())
                            {
                                // odano sütunu birinci, odafiyati ikinci sütun olarak seçildi
                                foundOdaNo = dr.IsDBNull(0) ? string.Empty : dr.GetValue(0).ToString();
                                foundFiyat = dr.IsDBNull(1) ? string.Empty : dr.GetValue(1).ToString();
                            }
                        }
                    }
                }

                // Güncelleme UI'ı reader/command/connection kapandıktan sonra yapalım
                if (!string.IsNullOrEmpty(foundOdaNo))
                {
                    suppressOdaNoTextChanged = true;
                    txtOdaNo.Text = foundOdaNo;
                    suppressOdaNoTextChanged = false;

                    lblOdaFiyati.Text = string.IsNullOrWhiteSpace(foundFiyat) ? "Ücret: ---" : "Günlük Ücret: " + foundFiyat + " TL";
                    lblOdaFiyati.ForeColor = Color.LimeGreen;
                }
                else
                {
                    MessageBox.Show("Bu tipte boş oda bulunamadı.");
                    suppressOdaNoTextChanged = true;
                    txtOdaNo.Clear();
                    suppressOdaNoTextChanged = false;
                    lblOdaFiyati.Text = "Ücret: ---";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oda arama hatası: " + ex.Message);
            }
        }

        // --- ODA NO DEĞİŞİNCE FİYAT GETİR (Hata Veren Yer 2) ---
        private void txtOdaNo_TextChanged(object sender, EventArgs e)
        {
            if (suppressOdaNoTextChanged) return;
            if (string.IsNullOrWhiteSpace(txtOdaNo.Text)) { lblOdaFiyati.Text = "Günlük Ücret: 0 TL"; return; }

            try
            {
                string sorgu = "SELECT odafiyati FROM [Oda_durumları] WHERE [odano] = @no";
                object sonuc = null;
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    using (OleDbCommand cmd = new OleDbCommand(sorgu, conn))
                    {
                        cmd.Parameters.AddWithValue("@no", txtOdaNo.Text);
                        sonuc = cmd.ExecuteScalar();
                    }
                }

                // CRITICAL FIX: Sonuç null ise hata vermesini engelle
                if (sonuc != null && sonuc != DBNull.Value)
                {
                    lblOdaFiyati.Text = "Günlük Ücret: " + sonuc.ToString() + " TL";
                    lblOdaFiyati.ForeColor = Color.LimeGreen;
                }
                else
                {
                    lblOdaFiyati.Text = "Oda Geçersiz";
                    lblOdaFiyati.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oda fiyatı alınırken hata: " + ex.Message);
            }
        }

        private void Temizle()
        {
            txtTC.Clear();
            txtAdSoyad.Clear();
            txtTelefon.Clear();
            suppressOdaNoTextChanged = true;
            txtOdaNo.Clear();
            suppressOdaNoTextChanged = false;
            lblOdaFiyati.Text = "Ücret: ---";
            lblOdaFiyati.ForeColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anasayfaform1 anasayfaform1 = new anasayfaform1();

            anasayfaform1.Show();

            this.Close();
        }
    }
}