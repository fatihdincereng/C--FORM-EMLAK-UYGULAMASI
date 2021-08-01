
namespace Emlak_Otomasyonu_v2
{
    partial class konutdüzenle
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
            this.MüsteriID = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.il2 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.kaydet = new System.Windows.Forms.Button();
            this.adres = new System.Windows.Forms.RichTextBox();
            this.ilce = new System.Windows.Forms.ComboBox();
            this.odasayisi = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.durum = new System.Windows.Forms.ComboBox();
            this.aktiflik = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.fiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.metrekare = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MüsteriID
            // 
            this.MüsteriID.Location = new System.Drawing.Point(171, 71);
            this.MüsteriID.Name = "MüsteriID";
            this.MüsteriID.ReadOnly = true;
            this.MüsteriID.Size = new System.Drawing.Size(121, 20);
            this.MüsteriID.TabIndex = 98;
            this.MüsteriID.TextChanged += new System.EventHandler(this.MüsteriID_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(168, 55);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 13);
            this.label20.TabIndex = 97;
            this.label20.Text = "Müşteri ID";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // il2
            // 
            this.il2.FormattingEnabled = true;
            this.il2.Location = new System.Drawing.Point(171, 116);
            this.il2.Name = "il2";
            this.il2.Size = new System.Drawing.Size(121, 21);
            this.il2.TabIndex = 96;
            this.il2.SelectedIndexChanged += new System.EventHandler(this.il2_SelectedIndexChanged);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Evet",
            "Hayir"});
            this.comboBox4.Location = new System.Drawing.Point(536, 118);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 95;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Evet",
            "Hayir"});
            this.comboBox3.Location = new System.Drawing.Point(536, 163);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 94;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Evet",
            "Hayir"});
            this.comboBox1.Location = new System.Drawing.Point(536, 206);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 93;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(456, 345);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 36);
            this.button3.TabIndex = 92;
            this.button3.Text = "Ana Sayfa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // kaydet
            // 
            this.kaydet.Location = new System.Drawing.Point(560, 345);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(98, 36);
            this.kaydet.TabIndex = 90;
            this.kaydet.Text = "Kaydet";
            this.kaydet.UseVisualStyleBackColor = true;
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(171, 216);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(192, 97);
            this.adres.TabIndex = 89;
            this.adres.Text = "";
            this.adres.TextChanged += new System.EventHandler(this.adres_TextChanged);
            // 
            // ilce
            // 
            this.ilce.FormattingEnabled = true;
            this.ilce.Location = new System.Drawing.Point(171, 168);
            this.ilce.Name = "ilce";
            this.ilce.Size = new System.Drawing.Size(121, 21);
            this.ilce.TabIndex = 88;
            this.ilce.SelectedIndexChanged += new System.EventHandler(this.ilce_SelectedIndexChanged);
            // 
            // odasayisi
            // 
            this.odasayisi.FormattingEnabled = true;
            this.odasayisi.Items.AddRange(new object[] {
            "1+0",
            "1+1",
            "2+0",
            "2+1",
            "3+0",
            "3+1",
            "3+2",
            "4+1",
            "4+2",
            "4+3"});
            this.odasayisi.Location = new System.Drawing.Point(17, 205);
            this.odasayisi.Name = "odasayisi";
            this.odasayisi.Size = new System.Drawing.Size(121, 21);
            this.odasayisi.TabIndex = 87;
            this.odasayisi.SelectedIndexChanged += new System.EventHandler(this.odasayisi_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DisplayMember = "AdiSoyadi";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(17, 71);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 86;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // durum
            // 
            this.durum.FormattingEnabled = true;
            this.durum.Items.AddRange(new object[] {
            "Satilik",
            "Kiralik"});
            this.durum.Location = new System.Drawing.Point(17, 163);
            this.durum.Name = "durum";
            this.durum.Size = new System.Drawing.Size(121, 21);
            this.durum.TabIndex = 85;
            this.durum.SelectedIndexChanged += new System.EventHandler(this.durum_SelectedIndexChanged);
            // 
            // aktiflik
            // 
            this.aktiflik.FormattingEnabled = true;
            this.aktiflik.Items.AddRange(new object[] {
            "Aktif",
            "Pasif"});
            this.aktiflik.Location = new System.Drawing.Point(17, 117);
            this.aktiflik.Name = "aktiflik";
            this.aktiflik.Size = new System.Drawing.Size(121, 21);
            this.aktiflik.TabIndex = 84;
            this.aktiflik.SelectedIndexChanged += new System.EventHandler(this.aktiflik_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(401, 293);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 83;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(14, 55);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 13);
            this.label19.TabIndex = 82;
            this.label19.Text = "Konut Sahibi";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(398, 277);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 13);
            this.label18.TabIndex = 81;
            this.label18.Text = "Kayıt Tarihi";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(533, 190);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 13);
            this.label17.TabIndex = 80;
            this.label17.Text = "Krediye Uygun";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(533, 145);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(25, 13);
            this.label16.TabIndex = 79;
            this.label16.Text = "Site";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(533, 102);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 78;
            this.label15.Text = "Eşyalı";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(536, 250);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(121, 20);
            this.textBox14.TabIndex = 77;
            this.textBox14.TextChanged += new System.EventHandler(this.textBox14_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(533, 234);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 76;
            this.label14.Text = "Balkon";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(401, 250);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 20);
            this.textBox13.TabIndex = 75;
            this.textBox13.TextChanged += new System.EventHandler(this.textBox13_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(398, 234);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 74;
            this.label13.Text = "Banyo";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(401, 206);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 73;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(398, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 72;
            this.label7.Text = "Kat Sayısı";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(401, 163);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 71;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(398, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 70;
            this.label8.Text = "Kat";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(401, 118);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 69;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(398, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 68;
            this.label9.Text = "Bina Yaşı";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(168, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 67;
            this.label10.Text = "Adres";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(168, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 66;
            this.label11.Text = "İlçe";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(168, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 13);
            this.label12.TabIndex = 65;
            this.label12.Text = "İl";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // fiyat
            // 
            this.fiyat.Location = new System.Drawing.Point(17, 293);
            this.fiyat.Name = "fiyat";
            this.fiyat.Size = new System.Drawing.Size(121, 20);
            this.fiyat.TabIndex = 64;
            this.fiyat.TextChanged += new System.EventHandler(this.fiyat_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "Fiyat";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // metrekare
            // 
            this.metrekare.Location = new System.Drawing.Point(17, 250);
            this.metrekare.Name = "metrekare";
            this.metrekare.Size = new System.Drawing.Size(121, 20);
            this.metrekare.TabIndex = 62;
            this.metrekare.TextChanged += new System.EventHandler(this.metrekare_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "Metre Kare";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Oda Sayısı";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Durum";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Aktiflik";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 57;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Konut ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // konutdüzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 393);
            this.Controls.Add(this.MüsteriID);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.il2);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.kaydet);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.ilce);
            this.Controls.Add(this.odasayisi);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.durum);
            this.Controls.Add(this.aktiflik);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.fiyat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.metrekare);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "konutdüzenle";
            this.Text = "Konut Düzenleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MüsteriID;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox il2;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button kaydet;
        private System.Windows.Forms.RichTextBox adres;
        private System.Windows.Forms.ComboBox ilce;
        private System.Windows.Forms.ComboBox odasayisi;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox durum;
        private System.Windows.Forms.ComboBox aktiflik;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox fiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox metrekare;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}