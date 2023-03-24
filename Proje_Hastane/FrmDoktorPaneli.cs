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
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }

        sqlBaglantisi bgl = new sqlBaglantisi();
        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
                            //DOKTORLARI DATAGRİDVİEW E ÇEKME
            
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Doktorlar", bgl.baglanti());  
            da.Fill(dt);
            dataDoktor.DataSource = dt;

                           //BRANSLARI COMBOBAXA AKTARMA


            SqlCommand komut3 = new SqlCommand("Select BransAd From Tbl_Brans ", bgl.baglanti());
            SqlDataReader reader3 = komut3.ExecuteReader();
            while (reader3.Read())
            {
                cmbBrans.Items.Add(reader3[0]);
            }
            bgl.baglanti().Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
                                  //DOKTOR EKLEME 
            
            SqlCommand komut = new SqlCommand("insert into Tbl_Doktorlar (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTc,DoktorSifre) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3",cmbBrans.Text);
            komut.Parameters.AddWithValue("@p4", mskTc.Text);
            komut.Parameters.AddWithValue("@p5", txtSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Eklendi", "Bilgi", MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void dataDoktor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                        //TEXTLERE DATAGRİDVİEWDEN SEÇİLENLERİ ÇEKME İŞLEMİ.

            int secilen = dataDoktor.SelectedCells[0].RowIndex;
            txtAd.Text = dataDoktor.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text= dataDoktor.Rows[secilen].Cells[2].Value.ToString();
            cmbBrans.Text = dataDoktor.Rows[secilen].Cells[3].Value.ToString();
            mskTc.Text = dataDoktor.Rows[secilen].Cells[4].Value.ToString();
            txtSifre.Text = dataDoktor.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
                              //DOKTOR SİLME BUTONU
            
            SqlCommand komut = new SqlCommand("Delete from Tbl_Doktorlar where DoktorTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("p1",mskTc.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close() ;
            MessageBox.Show("Kayıt Silindi");
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
                                           //DOKTOR GÜNCELLEME BUTONU
            
            SqlCommand komut = new SqlCommand("Update Tbl_Doktorlar set  DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p5 where DoktorTc=@p4 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbBrans.Text);
            komut.Parameters.AddWithValue("@p4", mskTc.Text);
            komut.Parameters.AddWithValue("@p5", txtSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
