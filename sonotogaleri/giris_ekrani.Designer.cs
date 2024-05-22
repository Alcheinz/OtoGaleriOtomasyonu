namespace Otogaleriotomasyon
{
    partial class giris_ekrani
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giris_ekrani));
            label1 = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button2 = new Button();
            groupBox3 = new GroupBox();
            button3 = new Button();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 25.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ControlDark;
            label1.Location = new Point(193, 61);
            label1.Name = "label1";
            label1.Size = new Size(409, 52);
            label1.TabIndex = 0;
            label1.Text = "Oto Galeri Otomasyonu";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlDark;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Font = new Font("Lucida Sans Unicode", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(12, 155);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(253, 169);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Admin Girişi";
            // 
            // button1
            // 
            button1.Location = new Point(64, 115);
            button1.Name = "button1";
            button1.Size = new Size(122, 29);
            button1.TabIndex = 2;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(52, 74);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.PlaceholderText = "Şifre";
            textBox2.Size = new Size(148, 35);
            textBox2.TabIndex = 1;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Lucida Sans Unicode", 10F);
            textBox1.Location = new Point(52, 35);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Kullanıcı Adı";
            textBox1.Size = new Size(148, 33);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(button2);
            groupBox2.Font = new Font("Lucida Sans Unicode", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(271, 155);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(264, 169);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Müşteri Girişi";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(58, 74);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.PlaceholderText = "Şifre";
            textBox3.Size = new Size(148, 35);
            textBox3.TabIndex = 4;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Lucida Sans Unicode", 10F);
            textBox4.Location = new Point(58, 35);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Kullanıcı Adı";
            textBox4.Size = new Size(148, 33);
            textBox4.TabIndex = 3;
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // button2
            // 
            button2.Location = new Point(70, 115);
            button2.Name = "button2";
            button2.Size = new Size(122, 29);
            button2.TabIndex = 5;
            button2.Text = "Giriş Yap";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(textBox5);
            groupBox3.Controls.Add(textBox6);
            groupBox3.Font = new Font("Lucida Sans Unicode", 11F);
            groupBox3.Location = new Point(541, 155);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(247, 169);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Müşteri Ol";
            // 
            // button3
            // 
            button3.Font = new Font("Lucida Sans Unicode", 10.8F);
            button3.Location = new Point(64, 115);
            button3.Name = "button3";
            button3.Size = new Size(122, 29);
            button3.TabIndex = 8;
            button3.Text = "Kayıt Ol";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(51, 73);
            textBox5.Name = "textBox5";
            textBox5.PasswordChar = '*';
            textBox5.PlaceholderText = "Şifre";
            textBox5.Size = new Size(148, 36);
            textBox5.TabIndex = 7;
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Lucida Sans Unicode", 10F);
            textBox6.Location = new Point(51, 34);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Kullanıcı Adı";
            textBox6.Size = new Size(148, 33);
            textBox6.TabIndex = 6;
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // giris_ekrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "giris_ekrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mersin Oto Galeri Otomasyonu";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button2;
        private Button button3;
        private TextBox textBox5;
        private TextBox textBox6;
    }
}
