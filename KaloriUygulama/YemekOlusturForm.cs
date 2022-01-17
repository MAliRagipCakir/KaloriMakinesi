using KaloriUygulama.Data;
using KaloriUygulama.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaloriUygulama
{
    public partial class YemekOlusturForm : Form
    {
        private readonly KaloriUygulamaDbContext db;

        public YemekOlusturForm(KaloriUygulamaDbContext db)
        {
            this.db = db;
            InitializeComponent();
            PorsiyonlariListele();
            KategorileriListele();
        }

        private void KategorileriListele()
        {
            if (db.Kategoriler.Any())
            {
                cmbKategoriler.DataSource = db.Kategoriler.OrderBy(x => x.KategoriAd).ToList();
                cmbKategoriler.DisplayMember = "KategoriAd";
            }
        }

        private void PorsiyonlariListele()
        {
            if (db.Porsiyonlar.Any())
            {
                cmbPorsiyonlar.DataSource = db.Porsiyonlar.OrderBy(x => x.PorsiyonAd).ToList();
                cmbPorsiyonlar.DisplayMember = "PorsiyonAd";
            }
        }

        private void btnResimAra_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                Filter = "Image Files |*.jpg;*.jpeg;*.png;",
                Title = "Yemek için Resim Seçiniz"
            };
            DialogResult dr = openFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string dosyaYolu = openFileDialog.FileName;
                Bitmap bitmap = new Bitmap(dosyaYolu);

                string ext = Path.GetExtension(dosyaYolu);
                string resimYolu = Environment.CurrentDirectory.Replace("bin\\Debug", "") + "Images\\Besin\\" + Guid.NewGuid().ToString() + ext;
                bitmap.Save(resimYolu);

                pboYemekResim.ImageLocation = resimYolu;
                txtResimYolu.Text = resimYolu;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string besinAd = txtBesinAd.Text.Trim();
            decimal kalori = nudKalori.Value;
            decimal gram = nudGram.Value;
            decimal protein = nudProtein.Value;
            decimal karbonhidrat = nudKarbonhidrat.Value;
            decimal yag = nudYag.Value;

            if (besinAd == "" || cmbPorsiyonlar.SelectedIndex == -1 || cmbKategoriler.SelectedIndex == -1)
            {
                MessageBox.Show("Besin Adı, Kategori veya Porsiyon alanı boş bırakılamaz");
                return;
            }
            else
            {
                Kategori kategori = (Kategori)cmbKategoriler.SelectedItem;
                Besin besin = new Besin()
                {
                    BesinAd = besinAd,
                    Kalori = kalori,
                    Gram = gram,
                    Karbonhidrat = karbonhidrat,
                    Protein = protein,
                    Yag = yag,
                    Kategori = kategori
                };

                if (!string.IsNullOrEmpty(pboYemekResim.ImageLocation))
                {
                    besin.BesinResimYolu = pboYemekResim.ImageLocation;
                }

                Porsiyon porsiyon = (Porsiyon)cmbPorsiyonlar.SelectedItem;

                if (db.Besinler.Any(x => x.BesinAd.ToLower() == besinAd.ToLower() && x.PorsiyonId == porsiyon.Id))
                {
                    MessageBox.Show("Bu isimde ve aynı porsiyon türünde bir Besin zaten kayıtlı");
                    return;
                }
                else
                {
                    if (db.Besinler.Any(x => x.BesinAd.ToLower() == besinAd.ToLower() && x.KategoriId != kategori.Id))
                    {
                        MessageBox.Show("Bu Besinin kategorisi daha önce belirlenmiş, yeni bir kategori ile kayıt edilemez");
                        return;
                    }
                    else
                    {
                        besin.Porsiyon = porsiyon;
                        db.Besinler.Add(besin);
                        db.SaveChanges();
                        //this.Close(); //Peş peşe eklenebilsin diye bu yorumda ve form temizleniyor
                        FormuTemizle();
                    }
                }
            }
        }

        private void FormuTemizle()
        {
            txtBesinAd.Text = "";
            txtResimYolu.Text = "";
            nudGram.Value = 0m;
            nudKalori.Value = 0m;
            nudKarbonhidrat.Value = 0m;
            nudProtein.Value = 0m;
            nudYag.Value = 0m;
            cmbKategoriler.SelectedIndex = -1;
            cmbPorsiyonlar.SelectedIndex = -1;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYemekOlusturCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
