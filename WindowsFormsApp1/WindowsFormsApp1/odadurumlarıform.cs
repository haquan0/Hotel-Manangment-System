using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace WindowsFormsApp1
{
   
    public partial class odadurumlarıform : Form
    {
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ödev.accdb");

        void VerileriListele()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                string sorgu = "SELECT * FROM Oda_durumları";
                
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri çekme hatası: " + ex.Message);
            }
        }
        public odadurumlarıform()
        {
            InitializeComponent();
        }

        private void odadurumlarıform_Load(object sender, EventArgs e)
        {
            VerileriListele();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();


                string sorgu = "SELECT * FROM Oda_durumları WHERE odano LIKE '" + textBox1.Text + "%'";

                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
                baglanti.Close();
            }
            catch { }
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            anasayfaform1 anasayfaform1 = new anasayfaform1();

            anasayfaform1.Show();

            this.Close();
        }
    }
}
