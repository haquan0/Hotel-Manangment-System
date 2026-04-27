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
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Veritabanı bağlantısı
            OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ödev.accdb");

            try
            {
                baglanti.Open();

                // Kullanicilar tablosunda bu bilgileri arıyoruz
                string sorgu = "SELECT * FROM Kullanicilar WHERE KullaniciAdi=@p1 AND Sifre=@p2";
                OleDbCommand komut = new OleDbCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@p1", textBox1.Text);
                komut.Parameters.AddWithValue("@p2", textBox2.Text);
                string kullanici = textBox1.Text;
                string sifre = textBox2.Text;

                OleDbDataReader dr = komut.ExecuteReader();

                // Eğer veritabanında böyle bir kayıt VARSA
                if (dr.Read())

                {
                    if (dr["KullaniciAdi"].ToString() == kullanici && dr["Sifre"].ToString() == sifre)
                    {
                        MessageBox.Show("Giriş Başarılı! Sisteme yönlendiriliyorsunuz...");

                        anasayfaform1 ana = new anasayfaform1();
                        ana.Show(); // Ana sayfayı açar
                        this.Hide(); // Giriş formunu gizler
                    }
                    else
                    {
                        MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre! Lütfen tekrar deneyin.", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // TextBox'ları temizle ve odağı kullanıcı adına ver
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox1.Focus();
                    }
                }
                // Eğer kayıt YOKSA veya BİLGİLER HATALIYSA
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre! Lütfen tekrar deneyin.", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // TextBox'ları temizle ve odağı kullanıcı adına ver
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantı hatası: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }
    }
}
