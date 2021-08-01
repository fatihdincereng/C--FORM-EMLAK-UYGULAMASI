using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Emlak_Otomasyonu_v2
{
    public partial class konutekle : Form
    {
        SqlBaglanti bgl = new SqlBaglanti();
        SqlCommand komut;
        SqlCommand kontrol;
        SqlDataAdapter da;
        

        public konutekle()
        {
            InitializeComponent();
        }


        public void ilceleri_göster()
        {
            //ilce.Items.Clear();
            SqlCommand ilcekomut = new SqlCommand("Select ilce from ilceler where sehir=@p1", bgl.baglanti());
            ilcekomut.Parameters.AddWithValue("@p1", il2.SelectedValue);
            SqlDataReader dr = ilcekomut.ExecuteReader();

            while (dr.Read())
            {
                ilce.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        private void konutekle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'emlakOtoDBDataSet3.ilceler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ilcelerTableAdapter.Fill(this.emlakOtoDBDataSet3.ilceler);
            // TODO: Bu kod satırı 'emlakOtoDBDataSet3.iller' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.illerTableAdapter1.Fill(this.emlakOtoDBDataSet3.iller);
            // TODO: Bu kod satırı 'emlakOtoDBDataSet3.müsteriler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.müsterilerTableAdapter.Fill(this.emlakOtoDBDataSet3.müsteriler);
            // TODO: Bu kod satırı 'emlakOtoDBDataSet2.iller' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.illerTableAdapter.Fill(this.emlakOtoDBDataSet2.iller);
            sehirlistesi();

        }
        void sehirlistesi()
        {
            SqlCommand sehirkomutu = new SqlCommand("Select sehir From iller", bgl.baglanti());
            SqlDataReader dr = sehirkomutu.ExecuteReader();

            while (dr.Read())
            {
                il2.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        void il2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ilceleri_göster();
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            String sorgu = "INSERT INTO Tbl_Konutlar(MüsteriID,Aktiflik,Durum,OdaSayisi,MetreKare,Fiyat,İl,İlce,Adres,BinaYasi,Kat,KatSayisi,Banyo,Balkon,Esyali,Site,KrediyeUygun,KayıtTarihi) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17,@p18)";
            komut = new SqlCommand(sorgu, bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MüsteriID.Text);
            komut.Parameters.AddWithValue("@p2", aktiflik.Text);
            komut.Parameters.AddWithValue("@p3", durum.Text);
            komut.Parameters.AddWithValue("@p4", odasayisi.Text);
            komut.Parameters.AddWithValue("@p5", metrekare.Text);
            komut.Parameters.AddWithValue("@p6", fiyat.Text);
            komut.Parameters.AddWithValue("@p7", il2.Text);
            komut.Parameters.AddWithValue("@p8", ilce.Text);
            komut.Parameters.AddWithValue("@p9", adres.Text);
            komut.Parameters.AddWithValue("@p10", binayasi.Text);
            komut.Parameters.AddWithValue("@p11", kat.Text);
            komut.Parameters.AddWithValue("@p12", katsayisi.Text);
            komut.Parameters.AddWithValue("@p13", banyo.Text);
            komut.Parameters.AddWithValue("@p14", balkon.Text);
            komut.Parameters.AddWithValue("@p15", esyali.Text);
            komut.Parameters.AddWithValue("@p16", site.Text);
            komut.Parameters.AddWithValue("@p17", krediyeuygun.Text);
            komut.Parameters.AddWithValue("@p18", dateTimePicker1.Value);
            komut.ExecuteNonQuery();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 emlak = new Form1();
            emlak.Show();
            this.Hide();
        }

        private void il2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ilce.Items.Clear();
            SqlCommand ilcekomut = new SqlCommand("Select ilce from ilceler where sehir=@p1", bgl.baglanti());
            ilcekomut.Parameters.AddWithValue("@p1", il2.SelectedIndex + 1);
            SqlDataReader dr = ilcekomut.ExecuteReader();

            while (dr.Read())
            {
                ilce.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }
    }
}
