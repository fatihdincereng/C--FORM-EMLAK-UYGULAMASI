
namespace Emlak_Otomasyonu_v2
{
    partial class müsterilerkayıt
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
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.eposta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.telefon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.isimsoyisim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.müsteriid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(486, 314);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 28);
            this.button4.TabIndex = 29;
            this.button4.Text = "Sil";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 273);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(486, 359);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 37);
            this.button3.TabIndex = 27;
            this.button3.Text = "Geri";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(385, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 28);
            this.button2.TabIndex = 26;
            this.button2.Text = "Düzenle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 28);
            this.button1.TabIndex = 25;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // eposta
            // 
            this.eposta.Location = new System.Drawing.Point(355, 376);
            this.eposta.Name = "eposta";
            this.eposta.Size = new System.Drawing.Size(100, 20);
            this.eposta.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "E-Posta";
            // 
            // telefon
            // 
            this.telefon.Location = new System.Drawing.Point(249, 376);
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(100, 20);
            this.telefon.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Telefon";
            // 
            // isimsoyisim
            // 
            this.isimsoyisim.Location = new System.Drawing.Point(37, 376);
            this.isimsoyisim.Name = "isimsoyisim";
            this.isimsoyisim.Size = new System.Drawing.Size(100, 20);
            this.isimsoyisim.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "İsim Soyisim";
            // 
            // müsteriid
            // 
            this.müsteriid.Location = new System.Drawing.Point(37, 322);
            this.müsteriid.Name = "müsteriid";
            this.müsteriid.ReadOnly = true;
            this.müsteriid.Size = new System.Drawing.Size(100, 20);
            this.müsteriid.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Müşteri ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 376);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            // 
            // tc
            // 
            this.tc.AutoSize = true;
            this.tc.Location = new System.Drawing.Point(141, 359);
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(21, 13);
            this.tc.TabIndex = 30;
            this.tc.Text = "TC";
            // 
            // müsterilerkayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 419);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.eposta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.telefon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.isimsoyisim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.müsteriid);
            this.Controls.Add(this.label1);
            this.Name = "müsterilerkayıt";
            this.Text = "Müşteri Kayıt";
            this.Load += new System.EventHandler(this.müsterilerkayıt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox eposta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox telefon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox isimsoyisim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox müsteriid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label tc;
    }
}