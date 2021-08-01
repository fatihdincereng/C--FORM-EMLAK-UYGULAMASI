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
    public partial class Form1 : Form
    {
        SqlBaglanti bgl = new SqlBaglanti();
        SqlCommand komut;
        SqlDataAdapter da;

         public string idgonder;

        public Form1()
        {
            InitializeComponent();
            verilerigoster();
        }
        void verilerigoster()
        {
            da = new SqlDataAdapter(" select KonutID, MüsteriID, Aktiflik,Durum,OdaSayisi,MetreKare,Fiyat,İl, İlce,Adres from Tbl_Konutlar ORDER BY KonutID ASC", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
        }

        void FiltreSorgusu()
        {
            string il = illerfiltre.Text;
            string ilce = ilcefiltre.Text;
            String durum = durumFiltre.Text;
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Konutlar where İl like '" + il + "%' and İlce like '" + ilce + "%' and Durum like '" + durum + "%'", bgl.baglanti());
            DataSet ds = new DataSet();
            da.Fill(ds, "Tbl_Konutlar ");
            dataGridView1.DataSource = ds.Tables["Tbl_Konutlar "];
            bgl.baglanti().Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void yenile_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'emlakOtoDBDataSet3.Tbl_Konutlar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_KonutlarTableAdapter.Fill(this.emlakOtoDBDataSet3.Tbl_Konutlar);
            sehirlistesi();

        }
        void sehirlistesi()
        {
            SqlCommand sehirkomutu = new SqlCommand("Select sehir From iller", bgl.baglanti());
            SqlDataReader dr = sehirkomutu.ExecuteReader();

            while (dr.Read())
            {
                illerfiltre.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();

        }


        private void ekleme_Click(object sender, EventArgs e)
        {
            konutekle emlak_kayit = new konutekle();
            emlak_kayit.Show();
            this.Hide();
        }

        private void duzenle_Click(object sender, EventArgs e)
        {
            String sorgu = "DELETE FROM Tbl_Konutlar WHERE KonutID=@id";
            komut = new SqlCommand(sorgu, bgl.baglanti());
            komut.Parameters.AddWithValue("id", Convert.ToInt32(label7.Text));
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            verilerigoster();
        }

        private void müsteriler_Click(object sender, EventArgs e)
        {
            müsterilerkayıt emlak_kayit = new müsterilerkayıt();
            emlak_kayit.Show();
            this.Hide();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            label7.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            düzenleme emlak_kayit = new düzenleme();
            emlak_kayit.konutıdtext.Text = label7.Text;
            emlak_kayit.Show();
            this.Hide();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            label7.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void filtrele_Click(object sender, EventArgs e)
        {
            FiltreSorgusu();

        }

        private void illerfiltre_SelectedIndexChanged(object sender, EventArgs e)
        {
            ilcefiltre.Items.Clear();
            SqlCommand ilcekomut = new SqlCommand("Select ilce from ilceler where sehir=@p1", bgl.baglanti());
            ilcekomut.Parameters.AddWithValue("@p1", illerfiltre.SelectedIndex + 1);
            SqlDataReader dr = ilcekomut.ExecuteReader();

            while (dr.Read())
            {
                ilcefiltre.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }
    }
}
