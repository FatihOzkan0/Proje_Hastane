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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }

        sqlBaglantisi bgl = new sqlBaglantisi();
        public string tc;
        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            //TC Yİ ÇEKME İŞLEMİ.
            
            lblTc.Text = tc;

            //AD SOYAD ÇEKME İŞLEMİ.

            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",lblTc.Text);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                lblAdSoyad.Text = reader[0] + " " + reader[1];
            }
            bgl.baglanti().Close(); 

            //GİRİŞ YAPAN DOKTORUN RANDEVULARINI dataGridViewe GETİRME İŞLEMİ.

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuDoktor= '" + lblAdSoyad.Text + "'", bgl.baglanti());  //SQL DE STRİNG İŞLEMLERİ YAPARKEN TEK TIRNAK KULLANIRIZ.
            da.Fill(dt);
            dataGridView1.DataSource= dt;
        }

        private void lblTc_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBilgiDüzenle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDüzenle frm = new FrmDoktorBilgiDüzenle();
            frm.tc = lblTc.Text;
            frm.Show();
        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular frm = new FrmDuyurular();
            frm.Show();
        }

        private void btnnCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();  //UYGULAMAYI KOMPİLE KAPATIR
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            richRandevuDetay.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
