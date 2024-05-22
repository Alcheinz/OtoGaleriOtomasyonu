using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing;
using Google.Protobuf.WellKnownTypes;
using System.Net.Http;

namespace Otogaleriotomasyon
{

    public partial class musteri_panel : Form
    {
        string connectionString = "server=localhost;port=3306;user=root;password=;database=otogaleridb";
        public musteri_panel()
        {
            InitializeComponent();
            dataGridView2.SelectionChanged += dataGridView2_SelectionChanged;

        }
        private void musteri_panel_Load_1(object sender, EventArgs e)
        {
            LoadAddedAraclar();
            dataGridView2.Columns["resimyolu"].Visible = false;






        }

        private void LoadAddedAraclar()
        {
            // Veritabanı bağladım
            BindingSource bindingSource = new BindingSource();

            
            DataSet dataSet = new DataSet();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM araclar";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                adapter.Fill(dataSet, "Araclar");
            }

            
            bindingSource.DataSource = dataSet.Tables["Araclar"];

            // DataGridView veritabanına bağladım
            dataGridView2.DataSource = bindingSource;

        }




        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView2.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView2.Rows[selectedRowIndex];

                uye_plaka_textBox1.Text = selectedRow.Cells["plaka"].Value.ToString();
                uye_marka_textBox2.Text = selectedRow.Cells["marka"].Value.ToString();
                uye_model_textBox3.Text = selectedRow.Cells["model"].Value.ToString();
                uye_yakit_tipi_textBox1.Text = selectedRow.Cells["yakit_tipi"].Value.ToString();
                uye_tramer_textBox1.Text = selectedRow.Cells["tramer_kaydi"].Value.ToString();
                uye_km_textBox1.Text = selectedRow.Cells["km"].Value.ToString();
                uye_fiyat_textBox1.Text = selectedRow.Cells["fiyat"].Value.ToString();
                // Resim yüklemesi için sütuna ekleyip resim ekledim.
                dataGridView2.Columns["resimyolu"].Visible = false;
                dataGridView2.Columns["durum"].Visible = false;
            }

            if (dataGridView2.SelectedCells.Count > 0)

            {
                int selectedRowIndex = dataGridView2.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView2.Rows[selectedRowIndex];

                object cellValue = selectedRow.Cells["resimyolu"].Value;
                if (cellValue != null && !string.IsNullOrEmpty(cellValue.ToString()))
                {
                    string imagePath = cellValue.ToString();
                    Image image = Image.FromFile(imagePath);
                    button2.BackgroundImage = image;
                }
                else
                {
                    // Resim yolu boşsa varsayılan bir resim veya başka bir işlem yap
                    
                    button2.BackgroundImage = null; // Resmi temizle
                }
            }




        }



        private void cikis_button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string arananMarka = marka_arama_textBox2.Text.Trim(); // Aranan marka adını aldım

            // Eğer aranan marka boşsa uyarı ver ve metodu sonlandır
            if (string.IsNullOrEmpty(arananMarka))
            {
                MessageBox.Show("Lütfen bir marka adı girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Veritabanından sadece aranan markaya ait araçları çekmek için yazdığım sorgu
            string query = "SELECT * FROM araclar WHERE marka = @marka";

            // Veritabanı bağlantısı
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);

                
                command.Parameters.AddWithValue("@marka", arananMarka);

                
                connection.Open();

                // Verileri çekmek için
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    // DataGridViewe veri tablosunu gönderdim.
                    dataGridView2.DataSource = dataTable;
                }
            }
        }




        private void temizle_button_Click(object sender, EventArgs e)
        {

            
            BindingSource bindingSource = new BindingSource();

            
            DataSet dataSet = new DataSet();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM araclar";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                adapter.Fill(dataSet, "Araclar");
            }

            
            bindingSource.DataSource = dataSet.Tables["Araclar"];

            // DataGridView nesnesini veri bağlama kaynağına bağladım
            dataGridView2.DataSource = bindingSource;

        }

        private void satin_al_button1_Click(object sender, EventArgs e)
        {

            string adsoyadd = adsoyad_textBox.Text.Trim();
            string telnoo = telefon_textBox.Text.Trim();
            string adress = adres_textBox.Text.Trim();

            if (string.IsNullOrEmpty(adsoyadd) || string.IsNullOrEmpty(telnoo) || string.IsNullOrEmpty(adress))
            {
                MessageBox.Show("Lütfen tüm gerekli bilgileri doldurun (Ad Soyad, Telefon, Adres).", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Seçili araç ID'sini ve kullanıcı bilgilerini al
            if (dataGridView2.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView2.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView2.Rows[selectedRowIndex];

                int aracId = Convert.ToInt32(selectedRow.Cells["id"].Value);
                string marka = selectedRow.Cells["marka"].Value.ToString();
                string model = selectedRow.Cells["model"].Value.ToString();
                string adsoyad = adsoyad_textBox.Text;
                string telno = telefon_textBox.Text;
                string adres = adres_textBox.Text;

                // Kullanıcı ID'sini oturumdan al
                int mevcutKullaniciID = 1; // Bu örnek için kullanıcı ID'sini sabit belirtiyoruz.
                                           // int mevcutKullaniciID = (int)HttpContext.Current.Session["KullaniciID"];

                // Veritabanına bağlantı
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MySqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        // Araç durumunu "Onay Bekliyor" olarak güncelle
                        string updateQuery = "UPDATE araclar SET durum = @durum WHERE id = @aracId";
                        MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection, transaction);
                        updateCommand.Parameters.AddWithValue("@durum", "OnayBekliyor");
                        updateCommand.Parameters.AddWithValue("@aracId", aracId);
                        updateCommand.ExecuteNonQuery();

                        // Satış onay tablosuna kayıt ekle
                        string insertQuery = "INSERT INTO satis_onay (AracID, KullaniciID, OnayDurumu, AdSoyad, TelNo, Adres) VALUES (@aracId, @kullaniciId, @onayDurumu, @adSoyad, @telNo, @adres)";
                        MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection, transaction);
                        insertCommand.Parameters.AddWithValue("@aracId", aracId);
                        insertCommand.Parameters.AddWithValue("@kullaniciId", mevcutKullaniciID);
                        insertCommand.Parameters.AddWithValue("@onayDurumu", "Beklemede");
                        insertCommand.Parameters.AddWithValue("@adSoyad", adsoyad);
                        insertCommand.Parameters.AddWithValue("@telNo", telno);
                        insertCommand.Parameters.AddWithValue("@adres", adres);
                        insertCommand.ExecuteNonQuery();

                        // Transaction başarılı, commit et
                        transaction.Commit();

                        MessageBox.Show("Araç satın alma isteği gönderildi. Admin onayını bekleyin.");
                    }
                    catch (Exception ex)
                    {
                        // Hata durumunda transaction geri al
                        transaction.Rollback();
                        MessageBox.Show("Bir hata oluştu: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen satın almak istediğiniz aracı seçin.");
            }
        }

        // Seçilen aracın bilgilerini alacak bir yöntem
        private string GetSelectedCarInfo()
        {
            if (dataGridView2.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView2.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView2.Rows[selectedRowIndex];

                string marka = selectedRow.Cells["marka"].Value.ToString();
                string model = selectedRow.Cells["model"].Value.ToString();
                string adsoyad = adsoyad_textBox.Text;
                string telno = telefon_textBox.Text;
                string adres = adres_textBox.Text;


                // Aracın bilgilerini bir string olarak döndür
                return $"Marka: {marka}\nModel: {model}\n Ad-Soyad:{adsoyad}\n Tel no: {telno}\n adres: {adres} ";
            }

            return "Seçili araç bulunamadı.";
        }
    }
    }


