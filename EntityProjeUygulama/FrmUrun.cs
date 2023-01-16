using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProjeUygulama
{
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void BtnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.TBLURUN select new
            {
                x.URUNID,
                x.URUNAD,
                x.MARKA,
                x.STOK,
                x.FIYAT,
                x.TBLKATEGORI.AD,
                x.DURUM,
            }).ToList();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            TBLURUN t = new TBLURUN();
            t.URUNAD = TxtUrun.Text;
            t.MARKA= TxtMarka.Text;
            t.STOK = short.Parse(TxtStok.Text);
            t.KATEGORI = int.Parse (CmbKategori.SelectedValue.ToString());
            t.FIYAT = decimal.Parse(TxtFiyat.Text);
            t.DURUM = true;
            db.TBLURUN.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Sisteme Kaydedildi.");
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int x =Convert.ToInt32(TxtId.Text);
            var urun = db.TBLURUN.Find(x);
            db.TBLURUN.Remove(urun);
            db.SaveChanges();
            MessageBox.Show("Ürün Silindi");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TxtId.Text);
            var urun = db.TBLURUN.Find(x);
            urun.URUNAD = TxtUrun.Text;
            urun.STOK = short.Parse(TxtStok.Text);
            urun.MARKA = TxtMarka.Text;
            db.SaveChanges();
            MessageBox.Show("Ürün Güncellendi.");

        }

        private void FrmUrun_Load(object sender, EventArgs e)
        {
            var kategoriler = (from x in db.TBLKATEGORI
                               select new 
                               { 
                                   x.ID, x.AD 
                               }
                               ).ToList();
            CmbKategori.ValueMember = "ID";
            CmbKategori.DisplayMember= "AD";
            CmbKategori.DataSource = kategoriler;
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            
        }
    }
}
