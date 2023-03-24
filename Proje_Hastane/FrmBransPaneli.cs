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

namespace Proje_Hastane
{
    public partial class FrmBransPaneli : Form
    {
        public FrmBransPaneli()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();

        private void FrmBransPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Brans",bgl.baglanti());
            da.Fill(dt);
            dataBrans.DataSource = dt;

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Brans (BransAd) values (@p1)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtBransAd.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Brans Eklendi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Tbl_Brans where Bransid=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtBransid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Brans Silindi");
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update  Tbl_Brans set BransAd=@p1 where Bransid=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtBransAd.Text);
            komut.Parameters.AddWithValue("@p2", txtBransid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Brans Güncellendi");

        }
    }
}
