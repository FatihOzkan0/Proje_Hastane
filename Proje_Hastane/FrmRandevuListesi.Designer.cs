﻿namespace Proje_Hastane
{
    partial class FrmRandevuListesi
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
            this.dataRandevu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataRandevu)).BeginInit();
            this.SuspendLayout();
            // 
            // dataRandevu
            // 
            this.dataRandevu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataRandevu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRandevu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataRandevu.Location = new System.Drawing.Point(0, 0);
            this.dataRandevu.Name = "dataRandevu";
            this.dataRandevu.RowHeadersWidth = 51;
            this.dataRandevu.RowTemplate.Height = 24;
            this.dataRandevu.Size = new System.Drawing.Size(1004, 551);
            this.dataRandevu.TabIndex = 0;
            // 
            // FrmRandevuListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 551);
            this.Controls.Add(this.dataRandevu);
            this.Name = "FrmRandevuListesi";
            this.Text = "FrmRandevuListesi";
            this.Load += new System.EventHandler(this.FrmRandevuListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataRandevu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataRandevu;
    }
}