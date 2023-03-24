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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }
           public string tc;

           sqlBaglantisi bgl = new sqlBaglantisi();
        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            lblTc.Text = tc;  //TC YİDE HASTA GİRİŞTEN ÇEKİYORUZ.

                                        //AD SOYAD ÇEKME İŞLEMİ                          

            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad From  Tbl_Hastalar where HastaTc=@p1", bgl.baglanti());  //TC YE BAKARAK HASTANIN ADINI SOYADINI ÇEKER.
            komut.Parameters.AddWithValue("@p1", lblTc.Text);
            
            SqlDataReader reader= komut.ExecuteReader();
            while(reader.Read())
            {
                lblAdSoyad.Text = reader[0]+ " " + reader[1];   //0 HASTA AD , 1 HASTA SOYAD.
            }
            bgl.baglanti().Close();

                                      //RANDEVU GEÇMİŞİ DATAGRİDVİEW
           
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where HastaTc="+tc,bgl.baglanti());   //HASTA TC YE GÖRE ÇEKİYORUZ.
            da.Fill(dt);
            dataRandevuGecmisi.DataSource= dt;

            //BRANŞLARI ÇEKME 

            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Brans", bgl.baglanti());
            SqlDataReader reader2 = komut2.ExecuteReader();
            while(reader2.Read())
            {
                cmbBranş.Items.Add(reader2[0]);
            }
            bgl.baglanti().Close();

        }

        private void cmbBranş_SelectedIndexChanged(object sender, EventArgs e)
        {
                                 //BRANS SEÇİLDİĞİ ZAMAN ALTINDA O BRANŞIN DOKTORLARINI GETİRME.
            
            cmbDoktor.Items.Clear();   //COMBO BOX IN İÇİNİ TEMİZLER SEÇİLEN DOKTOR İÇİNDE KALMASIN DİYE.
            
            SqlCommand komut3 = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", cmbBranş.Text);

            SqlDataReader reader3 = komut3.ExecuteReader();
            while(reader3.Read())
            {
                cmbDoktor.Items.Add(reader3[0] + " " + reader3[1] );
            }
            bgl.baglanti().Close();
        }

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
               //SEÇİLİ BRANSTAKİ AKTİF RANDEVULARI DATAFRİDVİEW EKLEME.
               
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select *From Tbl_Randevular where RandevuBrans='" + cmbBranş.Text + "'" + "and RandevuDurum=0" , bgl.baglanti());    //SQL DE STRİNG İFADELERİ TEK TIRNAK İÇİNDE YAZARIZ. RANDEVU DURUM =0 BOŞ OLAN RANDEVUYU TEMSİL EDER.
            da.Fill(dt);
            dataAktifRandevular.DataSource = dt;
        }

        private void lnkDüzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDuzenle fr = new FrmBilgiDuzenle();
            fr.TCno = lblTc.Text;
            fr.Show();
        }

        private void dataAktifRandevular_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                        //SEÇİLEN SATIRIN İD SİNİ İD TEXTİNE YAZAR.
            
            int secilen = dataAktifRandevular.SelectedCells[0].RowIndex;
            txtid.Text = dataAktifRandevular.Rows[secilen].Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Randevular Set RandevuDurum=1,HastaTc=@p1,HastaSikayet=@p2 where Randevuid=@p3",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTc.Text);
            komut.Parameters.AddWithValue("@p2",richŞikayet.Text);
            komut.Parameters.AddWithValue("@p3", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevü Alındı");
        }
    }
}
