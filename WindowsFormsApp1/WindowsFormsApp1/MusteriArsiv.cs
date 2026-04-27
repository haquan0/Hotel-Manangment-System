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
    public partial class MusteriArsiv : Form
    {
        // Veritabanı dosya isminin 'ödev.accdb' olduğundan emin ol
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ödev.accdb");

        public MusteriArsiv()
        {
            InitializeComponent();
        }

        // Bu metot verileri çekip tabloya basar
        void VerileriGetir(string sorgu)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvArsiv.DataSource = dt;
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        // Form ilk açıldığında çalışacak kısım
        private void MusteriArsiv_Load(object sender, EventArgs e)
        {
            // Tablo ismini köşeli parantez içinde yazmak hatayı önler
            VerileriGetir("SELECT * FROM [Musteriler]");
        }

        // Arama yapıldığında çalışacak kısım
        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            // Arama yaparken hata almamak için bağlantıyı kontrol edelim
            try
            {
                string aramaSorgusu = "SELECT * FROM [Musteriler] WHERE [AdSoyad] LIKE '%" + txtAra.Text + "%'";

                // Daha önce yazdığımız VerileriGetir metodunu çağırıyoruz
                VerileriGetir(aramaSorgusu);
            }
            catch (Exception ex)
            {
                // Hata olursa en azından nedenini görelim
                Console.WriteLine("Arama Hatası: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anasayfaform1 anasayfa = new anasayfaform1();
            anasayfa.Show();
            this.Close();
        }
    }

}
