using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Otogaleriotomasyon
{
    public partial class admin_panel : Form
    {

        // Veritabanı bağlantı stringi
        string connectionString = "server=localhost;port=3306;user=root;password=;database=otogaleridb";

        public admin_panel()
        {
            InitializeComponent();

        }

        private void admin_panel_Load(object sender, EventArgs e)
        {
            LoadUyeler();
            LoadAddedAraclar();
        }
        private void LoadAddedAraclar()
        {
            // Veritabanı bağlantısı
            BindingSource bindingSource = new BindingSource();

            DataSet dataSet = new DataSet();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // Araçlar tablosundaki tüm verileri al
                string query = "SELECT * FROM araclar";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                adapter.Fill(dataSet, "Araclar");
            }

            // Araçlar tablosunu DataGridView'e bağla
            bindingSource.DataSource = dataSet.Tables["Araclar"];
            dataGridView1.DataSource = bindingSource;

            // Bekleyen onaylar için sorgu yap
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // Satis_onay tablosuyla araclar tablosunu birleştir
                string query = "SELECT   so.AdSoyad,so.TelNo,a.marka, so.Adres, a.plaka,  a.model, a.yakit_tipi, a.tramer_kaydi,so.AracId, a.km, a.fiyat " +
                   "FROM satis_onay so " +
                   "INNER JOIN araclar a ON so.AracID = a.id " +
                   "WHERE so.OnayDurumu = 'Beklemede'";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                adapter.Fill(dataSet, "OnayBekleyenAraclar");
            }

            // Bekleyen onaylar için DataGridView'e bağla
            dataGridOktay.DataSource = dataSet.Tables["OnayBekleyenAraclar"];

        }

        private void LoadUyeler()
        {
            // Veri bağlama kaynağı oluşturdum
            BindingSource bindingSource = new BindingSource();

            // Veri seti oluşturdum ve uyeler tablosunu doldurdum
            DataSet dataSet = new DataSet();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM uyeler";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                adapter.Fill(dataSet, "Uyeler");
            }

            // Veri bağlama kaynağına veri setini ve uygun tabloya bagladim.
            bindingSource.DataSource = dataSet.Tables["Uyeler"];

            // DataGridView nesnesini veri bağlamaya kısmına bağladım.
            dataGridView2_admin.DataSource = bindingSource;
        }




        private void ekle_button3_Click(object sender, EventArgs e)
        {
            // Veritabanına bağlantı kur
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string insertQuery = "INSERT INTO araclar (plaka, marka, model, yakit_tipi, tramer_kaydi, km, fiyat) VALUES (@plaka, @marka, @model, @yakitTipi, @tramerKaydi, @km, @fiyat)";

                using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                {

                    command.Parameters.AddWithValue("@plaka", plaka_textBox1.Text);
                    command.Parameters.AddWithValue("@marka", marka_textBox2.Text);
                    command.Parameters.AddWithValue("@model", model_textBox3.Text);
                    command.Parameters.AddWithValue("@yakitTipi", yakit_tipi_comboBox1.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@tramerKaydi", tramer_comboBox1.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@km", Convert.ToInt32(km_textBox1.Text));
                    command.Parameters.AddWithValue("@fiyat", Convert.ToDecimal(fiyat_textBox1.Text));


                    // Bağlantıyı aç ve sorguyu çalıştır
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            LoadAddedAraclar();
            MessageBox.Show("Araç başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadUyeler(); // Yeniden yükleme
        }



        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

                plaka_textBox1.Text = selectedRow.Cells["plaka"].Value.ToString();
                marka_textBox2.Text = selectedRow.Cells["marka"].Value.ToString();
                model_textBox3.Text = selectedRow.Cells["model"].Value.ToString();
                yakit_tipi_comboBox1.SelectedItem = selectedRow.Cells["yakit_tipi"].Value.ToString();
                tramer_comboBox1.SelectedItem = selectedRow.Cells["tramer_kaydi"].Value.ToString();
                km_textBox1.Text = selectedRow.Cells["km"].Value.ToString();
                fiyat_textBox1.Text = selectedRow.Cells["fiyat"].Value.ToString();
                dataGridView1.Columns["durum"].Visible = false;
                dataGridView1.Columns["resimyolu"].Visible = false;
                // kullanıcı resim yüklemesi için sütunu ekleyip burada resmi yükleyebilir.

            }
        }

        private void guncelle_button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

                // Seçili satırın araç ID sini al
                int aracId = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                // Veritabanına bağlantı kur
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string updateQuery = "UPDATE araclar SET plaka = @plaka, marka = @marka, model = @model, yakit_tipi = @yakitTipi, tramer_kaydi = @tramerKaydi, km = @km, fiyat = @fiyat WHERE ID = @aracId";

                    using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                    {

                        command.Parameters.AddWithValue("@plaka", plaka_textBox1.Text);
                        command.Parameters.AddWithValue("@marka", marka_textBox2.Text);
                        command.Parameters.AddWithValue("@model", model_textBox3.Text);
                        command.Parameters.AddWithValue("@yakitTipi", yakit_tipi_comboBox1.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@tramerKaydi", tramer_comboBox1.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@km", Convert.ToInt32(km_textBox1.Text));
                        command.Parameters.AddWithValue("@fiyat", Convert.ToDecimal(fiyat_textBox1.Text));
                        command.Parameters.AddWithValue("@aracId", aracId);

                        // Bağlantıyı aç ve sorguyu çalıştır
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Araç başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUyeler(); // Yeniden yükleme
                LoadAddedAraclar();
            }
        }

        private void sil_button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                if (MessageBox.Show("Seçili aracı silmek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

                    // Seçili satırın araç ID sini al
                    int aracId = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                    // Veritabanına bağlantı kur
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        string deleteQuery = "DELETE FROM araclar WHERE ID = @aracId";

                        using (MySqlCommand command = new MySqlCommand(deleteQuery, connection))
                        {
                            // Parametre olarak araç ID sini ekledim
                            command.Parameters.AddWithValue("@aracId", aracId);

                            // Bağlantıyı aç ve sorguyu çalıştır
                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Araç başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUyeler(); // Yeniden yükleme
                    LoadAddedAraclar();
                }
            }
        }

        private void temizle_button_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void ClearControls()
        {
            plaka_textBox1.Clear();
            marka_textBox2.Clear();
            model_textBox3.Clear();
            yakit_tipi_comboBox1.SelectedIndex = -1;
            tramer_comboBox1.SelectedIndex = -1;
            km_textBox1.Clear();
            fiyat_textBox1.Clear();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridOktay.SelectedCells.Count > 0)
            {
                if (MessageBox.Show("Seçili aracı satışa çıkarmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int selectedRowIndex = dataGridOktay.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridOktay.Rows[selectedRowIndex];

                    // Seçili satırın araç ve satıcı bilgilerini al
                    string adSoyad = selectedRow.Cells["AdSoyad"].Value.ToString();
                    string telNo = selectedRow.Cells["TelNo"].Value.ToString();
                    string adres = selectedRow.Cells["Adres"].Value.ToString();
                    string marka = selectedRow.Cells["marka"].Value.ToString();
                    string model = selectedRow.Cells["model"].Value.ToString();
                    int aracId = Convert.ToInt32(selectedRow.Cells["AracId"].Value); // Buradaki "AracID" alanını kontrol et!

                    // Satışı yap ve fatura göster
                    string fatura = $"Araç Markası: {marka}\nModeli: {model}\nAlıcı Adı Soyadı: {adSoyad}\nTelefon Numarası: {telNo}\nAdres: {adres}";
                    MessageBox.Show(fatura, "Satış Faturası", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Seçili satışı onay tablosundan ve ana araç tablosundan sil
                    OnayBekleyenAracSil(aracId);
                    AnaAracSil(aracId);

                    // DataGridView'i yeniden yükle
                    LoadAddedAraclar();
                    LoadUyeler();
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir araç seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void OnayBekleyenAracSil(int aracId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string deleteQuery = "DELETE FROM satis_onay WHERE AracId = @aracId"; // Buradaki "AracID" alanını kontrol et!

                using (MySqlCommand command = new MySqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@aracId", aracId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private void AnaAracSil(int aracId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string deleteQuery = "DELETE FROM araclar WHERE id = @aracId"; // Buradaki "id" alanını kontrol et!

                using (MySqlCommand command = new MySqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@aracId", aracId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dataGridOktay.SelectedCells.Count > 0)
            {
                if (MessageBox.Show("Seçili aracın satışını iptal etmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int selectedRowIndex = dataGridOktay.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridOktay.Rows[selectedRowIndex];

                    // Seçili satırın araç ID'sini al
                    int aracId = Convert.ToInt32(selectedRow.Cells["AracID"].Value);

                    // Veritabanına bağlantı kur
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        string deleteQuery = "DELETE FROM satis_onay WHERE AracID = @aracId";

                        using (MySqlCommand command = new MySqlCommand(deleteQuery, connection))
                        {
                            // Parametre olarak araç ID'sini ekleyin
                            command.Parameters.AddWithValue("@aracId", aracId);

                            // Bağlantıyı aç ve sorguyu çalıştır
                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Satış başarıyla iptal edildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAddedAraclar();
                }
            }
        }
    }


}
    

