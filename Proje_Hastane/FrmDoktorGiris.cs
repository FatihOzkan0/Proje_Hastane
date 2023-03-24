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
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();

        private void FrmDoktorGiris_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Doktorlar where DoktorTc=@p1 and DoktorSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTc.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader reader = komut.ExecuteReader();
            if(reader.Read())
            {
                FrmDoktorDetay frm = new FrmDoktorDetay();
                frm.tc = mskTc.Text;
                frm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("HATALI KULLLANICI AD VEYA ŞİFRE");
            }
            bgl.baglanti().Close();
        }
    }
}
