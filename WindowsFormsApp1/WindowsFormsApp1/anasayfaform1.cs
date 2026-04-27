using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class anasayfaform1 : Form
    {
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ödev.accdb");

        // Login formundan gelecek kullanıcı adını tutan değişken
        public string girisYapanKullanici { get; set; }

        public anasayfaform1()
        {
            InitializeComponent();
        }

        private void anasayfaform1_Load(object sender, EventArgs e)
        {
            // Giriş yapan ismi üstteki label'a yazdır
            lblKullaniciIsmi.Text = "Hoş geldin, " + (string.IsNullOrEmpty(girisYapanKullanici) ? "Admin" : girisYapanKullanici.ToUpper());

            DashboardGuncelle();
        }

        public void DashboardGuncelle()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                // 1. Toplam Oda Sayısı
                OleDbCommand cmdToplam = new OleDbCommand("SELECT COUNT(*) FROM [Oda_durumları]", baglanti);
                int toplam = Convert.ToInt32(cmdToplam.ExecuteScalar());

                // 2. Dolu Oda Sayısı
                OleDbCommand cmdDolu = new OleDbCommand("SELECT COUNT(*) FROM [Oda_durumları] WHERE [odadurum] = 'Dolu'", baglanti);
                int dolu = Convert.ToInt32(cmdDolu.ExecuteScalar());

                int bos = toplam - dolu;

                // Verileri Labellara Aktar (Tasarım rengi korunur)
                lblToplamOda.Text = "Toplam Oda: " + toplam;
                lblDoluOda.Text = "Dolu Oda: " + dolu;
                lblBosOda.Text = "Boş Oda: " + bos;

                // 3. Doluluk Oranı
                if (toplam > 0)
                {
                    double oran = (double)dolu / toplam * 100;
                    lblDolulukOrani.Text = "Doluluk: %" + oran.ToString("0.0");
                }

                // 4. Kasa Ciro Hesabı
                OleDbCommand cmdKasa = new OleDbCommand("SELECT SUM(ToplamTutar) FROM [Musteriler]", baglanti);
                object kasa = cmdKasa.ExecuteScalar();

                if (kasa != DBNull.Value && kasa != null)
                {
                    lblKasaTutar.Text = "Toplam Ciro: " + kasa.ToString() + " TL";
                }
                else
                {
                    lblKasaTutar.Text = "Toplam Ciro: 0 TL";
                }

                baglanti.Close();
            }
            catch (Exception)
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            odadurumlarıform oda = new odadurumlarıform();
            oda.Show();
            this.Hide();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            MusteriKayit kayitFormu = new MusteriKayit();
            kayitFormu.Show();
            this.Hide();
        }

        private void btnMusteriCikisForm_Click(object sender, EventArgs e)
        {
            MusteriCikis cikisformu = new MusteriCikis();
            cikisformu.Show();
            this.Hide();
        }

        private void btnArsivGit_Click(object sender, EventArgs e)
        {
            MusteriArsiv musteriler = new MusteriArsiv();
            musteriler.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalisanYonetimi calisanForm = new CalisanYonetimi();
            calisanForm.Show();
            this.Hide();
        }


    }
}
