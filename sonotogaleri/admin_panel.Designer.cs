namespace Otogaleriotomasyon
{
    partial class admin_panel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_panel));
            groupBox1 = new GroupBox();
            satis = new Button();
            dataGridOktay = new DataGridView();
            label8 = new Label();
            temizle_button = new Button();
            dataGridView1 = new DataGridView();
            ekle_button3 = new Button();
            guncelle_button2 = new Button();
            sil_button1 = new Button();
            yakit_tipi_comboBox1 = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            fiyat_textBox1 = new TextBox();
            km_textBox1 = new TextBox();
            tramer_comboBox1 = new ComboBox();
            model_textBox3 = new TextBox();
            marka_textBox2 = new TextBox();
            plaka_textBox1 = new TextBox();
            label1 = new Label();
            uye_groupBox2 = new GroupBox();
            dataGridView2_admin = new DataGridView();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridOktay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            uye_groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2_admin).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = SystemColors.ControlDark;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(satis);
            groupBox1.Controls.Add(dataGridOktay);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(temizle_button);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(ekle_button3);
            groupBox1.Controls.Add(guncelle_button2);
            groupBox1.Controls.Add(sil_button1);
            groupBox1.Controls.Add(yakit_tipi_comboBox1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(fiyat_textBox1);
            groupBox1.Controls.Add(km_textBox1);
            groupBox1.Controls.Add(tramer_comboBox1);
            groupBox1.Controls.Add(model_textBox3);
            groupBox1.Controls.Add(marka_textBox2);
            groupBox1.Controls.Add(plaka_textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Lucida Sans Unicode", 10F);
            groupBox1.ImeMode = ImeMode.Off;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(924, 799);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Araç İşlemleri";
            // 
            // satis
            // 
            satis.Location = new Point(578, 538);
            satis.Name = "satis";
            satis.Size = new Size(150, 29);
            satis.TabIndex = 25;
            satis.Text = "Satışı Onayla";
            satis.UseVisualStyleBackColor = true;
            satis.Click += button1_Click;
            // 
            // dataGridOktay
            // 
            dataGridOktay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridOktay.Location = new Point(6, 572);
            dataGridOktay.Name = "dataGridOktay";
            dataGridOktay.RowHeadersWidth = 51;
            dataGridOktay.Size = new Size(885, 221);
            dataGridOktay.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 538);
            label8.Name = "label8";
            label8.Size = new Size(244, 21);
            label8.TabIndex = 23;
            label8.Text = "Satış Onayı Bekleyen Araçlar";
            label8.Click += label8_Click;
            // 
            // temizle_button
            // 
            temizle_button.Font = new Font("Lucida Sans Unicode", 9F);
            temizle_button.Location = new Point(225, 257);
            temizle_button.Name = "temizle_button";
            temizle_button.Size = new Size(142, 29);
            temizle_button.TabIndex = 22;
            temizle_button.Text = "Alanları Temizle";
            temizle_button.UseVisualStyleBackColor = true;
            temizle_button.Click += temizle_button_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 299);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(912, 221);
            dataGridView1.TabIndex = 19;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // ekle_button3
            // 
            ekle_button3.ForeColor = Color.LimeGreen;
            ekle_button3.Location = new Point(273, 182);
            ekle_button3.Name = "ekle_button3";
            ekle_button3.Size = new Size(94, 29);
            ekle_button3.TabIndex = 18;
            ekle_button3.Text = "Ekle";
            ekle_button3.UseVisualStyleBackColor = true;
            ekle_button3.Click += ekle_button3_Click;
            // 
            // guncelle_button2
            // 
            guncelle_button2.ForeColor = Color.DodgerBlue;
            guncelle_button2.Location = new Point(273, 109);
            guncelle_button2.Name = "guncelle_button2";
            guncelle_button2.Size = new Size(94, 29);
            guncelle_button2.TabIndex = 17;
            guncelle_button2.Text = "Güncelle";
            guncelle_button2.UseVisualStyleBackColor = true;
            guncelle_button2.Click += guncelle_button2_Click;
            // 
            // sil_button1
            // 
            sil_button1.ForeColor = Color.Red;
            sil_button1.Location = new Point(273, 40);
            sil_button1.Name = "sil_button1";
            sil_button1.Size = new Size(94, 29);
            sil_button1.TabIndex = 16;
            sil_button1.Text = "Sil";
            sil_button1.UseVisualStyleBackColor = true;
            sil_button1.Click += sil_button1_Click;
            // 
            // yakit_tipi_comboBox1
            // 
            yakit_tipi_comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            yakit_tipi_comboBox1.FormattingEnabled = true;
            yakit_tipi_comboBox1.Items.AddRange(new object[] { "Benzin", "Dizel", "Benzin + LPG" });
            yakit_tipi_comboBox1.Location = new Point(94, 153);
            yakit_tipi_comboBox1.Name = "yakit_tipi_comboBox1";
            yakit_tipi_comboBox1.Size = new Size(125, 29);
            yakit_tipi_comboBox1.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 265);
            label7.Name = "label7";
            label7.Size = new Size(49, 21);
            label7.TabIndex = 14;
            label7.Text = "Fiyat";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 226);
            label6.Name = "label6";
            label6.Size = new Size(36, 21);
            label6.TabIndex = 13;
            label6.Text = "KM";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Sans Unicode", 7F);
            label5.Location = new Point(6, 195);
            label5.Name = "label5";
            label5.Size = new Size(86, 16);
            label5.TabIndex = 12;
            label5.Text = "Tramer Kaydı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Sans Unicode", 9.5F);
            label4.Location = new Point(6, 156);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 11;
            label4.Text = "Yakıt Tipi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 117);
            label3.Name = "label3";
            label3.Size = new Size(62, 21);
            label3.TabIndex = 10;
            label3.Text = "Model";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 78);
            label2.Name = "label2";
            label2.Size = new Size(62, 21);
            label2.TabIndex = 9;
            label2.Text = "Marka";
            // 
            // fiyat_textBox1
            // 
            fiyat_textBox1.Location = new Point(94, 262);
            fiyat_textBox1.Name = "fiyat_textBox1";
            fiyat_textBox1.Size = new Size(125, 33);
            fiyat_textBox1.TabIndex = 8;
            // 
            // km_textBox1
            // 
            km_textBox1.Location = new Point(94, 223);
            km_textBox1.Name = "km_textBox1";
            km_textBox1.Size = new Size(125, 33);
            km_textBox1.TabIndex = 7;
            // 
            // tramer_comboBox1
            // 
            tramer_comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            tramer_comboBox1.FormattingEnabled = true;
            tramer_comboBox1.Items.AddRange(new object[] { "Var", "Yok", "Belki" });
            tramer_comboBox1.Location = new Point(94, 188);
            tramer_comboBox1.Name = "tramer_comboBox1";
            tramer_comboBox1.Size = new Size(125, 29);
            tramer_comboBox1.TabIndex = 6;
            // 
            // model_textBox3
            // 
            model_textBox3.Location = new Point(94, 114);
            model_textBox3.Name = "model_textBox3";
            model_textBox3.Size = new Size(125, 33);
            model_textBox3.TabIndex = 4;
            // 
            // marka_textBox2
            // 
            marka_textBox2.Location = new Point(94, 75);
            marka_textBox2.Name = "marka_textBox2";
            marka_textBox2.Size = new Size(125, 33);
            marka_textBox2.TabIndex = 3;
            // 
            // plaka_textBox1
            // 
            plaka_textBox1.Location = new Point(94, 36);
            plaka_textBox1.Name = "plaka_textBox1";
            plaka_textBox1.Size = new Size(125, 33);
            plaka_textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 39);
            label1.Name = "label1";
            label1.Size = new Size(54, 21);
            label1.TabIndex = 1;
            label1.Text = "Plaka";
            // 
            // uye_groupBox2
            // 
            uye_groupBox2.Controls.Add(dataGridView2_admin);
            uye_groupBox2.Font = new Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uye_groupBox2.Location = new Point(385, 12);
            uye_groupBox2.Name = "uye_groupBox2";
            uye_groupBox2.Size = new Size(551, 295);
            uye_groupBox2.TabIndex = 1;
            uye_groupBox2.TabStop = false;
            uye_groupBox2.Text = "Üye Listesi";
            // 
            // dataGridView2_admin
            // 
            dataGridView2_admin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2_admin.Location = new Point(6, 27);
            dataGridView2_admin.Name = "dataGridView2_admin";
            dataGridView2_admin.RowHeadersWidth = 51;
            dataGridView2_admin.Size = new Size(539, 262);
            dataGridView2_admin.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(737, 538);
            button1.Name = "button1";
            button1.Size = new Size(154, 29);
            button1.TabIndex = 26;
            button1.Text = "Satış İptali";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // admin_panel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(948, 823);
            Controls.Add(uye_groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "admin_panel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Oto Galeri Admin Panel";
            Load += admin_panel_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridOktay).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            uye_groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2_admin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox plaka_textBox1;
        private Label label1;
        private TextBox model_textBox3;
        private TextBox marka_textBox2;
        private ComboBox tramer_comboBox1;
        private TextBox fiyat_textBox1;
        private TextBox km_textBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox yakit_tipi_comboBox1;
        private Button ekle_button3;
        private Button guncelle_button2;
        private Button sil_button1;
        private GroupBox uye_groupBox2;
        private DataGridView dataGridView2_admin;
        private Button temizle_button;
        private DataGridView dataGridView1;
        private Label label8;
        private DataGridView dataGridOktay;
        private Button satis;
        private Button button1;
    }
}