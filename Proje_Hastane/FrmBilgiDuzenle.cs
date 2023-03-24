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
    public partial class FrmBilgiDuzenle : Form
    {
        public FrmBilgiDuzenle()
        {
            InitializeComponent();
        }

        public string TCno;

        sqlBaglantisi bgl = new sqlBaglantisi();
        private void FrmBilgiDuzenle_Load(object sender, EventArgs e)
        {
                           //BİLGİ DÜZENLEME KISMINA GİRİNCE AKTİF BİLGİLERİN KUTUCUKLARA DOLAR.
            
            mskTc.Text = TCno;

            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar where HastaTc=@p1 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTc.Text);

            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                 //TABLODAKİ ID LERİNE GÖRE YAZIYORUZ.

                txtAd.Text = dr[1].ToString();
                txtSoyad.Text = dr[2].ToString();
                mskTelefon.Text = dr[4].ToString();
                txtSifre.Text = dr[5].ToString();
                cmbCinsiyet.Text = dr[6].ToString();
            }
            bgl.baglanti().Close(); 
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
                                       //GÜNCELLE BUTONUNA BASINCA SQL DEKİ İLE GİRİLEN VERİLERİ DEĞİŞTİRİR.
            
            SqlCommand komut2 = new SqlCommand("update Tbl_Hastalar set HastaAd=@p1,HastaSoyad=@p2,HastaTelefon=@p3,HastaSifre=@p4,HastaCinsiyet=@p5 where HastaTc=@p6", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", txtAd.Text);
            komut2.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut2.Parameters.AddWithValue("@p3", mskTelefon.Text);
            komut2.Parameters.AddWithValue("@p4", txtSifre.Text);
            komut2.Parameters.AddWithValue("@p5", cmbCinsiyet.Text);
            komut2.Parameters.AddWithValue("@p6", mskTc.Text);

            komut2.ExecuteNonQuery();  //SELECT UPDATE DELETE SORGULARINDAKİ İŞLEMLERİ GERÇEKLEŞTİRMEK İÇİN KULLANILIIR.
            bgl.baglanti().Close();
            MessageBox.Show("GÜNCELLEME GERÇEKLEŞTİRİLDİ");
        }
    }
}
