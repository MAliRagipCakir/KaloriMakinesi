using KaloriUygulama.Data;
using KaloriUygulama.Entities;
using KaloriUygulama.Enums;
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
    public partial class YemekCesidiRaporForm : Form
    {
        private readonly KaloriUygulamaDbContext db;
        private readonly Kullanici kullanici;

        public YemekCesidiRaporForm(KaloriUygulamaDbContext db, Kullanici kullanici)
        {
            InitializeComponent();
            this.db = db;
            this.kullanici = kullanici;
            BilgileriGetir();
        }

        private void BilgileriGetir()
        {
            if (!db.OgunDetaylar.Any()) return;
            // Kişi Hangi yemekten hangi öğünde kaç gram yedi, Tüm zamanlar
            dgvYemekCesidiBazli.DataSource = db.OgunDetaylar
                .Where(x => x.Ogun.KullaniciId == kullanici.Id)
                .Select(y => new
                {
                    Besin = y.Besin.BesinAd,
                    Gram = y.OgunDetayGram,
                    Ogun = y.Ogun.Ad
                })
                .GroupBy(z => z.Besin)
                .Select(g => new
                {
                    Yemek = g.Key,
                    Sabah = g.Where(p => p.Ogun == OgunAdi.Sabah).Sum(s => (int?)s.Gram) ?? 0,
                    Oğle = g.Where(p => p.Ogun == OgunAdi.Ogle).Sum(s => (int?)s.Gram) ?? 0,
                    Akşam = g.Where(p => p.Ogun == OgunAdi.Aksam).Sum(s => (int?)s.Gram) ?? 0,
                    AraÖğün = g.Where(p => p.Ogun == OgunAdi.AraOgun).Sum(s => (int?)s.Gram) ?? 0,
                }).ToList();

            dgvYemekCesidiBazli.Columns[0].HeaderText = "Yemek Adı";
            dgvYemekCesidiBazli.Columns[1].HeaderText = "Sabah (Toplam Gram)";
            dgvYemekCesidiBazli.Columns[2].HeaderText = "Öğlen (Toplam Gram)";
            dgvYemekCesidiBazli.Columns[3].HeaderText = "Akşam (Toplam Gram)";
            dgvYemekCesidiBazli.Columns[4].HeaderText = "Ara Öğün (Toplam Gram)";
        }

        private void btnYemekKategoriRaporCikis_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
