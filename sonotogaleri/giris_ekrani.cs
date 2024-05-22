using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace Otogaleriotomasyon
{
    public partial class giris_ekrani : Form
    {
        System.Threading.Timer? timer;
        public giris_ekrani()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)

        {
            if (textBox1.Text == "admin" && textBox2.Text == "mersin")
            {
                // Admin panelini a�
                admin_panel admin_panel = new admin_panel();
                admin_panel.Show();

            }
            else
            {
                MessageBox.Show("Hatal� kullan�c� ad� veya �ifre!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Kullan�c� ad� ve �ifre alanlar�n�n bo� olup olmad���n� kontrol et
            if (string.IsNullOrWhiteSpace(textBox6.Text) || string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Kullan�c� ad� veya �ifre bo� b�rak�lamaz!");
                return;
            }
            // Veritaban� ba�lant� stringi
            string connectionString = "server=localhost;port=3306;user=root;password=;database=otogaleridb";

            // Kullan�c� ad� ve �ifreyi metin kutular�ndan ald���m k�s�m
            string kullaniciAdi = textBox6.Text;
            string sifre = textBox5.Text;

            // SQL sorgusu -- Kullan�c� ad�n�n veritaban�nda kullan�l�p kullan�lmad���n� kontrol et
            string selectQuery = "SELECT COUNT(*) FROM uyeler WHERE kullanici_adi = @kullaniciAdi";

            
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                
                using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);

                    // Veritaban�na ba�lanma ve SQL sorgusunu �al��t�rma
                    connection.Open();
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
                    {
                        // Kullan�c� ad� veritaban�nda varsa kay�t i�lemine izin verme
                        MessageBox.Show("Bu kullan�c� ad� zaten kullan�mda!");
                    }
                    else
                    {
                        // SQL sorgusu -- Kullan�c�y� veritaban�na ekle
                        string insertQuery = "INSERT INTO uyeler (kullanici_adi, sifre) VALUES (@kullaniciAdi, @sifre)";

                        using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                            insertCommand.Parameters.AddWithValue("@sifre", sifre);

                            insertCommand.ExecuteNonQuery();

                            // Kay�t i�leminin ba�ar�l� oldu�unu g�steren mesaj
                            MessageBox.Show("Ba�ar�yla kay�t oldunuz! M��teri giri�ine y�nlendiriliyorsunuz...");




                        }
                    }
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Kullan�c� ad� ve �ifre alanlar�n�n bo� olup olmad���n� kontrol et
            if (string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Kullan�c� ad� veya �ifre bo� b�rak�lamaz!");
                return;
            }

            string kullaniciAdi = textBox4.Text; // textBox4 kullan�c� ad� alan� olacak
            string sifre = textBox3.Text; // textBox3 �ifre alan� olacak

            // Veritaban� ba�lant� stringi
            string connectionString = "server=localhost;port=3306;user=root;password=;database=otogaleridb";

            // Kullan�c� ad� ve �ifreyi do�rulama y�ntemi 
            bool girisBasarili = KullaniciDogrula(kullaniciAdi, sifre, connectionString);

            if (girisBasarili)
            {
                // M��teri panelini a�
                musteri_panel musteriPanel = new musteri_panel();
                musteriPanel.Show();
            }
            else
            {
                // Hatal� giri� olursa kullan�c�ya uyar� mesaj� g�ster
                MessageBox.Show("Hatal� kullan�c� ad� veya �ifre!");
            }
        }

        private bool KullaniciDogrula(string kullaniciAdi, string sifre, string connectionString)
        {
            // SQL sorgusu -- Kullan�c� ad� ve �ifreyle giri� yapmay� kontrol et
            string selectQuery = "SELECT COUNT(*) FROM uyeler WHERE kullanici_adi = @kullaniciAdi AND sifre = @sifre";

            
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                
                using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                    command.Parameters.AddWithValue("@sifre", sifre);

                    
                    connection.Open();
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    // E�er kullan�c� varsa true d�nd�r, yoksa false d�nd�r
                    return count > 0;
                }
            }
        }
    }
}