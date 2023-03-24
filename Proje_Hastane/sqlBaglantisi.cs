using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;   //SQL BAĞLANTISI İÇİN KÜTÜPHANEMİZ.

namespace Proje_Hastane
{
    internal class sqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-TJ8KD78\\SQLEXPRESS02;Initial Catalog=HastaneProje;Integrated Security=True");  //VERİ TABANI ADRESİMİ PROJECT,ADD NEW DATA SOURCE DEN ALIYORUZ.
            baglan.Open();
            return baglan;
        }
    }
}
