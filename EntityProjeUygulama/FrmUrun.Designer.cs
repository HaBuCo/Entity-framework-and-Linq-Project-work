namespace EntityProjeUygulama
{
    partial class FrmUrun
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtUrun = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtMarka = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtStok = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtFiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtDurum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnListele = new System.Windows.Forms.Button();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CmbKategori = new System.Windows.Forms.ComboBox();
            this.BtnTemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(179)))), ((int)(((byte)(101)))));
            this.label1.Location = new System.Drawing.Point(117, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(157, 27);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(180, 31);
            this.TxtId.TabIndex = 1;
            // 
            // TxtUrun
            // 
            this.TxtUrun.Location = new System.Drawing.Point(157, 64);
            this.TxtUrun.Name = "TxtUrun";
            this.TxtUrun.Size = new System.Drawing.Size(180, 31);
            this.TxtUrun.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(179)))), ((int)(((byte)(101)))));
            this.label2.Location = new System.Drawing.Point(86, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "ÜRÜN:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TxtMarka
            // 
            this.TxtMarka.Location = new System.Drawing.Point(157, 101);
            this.TxtMarka.Name = "TxtMarka";
            this.TxtMarka.Size = new System.Drawing.Size(180, 31);
            this.TxtMarka.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(179)))), ((int)(((byte)(101)))));
            this.label3.Location = new System.Drawing.Point(66, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "MARKA:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TxtStok
            // 
            this.TxtStok.Location = new System.Drawing.Point(157, 138);
            this.TxtStok.Name = "TxtStok";
            this.TxtStok.Size = new System.Drawing.Size(180, 31);
            this.TxtStok.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(179)))), ((int)(((byte)(101)))));
            this.label4.Location = new System.Drawing.Point(91, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "STOK:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // TxtFiyat
            // 
            this.TxtFiyat.Location = new System.Drawing.Point(157, 175);
            this.TxtFiyat.Name = "TxtFiyat";
            this.TxtFiyat.Size = new System.Drawing.Size(180, 31);
            this.TxtFiyat.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(179)))), ((int)(((byte)(101)))));
            this.label5.Location = new System.Drawing.Point(88, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "FİYAT:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // TxtDurum
            // 
            this.TxtDurum.Location = new System.Drawing.Point(157, 212);
            this.TxtDurum.Name = "TxtDurum";
            this.TxtDurum.Size = new System.Drawing.Size(180, 31);
            this.TxtDurum.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(179)))), ((int)(((byte)(101)))));
            this.label6.Location = new System.Drawing.Point(69, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "DURUM:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(179)))), ((int)(((byte)(101)))));
            this.label7.Location = new System.Drawing.Point(41, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "KATEGORİ:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // BtnListele
            // 
            this.BtnListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(179)))), ((int)(((byte)(101)))));
            this.BtnListele.Location = new System.Drawing.Point(343, 27);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(123, 68);
            this.BtnListele.TabIndex = 14;
            this.BtnListele.Text = "LİSTELE";
            this.BtnListele.UseVisualStyleBackColor = false;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(179)))), ((int)(((byte)(101)))));
            this.BtnEkle.Location = new System.Drawing.Point(493, 27);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(123, 68);
            this.BtnEkle.TabIndex = 15;
            this.BtnEkle.Text = "EKLE";
            this.BtnEkle.UseVisualStyleBackColor = false;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(179)))), ((int)(((byte)(101)))));
            this.BtnSil.Location = new System.Drawing.Point(343, 110);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(123, 68);
            this.BtnSil.TabIndex = 16;
            this.BtnSil.Text = "SİL";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(179)))), ((int)(((byte)(101)))));
            this.BtnGuncelle.Location = new System.Drawing.Point(493, 110);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(123, 68);
            this.BtnGuncelle.TabIndex = 17;
            this.BtnGuncelle.Text = "GÜNCELLE";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 328);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(571, 219);
            this.dataGridView1.TabIndex = 18;
            // 
            // CmbKategori
            // 
            this.CmbKategori.Enabled = false;
            this.CmbKategori.FormattingEnabled = true;
            this.CmbKategori.Location = new System.Drawing.Point(157, 249);
            this.CmbKategori.Name = "CmbKategori";
            this.CmbKategori.Size = new System.Drawing.Size(180, 30);
            this.CmbKategori.TabIndex = 19;
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(179)))), ((int)(((byte)(101)))));
            this.BtnTemizle.Location = new System.Drawing.Point(343, 200);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(273, 43);
            this.BtnTemizle.TabIndex = 20;
            this.BtnTemizle.Text = "TEMİZLE";
            this.BtnTemizle.UseVisualStyleBackColor = false;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // FrmUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(628, 559);
            this.Controls.Add(this.BtnTemizle);
            this.Controls.Add(this.CmbKategori);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.BtnListele);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtDurum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtFiyat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtStok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtMarka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtUrun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUrun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.FrmUrun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtUrun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtMarka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtStok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtFiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtDurum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox CmbKategori;
        private System.Windows.Forms.Button BtnTemizle;
    }
}