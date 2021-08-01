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
    public partial class müsterilerkayıt : Form
    {
        SqlBaglanti bgl = new SqlBaglanti();
        SqlCommand komut;
        SqlDataAdapter da;

        public müsterilerkayıt()
        {
            InitializeComponent();
        }
        void verilerigoster()
        {
            da = new SqlDataAdapter("Select * From müsteriler", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
        }
        private void müsterilerkayıt_Load(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string veri = "insert into müsteriler(AdiSoyadi,Telefon,Eposta,TC) values (@p2,@p3,@p4,@p5)";
            komut = new SqlCommand(veri, bgl.baglanti());
            komut.Parameters.AddWithValue("@p2", isimsoyisim.Text);
            komut.Parameters.AddWithValue("@p3", telefon.Text);
            komut.Parameters.AddWithValue("@p4", eposta.Text);
            komut.Parameters.AddWithValue("@p5", textBox1.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            verilerigoster();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String veri = "DELETE FROM müsteriler WHERE MusteriID=@id";
            komut = new SqlCommand(veri, bgl.baglanti());
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(müsteriid.Text));
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            verilerigoster();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string veri = "update müsteriler set İsimSoyisim=@p2 ,Telefon=@p3,TC=@p4,Eposta=@p5 where MüsteriID=@id";
            komut = new SqlCommand(veri, bgl.baglanti());
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(müsteriid.Text));
            komut.Parameters.AddWithValue("@p2", isimsoyisim.Text);
            komut.Parameters.AddWithValue("@p3", telefon.Text);
            komut.Parameters.AddWithValue("@p4", textBox1.Text);
            komut.Parameters.AddWithValue("@p5", eposta.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            verilerigoster();
        }


            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                müsteriid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                isimsoyisim.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                telefon.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                eposta.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 emlak = new Form1();
            emlak.Show();
            this.Hide();
        }
    }
}
