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
                // Admin panelini aç
                admin_panel admin_panel = new admin_panel();
                admin_panel.Show();

            }
            else
            {
                MessageBox.Show("Hatalý kullanýcý adý veya þifre!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Kullanýcý adý ve þifre alanlarýnýn boþ olup olmadýðýný kontrol et
            if (string.IsNullOrWhiteSpace(textBox6.Text) || string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Kullanýcý adý veya þifre boþ býrakýlamaz!");
                return;
            }
            // Veritabaný baðlantý stringi
            string connectionString = "server=localhost;port=3306;user=root;password=;database=otogaleridb";

            // Kullanýcý adý ve þifreyi metin kutularýndan aldýðým kýsým
            string kullaniciAdi = textBox6.Text;
            string sifre = textBox5.Text;

            // SQL sorgusu -- Kullanýcý adýnýn veritabanýnda kullanýlýp kullanýlmadýðýný kontrol et
            string selectQuery = "SELECT COUNT(*) FROM uyeler WHERE kullanici_adi = @kullaniciAdi";

            
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                
                using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);

                    // Veritabanýna baðlanma ve SQL sorgusunu çalýþtýrma
                    connection.Open();
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
                    {
                        // Kullanýcý adý veritabanýnda varsa kayýt iþlemine izin verme
                        MessageBox.Show("Bu kullanýcý adý zaten kullanýmda!");
                    }
                    else
                    {
                        // SQL sorgusu -- Kullanýcýyý veritabanýna ekle
                        string insertQuery = "INSERT INTO uyeler (kullanici_adi, sifre) VALUES (@kullaniciAdi, @sifre)";

                        using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                            insertCommand.Parameters.AddWithValue("@sifre", sifre);

                            insertCommand.ExecuteNonQuery();

                            // Kayýt iþleminin baþarýlý olduðunu gösteren mesaj
                            MessageBox.Show("Baþarýyla kayýt oldunuz! Müþteri giriþine yönlendiriliyorsunuz...");




                        }
                    }
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Kullanýcý adý ve þifre alanlarýnýn boþ olup olmadýðýný kontrol et
            if (string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Kullanýcý adý veya þifre boþ býrakýlamaz!");
                return;
            }

            string kullaniciAdi = textBox4.Text; // textBox4 kullanýcý adý alaný olacak
            string sifre = textBox3.Text; // textBox3 þifre alaný olacak

            // Veritabaný baðlantý stringi
            string connectionString = "server=localhost;port=3306;user=root;password=;database=otogaleridb";

            // Kullanýcý adý ve þifreyi doðrulama yöntemi 
            bool girisBasarili = KullaniciDogrula(kullaniciAdi, sifre, connectionString);

            if (girisBasarili)
            {
                // Müþteri panelini aç
                musteri_panel musteriPanel = new musteri_panel();
                musteriPanel.Show();
            }
            else
            {
                // Hatalý giriþ olursa kullanýcýya uyarý mesajý göster
                MessageBox.Show("Hatalý kullanýcý adý veya þifre!");
            }
        }

        private bool KullaniciDogrula(string kullaniciAdi, string sifre, string connectionString)
        {
            // SQL sorgusu -- Kullanýcý adý ve þifreyle giriþ yapmayý kontrol et
            string selectQuery = "SELECT COUNT(*) FROM uyeler WHERE kullanici_adi = @kullaniciAdi AND sifre = @sifre";

            
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                
                using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                    command.Parameters.AddWithValue("@sifre", sifre);

                    
                    connection.Open();
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    // Eðer kullanýcý varsa true döndür, yoksa false döndür
                    return count > 0;
                }
            }
        }
    }
}