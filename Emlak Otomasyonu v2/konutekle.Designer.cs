
namespace Emlak_Otomasyonu_v2
{
    partial class konutekle
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.konutıd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.metrekare = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.katsayisi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.kat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.binayasi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.banyo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.balkon = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.aktiflik = new System.Windows.Forms.ComboBox();
            this.durum = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.müsterilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emlakOtoDBDataSet3 = new Emlak_Otomasyonu_v2.EmlakOtoDBDataSet3();
            this.odasayisi = new System.Windows.Forms.ComboBox();
            this.ilce = new System.Windows.Forms.ComboBox();
            this.adres = new System.Windows.Forms.RichTextBox();
            this.kaydet = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.krediyeuygun = new System.Windows.Forms.ComboBox();
            this.site = new System.Windows.Forms.ComboBox();
            this.esyali = new System.Windows.Forms.ComboBox();
            this.illerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.il2 = new System.Windows.Forms.ComboBox();
            this.müsterilerTableAdapter = new Emlak_Otomasyonu_v2.EmlakOtoDBDataSet3TableAdapters.müsterilerTableAdapter();
            this.label20 = new System.Windows.Forms.Label();
            this.MüsteriID = new System.Windows.Forms.TextBox();
            this.illerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.illerTableAdapter1 = new Emlak_Otomasyonu_v2.EmlakOtoDBDataSet3TableAdapters.illerTableAdapter();
            this.emlakOtoDBDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.illerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ilcelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ilcelerTableAdapter = new Emlak_Otomasyonu_v2.EmlakOtoDBDataSet3TableAdapters.ilcelerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.müsterilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emlakOtoDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.illerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.illerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emlakOtoDBDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.illerBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilcelerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Konut ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // konutıd
            // 
            this.konutıd.Location = new System.Drawing.Point(16, 32);
            this.konutıd.Name = "konutıd";
            this.konutıd.ReadOnly = true;
            this.konutıd.Size = new System.Drawing.Size(121, 20);
            this.konutıd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Aktiflik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Oda Sayısı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Durum";
            // 
            // fiyat
            // 
            this.fiyat.Location = new System.Drawing.Point(16, 293);
            this.fiyat.Name = "fiyat";
            this.fiyat.Size = new System.Drawing.Size(121, 20);
            this.fiyat.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fiyat";
            // 
            // metrekare
            // 
            this.metrekare.Location = new System.Drawing.Point(16, 250);
            this.metrekare.Name = "metrekare";
            this.metrekare.Size = new System.Drawing.Size(121, 20);
            this.metrekare.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Metre Kare";
            // 
            // katsayisi
            // 
            this.katsayisi.Location = new System.Drawing.Point(400, 206);
            this.katsayisi.Name = "katsayisi";
            this.katsayisi.Size = new System.Drawing.Size(100, 20);
            this.katsayisi.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(397, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Kat Sayısı";
            // 
            // kat
            // 
            this.kat.Location = new System.Drawing.Point(400, 163);
            this.kat.Name = "kat";
            this.kat.Size = new System.Drawing.Size(100, 20);
            this.kat.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(397, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Kat";
            // 
            // binayasi
            // 
            this.binayasi.Location = new System.Drawing.Point(400, 118);
            this.binayasi.Name = "binayasi";
            this.binayasi.Size = new System.Drawing.Size(100, 20);
            this.binayasi.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(397, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Bina Yaşı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(167, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Adres";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(167, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "İlçe";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(167, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "İl";
            // 
            // banyo
            // 
            this.banyo.Location = new System.Drawing.Point(400, 250);
            this.banyo.Name = "banyo";
            this.banyo.Size = new System.Drawing.Size(100, 20);
            this.banyo.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(397, 234);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Banyo";
            // 
            // balkon
            // 
            this.balkon.Location = new System.Drawing.Point(535, 250);
            this.balkon.Name = "balkon";
            this.balkon.Size = new System.Drawing.Size(121, 20);
            this.balkon.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(532, 234);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Balkon";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(532, 102);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "Eşyalı";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(532, 145);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(25, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Site";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(532, 190);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 13);
            this.label17.TabIndex = 32;
            this.label17.Text = "Krediye Uygun";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(397, 277);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 13);
            this.label18.TabIndex = 34;
            this.label18.Text = "Kayıt Tarihi";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(13, 55);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 13);
            this.label19.TabIndex = 36;
            this.label19.Text = "Konut Sahibi";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(400, 293);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 38;
            // 
            // aktiflik
            // 
            this.aktiflik.FormattingEnabled = true;
            this.aktiflik.Items.AddRange(new object[] {
            "Aktif",
            "Pasif"});
            this.aktiflik.Location = new System.Drawing.Point(16, 117);
            this.aktiflik.Name = "aktiflik";
            this.aktiflik.Size = new System.Drawing.Size(121, 21);
            this.aktiflik.TabIndex = 39;
            // 
            // durum
            // 
            this.durum.FormattingEnabled = true;
            this.durum.Items.AddRange(new object[] {
            "Satilik",
            "Kiralik"});
            this.durum.Location = new System.Drawing.Point(16, 163);
            this.durum.Name = "durum";
            this.durum.Size = new System.Drawing.Size(121, 21);
            this.durum.TabIndex = 40;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.müsterilerBindingSource;
            this.comboBox2.DisplayMember = "AdiSoyadi";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(16, 71);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 41;
            // 
            // müsterilerBindingSource
            // 
            this.müsterilerBindingSource.DataMember = "müsteriler";
            this.müsterilerBindingSource.DataSource = this.emlakOtoDBDataSet3;
            // 
            // emlakOtoDBDataSet3
            // 
            this.emlakOtoDBDataSet3.DataSetName = "EmlakOtoDBDataSet3";
            this.emlakOtoDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.odasayisi.Location = new System.Drawing.Point(16, 205);
            this.odasayisi.Name = "odasayisi";
            this.odasayisi.Size = new System.Drawing.Size(121, 21);
            this.odasayisi.TabIndex = 42;
            // 
            // ilce
            // 
            this.ilce.FormattingEnabled = true;
            this.ilce.Location = new System.Drawing.Point(170, 168);
            this.ilce.Name = "ilce";
            this.ilce.Size = new System.Drawing.Size(121, 21);
            this.ilce.TabIndex = 44;
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(170, 216);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(192, 97);
            this.adres.TabIndex = 45;
            this.adres.Text = "";
            // 
            // kaydet
            // 
            this.kaydet.Location = new System.Drawing.Point(246, 329);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(98, 36);
            this.kaydet.TabIndex = 46;
            this.kaydet.Text = "Kaydet";
            this.kaydet.UseVisualStyleBackColor = true;
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(350, 329);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 36);
            this.button3.TabIndex = 48;
            this.button3.Text = "Ana Sayfa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // krediyeuygun
            // 
            this.krediyeuygun.FormattingEnabled = true;
            this.krediyeuygun.Items.AddRange(new object[] {
            "Evet",
            "Hayir"});
            this.krediyeuygun.Location = new System.Drawing.Point(535, 206);
            this.krediyeuygun.Name = "krediyeuygun";
            this.krediyeuygun.Size = new System.Drawing.Size(121, 21);
            this.krediyeuygun.TabIndex = 49;
            // 
            // site
            // 
            this.site.FormattingEnabled = true;
            this.site.Items.AddRange(new object[] {
            "Evet",
            "Hayir"});
            this.site.Location = new System.Drawing.Point(535, 163);
            this.site.Name = "site";
            this.site.Size = new System.Drawing.Size(121, 21);
            this.site.TabIndex = 50;
            // 
            // esyali
            // 
            this.esyali.FormattingEnabled = true;
            this.esyali.Items.AddRange(new object[] {
            "Evet",
            "Hayir"});
            this.esyali.Location = new System.Drawing.Point(535, 118);
            this.esyali.Name = "esyali";
            this.esyali.Size = new System.Drawing.Size(121, 21);
            this.esyali.TabIndex = 51;
            // 
            // illerBindingSource
            // 
            this.illerBindingSource.DataMember = "iller";
            // 
            // il2
            // 
            this.il2.FormattingEnabled = true;
            this.il2.Location = new System.Drawing.Point(170, 116);
            this.il2.Name = "il2";
            this.il2.Size = new System.Drawing.Size(121, 21);
            this.il2.TabIndex = 52;
            this.il2.SelectedIndexChanged += new System.EventHandler(this.il2_SelectedIndexChanged_1);
            // 
            // müsterilerTableAdapter
            // 
            this.müsterilerTableAdapter.ClearBeforeFill = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(167, 55);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 13);
            this.label20.TabIndex = 54;
            this.label20.Text = "Müşteri ID";
            // 
            // MüsteriID
            // 
            this.MüsteriID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.müsterilerBindingSource, "MusteriID", true));
            this.MüsteriID.Location = new System.Drawing.Point(170, 71);
            this.MüsteriID.Name = "MüsteriID";
            this.MüsteriID.ReadOnly = true;
            this.MüsteriID.Size = new System.Drawing.Size(121, 20);
            this.MüsteriID.TabIndex = 55;
            // 
            // illerBindingSource1
            // 
            this.illerBindingSource1.DataMember = "iller";
            this.illerBindingSource1.DataSource = this.emlakOtoDBDataSet3;
            // 
            // illerTableAdapter1
            // 
            this.illerTableAdapter1.ClearBeforeFill = true;
            // 
            // emlakOtoDBDataSet3BindingSource
            // 
            this.emlakOtoDBDataSet3BindingSource.DataSource = this.emlakOtoDBDataSet3;
            this.emlakOtoDBDataSet3BindingSource.Position = 0;
            // 
            // illerBindingSource2
            // 
            this.illerBindingSource2.DataMember = "iller";
            this.illerBindingSource2.DataSource = this.emlakOtoDBDataSet3BindingSource;
            // 
            // ilcelerBindingSource
            // 
            this.ilcelerBindingSource.DataMember = "ilceler";
            this.ilcelerBindingSource.DataSource = this.emlakOtoDBDataSet3BindingSource;
            // 
            // ilcelerTableAdapter
            // 
            this.ilcelerTableAdapter.ClearBeforeFill = true;
            // 
            // konutekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 404);
            this.Controls.Add(this.MüsteriID);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.il2);
            this.Controls.Add(this.esyali);
            this.Controls.Add(this.site);
            this.Controls.Add(this.krediyeuygun);
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
            this.Controls.Add(this.balkon);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.banyo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.katsayisi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.kat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.binayasi);
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
            this.Controls.Add(this.konutıd);
            this.Controls.Add(this.label1);
            this.Name = "konutekle";
            this.Text = "Konut Ekleme";
            this.Load += new System.EventHandler(this.konutekle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.müsterilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emlakOtoDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.illerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.illerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emlakOtoDBDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.illerBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilcelerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox konutıd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox metrekare;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox katsayisi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox kat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox binayasi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox banyo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox balkon;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox aktiflik;
        private System.Windows.Forms.ComboBox durum;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox odasayisi;
        private System.Windows.Forms.ComboBox ilce;
        private System.Windows.Forms.RichTextBox adres;
        private System.Windows.Forms.Button kaydet;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox krediyeuygun;
        private System.Windows.Forms.ComboBox site;
        private System.Windows.Forms.ComboBox esyali;
       // private EmlakOtoDBDataSet2 emlakOtoDBDataSet2;
        private System.Windows.Forms.BindingSource illerBindingSource;
       // private EmlakOtoDBDataSet2TableAdapters.illerTableAdapter illerTableAdapter;
        private System.Windows.Forms.ComboBox il2;
        private EmlakOtoDBDataSet3 emlakOtoDBDataSet3;
        private System.Windows.Forms.BindingSource müsterilerBindingSource;
        private EmlakOtoDBDataSet3TableAdapters.müsterilerTableAdapter müsterilerTableAdapter;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox MüsteriID;
        private System.Windows.Forms.BindingSource illerBindingSource1;
        private EmlakOtoDBDataSet3TableAdapters.illerTableAdapter illerTableAdapter1;
        private System.Windows.Forms.BindingSource illerBindingSource2;
        private System.Windows.Forms.BindingSource emlakOtoDBDataSet3BindingSource;
        private System.Windows.Forms.BindingSource ilcelerBindingSource;
        private EmlakOtoDBDataSet3TableAdapters.ilcelerTableAdapter ilcelerTableAdapter;
    }
}