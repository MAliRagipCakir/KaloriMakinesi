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
    public partial class YemekAraForm : Form
    {
        private readonly KaloriUygulamaDbContext db;
        private Besin besin;

        public YemekAraForm(KaloriUygulamaDbContext db)
        {
            this.db = db;
            InitializeComponent();
            txtYemekAra.Text = "a";//event tetiklensin
            txtYemekAra.Text = "";
        }

        private void txtYemekAra_TextChanged(object sender, EventArgs e)
        {
            string arananYemek = txtYemekAra.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(arananYemek))
            {
                lblKontrol.Visible = false;
                //dgvArananYemekler.DataSource = null;
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
                {
                    lblKontrol.Visible = false;
                }
            }

            if (db.Besinler.Any())
            {
                dgvArananYemekler.DataSource = db.Besinler.Where(x => x.BesinAd.ToLower().Contains(arananYemek)).Select(y => new
                {
                    Besin = y.BesinAd,
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

        private void DegerleriTemizle()
        {
            lblBesinAd.Text = "...";
            lblGram.Text = "0";
            lblKalori.Text = "0";
            lblKarbonhidrat.Text = "0";
            lblProtein.Text = "0";
            lblYag.Text = "0";
            besin = null;
        }

        private void dgvArananYemekler_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArananYemekler.SelectedRows.Count == 0)
            {
                cmbPorsiyonlar.DataSource = null;
                pboYemekResim.ImageLocation = "";
                DegerleriTemizle();
            }
            else
            {
                string arananBesinAd = (string)dgvArananYemekler.SelectedRows[0].Cells[0].Value;
                besin = db.Besinler.FirstOrDefault(x => x.BesinAd == arananBesinAd);
                cmbPorsiyonlar.DataSource = db.Porsiyonlar.Where(x => x.Besinler.Any(y => y.BesinAd == arananBesinAd)).ToList();
                cmbPorsiyonlar.DisplayMember = "PorsiyonAd";
                pboYemekResim.ImageLocation = besin.BesinResimYolu;
            }
        }

        private void cmbPorsiyonlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (besin == null) return;
            if (cmbPorsiyonlar.SelectedIndex == -1)
            {
                DegerleriTemizle();
                return;
            }
            else
            {
                Porsiyon porsiyon = (Porsiyon)cmbPorsiyonlar.SelectedItem;
                string arananBesinAd = (string)dgvArananYemekler.SelectedRows[0].Cells[0].Value;
                besin = db.Besinler.FirstOrDefault(x => x.BesinAd == arananBesinAd && x.Porsiyon.Id == porsiyon.Id);
                BesinDegerleriniGetir(besin);
            }
        }

        private void BesinDegerleriniGetir(Besin besin)
        {
            lblBesinAd.Text = besin.BesinAd;
            lblGram.Text = besin.Gram.ToString("N2");
            lblKalori.Text = besin.Kalori.ToString("N2");
            lblKarbonhidrat.Text = besin.Karbonhidrat.ToString("N2");
            lblProtein.Text = besin.Protein.ToString("N2");
            lblYag.Text = besin.Yag.ToString("N2");
        }

        private void btnYemekAraCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
