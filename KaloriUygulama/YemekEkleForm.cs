using KaloriUygulama.Data;
using KaloriUygulama.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaloriUygulama
{
    public partial class YemekEkleForm : Form
    {
        private readonly KaloriUygulamaDbContext db;
        private readonly Ogun ogun;

        private Besin arananBesin = null;
        private Besin eklenecekBesin = null;
        private OgunDetay ogunDetay = null;
        private Porsiyon seciliPorsiyon = null;
        public YemekEkleForm(KaloriUygulamaDbContext db, Ogun ogun)
        {
            this.db = db;
            this.ogun = ogun;
            InitializeComponent();
            txtYemekAra.Text = "a";//event tetiklensin tüm yemekler gelsin
            txtYemekAra.Text = "";
        }

        private void txtYemekAra_TextChanged(object sender, EventArgs e)
        {
            string arananYemek = txtYemekAra.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(arananYemek))
            {
                lblKontrol.Visible = false;
                cmbPorsiyonlar.DataSource = null;
                DegerleriTemizle();
                dgvArananYemekler.DataSource = db.Besinler.Select(y => new
                {
                    Besin = y.BesinAd,
                    Kategori = y.Kategori.KategoriAd
                }).Distinct().ToList();
                return;
            }
            else
            {
                if (arananYemek.Length < 3)
                {
                    lblKontrol.Visible = true;
                    dgvArananYemekler.DataSource = null;
                    cmbPorsiyonlar.DataSource = null;
                    DegerleriTemizle();
                    return;
                }
                else
                    lblKontrol.Visible = false;
            }


            if (db.Besinler.Any())
            {
                dgvArananYemekler.DataSource = db.Besinler.Where(x => x.BesinAd.ToLower().Contains(arananYemek) || x.Kategori.KategoriAd.ToLower().Contains(arananYemek)).Select(y => new
                {
                    Besin =y.BesinAd,
                    Kategori = y.Kategori.KategoriAd
                }).Distinct().ToList();
            }
            else
            {
                dgvArananYemekler.DataSource = null;
                cmbPorsiyonlar.DataSource = null;
                DegerleriTemizle();
            }
        }

        private void dgvArananYemekler_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArananYemekler.SelectedRows.Count == 0)
            {
                pboYemekResim.ImageLocation = "";
                cmbPorsiyonlar.DataSource = null;
                DegerleriTemizle();
            }
            else
            {
                string eklenecekBesinAd = (string)dgvArananYemekler.SelectedRows[0].Cells[0].Value;
                arananBesin = db.Besinler.FirstOrDefault(x => x.BesinAd == eklenecekBesinAd);
                cmbPorsiyonlar.DataSource = db.Porsiyonlar.Where(x => x.Besinler.Any(y => y.BesinAd == arananBesin.BesinAd)).ToList();
                cmbPorsiyonlar.DisplayMember = "PorsiyonAd";
                pboYemekResim.ImageLocation = arananBesin.BesinResimYolu;// Eğer Aynı isimde farklı porsiyonlarla yemek eklenirken farklı resimler kullanılmışsa burda dgv'ye distinct olarak attığımız için ilk gelenin resmi gözükür, Buna bir çözüm düşünülebilir?? mi??
            }
        }

        private void cmbPorsiyonlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (arananBesin == null)
                return;

            if (cmbPorsiyonlar.SelectedIndex == -1)
            {
                DegerleriTemizle();
                return;
            }
            else
            {
                seciliPorsiyon = (Porsiyon)cmbPorsiyonlar.SelectedItem;
                ogunDetay = new OgunDetay();
                string eklenecekBesinAd = (string)dgvArananYemekler.SelectedRows[0].Cells[0].Value;
                arananBesin = db.Besinler.FirstOrDefault(x => x.BesinAd == eklenecekBesinAd);
                eklenecekBesin = db.Besinler.FirstOrDefault(x => x.BesinAd == arananBesin.BesinAd && x.PorsiyonId == seciliPorsiyon.Id);
                ogunDetay.Besin = eklenecekBesin;
                BesinDegerleriGuncelle(ogunDetay);
            }
        }

        private void DegerleriTemizle()
        {
            seciliPorsiyon = null;
            eklenecekBesin = null;
            ogunDetay = null;
            nudAdet.Value = 0;
            lblBesinAd.Text = "...";
            lblGram.Text = "0";
            lblKalori.Text = "0";
            lblKarbonhidrat.Text = "0";
            lblProtein.Text = "0";
            lblYag.Text = "0";
        }

        private void BesinDegerleriGuncelle(OgunDetay ogunDetay)
        {
            decimal adet = nudAdet.Value;
            ogunDetay.Adet = adet;
            ogunDetay.OgunDetayGram = ogunDetay.Besin.Gram * adet;
            ogunDetay.OgunDetayKalori = ogunDetay.Besin.Kalori * adet;
            ogunDetay.OgunDetayKarbonhidrat = ogunDetay.Besin.Karbonhidrat * adet;
            ogunDetay.OgunDetayProtein = ogunDetay.Besin.Protein * adet;
            ogunDetay.OgunDetayYag = ogunDetay.Besin.Yag * adet;

            lblBesinAd.Text = ogunDetay.Besin.BesinAd;
            lblGram.Text = ogunDetay.OgunDetayGram.ToString("N2");
            lblKalori.Text = ogunDetay.OgunDetayKalori.ToString("N2");
            lblKarbonhidrat.Text = ogunDetay.OgunDetayKarbonhidrat.ToString("N2");
            lblProtein.Text = ogunDetay.OgunDetayProtein.ToString("N2");
            lblYag.Text = ogunDetay.OgunDetayYag.ToString("N2");
        }

        private void nudAdet_ValueChanged(object sender, EventArgs e)
        {
            if (ogunDetay == null || arananBesin == null || eklenecekBesin == null || seciliPorsiyon == null)//bazı kontroller silinebilir düşünmek lazım aşırı güvenli bir if
                return;
            BesinDegerleriGuncelle(ogunDetay);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (ogunDetay == null || arananBesin == null || eklenecekBesin == null || seciliPorsiyon == null)
            {
                MessageBox.Show("Lütfen bir Besin ve Porsiyon türü seçiniz");
                return;
            }
            else
            {
                if (ogunDetay.Adet == 0)
                {
                    MessageBox.Show("Porsiyon Adeti '0' Olamaz!");
                }
                else
                {
                    ogun.OgunDetaylar.Add(ogunDetay);
                    db.SaveChanges();
                    this.Close();
                }
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
