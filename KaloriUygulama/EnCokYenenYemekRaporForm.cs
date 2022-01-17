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
    public partial class EnCokYenenYemekRaporForm : Form
    {
        private readonly KaloriUygulamaDbContext db;
        private readonly Kullanici kullanici;

        public EnCokYenenYemekRaporForm(KaloriUygulamaDbContext db, Kullanici kullanici)
        {
            InitializeComponent();
            this.db = db;
            this.kullanici = kullanici;
            BilgileriGetir();
        }

        private void BilgileriGetir()
        {
            if (!db.OgunDetaylar.Any()) return;
            // Kişi En Çok yenen Yemekler Gram bazlı Büyükten Küçüğe sıralı
            dgvEnCokYenenListe.DataSource = db.OgunDetaylar
                .Where(x => x.Ogun.KullaniciId == kullanici.Id)
                .Select(y => new
                {
                    Besin = y.Besin.BesinAd,
                    Gram = y.OgunDetayGram,
                })
                .GroupBy(z => z.Besin)
                .Select(g => new
                {
                    Yemek = g.Key,
                    Gram = g.Sum(s => s.Gram)
                })
                .OrderByDescending(k => k.Gram).ToList();

            // Kişi En Çok yenen Yemekler Gram bazlı Büyükten Küçüğe sıralı Grafik
            var list = db.OgunDetaylar
                .Where(x => x.Ogun.KullaniciId == kullanici.Id)
                .Select(y => new
                {
                    Besin = y.Besin.BesinAd,
                    Gram = y.OgunDetayGram,
                })
                .GroupBy(z => z.Besin)
                .Select(g => new
                {
                    Yemek = g.Key,
                    Gram = g.Sum(s => s.Gram)
                })
                .OrderByDescending(k => k.Gram).ToList().Take(10);
            chartEnCokYenenGrafik.Series["Series1"].Points.DataBindXY(list.Select(x => x.Yemek).ToList(), list.Select(y => y.Gram).ToList());
            chartEnCokYenenGrafik.Series["Series1"].IsValueShownAsLabel = true;
        }

        private void btnEnCokYenenYemekCikis_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
