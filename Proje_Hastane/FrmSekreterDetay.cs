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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }

        public string TcNo;

        sqlBaglantisi bgl = new sqlBaglantisi();

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
         
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            lblTc.Text= TcNo;

                                     //VERİ TABANINDAN AD SOYAD ÇEKME.

            SqlCommand komut = new SqlCommand("Select SekreterAdSoyad From Tbl_Sekreter where SekreterTc=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",lblTc.Text);

            SqlDataReader reader= komut.ExecuteReader();
            while(reader.Read())
            {
                lblAdSoyad.Text = reader[0].ToString();
            }
            bgl.baglanti().Close();

            //BRANŞLARI DATA GRİEDVİEWE ÇEKME İŞLEMİ.

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Brans ", bgl.baglanti());
            da.Fill(dt);
            dataBrans.DataSource = dt;

            //DOKTORLARI DATA GRİEDVİEWE ÇEKKME İŞLEMİ.

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoktorAd+' '+DoktorSoyad) as 'Doktor', DoktorBrans From Tbl_Doktorlar", bgl.baglanti());  //DOKTOR AD SOYADI BERABER TEK SUTUNDA KULLANDIK BU YÜZDEN AS İLE O SUTUNA AD VERDİK.
            da2.Fill(dt2);
            dataDoktor.DataSource = dt2;

            //BRANSI COMBOBOXA ÇEKME

            SqlCommand komut3 = new SqlCommand("Select BransAd From Tbl_Brans ", bgl.baglanti());
            SqlDataReader reader3 = komut3.ExecuteReader();
            while (reader3.Read())
            {
                cmbBrans.Items.Add(reader3[0]);
            }
            bgl.baglanti().Close();


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
                                      //RANDEVU OLUŞTURMA VE RANDEVUYU SQL E KAYDETME.
            
            SqlCommand komut2 = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@r1,@r2,@r3,@r4)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@r1", mskTarih.Text);
            komut2.Parameters.AddWithValue("@r2", mskSaat.Text);
            komut2.Parameters.AddWithValue("@r3", cmbBrans.Text);
            komut2.Parameters.AddWithValue("@r4", cmbDoktor.Text);
            
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu");
        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
                                          //COMBOBOXA DOKTORLARI SEÇİLEN BRANS COMBOBOXA GÖRE GETİRİR.
            
            cmbDoktor.Items.Clear();   //BİR KERE SEÇTİĞİMİZ DOKTORU DİĞER BRANSLARDA DA GÖSTERMESİN DİYE TEMİZLİYORUZ.

            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbBrans.Text);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                cmbDoktor.Items.Add(reader[0]+" " + reader[1]);
            }
            bgl.baglanti().Close();
        }

        private void btnDuyuruOluştur_Click(object sender, EventArgs e)
        {
                               //SEKRETER DUYURU OLUŞTURMA.
            
            SqlCommand komut = new SqlCommand("insert into Tbl_Duyurular (Duyuru) values (@d1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", richDuyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu");
        }

        private void btnDoktorPaneli_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli frp = new FrmDoktorPaneli();
            frp.Show();
        }

        private void btnBranşPaneli_Click(object sender, EventArgs e)
        {
            FrmBransPaneli fr = new FrmBransPaneli();
            fr.Show();

        }

        private void btnRandevuListe_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi fr = new FrmRandevuListesi();
            fr.Show();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr = new FrmDuyurular();
            fr.Show();
        }
    }
}
