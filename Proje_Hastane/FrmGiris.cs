using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmHastaGiris fr = new FrmHastaGiris();
            fr.Show();  //DİĞER FORMU GETİRİR.
            this.Hide(); //ÖNCEKİ FORMU GİZLER.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmDoktorGiris fr = new FrmDoktorGiris();
            fr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmSekreterGiris fr = new FrmSekreterGiris();
            fr.Show();
            this.Hide();
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
