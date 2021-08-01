
namespace Emlak_Otomasyonu_v2
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblKonutlarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.emlakOtoDBDataSet3 = new Emlak_Otomasyonu_v2.EmlakOtoDBDataSet3();
            this.label1 = new System.Windows.Forms.Label();
            this.ekleme = new System.Windows.Forms.Button();
            this.KonutSil = new System.Windows.Forms.Button();
            this.müsteriler = new System.Windows.Forms.Button();
            this.yenile = new System.Windows.Forms.Button();
            this.filtrele = new System.Windows.Forms.Button();
            this.ilcefiltre = new System.Windows.Forms.ComboBox();
            this.illerfiltre = new System.Windows.Forms.ComboBox();
            this.durumFiltre = new System.Windows.Forms.ComboBox();
            this.tbl_KonutlarTableAdapter = new Emlak_Otomasyonu_v2.EmlakOtoDBDataSet3TableAdapters.Tbl_KonutlarTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tblKonutlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emlakOtoDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKonutlarBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emlakOtoDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKonutlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emlakOtoDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dataGridView1.DataSource = this.tblKonutlarBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(139, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1026, 372);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "KonutID";
            this.dataGridViewTextBoxColumn1.HeaderText = "KonutID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MüsteriID";
            this.dataGridViewTextBoxColumn2.HeaderText = "MüsteriID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Aktiflik";
            this.dataGridViewTextBoxColumn3.HeaderText = "Aktiflik";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Durum";
            this.dataGridViewTextBoxColumn4.HeaderText = "Durum";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "OdaSayisi";
            this.dataGridViewTextBoxColumn5.HeaderText = "OdaSayisi";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MetreKare";
            this.dataGridViewTextBoxColumn6.HeaderText = "MetreKare";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Fiyat";
            this.dataGridViewTextBoxColumn7.HeaderText = "Fiyat";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "İl";
            this.dataGridViewTextBoxColumn8.HeaderText = "İl";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "İlce";
            this.dataGridViewTextBoxColumn9.HeaderText = "İlce";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Adres";
            this.dataGridViewTextBoxColumn10.HeaderText = "Adres";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 200;
            // 
            // tblKonutlarBindingSource1
            // 
            this.tblKonutlarBindingSource1.DataMember = "Tbl_Konutlar";
            this.tblKonutlarBindingSource1.DataSource = this.emlakOtoDBDataSet3;
            // 
            // emlakOtoDBDataSet3
            // 
            this.emlakOtoDBDataSet3.DataSetName = "EmlakOtoDBDataSet3";
            this.emlakOtoDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1171, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Portföy";
            // 
            // ekleme
            // 
            this.ekleme.Location = new System.Drawing.Point(1171, 326);
            this.ekleme.Name = "ekleme";
            this.ekleme.Size = new System.Drawing.Size(121, 34);
            this.ekleme.TabIndex = 3;
            this.ekleme.Text = "Konut Ekle";
            this.ekleme.UseVisualStyleBackColor = true;
            this.ekleme.Click += new System.EventHandler(this.ekleme_Click);
            // 
            // KonutSil
            // 
            this.KonutSil.Location = new System.Drawing.Point(12, 361);
            this.KonutSil.Name = "KonutSil";
            this.KonutSil.Size = new System.Drawing.Size(121, 34);
            this.KonutSil.TabIndex = 4;
            this.KonutSil.Text = "Konut Sil";
            this.KonutSil.UseVisualStyleBackColor = true;
            this.KonutSil.Click += new System.EventHandler(this.duzenle_Click);
            // 
            // müsteriler
            // 
            this.müsteriler.Location = new System.Drawing.Point(1172, 366);
            this.müsteriler.Name = "müsteriler";
            this.müsteriler.Size = new System.Drawing.Size(121, 34);
            this.müsteriler.TabIndex = 5;
            this.müsteriler.Text = "Müşteriler";
            this.müsteriler.UseVisualStyleBackColor = true;
            this.müsteriler.Click += new System.EventHandler(this.müsteriler_Click);
            // 
            // yenile
            // 
            this.yenile.Location = new System.Drawing.Point(12, 164);
            this.yenile.Name = "yenile";
            this.yenile.Size = new System.Drawing.Size(121, 21);
            this.yenile.TabIndex = 10;
            this.yenile.Text = "Yenile";
            this.yenile.UseVisualStyleBackColor = true;
            this.yenile.Click += new System.EventHandler(this.yenile_Click);
            // 
            // filtrele
            // 
            this.filtrele.Location = new System.Drawing.Point(12, 137);
            this.filtrele.Name = "filtrele";
            this.filtrele.Size = new System.Drawing.Size(121, 21);
            this.filtrele.TabIndex = 9;
            this.filtrele.Text = "Filtrele";
            this.filtrele.UseVisualStyleBackColor = true;
            this.filtrele.Click += new System.EventHandler(this.filtrele_Click);
            // 
            // ilcefiltre
            // 
            this.ilcefiltre.FormattingEnabled = true;
            this.ilcefiltre.Location = new System.Drawing.Point(12, 110);
            this.ilcefiltre.Name = "ilcefiltre";
            this.ilcefiltre.Size = new System.Drawing.Size(121, 21);
            this.ilcefiltre.TabIndex = 8;
            // 
            // illerfiltre
            // 
            this.illerfiltre.FormattingEnabled = true;
            this.illerfiltre.Location = new System.Drawing.Point(12, 70);
            this.illerfiltre.Name = "illerfiltre";
            this.illerfiltre.Size = new System.Drawing.Size(121, 21);
            this.illerfiltre.TabIndex = 7;
            this.illerfiltre.SelectedIndexChanged += new System.EventHandler(this.illerfiltre_SelectedIndexChanged);
            // 
            // durumFiltre
            // 
            this.durumFiltre.FormattingEnabled = true;
            this.durumFiltre.Items.AddRange(new object[] {
            "Satilik",
            "Kiralik"});
            this.durumFiltre.Location = new System.Drawing.Point(12, 28);
            this.durumFiltre.Name = "durumFiltre";
            this.durumFiltre.Size = new System.Drawing.Size(121, 21);
            this.durumFiltre.TabIndex = 6;
            // 
            // tbl_KonutlarTableAdapter
            // 
            this.tbl_KonutlarTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Durum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "İl";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "İlçe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(136, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Seçilen Konut ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(229, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 407);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.yenile);
            this.Controls.Add(this.filtrele);
            this.Controls.Add(this.ilcefiltre);
            this.Controls.Add(this.illerfiltre);
            this.Controls.Add(this.durumFiltre);
            this.Controls.Add(this.müsteriler);
            this.Controls.Add(this.KonutSil);
            this.Controls.Add(this.ekleme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Emlak";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKonutlarBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emlakOtoDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKonutlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emlakOtoDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ekleme;
        private System.Windows.Forms.Button KonutSil;
        private System.Windows.Forms.Button müsteriler;
        private System.Windows.Forms.Button yenile;
        private System.Windows.Forms.Button filtrele;
        private System.Windows.Forms.ComboBox ilcefiltre;
        private System.Windows.Forms.ComboBox illerfiltre;
        private System.Windows.Forms.ComboBox durumFiltre;
        private System.Windows.Forms.BindingSource emlakOtoDBDataSetBindingSource;
        //private EmlakOtoDBDataSet emlakOtoDBDataSet;
       // private EmlakOtoDBDataSet1 emlakOtoDBDataSet1;
        private System.Windows.Forms.BindingSource tblKonutlarBindingSource;
       // private EmlakOtoDBDataSet1TableAdapters.Tbl_KonutlarTableAdapter tbl_KonutlarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn konutIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn müsteriIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aktiflikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaSayisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metreKareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private EmlakOtoDBDataSet3 emlakOtoDBDataSet3;
        private System.Windows.Forms.BindingSource tblKonutlarBindingSource1;
        private EmlakOtoDBDataSet3TableAdapters.Tbl_KonutlarTableAdapter tbl_KonutlarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
    }
}