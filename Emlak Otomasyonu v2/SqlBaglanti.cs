using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Emlak_Otomasyonu_v2
{
    class SqlBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-USRDG38;Initial Catalog=EmlakOtoDB;Integrated Security=True");
            baglan.Open();
            return baglan;

        }
    }
}
