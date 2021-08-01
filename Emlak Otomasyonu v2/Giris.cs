using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emlak_Otomasyonu_v2
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        
        private void Giris_Load(object sender, EventArgs e)
        {

        }

        private void gir_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                Form1 emlak_kayit = new Form1();
                emlak_kayit.Show();
                this.Hide();
            }
        }
    }
}
