namespace Proje_Hastane
{
    partial class FrmSekreterDetay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpSekreterBilgi = new System.Windows.Forms.GroupBox();
            this.lblTc = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDuyuruOluştur = new System.Windows.Forms.Button();
            this.richDuyuru = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.checkDurum = new System.Windows.Forms.CheckBox();
            this.cmbDoktor = new System.Windows.Forms.ComboBox();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.mskSaat = new System.Windows.Forms.MaskedTextBox();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.mskTarih = new System.Windows.Forms.MaskedTextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataBrans = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataDoktor = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnRandevuListe = new System.Windows.Forms.Button();
            this.btnBranşPaneli = new System.Windows.Forms.Button();
            this.btnDoktorPaneli = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grpSekreterBilgi.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBrans)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDoktor)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSekreterBilgi
            // 
            this.grpSekreterBilgi.Controls.Add(this.lblTc);
            this.grpSekreterBilgi.Controls.Add(this.lblAdSoyad);
            this.grpSekreterBilgi.Controls.Add(this.label2);
            this.grpSekreterBilgi.Controls.Add(this.label1);
            this.grpSekreterBilgi.Location = new System.Drawing.Point(12, 12);
            this.grpSekreterBilgi.Name = "grpSekreterBilgi";
            this.grpSekreterBilgi.Size = new System.Drawing.Size(319, 192);
            this.grpSekreterBilgi.TabIndex = 1;
            this.grpSekreterBilgi.TabStop = false;
            this.grpSekreterBilgi.Text = "Sekreter Bilgi";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTc.Location = new System.Drawing.Point(165, 41);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(108, 20);
            this.lblTc.TabIndex = 3;
            this.lblTc.Text = "00000000000";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.Location = new System.Drawing.Point(165, 107);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(102, 20);
            this.lblAdSoyad.TabIndex = 2;
            this.lblAdSoyad.Text = "NULL NULL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(28, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC no :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDuyuruOluştur);
            this.groupBox2.Controls.Add(this.richDuyuru);
            this.groupBox2.Location = new System.Drawing.Point(12, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 298);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // btnDuyuruOluştur
            // 
            this.btnDuyuruOluştur.Location = new System.Drawing.Point(93, 249);
            this.btnDuyuruOluştur.Name = "btnDuyuruOluştur";
            this.btnDuyuruOluştur.Size = new System.Drawing.Size(122, 34);
            this.btnDuyuruOluştur.TabIndex = 1;
            this.btnDuyuruOluştur.Text = "Oluştur";
            this.btnDuyuruOluştur.UseVisualStyleBackColor = true;
            this.btnDuyuruOluştur.Click += new System.EventHandler(this.btnDuyuruOluştur_Click);
            // 
            // richDuyuru
            // 
            this.richDuyuru.Location = new System.Drawing.Point(6, 21);
            this.richDuyuru.Name = "richDuyuru";
            this.richDuyuru.Size = new System.Drawing.Size(307, 222);
            this.richDuyuru.TabIndex = 0;
            this.richDuyuru.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.checkDurum);
            this.groupBox1.Controls.Add(this.cmbDoktor);
            this.groupBox1.Controls.Add(this.cmbBrans);
            this.groupBox1.Controls.Add(this.mskSaat);
            this.groupBox1.Controls.Add(this.mskTc);
            this.groupBox1.Controls.Add(this.mskTarih);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(368, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 508);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Randevu Paneli";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(183, 397);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(122, 32);
            this.btnKaydet.TabIndex = 15;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // checkDurum
            // 
            this.checkDurum.AutoSize = true;
            this.checkDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkDurum.Location = new System.Drawing.Point(157, 348);
            this.checkDurum.Name = "checkDurum";
            this.checkDurum.Size = new System.Drawing.Size(82, 24);
            this.checkDurum.TabIndex = 14;
            this.checkDurum.Text = "Durum";
            this.checkDurum.UseVisualStyleBackColor = true;
            // 
            // cmbDoktor
            // 
            this.cmbDoktor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDoktor.FormattingEnabled = true;
            this.cmbDoktor.Location = new System.Drawing.Point(157, 236);
            this.cmbDoktor.Name = "cmbDoktor";
            this.cmbDoktor.Size = new System.Drawing.Size(181, 28);
            this.cmbDoktor.TabIndex = 13;
            // 
            // cmbBrans
            // 
            this.cmbBrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(157, 188);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(181, 28);
            this.cmbBrans.TabIndex = 12;
            this.cmbBrans.SelectedIndexChanged += new System.EventHandler(this.cmbBrans_SelectedIndexChanged);
            // 
            // mskSaat
            // 
            this.mskSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskSaat.Location = new System.Drawing.Point(157, 136);
            this.mskSaat.Mask = "00:00";
            this.mskSaat.Name = "mskSaat";
            this.mskSaat.Size = new System.Drawing.Size(181, 27);
            this.mskSaat.TabIndex = 11;
            this.mskSaat.ValidatingType = typeof(System.DateTime);
            // 
            // mskTc
            // 
            this.mskTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTc.Location = new System.Drawing.Point(157, 295);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(181, 27);
            this.mskTc.TabIndex = 10;
            // 
            // mskTarih
            // 
            this.mskTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTarih.Location = new System.Drawing.Point(157, 90);
            this.mskTarih.Mask = "00/00/0000";
            this.mskTarih.Name = "mskTarih";
            this.mskTarih.Size = new System.Drawing.Size(181, 27);
            this.mskTarih.TabIndex = 9;
            this.mskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtid.Location = new System.Drawing.Point(157, 48);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(181, 27);
            this.txtid.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(48, 301);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "TC :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(48, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Doktor :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(48, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Brans :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(48, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Saat : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(48, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tarih :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(48, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "id :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataBrans);
            this.groupBox3.Location = new System.Drawing.Point(803, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(378, 312);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Brans";
            // 
            // dataBrans
            // 
            this.dataBrans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataBrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataBrans.Location = new System.Drawing.Point(3, 18);
            this.dataBrans.Name = "dataBrans";
            this.dataBrans.RowHeadersWidth = 51;
            this.dataBrans.RowTemplate.Height = 24;
            this.dataBrans.Size = new System.Drawing.Size(372, 291);
            this.dataBrans.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataDoktor);
            this.groupBox4.Location = new System.Drawing.Point(806, 330);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(378, 317);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Doktorlar";
            // 
            // dataDoktor
            // 
            this.dataDoktor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataDoktor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDoktor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataDoktor.Location = new System.Drawing.Point(3, 18);
            this.dataDoktor.Name = "dataDoktor";
            this.dataDoktor.RowHeadersWidth = 51;
            this.dataDoktor.RowTemplate.Height = 24;
            this.dataDoktor.Size = new System.Drawing.Size(372, 296);
            this.dataDoktor.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.btnRandevuListe);
            this.groupBox5.Controls.Add(this.btnBranşPaneli);
            this.groupBox5.Controls.Add(this.btnDoktorPaneli);
            this.groupBox5.Location = new System.Drawing.Point(34, 546);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(723, 98);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Hızlı Erişim";
            // 
            // btnRandevuListe
            // 
            this.btnRandevuListe.Location = new System.Drawing.Point(373, 43);
            this.btnRandevuListe.Name = "btnRandevuListe";
            this.btnRandevuListe.Size = new System.Drawing.Size(164, 40);
            this.btnRandevuListe.TabIndex = 2;
            this.btnRandevuListe.Text = "Randevu Liste";
            this.btnRandevuListe.UseVisualStyleBackColor = true;
            this.btnRandevuListe.Click += new System.EventHandler(this.btnRandevuListe_Click);
            // 
            // btnBranşPaneli
            // 
            this.btnBranşPaneli.Location = new System.Drawing.Point(185, 43);
            this.btnBranşPaneli.Name = "btnBranşPaneli";
            this.btnBranşPaneli.Size = new System.Drawing.Size(157, 40);
            this.btnBranşPaneli.TabIndex = 1;
            this.btnBranşPaneli.Text = "Branş Paneli";
            this.btnBranşPaneli.UseVisualStyleBackColor = true;
            this.btnBranşPaneli.Click += new System.EventHandler(this.btnBranşPaneli_Click);
            // 
            // btnDoktorPaneli
            // 
            this.btnDoktorPaneli.Location = new System.Drawing.Point(10, 43);
            this.btnDoktorPaneli.Name = "btnDoktorPaneli";
            this.btnDoktorPaneli.Size = new System.Drawing.Size(147, 40);
            this.btnDoktorPaneli.TabIndex = 0;
            this.btnDoktorPaneli.Text = "Doktor Paneli";
            this.btnDoktorPaneli.UseVisualStyleBackColor = true;
            this.btnDoktorPaneli.Click += new System.EventHandler(this.btnDoktorPaneli_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(564, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Duyurular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmSekreterDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1193, 659);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpSekreterBilgi);
            this.Name = "FrmSekreterDetay";
            this.Text = "FrmSekreterDetay";
            this.Load += new System.EventHandler(this.FrmSekreterDetay_Load);
            this.grpSekreterBilgi.ResumeLayout(false);
            this.grpSekreterBilgi.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataBrans)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataDoktor)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSekreterBilgi;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDuyuruOluştur;
        private System.Windows.Forms.RichTextBox richDuyuru;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.CheckBox checkDurum;
        private System.Windows.Forms.ComboBox cmbDoktor;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.MaskedTextBox mskSaat;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.MaskedTextBox mskTarih;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataBrans;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataDoktor;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnRandevuListe;
        private System.Windows.Forms.Button btnBranşPaneli;
        private System.Windows.Forms.Button btnDoktorPaneli;
        private System.Windows.Forms.Button button1;
    }
}