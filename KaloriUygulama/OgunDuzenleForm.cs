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
    public partial class OgunDuzenleForm : Form
    {
        private readonly OgunDetay ogunDetay;
        private readonly KaloriUygulamaDbContext db;
        private string besinAdi;
        private Porsiyon secilenPorsiyon;

        public OgunDuzenleForm(OgunDetay ogunDetay, KaloriUygulamaDbContext db)
        {
            this.ogunDetay = ogunDetay;
            this.db = db;
            besinAdi = ogunDetay.Besin.BesinAd;
            secilenPorsiyon = ogunDetay.Besin.Porsiyon;
            InitializeComponent();
            nudAdet.Value = ogunDetay.Adet;

            cmbPorsiyonlar.DataSource = db.Porsiyonlar.Where(x => x.Besinler.Any(y => y.BesinAd == besinAdi)).ToList();
            cmbPorsiyonlar.SelectedItem = secilenPorsiyon;
            cmbPorsiyonlar.DisplayMember = "PorsiyonAd";
            BesinDegerleriGuncelle(ogunDetay);

        }

        private void cmbPorsiyonlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPorsiyonlar.SelectedIndex == -1) return;

            var secilenPorsiyon = (Porsiyon)cmbPorsiyonlar.SelectedItem;
            Besin besin = db.Besinler.FirstOrDefault(x => x.BesinAd == besinAdi && x.PorsiyonId == secilenPorsiyon.Id);
            ogunDetay.Besin = besin;
            BesinDegerleriGuncelle(ogunDetay);
        }

        private void nudAdet_ValueChanged(object sender, EventArgs e)
        {
            BesinDegerleriGuncelle(ogunDetay);
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

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (ogunDetay.Adet == 0)
            {
                MessageBox.Show("Porsiyon Adeti '0' Olamaz!");
            }
            else
            {
                db.SaveChanges();
                this.Close();
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
