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
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }

        sqlBaglantisi bgl = new sqlBaglantisi();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lnkÜye_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmUyeKayit fr = new FrmUyeKayit();
            fr.Show();

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar Where HastaTc=@p1 and HastaSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTc.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text );

            SqlDataReader reader = komut.ExecuteReader();   //KOMUTLARI OKUR.

            if(reader.Read())   //EĞER DÜZGÜNCE OKURSA ÇALIŞIR.
            {
                FrmHastaDetay fr = new FrmHastaDetay();
                fr.tc=mskTc.Text;  //HASTA DETAYA TC Yİ AKTARIR.
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("HATALI TC VEYA ŞİFRE");
            }
            bgl.baglanti().Close();


        }

        private void FrmHastaGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
