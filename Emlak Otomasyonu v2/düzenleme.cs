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
    public partial class düzenleme : Form
    {
        SqlBaglanti bgl = new SqlBaglanti();
        SqlCommand komut;
        SqlDataAdapter da;

        public string idgonder;
        public düzenleme()
        {
            InitializeComponent();
        }

        private void düzenleme_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'emlakOtoDBDataSet3.Tbl_Konutlar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_KonutlarTableAdapter.Fill(this.emlakOtoDBDataSet3.Tbl_Konutlar);
            // TODO: Bu kod satırı 'emlakOtoDBDataSet3.müsteriler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.müsterilerTableAdapter.Fill(this.emlakOtoDBDataSet3.müsteriler);
            sehirlistesi();
            verilerigetir();
            müsterilerigöster();
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
        void verilerigetir()
        {
            SqlCommand verikomutu = new SqlCommand("Select * From Tbl_Konutlar where KonutID like'" + konutıdtext.Text+"'", bgl.baglanti());
            SqlDataReader dr = verikomutu.ExecuteReader();

            while (dr.Read())
            {
                MüsteriID.Text = dr[1].ToString();
               aktiflik.Text = dr[2].ToString();
                durum.Text = dr[3].ToString();
                odasayisi.Text = dr[4].ToString();
                metrekare.Text = dr[5].ToString();
                fiyat.Text = dr[6].ToString();
                il2.Text = dr[7].ToString();
                ilce.Text = dr[8].ToString();
                adres.Text = dr[9].ToString();
                binayasi.Text = dr[10].ToString();
                kat.Text = dr[11].ToString();
                katsayisi.Text = dr[12].ToString();
                banyo.Text = dr[13].ToString();
                balkon.Text = dr[14].ToString();
                esyali.Text = dr[15].ToString();
                site.Text = dr[16].ToString();
                krediyeuygun.Text = dr[17].ToString();
                dateTimePicker1.Text = dr[18].ToString();


            }
            bgl.baglanti().Close();

        }
        void müsterilerigöster()
        {
            SqlCommand verikomutu = new SqlCommand(" select * from müsteriler where MusteriID like '" + MüsteriID.Text+"'" , bgl.baglanti());
            SqlDataReader dr = verikomutu.ExecuteReader();
            while (dr.Read())
            {
                sahibi.Text = dr[1].ToString();
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Form1 emlak = new Form1();
            emlak.Show();
            this.Hide();
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            String sorgu = (" UPDATE Tbl_Konutlar SET MüsteriID=@p2,Aktiflik=@p3, Durum=@p4, OdaSayisi=@p5, MetreKare=@p6, " +
                "Fiyat=@p7,İl = @p8, İlce = @p9, Adres = @p10, BinaYasi = @p11, Kat = @p12,KatSayisi = @p13, Banyo = @p14, " +
                "Balkon = @p15, Esyali = @p16, Site = @p17, KrediyeUygun = @p18 WHERE KonutID = @id");
            komut = new SqlCommand(sorgu, bgl.baglanti());
            komut = new SqlCommand(sorgu, bgl.baglanti());
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(konutıdtext.Text));
            komut.Parameters.AddWithValue("@p2", MüsteriID.Text);
            komut.Parameters.AddWithValue("@p3", aktiflik.Text);
            komut.Parameters.AddWithValue("@p4", durum.Text);
            komut.Parameters.AddWithValue("@p5", odasayisi.Text);
            komut.Parameters.AddWithValue("@p6", metrekare.Text);
            komut.Parameters.AddWithValue("@p7", fiyat.Text);
            komut.Parameters.AddWithValue("@p8", il2.Text);
            komut.Parameters.AddWithValue("@p9", ilce.Text);
            komut.Parameters.AddWithValue("@p10", adres.Text);
            komut.Parameters.AddWithValue("@p11", binayasi.Text);
            komut.Parameters.AddWithValue("@p12", kat.Text);
            komut.Parameters.AddWithValue("@p13", katsayisi.Text);
            komut.Parameters.AddWithValue("@p14", banyo.Text);
            komut.Parameters.AddWithValue("@p15", balkon.Text);
            komut.Parameters.AddWithValue("@p16", esyali.Text);
            komut.Parameters.AddWithValue("@p17", site.Text);
            komut.Parameters.AddWithValue("@p18", krediyeuygun.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void il2_SelectedIndexChanged(object sender, EventArgs e)
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
