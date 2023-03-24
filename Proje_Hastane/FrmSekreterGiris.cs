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
    public partial class FrmSekreterGiris : Form
    {
        public FrmSekreterGiris()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        private void btnGiris_Click(object sender, EventArgs e)
        {
                                   //SEKRETER TC ŞİFRE DOĞRU MU DİYE KONTROL EDİP GİRİŞ YAPAR.
            
            SqlCommand komut = new SqlCommand("Select * From Tbl_Sekreter where SekreterTc=@p1 and SekreterSifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTc.Text);
            komut.Parameters.AddWithValue("@p2",txtSifre.Text);
            SqlDataReader reader = komut.ExecuteReader();

            if(reader.Read())
            {
                FrmSekreterDetay fr = new FrmSekreterDetay();
                fr.TcNo = mskTc.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("HATALI TC VEYA ŞİFRE");
            }
            bgl.baglanti().Close();
        }
    }
}
